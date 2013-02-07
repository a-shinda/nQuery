using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using nQueryLib.Core;
using nQueryLib.nQueryUtil;

namespace nQueryLib
{
    /// <summary>
    /// nQueryセレクタ
    /// </summary>
    public static class nQuery
    {
        private static Dictionary<Control, nQueryCore> _dicCtrl = new Dictionary<Control, nQueryCore>();

        /// <summary>
        /// 対象コントロールに紐づくnQueryオブジェクトを生成または返却する
        /// </summary>
        /// <param name="ctrl">動作させたいコントロール</param>
        /// <returns></returns>
        public static nQueryCore Select(Control ctrl)
        {
            if (_dicCtrl.ContainsKey(ctrl))
            {
                return _dicCtrl[ctrl];
            }
            else
            {
                nQueryCore ret = new nQueryCore(ctrl);
                ret.OriginalPos = ctrl.Location;
                ret.OriginalSize = ctrl.Size;
                _dicCtrl.Add(ctrl, ret);
                return ret;
            }
        }

    }
}

namespace nQueryLib.Core
{

    /// <summary>
    /// nQuery本体
    /// </summary>
    public class nQueryCore : IDisposable
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="ctrl"></param>
        public nQueryCore(Control ctrl)
        {
            _targetCtrl = ctrl;
            _parentForm = ctrl.FindForm();

            // ターゲットが破棄された場合、自分自身も破棄する
            _targetCtrl.Disposed += (sender, e) =>
            {
                this.Dispose();
            };

            _parentForm.Disposed += (sender, e) =>
            {
                this.Dispose();
            };

        }

        /// <summary>
        /// マウスポイントが対象コントロールのクライアント領域にある場合：true / それ以外：false
        /// </summary>
        public bool IsMouseUnder
        {
            get {

                return  nQueryUtil.FunctionUtil.IsMouseUnderInRect(_targetCtrl);
            }
        }

        private Point _OriginalPos = new Point(0,0);
        /// <summary>
        /// 動作開始時のポジション
        /// </summary>
        public Point OriginalPos
        {
            get {
                return _OriginalPos;
            }
            set {
                _OriginalPos = value;
            }
        }

        private Size _OriginalSize = new Size(0, 0);
        /// <summary>
        /// 動作開始時のサイズ
        /// </summary>
        public Size OriginalSize
        {
            get
            {
                return _OriginalSize;
            }
            set
            {
                _OriginalSize = value;
            }
        }

        private Control _targetCtrl = null;
        private Form _parentForm = null;
        private System.Threading.Timer _moveTimer = null;
        private System.Threading.Timer _sizeTimer = null;
        private System.Threading.Timer _fadeTimer = null;

        /// <summary>
        /// アニメーションの停止処理
        /// </summary>
        /// <returns></returns>
        public nQueryCore Stop()
        {
            DoDisposeTimer();
            return this;
        }

        /// <summary>
        /// コントロールの移動を行う
        /// </summary>
        /// <param name="x">X軸方向の移動終了時のポジション</param>
        /// <param name="y">Y軸方向の移動終了時のポジション</param>
        /// <param name="speed">動作完了までにかける秒数(m/s)</param>
        /// <returns></returns>
        public nQueryCore Move(int x, int y, int speed)
        {
            try
            {
                // CallBack無し
                DoMove(x, y, speed, null);
            }
            catch (Exception ex)
            { }

            return this;
        }

        /// <summary>
        /// コントロールの移動を行う
        /// </summary>
        /// <param name="x">X軸方向の移動終了時のポジション</param>
        /// <param name="y">Y軸方向に移動終了時のポジション</param>
        /// <param name="speed">動作完了までにかける秒数(m/s)</param>
        /// <param name="callback">移動完了後に実行されるデリゲード</param>
        public nQueryCore Move(int x, int y, int speed, Action callBack)
        {
            try
            {
                DoMove(x, y, speed, callBack);
            }
            catch (Exception ex)
            { }

            return this;
        }

