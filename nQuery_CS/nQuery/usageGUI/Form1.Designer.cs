namespace usageGUI
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.butDoup = new System.Windows.Forms.Button();
            this.butMoveStop = new System.Windows.Forms.Button();
            this.pnlMoveTarget = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDoDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblUnder = new System.Windows.Forms.Label();
            this.btnScaleUp = new System.Windows.Forms.Button();
            this.pnlSizeTarget = new System.Windows.Forms.Panel();
            this.btnScaleDown = new System.Windows.Forms.Button();
            this.transparentPanel1 = new nQueryLib.UI.TransparentPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.transparentLabel1 = new nQueryLib.UI.TransparentPanel();
            this.panel2.SuspendLayout();
            this.transparentPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butDoup
            // 
            this.butDoup.Location = new System.Drawing.Point(12, 12);
            this.butDoup.Name = "butDoup";
            this.butDoup.Size = new System.Drawing.Size(75, 23);
            this.butDoup.TabIndex = 0;
            this.butDoup.Text = "Start Up";
            this.butDoup.UseVisualStyleBackColor = true;
            this.butDoup.Click += new System.EventHandler(this.butDoup_Click);
            // 
            // butMoveStop
            // 
            this.butMoveStop.Location = new System.Drawing.Point(93, 12);
            this.butMoveStop.Name = "butMoveStop";
            this.butMoveStop.Size = new System.Drawing.Size(75, 23);
            this.butMoveStop.TabIndex = 1;
            this.butMoveStop.Text = "Stop";
            this.butMoveStop.UseVisualStyleBackColor = true;
            this.butMoveStop.Click += new System.EventHandler(this.btnMoveStop_Click);
            // 
            // pnlMoveTarget
            // 
            this.pnlMoveTarget.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMoveTarget.Location = new System.Drawing.Point(90, 90);
            this.pnlMoveTarget.Name = "pnlMoveTarget";
            this.pnlMoveTarget.Size = new System.Drawing.Size(36, 37);
            this.pnlMoveTarget.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "1000";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(508, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 162);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(17, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Back";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(479, 449);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(53, 19);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "100";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(538, 449);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(53, 19);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "100";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(597, 449);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(53, 19);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "100";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(656, 449);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(53, 19);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "100";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(479, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Change";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDoDown
            // 
            this.btnDoDown.Location = new System.Drawing.Point(12, 41);
            this.btnDoDown.Name = "btnDoDown";
            this.btnDoDown.Size = new System.Drawing.Size(75, 23);
            this.btnDoDown.TabIndex = 11;
            this.btnDoDown.Text = "Start Down";
            this.btnDoDown.UseVisualStyleBackColor = true;
            this.btnDoDown.Click += new System.EventHandler(this.butDoDown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "speed";
            // 
            // lblTop
            // 
            this.lblTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTop.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.lblTop.Location = new System.Drawing.Point(344, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(188, 74);
            this.lblTop.TabIndex = 13;
            this.lblTop.Text = "Hover Me!";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTop.MouseLeave += new System.EventHandler(this.lblTop_MouseLeave);
            this.lblTop.MouseEnter += new System.EventHandler(this.lblTop_MouseEnter);
            // 
            // lblUnder
            // 
            this.lblUnder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.lblUnder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnder.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUnder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblUnder.Location = new System.Drawing.Point(344, 9);
            this.lblUnder.Name = "lblUnder";
            this.lblUnder.Size = new System.Drawing.Size(188, 74);
            this.lblUnder.TabIndex = 14;
            this.lblUnder.Text = "Hello nQuery";
            this.lblUnder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUnder.MouseLeave += new System.EventHandler(this.lblUnder_MouseLeave);
            // 
            // btnScaleUp
            // 
            this.btnScaleUp.Location = new System.Drawing.Point(12, 273);
            this.btnScaleUp.Name = "btnScaleUp";
            this.btnScaleUp.Size = new System.Drawing.Size(75, 37);
            this.btnScaleUp.TabIndex = 15;
            this.btnScaleUp.Text = "ScaleUp";
            this.btnScaleUp.UseVisualStyleBackColor = true;
            this.btnScaleUp.Click += new System.EventHandler(this.btnScaleUp_Click);
            // 
            // pnlSizeTarget
            // 
            this.pnlSizeTarget.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlSizeTarget.Location = new System.Drawing.Point(104, 273);
            this.pnlSizeTarget.Name = "pnlSizeTarget";
            this.pnlSizeTarget.Size = new System.Drawing.Size(36, 37);
            this.pnlSizeTarget.TabIndex = 3;
            // 
            // btnScaleDown
            // 
            this.btnScaleDown.Location = new System.Drawing.Point(12, 330);
            this.btnScaleDown.Name = "btnScaleDown";
            this.btnScaleDown.Size = new System.Drawing.Size(75, 37);
            this.btnScaleDown.TabIndex = 16;
            this.btnScaleDown.Text = "ScaleDown";
            this.btnScaleDown.UseVisualStyleBackColor = true;
            this.btnScaleDown.Click += new System.EventHandler(this.btnScaleDown_Click);
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.AllowTransparency = true;
            this.transparentPanel1.Controls.Add(this.button6);
            this.transparentPanel1.Controls.Add(this.button5);
            this.transparentPanel1.Controls.Add(this.button4);
            this.transparentPanel1.Location = new System.Drawing.Point(488, 214);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(112, 229);
            this.transparentPanel1.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(19, 156);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.AllowTransparency = true;
            this.transparentLabel1.Location = new System.Drawing.Point(606, 214);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(110, 232);
            this.transparentLabel1.TabIndex = 4;
            this.transparentLabel1.Text = "transparentLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 508);
            this.Controls.Add(this.btnScaleDown);
            this.Controls.Add(this.pnlSizeTarget);
            this.Controls.Add(this.btnScaleUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDoDown);
            this.Controls.Add(this.transparentPanel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.transparentLabel1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pnlMoveTarget);
            this.Controls.Add(this.butMoveStop);
            this.Controls.Add(this.butDoup);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.lblUnder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.transparentPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butDoup;
        private System.Windows.Forms.Button butMoveStop;
        private System.Windows.Forms.Panel pnlMoveTarget;
        private System.Windows.Forms.TextBox textBox1;
        private nQueryLib.UI.TransparentPanel transparentLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private nQueryLib.UI.TransparentPanel transparentPanel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDoDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblUnder;
        private System.Windows.Forms.Button btnScaleUp;
        private System.Windows.Forms.Panel pnlSizeTarget;
        private System.Windows.Forms.Button btnScaleDown;
    }
}

