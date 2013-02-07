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

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// StartUpボタンクリック
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
        /// StartDownクリック
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
                                                         nQuery.Select(pnlMoveTarget).OriginalPos.Y + 120, 
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
        /// lblMoveEnにマウスポインタが侵入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMoveEn_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                // サブラベルを下方に移動
                nQuery.Select(lblMoveJa).Stop().Move(lblMoveEn.Location.X, lblMoveEn.Location.Y + lblMoveEn.Height, 200);

                // パネルを右に移動しながらサイズを変更する
                nQuery.Select(pnlMoveSample).Stop().Move(lblMoveEn.Location.X + lblMoveEn.Size.Width, lblMoveEn.Location.Y, 100)
                                               .Size(541, 484, 200);
            }
            catch (Exception ex)
            { }
        }

        /// <summary>
        /// lblMoveEnからマウスポインタが離脱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMoveEn_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                // lblUnderまたはpnlInCtrlにマウスが当たっている場合は処理を行わない
                if (!nQuery.Select(lblMoveJa).IsMouseUnder && !nQuery.Select(pnlMoveSample).IsMouseUnder)
                {
                    CloseMoveSample();
                }
            }
            catch (Exception ex)
            { }
        }

        /// <summary>
        /// lblMoveJaからマウスポインタが離脱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMoveJa_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                // pnlMoveSampleにフォーカスがあたっていない場合
                if (!nQuery.Select(pnlMoveSample).IsMouseUnder)
                {
                    CloseMoveSample();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// pnlMoveSampleからマウスポインタが離脱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlMoveSample_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                // lblMoveJaにフォーカスがあたっていない場合
                // また、コントロールが内包するコントロールにMouseEnterが発生すると
                // MouseLeaveが発生するので
                // pnlMoveSampleがマウス座標下にいないことも条件に含める
                if (!nQuery.Select(lblMoveJa).IsMouseUnder && !nQuery.Select(pnlMoveSample).IsMouseUnder)
                {
                    CloseMoveSample();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseMoveSample()
        {
            // 元のポジションまで戻す
            nQuery.Select(lblMoveJa).Stop().Move(lblMoveEn.Location.X, lblMoveEn.Location.Y, 200);
            nQuery.Select(pnlMoveSample).Stop().Move(lblMoveEn.Location.X, lblMoveEn.Location.Y, 300)
                                           .Size(lblMoveEn.Size.Width, lblMoveEn.Size.Height, 200);

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

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
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


        private void lblSizeSample_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                // サブラベルを下方に移動
                nQuery.Select(lblSizeJa).Stop().Move(lblSizeEn.Location.X, lblSizeEn.Location.Y + lblSizeEn.Height, 200);

                // パネルを右に移動しながらサイズを変更する
                nQuery.Select(pnlSizeSample).Stop().Move(lblSizeEn.Location.X + lblSizeEn.Size.Width, lblMoveEn.Location.Y, 100)
                                                   .Size(541, 484, 200);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblSizeEn_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (!nQuery.Select(lblSizeJa).IsMouseUnder && !nQuery.Select(pnlSizeSample).IsMouseUnder)
                {
                    CloseSizeSample();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblSizeJa_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                // pnlSizeSampleにフォーカスがあたっていない場合
                if (!nQuery.Select(pnlSizeSample).IsMouseUnder)
                {
                    CloseSizeSample();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnlSizeSample_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                // lblSizeJaにフォーカスがあたっていない場合
                // また、コントロールが内包するコントロールにMouseEnterが発生すると
                // MouseLeaveが発生するので
                // pnlSizeSampleがマウス座標下にいないことも条件に含める
                if (!nQuery.Select(lblSizeJa).IsMouseUnder && !nQuery.Select(pnlSizeSample).IsMouseUnder)
                {
                    CloseSizeSample();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseSizeSample()
        {
            // 元のポジションまで戻す
            nQuery.Select(lblSizeJa).Stop().Move(lblSizeEn.Location.X, lblSizeEn.Location.Y, 200);
            nQuery.Select(pnlSizeSample).Stop().Move(lblSizeEn.Location.X, lblSizeEn.Location.Y, 300)
                                           .Size(lblSizeEn.Size.Width, lblSizeEn.Size.Height, 200);

        }
    }
}