        /// <summary>
        /// 移動実処理
        /// </summary>
        /// <param name="x">X軸方向に移動させる量(point)</param>
        /// <param name="y">Y軸方向に移動させる量(point)</param>
        /// <param name="speed">動作完了までにかける秒数(m/s)</param>
        /// <param name="callback">移動完了後に実行されるデリゲード</param>
        private void DoMove(int x, int y, int speed, Action callBack)
        {
            // 同じ位置から移動処理が行われた場合
            if (_targetCtrl.Location.X == x && _targetCtrl.Location.Y == y)
            {
                if (callBack != null)
                    callBack();
            }

            // ここまで移動したら終了
            Point _endPos = new Point(x, y);
            x = x - _targetCtrl.Location.X;
            y = y - _targetCtrl.Location.Y;

            // 0.01秒毎の移動距離を算出
            double moveXdbl = (x * 0.01) / (speed * 0.001);
            double moveYdbl = (y * 0.01) / (speed * 0.001);
            int moveXInt = Math.Abs(moveXdbl) < 1 ? 1 : int.Parse(Math.Ceiling(Math.Abs(moveXdbl)).ToString());
            int moveYInt = Math.Abs(moveYdbl) < 1 ? 1 : int.Parse(Math.Ceiling(Math.Abs(moveYdbl)).ToString());

            if (x < 0)
                moveXInt = 0 - moveXInt;
            if (y < 0)
                moveYInt = 0 - moveYInt;

            bool xEndFlg = false;
            bool yEndFlg = false;

            Point movingPos = new Point(_targetCtrl.Location.X, _targetCtrl.Location.Y);

            // 1サイクルの移動距離が1を下回る場合に使う変数群(WindowsFormのLocationは整数値のみを設定可能なため)
            double leaveXSum = 0;
            double leaveYSum = 0;
            double leaveX = 0;
            double leaveY = 0;
            bool canXadd = true;
            bool canYadd = true;
            double moveXSum = 0;
            double moveYSum = 0;
            int addValX = 0;
            int addValY = 0;

            // ThreadTimerを使用してバックグラウンドで処理を行う
            _moveTimer = new System.Threading.Timer(state =>
            {
                try
                {
                    #region 移動値の計算

                    moveXSum += moveXdbl;
                    moveYSum += moveYdbl;

                    if (Math.Abs(moveXSum) < 1)
                    {
                        // 移動幅が1ポイント以下
                        canXadd = false;
                    }
                    else
                    {
                        // 移動幅キャッシュをクリア
                        moveXSum = 0;
                        canXadd = true;
                    }

                    // 端数を算出する
                    if (FunctionUtil.HasLeaves(moveXSum, out leaveX))
                    {
                        // キャッシュ
                        leaveXSum += Math.Abs(leaveX);
                        if (Math.Abs(leaveXSum) > 1)
                        {
                            if (moveXdbl > 0)
                            {
                                addValX = moveXInt + 1;
                            }
                            else
                            {
                                addValX = moveXInt - 1;
                            }
                            leaveXSum -= 1;


                            // 1サイクルの移動距離が0point以下でも端数が1pointを上回る場合は処理を行う
                            if (!canXadd)
                            {
                                canXadd = true;
                                if (moveXdbl > 0)
                                {
                                    addValX = 1;
                                }
                                else
                                {
                                    addValX = -1;
                                }
                            }

                        }
                        else
                        {
                            addValX = moveXInt;
                        }
                    }
                    else
                    {
                        // 端数無し
                        addValX = moveXInt;
                    }

                    if (Math.Abs(moveYSum) < 1)
                    {
                        // 移動幅が1ポイント以下
                        canYadd = false;
                    }
                    else
                    {
                        // 移動幅キャッシュをクリア
                        moveYSum = 0;
                        canYadd = true;
                    }

                    // 端数を算出する
                    if (FunctionUtil.HasLeaves(moveYSum, out leaveY))
                    {
                        // キャッシュ
                        leaveYSum += Math.Abs(leaveY);
                        if (Math.Abs(leaveYSum) > 1)
                        {
                            if (moveYdbl > 0)
                            {
                                addValY = moveYInt + 1;
                            }
                            else
                            {
                                addValY = moveYInt - 1;
                            }
                            leaveYSum -= 1;


                            // 1サイクルの移動距離が0point以下でも端数が1pointを上回る場合は処理を行う
                            if (!canYadd)
                            {
                                canYadd = true;
                                if (moveYdbl > 0)
                                {
                                    addValY = 1;
                                }
                                else
                                {
                                    addValY = -1;
                                }
                            }

                        }
                        else
                        {
                            addValY = moveYInt;
                        }
                    }
                    else
                    {
                        // 端数無し
                        addValY = moveYInt;
                    }

                    if (!canXadd && !canYadd)
                    {
                        return;
                    }

                    #endregion

                    // UIスレッドで動作させる
                    _parentForm.BeginInvoke((Action)(() =>
                    {
                        #region 移動本処理

                        // 処理が終わっていないかつ、移動可能フラグがたっていればポイントを＋していく
                        if (!xEndFlg && canXadd)
                        {
                            movingPos = new Point(movingPos.X + addValX, movingPos.Y);
                        }

                        if (!yEndFlg && canYadd)
                        {
                            movingPos = new Point(movingPos.X, movingPos.Y + addValY);
                        }

                        // 移動
                        _targetCtrl.Location = movingPos;

                        // 終了条件判定
                        if (moveXdbl > 0)
                        {
                            // +方向の動作
                            if (_endPos.X <= this._targetCtrl.Location.X)
                            {
                                if (_endPos.X < this._targetCtrl.Location.X)
                                    this._targetCtrl.Location = new Point(_endPos.X, this._targetCtrl.Location.Y);
                                xEndFlg = true;
                            }
                        }
                        else
                        {
                            // -方向の動作
                            if (_endPos.X >= this._targetCtrl.Location.X)
                            {
                                if (_endPos.X > this._targetCtrl.Location.X)
                                    this._targetCtrl.Location = new Point(_endPos.X, this._targetCtrl.Location.Y);
                                xEndFlg = true;
                            }
                        }

                        if (moveYdbl > 0)
                        {
                            if (_endPos.Y <= this._targetCtrl.Location.Y)
                            {
                                if (_endPos.Y < this._targetCtrl.Location.Y)
                                    this._targetCtrl.Location = new Point(this._targetCtrl.Location.X, _endPos.Y);
                                yEndFlg = true;
                            }
                        }
                        else
                        {
                            if (_endPos.Y >= this._targetCtrl.Location.Y)
                            {
                                if (_endPos.Y > this._targetCtrl.Location.Y)
                                    this._targetCtrl.Location = new Point(this._targetCtrl.Location.X, _endPos.Y);
                                yEndFlg = true;
                            }
                        }

                        // 終了条件を満たしている場合
                        if (xEndFlg && yEndFlg)
                        {
                            _moveTimer.Dispose();

                            // CallBackが渡されている場合は実行
                            if (callBack != null)
                                callBack();
                        }

                        #endregion
                    }));
                }
                catch (Exception ex)
                {
                    _moveTimer.Dispose();
                }

            }, null, 0, 10); // 0.01秒サイクルで動作する
        }

