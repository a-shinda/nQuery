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

                Rectangle rect = _targetCtrl.ClientRectangle;
                return  GetContainState(_targetCtrl, rect);
            }
        }

        private bool GetContainState(Control ctrl, Rectangle rect)
        {
            // マウス座標（スクリーン座標系）の取得
            Point mouseScreenPos = Control.MousePosition;
            // マウス座標をクライアント座標系へ変換
            Point mouseClientPos = ctrl.PointToClient(mouseScreenPos);
            // マウス座標（クライアント座標系）が領域内かどうか
            return rect.Contains(mouseClientPos);
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

        private Control _targetCtrl = null;
        private Form _parentForm = null;
        private System.Threading.Timer _moveTimer = null;
        private System.Threading.Timer _sizeTimer = null;
        Point endPos = new Point(0,0);

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
            endPos = new Point(x, y);
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
                if (Util.HasLeaves(moveXSum, out leaveX))
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
                                addValX = - 1;
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
                if (Util.HasLeaves(moveYSum, out leaveY))
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
                        if (endPos.X <= this._targetCtrl.Location.X)
                        {
                            if (endPos.X < this._targetCtrl.Location.X)
                                this._targetCtrl.Location = new Point( endPos.X, this._targetCtrl.Location.Y);
                            xEndFlg = true;
                        }
                    }
                    else
                    { 
                        // -方向の動作
                        if (endPos.X >= this._targetCtrl.Location.X)
                        {
                            if (endPos.X > this._targetCtrl.Location.X)
                                this._targetCtrl.Location = new Point(endPos.X, this._targetCtrl.Location.Y);
                            xEndFlg = true;
                        }
                    }

                    if (moveYdbl > 0)
                    {
                        if (endPos.Y <= this._targetCtrl.Location.Y)
                        {
                            if (endPos.Y < this._targetCtrl.Location.Y)
                                this._targetCtrl.Location = new Point(this._targetCtrl.Location.X, endPos.Y);
                            yEndFlg = true;
                        }
                    }
                    else
                    {
                        if (endPos.Y >= this._targetCtrl.Location.Y)
                        {
                            if (endPos.Y > this._targetCtrl.Location.Y)
                                this._targetCtrl.Location = new Point(this._targetCtrl.Location.X, endPos.Y);
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

            }, null, 0, 10); // 0.01秒サイクルで動作する
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="speed"></param>
        /// <param name="callBack"></param>
        private void DoSize(int width, int height, int speed, Action callBack)
        { 
        
        }

        /// <summary>
        /// タイマー群を破棄
        /// </summary>
        private void DoDisposeTimer()
        {
            if (this._moveTimer != null)
            {
                this._moveTimer.Dispose();
            }

            if (this._sizeTimer != null)
                this._sizeTimer.Dispose();
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

    public static class Util
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
    }

}