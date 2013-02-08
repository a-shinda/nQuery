using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using nQueryLib;

namespace usageGUI
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// メニューのセット定義
        /// </summary>
        private class MenueSet
        {
            /// <summary>
            /// 英語表記の上部ラベル
            /// </summary>
            public Control Parent { get; set; }
            /// <summary>
            /// 日本語表記のラベル
            /// </summary>
            public Control Sub { get; set; }
            /// <summary>
            /// サンプルが格納されているパネル
            /// </summary>
            public Control Pnl { get; set; }
        }

        private List<MenueSet> _listMenueSet = null;
        /// <summary>
        /// アニメーションで展開されるセットを定義したリスト
        /// </summary>
        private List<MenueSet> ListMenueSet
        {
            get
            {
                if (_listMenueSet == null)
                {
                    _listMenueSet = new List<MenueSet>();
                    _listMenueSet.AddRange(new MenueSet[]{new MenueSet{Parent = lblWhatEn, Sub= lblWhatJa, Pnl = pnlWhat}, 
                                                          new MenueSet{Parent = lblMoveEn, Sub= lblMoveJa, Pnl = pnlMoveSample}, 
                                                          new MenueSet{Parent = lblSizeEn, Sub= lblSizeJa, Pnl = pnlSizeSample},
                                                          new MenueSet{Parent = lblFadeEn, Sub= lblFadeJa, Pnl = pnlFadeSample}});
                }

                return _listMenueSet;
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ロード(デモ用スプラッシュを展開)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                // デモ用スプラッシュを表示
                using (frmSplash frmSp = new frmSplash())
                {
                    frmSp.ShowDialog();
                }
                this.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region 上部メニュー群関係の処理

        /// <summary>
        /// 上部メニューラベルにマウスポインタが侵入(サンプルを開く/閉じる)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblTop_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                // 展開
                OpenSamplePnl((Control)sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// サンプル展開
        /// </summary>
        /// <param name="Control">対象コントロール</param>
        private void OpenSamplePnl(Control ctrl)
        {
            var target = from c in ListMenueSet
                         where c.Parent == ctrl
                         select c;

            // 該当コントロールなし
            if (target.Count() == 0)
            {
                foreach (MenueSet _set in ListMenueSet)
                {
                    CloseSamplePnl(_set);
                }
                return;
            }

            // 自分自身は展開し、自分以外は閉じる
            foreach (MenueSet _set in ListMenueSet)
            {
                if (_set == (MenueSet)target.First())
                {
                    // サブラベルを下方に移動
                    nQuery.Select(_set.Sub).Stop().Move(_set.Parent.Location.X, _set.Parent.Location.Y + _set.Parent.Height, 200);

                    // パネルを右に移動しながらサイズを変更する
                    nQuery.Select(_set.Pnl).Stop().Move(12, 137, 100)
                                                 .Size(751, 359, 200);
                }
                else
                {
                    CloseSamplePnl(_set);
                }
            }
        }

        /// <summary>
        /// サンプル閉じる
        /// </summary>
        /// <param name="set">メニューセット</param>
        private void CloseSamplePnl(MenueSet set)
        {
            // 元のポジションまで戻す
            nQuery.Select(set.Sub).Stop().Move(set.Parent.Location.X, set.Parent.Location.Y, 200);
            nQuery.Select(set.Pnl).Stop().Move(set.Parent.Location.X, set.Parent.Location.Y, 300)
                                         .Size(set.Parent.Size.Width, set.Parent.Size.Height, 200);

        }

        #endregion

        /// <summary>
        /// StartUpボタンクリック(上へ移動)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butDoup_Click(object sender, EventArgs e)
        {
            try
            {
                // 動作中の色を変える
                pnlMoveTarget.BackColor = ColorTranslator.FromHtml("#FFD464");
                // Location(90, 90)へテキストボックスで指定したスピードで移動
                nQuery.Select(pnlMoveTarget).Stop().Move(nQuery.Select(pnlMoveTarget).OriginalPos.X,
                                                         nQuery.Select(pnlMoveTarget).OriginalPos.Y - 50,
                                                         int.Parse(textBox1.Text),
                                                         new Action(() =>
                {
                    // 動作完了後色を戻す
                    pnlMoveTarget.BackColor = ColorTranslator.FromHtml("#555555");

                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// StartDownクリック(下へ移動)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butDoDown_Click(object sender, EventArgs e)
        {
            try
            {

                // 動作中の色を変える
                pnlMoveTarget.BackColor = ColorTranslator.FromHtml("#FFD464");

                // 現在地より120px下へテキストボックスで指定したスピードで移動
                nQuery.Select(pnlMoveTarget).Stop().Move(nQuery.Select(pnlMoveTarget).OriginalPos.X,
                                                         nQuery.Select(pnlMoveTarget).OriginalPos.Y + 50, 
                                                         int.Parse(textBox1.Text),
                                                         new Action(() =>
                {
                    // 動作完了後色を戻す
                    pnlMoveTarget.BackColor = ColorTranslator.FromHtml("#555555");

                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 左へ移動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoLeft_Click(object sender, EventArgs e)
        {
            try
            {

                // 動作中の色を変える
                pnlMoveTarget.BackColor = ColorTranslator.FromHtml("#FFD464");

                // 現在地より120px下へテキストボックスで指定したスピードで移動
                nQuery.Select(pnlMoveTarget).Stop().Move(nQuery.Select(pnlMoveTarget).OriginalPos.X - 50,
                                                         nQuery.Select(pnlMoveTarget).OriginalPos.Y,
                                                         int.Parse(textBox1.Text),
                                                         new Action(() =>
                                                         {
                                                             // 動作完了後色を戻す
                                                             pnlMoveTarget.BackColor = ColorTranslator.FromHtml("#555555");

                                                         }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 右へ移動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoRight_Click(object sender, EventArgs e)
        {
            try
            {

                // 動作中の色を変える
                pnlMoveTarget.BackColor = ColorTranslator.FromHtml("#FFD464");

                // 現在地より120px下へテキストボックスで指定したスピードで移動
                nQuery.Select(pnlMoveTarget).Stop().Move(nQuery.Select(pnlMoveTarget).OriginalPos.X + 50,
                                                         nQuery.Select(pnlMoveTarget).OriginalPos.Y,
                                                         int.Parse(textBox1.Text),
                                                         new Action(() =>
                                                         {
                                                             // 動作完了後色を戻す
                                                             pnlMoveTarget.BackColor = ColorTranslator.FromHtml("#555555");

                                                         }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 初期ポジション
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrgPos_Click(object sender, EventArgs e)
        {
            try
            {

                // 動作中の色を変える
                pnlMoveTarget.BackColor = ColorTranslator.FromHtml("#FFD464");

                // 現在地より120px下へテキストボックスで指定したスピードで移動
                nQuery.Select(pnlMoveTarget).Stop().Move(nQuery.Select(pnlMoveTarget).OriginalPos.X,
                                                         nQuery.Select(pnlMoveTarget).OriginalPos.Y,
                                                         int.Parse(textBox1.Text),
                                                         new Action(() =>
                                                         {
                                                             // 動作完了後色を戻す
                                                             pnlMoveTarget.BackColor = ColorTranslator.FromHtml("#555555");

                                                         }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Stopボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveStop_Click(object sender, EventArgs e)
        {
            try
            {
                // 動作を中断
                nQuery.Select(pnlMoveTarget).Stop();
                pnlMoveTarget.BackColor = ColorTranslator.FromHtml("#555555");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 拡大ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScaleUp_Click(object sender, EventArgs e)
        {
            try
            {
                // 動作中の色を変える
                pnlSizeTarget.BackColor = ColorTranslator.FromHtml("#FFD464");
                nQuery.Select(pnlSizeTarget).Stop().Size(200, 200, 1000, new Action(() =>
                {
                    // 動作完了後色を戻す
                    pnlSizeTarget.BackColor = ColorTranslator.FromHtml("#555555");

                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 縮小ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScaleDown_Click(object sender, EventArgs e)
        {
            try
            {
                // 動作中の色を変える
                pnlSizeTarget.BackColor = ColorTranslator.FromHtml("#FFD464");
                nQuery.Select(pnlSizeTarget).Stop().Size(nQuery.Select(pnlSizeTarget).OriginalSize.Width, 
                                                         nQuery.Select(pnlSizeTarget).OriginalSize.Height, 
                                                         1000, new Action(() =>
                {
                    // 動作完了後色を戻す
                    pnlSizeTarget.BackColor = ColorTranslator.FromHtml("#555555");

                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                nQuery.Select(pnlOpaTarget).Stop().FadeTo(int.Parse(txtOpacity.Text),
                                                         int.Parse(txtOpaSpeed.Text), 
                                                         new Action(() =>
                                                         {
                                                             

                                                         }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



    }
}