        /// <summary>
        /// コントロールの拡大/縮小を行う
        /// </summary>
        /// <param name="width">拡大/縮小終了後の幅</param>
        /// <param name="height">拡大/縮小終了後の高さ</param>
        /// <param name="speed">動作完了までにかける秒数(m/s)</param>
        public nQueryCore Size(int width, int height, int speed)
        {
            try
            {
                DoSize(width, height, speed, null);
            }
            catch (Exception ex)
            { }

            return this;
        }

        /// <summary>
        /// コントロールの拡大/縮小を行う
        /// </summary>
        /// <param name="width">拡大/縮小終了後の幅</param>
        /// <param name="height">拡大/縮小終了後の高さ</param>
        /// <param name="speed">動作完了までにかける秒数(m/s)</param>
        /// <param name="callback">拡大/縮小完了後に実行されるデリゲード</param>
        public nQueryCore Size(int width, int height, int speed, Action callBack)
        {
            try
            {
                DoSize(width, height, speed, callBack);
            }
            catch (Exception ex)
            { }

            return this;
        }

        /// <summary>
        /// 拡大/縮小実処理
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="speed"></param>
        /// <param name="callBack"></param>
        private void DoSize(int width, int height, int speed, Action callBack)
        { 
            // 同じ位置から移動処理が行われた場合
            if (_targetCtrl.Size.Width == width && _targetCtrl.Size.Height == height)
            {
                if (callBack != null)
                    callBack();
            }

            // ここまで移動したら終了
            Size _endSize = new Size(width, height);
            width = width - _targetCtrl.Size.Width;
            height = height - _targetCtrl.Size.Height;

            // 0.01秒毎の移動距離を算出
            double sizeXdbl = (width * 0.01) / (speed * 0.001);
            double sizeYdbl = (height * 0.01) / (speed * 0.001);
            int sizeXInt = Math.Abs(sizeXdbl) < 1 ? 1 : int.Parse(Math.Ceiling(Math.Abs(sizeXdbl)).ToString());
            int sizeYInt = Math.Abs(sizeYdbl) < 1 ? 1 : int.Parse(Math.Ceiling(Math.Abs(sizeYdbl)).ToString());

            if (width < 0)
                sizeXInt = 0 - sizeXInt;
            if (height < 0)
                sizeYInt = 0 - sizeYInt;

            bool widthEndFlg = false;
            bool heightEndFlg = false;

            Size movingSize = new Size(_targetCtrl.Size.Width, _targetCtrl.Size.Height);

            // 1サイクルの拡張/縮小が1を下回る場合に使う変数群(WindowsFormのSizeは整数値のみを設定可能なため)
            double leaveWidthSum = 0;
            double leaveHeightSum = 0;
            double leaveWidth = 0;
            double leaveHeight = 0;
            bool canWidthadd = true;
            bool canHeightadd = true;
            double sizeWidthSum = 0;
            double sizeHeightSum = 0;
            int addValWidth = 0;
            int addValHeight = 0;

            // ThreadTimerを使用してバックグラウンドで処理を行う
            _sizeTimer = new System.Threading.Timer(state =>
            {
                try
                {
                    #region 拡張/縮小値の計算

                    sizeWidthSum += sizeXdbl;
                    sizeHeightSum += sizeYdbl;

                    if (Math.Abs(sizeWidthSum) < 1)
                    {
                        // 拡張/縮小値が1ポイント以下
                        canWidthadd = false;
                    }
                    else
                    {
                        // 拡張/縮小値キャッシュをクリア
                        sizeWidthSum = 0;
                        canWidthadd = true;
                    }

                    // 端数を算出する
                    if (FunctionUtil.HasLeaves(sizeWidthSum, out leaveWidth))
                    {
                        // キャッシュ
                        leaveWidthSum += Math.Abs(leaveWidth);
                        if (Math.Abs(leaveWidthSum) > 1)
                        {
                            if (sizeXdbl > 0)
                            {
                                addValWidth = sizeXInt + 1;
                            }
                            else
                            {
                                addValWidth = sizeXInt - 1;
                            }
                            leaveWidthSum -= 1;


                            // 1サイクルの拡張/縮小値が0point以下でも端数が1pointを上回る場合は処理を行う
                            if (!canWidthadd)
                            {
                                canWidthadd = true;
                                if (sizeXdbl > 0)
                                {
                                    addValWidth = 1;
                                }
                                else
                                {
                                    addValWidth = -1;
                                }
                            }

                        }
                        else
                        {
                            addValWidth = sizeXInt;
                        }
                    }
                    else
                    {
                        // 端数無し
                        addValWidth = sizeXInt;
                    }

                    if (Math.Abs(sizeHeightSum) < 1)
                    {
                        // 拡張/縮小値が1ポイント以下
                        canHeightadd = false;
                    }
                    else
                    {
                        // 拡張/縮小値キャッシュをクリア
                        sizeHeightSum = 0;
                        canHeightadd = true;
                    }

                    // 端数を算出する
                    if (FunctionUtil.HasLeaves(sizeHeightSum, out leaveHeight))
                    {
                        // キャッシュ
                        leaveHeightSum += Math.Abs(leaveHeight);
                        if (Math.Abs(leaveHeightSum) > 1)
                        {
                            if (sizeYdbl > 0)
                            {
                                addValHeight = sizeYInt + 1;
                            }
                            else
                            {
                                addValHeight = sizeYInt - 1;
                            }
                            leaveHeightSum -= 1;


                            // 1サイクルの拡張/縮小値が0point以下でも端数が1pointを上回る場合は処理を行う
                            if (!canHeightadd)
                            {
                                canHeightadd = true;
                                if (sizeYdbl > 0)
                                {
                                    addValHeight = 1;
                                }
                                else
                                {
                                    addValHeight = -1;
                                }
                            }

                        }
                        else
                        {
                            addValHeight = sizeYInt;
                        }
                    }
                    else
                    {
                        // 端数無し
                        addValHeight = sizeYInt;
                    }

                    if (!canWidthadd && !canHeightadd)
                    {
                        return;
                    }

                    #endregion

                    // UIスレッドで動作させる
                    _parentForm.BeginInvoke((Action)(() =>
                    {
                        #region 移動本処理

                        // 処理が終わっていないかつ、移動可能フラグがたっていればポイントを＋していく
                        if (!widthEndFlg && canWidthadd)
                        {
                            movingSize = new Size(movingSize.Width + addValWidth, movingSize.Height);
                        }

                        if (!heightEndFlg && canHeightadd)
                        {
                            movingSize = new Size(movingSize.Width, movingSize.Height + addValHeight);
                        }

                        // 移動
                        _targetCtrl.Size = movingSize;

                        // 終了条件判定
                        if (sizeXdbl > 0)
                        {
                            // +方向の動作
                            if (_endSize.Width <= this._targetCtrl.Size.Width)
                            {
                                if (_endSize.Width < this._targetCtrl.Size.Width)
                                    this._targetCtrl.Size = new Size(_endSize.Width, this._targetCtrl.Size.Height);
                                widthEndFlg = true;
                            }
                        }
                        else
                        {
                            // -方向の動作
                            if (_endSize.Width >= this._targetCtrl.Size.Width)
                            {
                                if (_endSize.Width > this._targetCtrl.Size.Width)
                                    this._targetCtrl.Size = new Size(_endSize.Width, this._targetCtrl.Size.Height);
                                widthEndFlg = true;
                            }
                        }

                        if (sizeYdbl > 0)
                        {
                            if (_endSize.Height <= this._targetCtrl.Size.Height)
                            {
                                if (_endSize.Height < this._targetCtrl.Size.Height)
                                    this._targetCtrl.Size = new Size(this._targetCtrl.Size.Width, _endSize.Height);
                                heightEndFlg = true;
                            }
                        }
                        else
                        {
                            if (_endSize.Height >= this._targetCtrl.Size.Height)
                            {
                                if (_endSize.Height > this._targetCtrl.Size.Height)
                                    this._targetCtrl.Size = new Size(this._targetCtrl.Size.Width, _endSize.Height);
                                heightEndFlg = true;
                            }
                        }

                        // 終了条件を満たしている場合
                        if (widthEndFlg && heightEndFlg)
                        {
                            _sizeTimer.Dispose();

                            // CallBackが渡されている場合は実行
                            if (callBack != null)
                                callBack();
                        }

                        #endregion
                    }));
                }
                catch (Exception ex)
                {
                    _sizeTimer.Dispose();
                }

            }, null, 0, 10); // 0.01秒サイクルで動作する
        }

