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

            transparentLabel1.BackColor =  Color.FromArgb(220, 255, 255, 255); // 半透明
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
        /// lblTopにマウスポインタが侵入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblTop_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                // ラベルを下方に移動
                nQuery.Select(lblUnder).Stop().Move(lblTop.Location.X, lblTop.Location.Y + lblTop.Height, 200);

                // パネルを右に移動しながらサイズを変更する
                nQuery.Select(pnlInCtrl).Stop().Move(lblTop.Location.X + lblTop.Size.Width, lblTop.Location.Y, 100)
                                               .Size(lblTop.Size.Width, lblTop.Size.Height * 2, 200);
            }
            catch (Exception ex)
            { }
        }

        /// <summary>
        /// lblTopからマウスポインタが離脱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblTop_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                // lblUnderまたはpnlInCtrlにマウスが当たっている場合は処理を行わない
                if (!nQuery.Select(lblUnder).IsMouseUnder && !nQuery.Select(pnlInCtrl).IsMouseUnder)
                {
                    nQuery.Select(lblUnder).Stop().Move(lblTop.Location.X, lblTop.Location.Y, 500);
                    nQuery.Select(pnlInCtrl).Stop().Move(lblTop.Location.X, lblTop.Location.Y, 500).Size(lblTop.Size.Width, lblTop.Size.Height,200);
                }
            }
            catch (Exception ex)
            { }
        }

        /// <summary>
        /// lblUnderからマウスポインタが離脱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblUnder_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                // pnlInCtrlにフォーカスがあたっていない場合
                if (!nQuery.Select(pnlInCtrl).IsMouseUnder)
                {
                    // 元のポジションまで戻す
                    nQuery.Select(lblUnder).Stop().Move(lblTop.Location.X, lblTop.Location.Y, 500);
                    nQuery.Select(pnlInCtrl).Stop().Move(lblTop.Location.X, lblTop.Location.Y, 500).Size(lblTop.Size.Width, lblTop.Size.Height, 200);
                }
            }
            catch (Exception ex)
            { }
        }

        /// <summary>
        /// pnlInCtrlからマウスポインタが離脱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlInCtrl_MouseLeave(object sender, EventArgs e)
        {
            // lblUnderにフォーカスがあたっていない場合
            // また、コントロールが内包するコントロールにMouseEnterが発生すると
            // MouseLeaveが発生するので
            // pnlInCtrlがマウス座標下にいないことも条件に含める
            if (!nQuery.Select(lblUnder).IsMouseUnder && !nQuery.Select(pnlInCtrl).IsMouseUnder)
            {
                // 元のポジションまで戻す
                nQuery.Select(lblUnder).Stop().Move(lblTop.Location.X, lblTop.Location.Y, 500);
                nQuery.Select(pnlInCtrl).Stop().Move(lblTop.Location.X, lblTop.Location.Y, 500).Size(lblTop.Size.Width, lblTop.Size.Height, 200);
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

        private void button3_Click(object sender, EventArgs e)
        {
            transparentLabel1.BackColor = Color.FromArgb(int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text));
            transparentPanel1.BackColor = Color.FromArgb(int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text));

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

    }
}
