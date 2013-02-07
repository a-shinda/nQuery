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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            try
            {
                // Demoアクションを行う
                nQuery.Select(this).Size(500, 250, 500, new Action(() =>
                {
                    nQuery.Select(lblN).Move(178, lblQuery.Location.Y, 2000, new Action(() =>
                    {
                        lblN.ForeColor = ColorTranslator.FromHtml("#FF007E");
                        lblN.Update();
                        nQuery.Select(this).Stop();
                        BoundAndClose()();

                    }));

                })).Move(this.Location.X - 200, this.Location.Y, 500);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 左方向にバウンドしたあと、フォームを閉じる
        /// </summary>
        /// <returns></returns>
        private Action BoundAndClose()
        {
            return new Action(() =>
            {
                nQuery.Select(lblN).Move(lblN.Location.X - 10, lblN.Location.Y, 100, new Action(() =>
                    {
                        nQuery.Select(lblN).Move(lblN.Location.X + 8, lblN.Location.Y, 80, new Action(() =>
                        {
                            nQuery.Select(lblN).Move(lblN.Location.X - 4, lblN.Location.Y, 50, new Action(() =>
                            {
                                nQuery.Select(lblN).Move(lblN.Location.X + 4, lblN.Location.Y, 50, new Action(() =>
                                {
                                    nQuery.Select(lblN).Move(lblN.Location.X - 4, lblN.Location.Y, 50, new Action(() =>
                                    {
                                        nQuery.Select(lblN).Move(lblN.Location.X + 4, lblN.Location.Y, 50, new Action(() =>
                                        {
                                            System.Threading.Thread.Sleep(1500);
                                            this.Close();

                                        })); 
                                    })); 
                                })); 
                            })); 
                        })); 
                    })); 
            });
        }
    }
}