        /// <summary>
        /// コントロールのFadeIn / FadeOutを行う
        /// </summary>
        /// <param name="opacity">動作完了時のOpacityのパーセント(0 - 100)</param>
        /// <param name="speed">動作完了までにかける秒数(m/s)</param>
        public nQueryCore FadeTo(int opacity, int speed)
        {
            try
            {
                DoFadeTo(opacity, speed, null);
            }
            catch (Exception ex)
            { }

            return this;
        }

        /// <summary>
        /// コントロールのFadeIn / FadeOutを行う
        /// </summary>
        /// <param name="opacity">動作完了時のOpacityのパーセント(0 - 100)</param>
        /// <param name="speed">動作完了までにかける秒数(m/s)</param>
        /// <param name="callback">拡大/縮小完了後に実行されるデリゲード</param>
        public nQueryCore FadeTo(int opacity, int speed, Action callBack)
        {
            try
            {
                DoFadeTo(opacity, speed, callBack);
            }
            catch (Exception ex)
            { }

            return this;
        }

        /// <summary>
        /// FadeIn / FadeOut実処理
        /// </summary>
        /// <param name="opacity"></param>
        /// <param name="speed"></param>
        /// <param name="callBack"></param>
        private void DoFadeTo(int opacity, int speed, Action callBack)
        {
            if (opacity > 100 || opacity < 0)
            {
                if (callBack != null)
                    callBack();
                return;
            }

            if (speed == 0)
            {
                _targetCtrl.BackColor = Color.FromArgb(0, _targetCtrl.BackColor.R, _targetCtrl.BackColor.G, _targetCtrl.BackColor.B);

                if (callBack != null)
                    callBack();
                return;
            }

            // パーセンテージから設定するアルファ値を取得
            int endOpInt = int.Parse(Math.Ceiling(255 * (opacity * 0.01)).ToString());
            int startOpInt = Color.FromArgb(_targetCtrl.BackColor.ToArgb()).A; // 初期値

            // 0.1秒毎に+-するアルファ値を算出する
            int addOpInt = Math.Abs(endOpInt - startOpInt); // 増減の絶対値
            addOpInt = int.Parse(Math.Ceiling(addOpInt / ((speed * 0.001) / 0.1)).ToString());

            bool fadeEndFlg = false;

            _fadeTimer = new System.Threading.Timer(state =>
            {
                try
                {
                    #region Fade処理

                    if (startOpInt < endOpInt)
                    {
                        // +方向
                        startOpInt += addOpInt;
                        if (startOpInt >= endOpInt)
                        {
                            if (endOpInt > 255)
                                endOpInt = 255;
                            if (startOpInt > endOpInt)
                                startOpInt = endOpInt;

                            fadeEndFlg = true;
                        }
                    }
                    else
                    {
                        // -方向
                        startOpInt -= addOpInt;
                        if (startOpInt <= endOpInt)
                        {
                            if (endOpInt < 0)
                                endOpInt = 0;
                            if (startOpInt < endOpInt)
                                startOpInt = endOpInt;

                            fadeEndFlg = true;
                        }
                    }

                    // UIスレッドで動作させる
                    _parentForm.BeginInvoke((Action)(() =>
                    {

                        if (_targetCtrl.GetType() == typeof(Form))
                        {
                            ((Form)_targetCtrl).Opacity = (startOpInt / 255);
                        }
                        else
                        {
                            _targetCtrl.BackColor = Color.FromArgb(startOpInt, _targetCtrl.BackColor.R, _targetCtrl.BackColor.G, _targetCtrl.BackColor.B);
                        }

                        if (fadeEndFlg)
                        {
                            _fadeTimer.Dispose();
                            if (callBack != null)
                                callBack();
                        }

                    }));
                    #endregion
                }
                catch(Exception ex)
                {
                    _fadeTimer.Dispose();
                }

            }, null, 0, 100); // 0.1秒サイクルで動作する
        }

