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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            transparentLabel1.BackColor =  Color.FromArgb(220, 255, 255, 255); // 半透明
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.BackColor = ColorTranslator.FromHtml("#FFD464");
                nQuery.Select(panel1).Stop().Move(90, 90, int.Parse(textBox1.Text), new Action(() =>
                {
                    panel1.BackColor = ColorTranslator.FromHtml("#555555");
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.BackColor = ColorTranslator.FromHtml("#FFD464");
                nQuery.Select(panel1).Stop().Move(90, 200, int.Parse(textBox1.Text), new Action(() =>
                {
                    panel1.BackColor = ColorTranslator.FromHtml("#555555");
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nQuery.Select(panel1).Stop();
            panel1.BackColor = ColorTranslator.FromHtml("#555555");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            transparentLabel1.BackColor = Color.FromArgb(int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text));
            transparentPanel1.BackColor = Color.FromArgb(int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text)); 

        }

        private void lblTop_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                if (lblUnder.Location == nQuery.Select(lblUnder).OriginalPos)
                {
                    nQuery.Select(lblUnder).Stop().Move(0, lblTop.Height, 200);
                }
            }
            catch (Exception ex)
            { }
        }

        private void lblUnder_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                nQuery.Select(lblUnder).Stop().Move(0, -(lblTop.Height), 200);
            }
            catch (Exception ex)
            { }
        }

    }
}
