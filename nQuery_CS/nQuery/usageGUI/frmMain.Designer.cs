namespace usageGUI
{
    partial class frmMain
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
            this.btnDoDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMoveEn = new System.Windows.Forms.Label();
            this.lblMoveJa = new System.Windows.Forms.Label();
            this.btnScaleUp = new System.Windows.Forms.Button();
            this.pnlSizeTarget = new System.Windows.Forms.Panel();
            this.btnScaleDown = new System.Windows.Forms.Button();
            this.pnlMoveSample = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpacity = new System.Windows.Forms.TextBox();
            this.txtOpaSpeed = new System.Windows.Forms.TextBox();
            this.pnlOpaTarget = new nQueryLib.UI.nQueryOpacityPanel();
            this.lblSizeEn = new System.Windows.Forms.Label();
            this.lblSizeJa = new System.Windows.Forms.Label();
            this.pnlSizeSample = new System.Windows.Forms.Panel();
            this.pnlMoveSample.SuspendLayout();
            this.pnlSizeSample.SuspendLayout();
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
            // lblMoveEn
            // 
            this.lblMoveEn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblMoveEn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMoveEn.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMoveEn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.lblMoveEn.Location = new System.Drawing.Point(12, 12);
            this.lblMoveEn.Name = "lblMoveEn";
            this.lblMoveEn.Size = new System.Drawing.Size(188, 74);
            this.lblMoveEn.TabIndex = 13;
            this.lblMoveEn.Text = "Move Sample";
            this.lblMoveEn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMoveEn.MouseLeave += new System.EventHandler(this.lblMoveEn_MouseLeave);
            this.lblMoveEn.MouseEnter += new System.EventHandler(this.lblMoveEn_MouseEnter);
            // 
            // lblMoveJa
            // 
            this.lblMoveJa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.lblMoveJa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMoveJa.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMoveJa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblMoveJa.Location = new System.Drawing.Point(12, 12);
            this.lblMoveJa.Name = "lblMoveJa";
            this.lblMoveJa.Size = new System.Drawing.Size(188, 74);
            this.lblMoveJa.TabIndex = 14;
            this.lblMoveJa.Text = "Moveの使い方の説明です";
            this.lblMoveJa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMoveJa.MouseLeave += new System.EventHandler(this.lblMoveJa_MouseLeave);
            // 
            // btnScaleUp
            // 
            this.btnScaleUp.Location = new System.Drawing.Point(22, 18);
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
            this.pnlSizeTarget.Location = new System.Drawing.Point(114, 18);
            this.pnlSizeTarget.Name = "pnlSizeTarget";
            this.pnlSizeTarget.Size = new System.Drawing.Size(36, 37);
            this.pnlSizeTarget.TabIndex = 3;
            // 
            // btnScaleDown
            // 
            this.btnScaleDown.Location = new System.Drawing.Point(22, 75);
            this.btnScaleDown.Name = "btnScaleDown";
            this.btnScaleDown.Size = new System.Drawing.Size(75, 37);
            this.btnScaleDown.TabIndex = 16;
            this.btnScaleDown.Text = "ScaleDown";
            this.btnScaleDown.UseVisualStyleBackColor = true;
            this.btnScaleDown.Click += new System.EventHandler(this.btnScaleDown_Click);
            // 
            // pnlMoveSample
            // 
            this.pnlMoveSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.pnlMoveSample.Controls.Add(this.butDoup);
            this.pnlMoveSample.Controls.Add(this.butMoveStop);
            this.pnlMoveSample.Controls.Add(this.pnlMoveTarget);
            this.pnlMoveSample.Controls.Add(this.textBox1);
            this.pnlMoveSample.Controls.Add(this.btnDoDown);
            this.pnlMoveSample.Controls.Add(this.label2);
            this.pnlMoveSample.Location = new System.Drawing.Point(12, 12);
            this.pnlMoveSample.Name = "pnlMoveSample";
            this.pnlMoveSample.Size = new System.Drawing.Size(188, 74);
            this.pnlMoveSample.TabIndex = 17;
            this.pnlMoveSample.MouseLeave += new System.EventHandler(this.pnlMoveSample_MouseLeave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Change";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(547, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 93);
            this.label3.TabIndex = 19;
            this.label3.Text = "This text is background";
            // 
            // txtOpacity
            // 
            this.txtOpacity.Location = new System.Drawing.Point(540, 429);
            this.txtOpacity.Name = "txtOpacity";
            this.txtOpacity.Size = new System.Drawing.Size(53, 19);
            this.txtOpacity.TabIndex = 20;
            this.txtOpacity.Text = "100";
            // 
            // txtOpaSpeed
            // 
            this.txtOpaSpeed.Location = new System.Drawing.Point(599, 429);
            this.txtOpaSpeed.Name = "txtOpaSpeed";
            this.txtOpaSpeed.Size = new System.Drawing.Size(53, 19);
            this.txtOpaSpeed.TabIndex = 21;
            this.txtOpaSpeed.Text = "1000";
            // 
            // pnlOpaTarget
            // 
            this.pnlOpaTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.pnlOpaTarget.Location = new System.Drawing.Point(540, 273);
            this.pnlOpaTarget.Name = "pnlOpaTarget";
            this.pnlOpaTarget.Size = new System.Drawing.Size(165, 150);
            this.pnlOpaTarget.TabIndex = 5;
            this.pnlOpaTarget.Text = "nQueryOpacityPanel1";
            // 
            // lblSizeEn
            // 
            this.lblSizeEn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblSizeEn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSizeEn.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSizeEn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.lblSizeEn.Location = new System.Drawing.Point(12, 92);
            this.lblSizeEn.Name = "lblSizeEn";
            this.lblSizeEn.Size = new System.Drawing.Size(188, 74);
            this.lblSizeEn.TabIndex = 22;
            this.lblSizeEn.Text = "Size Sample";
            this.lblSizeEn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSizeEn.MouseLeave += new System.EventHandler(this.lblSizeEn_MouseLeave);
            this.lblSizeEn.MouseEnter += new System.EventHandler(this.lblSizeSample_MouseEnter);
            // 
            // lblSizeJa
            // 
            this.lblSizeJa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(102)))));
            this.lblSizeJa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSizeJa.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSizeJa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblSizeJa.Location = new System.Drawing.Point(12, 92);
            this.lblSizeJa.Name = "lblSizeJa";
            this.lblSizeJa.Size = new System.Drawing.Size(188, 74);
            this.lblSizeJa.TabIndex = 23;
            this.lblSizeJa.Text = "Sizeの使い方の説明です";
            this.lblSizeJa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSizeJa.MouseLeave += new System.EventHandler(this.lblSizeJa_MouseLeave);
            // 
            // pnlSizeSample
            // 
            this.pnlSizeSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.pnlSizeSample.Controls.Add(this.btnScaleUp);
            this.pnlSizeSample.Controls.Add(this.pnlSizeTarget);
            this.pnlSizeSample.Controls.Add(this.btnScaleDown);
            this.pnlSizeSample.Location = new System.Drawing.Point(12, 92);
            this.pnlSizeSample.Name = "pnlSizeSample";
            this.pnlSizeSample.Size = new System.Drawing.Size(188, 74);
            this.pnlSizeSample.TabIndex = 24;
            this.pnlSizeSample.MouseLeave += new System.EventHandler(this.pnlSizeSample_MouseLeave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 508);
            this.Controls.Add(this.txtOpaSpeed);
            this.Controls.Add(this.txtOpacity);
            this.Controls.Add(this.pnlOpaTarget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblMoveEn);
            this.Controls.Add(this.lblMoveJa);
            this.Controls.Add(this.pnlMoveSample);
            this.Controls.Add(this.lblSizeEn);
            this.Controls.Add(this.lblSizeJa);
            this.Controls.Add(this.pnlSizeSample);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMoveSample.ResumeLayout(false);
            this.pnlMoveSample.PerformLayout();
            this.pnlSizeSample.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butDoup;
        private System.Windows.Forms.Button butMoveStop;
        private System.Windows.Forms.Panel pnlMoveTarget;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDoDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMoveEn;
        private System.Windows.Forms.Label lblMoveJa;
        private System.Windows.Forms.Button btnScaleUp;
        private System.Windows.Forms.Panel pnlSizeTarget;
        private System.Windows.Forms.Button btnScaleDown;
        private System.Windows.Forms.Panel pnlMoveSample;
        private System.Windows.Forms.Button button2;
        private nQueryLib.UI.nQueryOpacityPanel pnlOpaTarget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpacity;
        private System.Windows.Forms.TextBox txtOpaSpeed;
        private System.Windows.Forms.Label lblSizeEn;
        private System.Windows.Forms.Label lblSizeJa;
        private System.Windows.Forms.Panel pnlSizeSample;
    }
}