        /// <summary>
        /// タイマー群を破棄
        /// </summary>
        private void DoDisposeTimer()
        {
            if (this._moveTimer != null)
                this._moveTimer.Dispose();

            if (this._sizeTimer != null)
                this._sizeTimer.Dispose();

            if (this._fadeTimer != null)
                this._fadeTimer.Dispose();
        }

        #region IDisposable メンバ

        public void Dispose()
        {
            DoDisposeTimer();
        }

        #endregion
    }

}

namespace nQueryLib.nQueryUtil
{
    /// <summary>
    /// 関数系Util
    /// </summary>
    public static class FunctionUtil
    {
        /// <summary>
        /// 端数を取得する
        /// </summary>
        /// <param name="dblTarget"></param>
        /// <returns></returns>
        public static double GetLeaves(double dblTarget)
        {
            return dblTarget - System.Math.Floor(dblTarget);
        }

        /// <summary>
        /// 端数が存在するか判定を行い、outとして端数自体を返す
        /// </summary>
        /// <param name="dblTarget"></param>
        /// <param name="dblLeaves"></param>
        /// <returns></returns>
        public static bool HasLeaves(double dblTarget, out double dblLeaves)
        {
            dblLeaves = dblTarget - Math.Floor(dblTarget);

            if (dblTarget - dblLeaves != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// マウス座標の直下が引数で渡されたコントロールの描画領域内か判定する(内包コントロール含む)
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="rect"></param>
        /// <returns></returns>
        public static bool IsMouseUnderInRect(Control ctrl)
        {
            // マウス座標（スクリーン座標系）の取得
            Point mouseScreenPos = Control.MousePosition;
            // マウス座標をクライアント座標系へ変換
            Point mouseClientPos = ctrl.PointToClient(mouseScreenPos);
            // マウス座標（クライアント座標系）が領域内かどうか
            Rectangle rect = ctrl.ClientRectangle;
            if (rect.Contains(mouseClientPos))
            {
                return true;
            }
            else { 
                // 内包コントロールが該当するか判定する
                foreach (Control _c in GetAllControls(ctrl))
                {
                    rect = _c.ClientRectangle;
                    if (rect.Contains(mouseClientPos))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 引数で渡されたコントロール内の全てのコントロールを取得する(コンテナ内含む)
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        public static List<Control> GetAllControls(Control top)
        {
            List<Control> buf = new List<Control>();
            foreach (Control c in top.Controls)
            {
                buf.Add(c);
                buf.AddRange(GetAllControls(c));
            }
            return buf;
        } 
    }

    /// <summary>
    /// 描画系Util
    /// </summary>
    public static class DrawingUtil
    {

        /// <summary>
        /// コントロールの背景を描画します。
        /// </summary>
        /// <param name="pevent">描画先のコントロールに関連する情報</param>
        public static void DrawBackground(Control ctrl, System.Windows.Forms.PaintEventArgs pevent)
        {
            // 背景色
            using (SolidBrush sb = new SolidBrush(ctrl.BackColor))
            {
                pevent.Graphics.FillRectangle(sb, ctrl.ClientRectangle);
            }

            // 背景画像
            if (ctrl.BackgroundImage != null)
            {
                DrawBackgroundImage(ctrl, pevent.Graphics, ctrl.BackgroundImage, ctrl.BackgroundImageLayout);
            }
        }

        /// <summary>
        /// コントロールの背景画像を描画します。
        /// </summary>
        /// <param name="g">描画に使用するグラフィックス オブジェクト</param>
        /// <param name="img">描画する画像</param>
        /// <param name="layout">画像のレイアウト</param>
        public static void DrawBackgroundImage(Control ctrl, Graphics g, Image img, ImageLayout layout)
        {
            Size imgSize = img.Size;

            switch (layout)
            {
                case ImageLayout.None:
                    g.DrawImage(img, 0, 0, imgSize.Width, imgSize.Height);

                    break;
                case ImageLayout.Tile:
                    int xCount = Convert.ToInt32(Math.Ceiling((double)ctrl.ClientRectangle.Width / (double)imgSize.Width));
                    int yCount = Convert.ToInt32(Math.Ceiling((double)ctrl.ClientRectangle.Height / (double)imgSize.Height));
                    for (int x = 0; x <= xCount - 1; x++)
                    {
                        for (int y = 0; y <= yCount - 1; y++)
                        {
                            g.DrawImage(img, imgSize.Width * x, imgSize.Height * y, imgSize.Width, imgSize.Height);
                        }
                    }

                    break;
                case ImageLayout.Center:
                    {
                        int x = 0;
                        if (ctrl.ClientRectangle.Width > imgSize.Width)
                        {
                            x = (int)Math.Floor((double)(ctrl.ClientRectangle.Width - imgSize.Width) / 2.0);
                        }
                        int y = 0;
                        if (ctrl.ClientRectangle.Height > imgSize.Height)
                        {
                            y = (int)Math.Floor((double)(ctrl.ClientRectangle.Height - imgSize.Height) / 2.0);
                        }
                        g.DrawImage(img, x, y, imgSize.Width, imgSize.Height);

                        break;
                    }
                case ImageLayout.Stretch:
                    g.DrawImage(img, 0, 0, ctrl.ClientRectangle.Width, ctrl.ClientRectangle.Height);

                    break;
                case ImageLayout.Zoom:
                    {
                        double xRatio = (double)ctrl.ClientRectangle.Width / (double)imgSize.Width;
                        double yRatio = (double)ctrl.ClientRectangle.Height / (double)imgSize.Height;
                        double minRatio = Math.Min(xRatio, yRatio);

                        Size zoomSize = new Size(Convert.ToInt32(Math.Ceiling(imgSize.Width * minRatio)), Convert.ToInt32(Math.Ceiling(imgSize.Height * minRatio)));

                        int x = 0;
                        if (ctrl.ClientRectangle.Width > zoomSize.Width)
                        {
                            x = (int)Math.Floor((double)(ctrl.ClientRectangle.Width - zoomSize.Width) / 2.0);
                        }
                        int y = 0;
                        if (ctrl.ClientRectangle.Height > zoomSize.Height)
                        {
                            y = (int)Math.Floor((double)(ctrl.ClientRectangle.Height - zoomSize.Height) / 2.0);
                        }
                        g.DrawImage(img, x, y, zoomSize.Width, zoomSize.Height);

                        break;
                    }
            }
        }

        /// <summary>
        /// 親コントロールと背面にあるコントロールを描画します。
        /// </summary>
        /// <param name="pevent">描画先のコントロールに関連する情報</param>
        public static void DrawParentWithBackControl(Control ctrl, System.Windows.Forms.PaintEventArgs pevent)
        {
            // 親コントロールを描画
            DrawParentControl(ctrl, ctrl.Parent, pevent);

            // 親コントロールとの間のコントロールを親側から描画
            for (int i = ctrl.Parent.Controls.Count - 1; i >= 0; i--)
            {
                Control c = ctrl.Parent.Controls[i];
                if (c == ctrl)
                {
                    break;
                }
                if (ctrl.Bounds.IntersectsWith(c.Bounds) == false)
                {
                    continue;
                }

                DrawBackControl(ctrl, c, pevent);
            }
        }

        /// <summary>
        /// 親コントロールを描画します。
        /// </summary>
        /// <param name="c">親コントロール</param>
        /// <param name="pevent">描画先のコントロールに関連する情報</param>
        public static void DrawParentControl(Control ctrl, Control parentCtrl, System.Windows.Forms.PaintEventArgs pevent)
        {
            using (Bitmap bmp = new Bitmap(parentCtrl.Width, parentCtrl.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    using (PaintEventArgs p = new PaintEventArgs(g, parentCtrl.ClientRectangle))
                    {
                        ((nQueryLib.UI.InQueryOpacity)ctrl).CallInvokePaintBackground(parentCtrl, p);
                        ((nQueryLib.UI.InQueryOpacity)ctrl).CallInvokePaint(parentCtrl, p);
                    }
                }

                int offsetX = ctrl.Left + (int)Math.Floor((double)(ctrl.Bounds.Width - ctrl.ClientRectangle.Width) / 2.0);
                int offsetY = ctrl.Top + (int)Math.Floor((double)(ctrl.Bounds.Height - ctrl.ClientRectangle.Height) / 2.0);
                pevent.Graphics.DrawImage(bmp, ctrl.ClientRectangle, new Rectangle(offsetX, offsetY, ctrl.ClientRectangle.Width, ctrl.ClientRectangle.Height), GraphicsUnit.Pixel);
            }
        }

        /// <summary>
        /// 背面のコントロールを描画します。
        /// </summary>
        /// <param name="c">背面のコントロール</param>
        /// <param name="pevent">描画先のコントロールに関連する情報</param>
        public static void DrawBackControl(Control ctrl, Control parentControl, System.Windows.Forms.PaintEventArgs pevent)
        {
            using (Bitmap bmp = new Bitmap(parentControl.Width, parentControl.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
            {
                parentControl.DrawToBitmap(bmp, new Rectangle(0, 0, parentControl.Width, parentControl.Height));

                int offsetX = (parentControl.Left - ctrl.Left) - (int)Math.Floor((double)(ctrl.Bounds.Width - ctrl.ClientRectangle.Width) / 2.0);
                int offsetY = (parentControl.Top - ctrl.Top) - (int)Math.Floor((double)(ctrl.Bounds.Height - ctrl.ClientRectangle.Height) / 2.0);
                pevent.Graphics.DrawImage(bmp, offsetX, offsetY, parentControl.Width, parentControl.Height);
            }
        }

    }
}