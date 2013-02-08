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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrgPos = new System.Windows.Forms.Button();
            this.btnDoRight = new System.Windows.Forms.Button();
            this.btnDoLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nQueryOpacityLabel18 = new nQueryLib.UI.nQueryOpacityLabel();
            this.nQueryOpacityLabel17 = new nQueryLib.UI.nQueryOpacityLabel();
            this.nQueryOpacityLabel2 = new nQueryLib.UI.nQueryOpacityLabel();
            this.nQueryOpacityLabel1 = new nQueryLib.UI.nQueryOpacityLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpacity = new System.Windows.Forms.TextBox();
            this.txtOpaSpeed = new System.Windows.Forms.TextBox();
            this.lblSizeEn = new System.Windows.Forms.Label();
            this.lblSizeJa = new System.Windows.Forms.Label();
            this.pnlSizeSample = new System.Windows.Forms.Panel();
            this.pnlOpaTarget = new nQueryLib.UI.nQueryOpacityPanel();
            this.lblFadeEn = new System.Windows.Forms.Label();
            this.lblWhatEn = new System.Windows.Forms.Label();
            this.lblFadeJa = new System.Windows.Forms.Label();
            this.pnlFadeSample = new System.Windows.Forms.Panel();
            this.lblQuery = new nQueryLib.UI.nQueryOpacityLabel();
            this.lblWhatJa = new System.Windows.Forms.Label();
            this.pnlWhat = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nQueryOpacityLabel16 = new nQueryLib.UI.nQueryOpacityLabel();
            this.nQueryOpacityLabel13 = new nQueryLib.UI.nQueryOpacityLabel();
            this.nQueryOpacityLabel14 = new nQueryLib.UI.nQueryOpacityLabel();
            this.nQueryOpacityLabel15 = new nQueryLib.UI.nQueryOpacityLabel();
            this.nQueryOpacityLabel12 = new nQueryLib.UI.nQueryOpacityLabel();
            this.nQueryOpacityLabel10 = new nQueryLib.UI.nQueryOpacityLabel();
            this.nQueryOpacityLabel11 = new nQueryLib.UI.nQueryOpacityLabel();
            this.nQueryOpacityLabel9 = new nQueryLib.UI.nQueryOpacityLabel();
            this.nQueryOpacityLabel8 = new nQueryLib.UI.nQueryOpacityLabel();
            this.nQueryOpacityLabel7 = new nQueryLib.UI.nQueryOpacityLabel();
            this.nQueryOpacityLabel5 = new nQueryLib.UI.nQueryOpacityLabel();
            this.nQueryOpacityLabel6 = new nQueryLib.UI.nQueryOpacityLabel();
            this.nQueryOpacityLabel3 = new nQueryLib.UI.nQueryOpacityLabel();
            this.nQueryOpacityLabel4 = new nQueryLib.UI.nQueryOpacityLabel();
            this.pnlMoveSample.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSizeSample.SuspendLayout();
            this.pnlFadeSample.SuspendLayout();
            this.pnlWhat.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // butDoup
            // 
            this.butDoup.Location = new System.Drawing.Point(61, 90);
            this.butDoup.Name = "butDoup";
            this.butDoup.Size = new System.Drawing.Size(35, 35);
            this.butDoup.TabIndex = 0;
            this.butDoup.Text = "↑";
            this.butDoup.UseVisualStyleBackColor = true;
            this.butDoup.Click += new System.EventHandler(this.butDoup_Click);
            // 
            // butMoveStop
            // 
            this.butMoveStop.Location = new System.Drawing.Point(61, 128);
            this.butMoveStop.Name = "butMoveStop";
            this.butMoveStop.Size = new System.Drawing.Size(35, 35);
            this.butMoveStop.TabIndex = 1;
            this.butMoveStop.Text = "■";
            this.butMoveStop.UseVisualStyleBackColor = true;
            this.butMoveStop.Click += new System.EventHandler(this.btnMoveStop_Click);
            // 
            // pnlMoveTarget
            // 
            this.pnlMoveTarget.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMoveTarget.Location = new System.Drawing.Point(330, 150);
            this.pnlMoveTarget.Name = "pnlMoveTarget";
            this.pnlMoveTarget.Size = new System.Drawing.Size(36, 37);
            this.pnlMoveTarget.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 21);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "1000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDoDown
            // 
            this.btnDoDown.Location = new System.Drawing.Point(61, 166);
            this.btnDoDown.Name = "btnDoDown";
            this.btnDoDown.Size = new System.Drawing.Size(35, 35);
            this.btnDoDown.TabIndex = 11;
            this.btnDoDown.Text = "↓";
            this.btnDoDown.UseVisualStyleBackColor = true;
            this.btnDoDown.Click += new System.EventHandler(this.butDoDown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "speed";
            // 
            // lblMoveEn
            // 
            this.lblMoveEn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(76)))), ((int)(((byte)(187)))));
            this.lblMoveEn.Font = new System.Drawing.Font("HGS明朝E", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMoveEn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblMoveEn.Location = new System.Drawing.Point(200, 5);
            this.lblMoveEn.Name = "lblMoveEn";
            this.lblMoveEn.Size = new System.Drawing.Size(188, 74);
            this.lblMoveEn.TabIndex = 13;
            this.lblMoveEn.Text = "Move Sample";
            this.lblMoveEn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMoveEn.MouseEnter += new System.EventHandler(this.lblTop_MouseEnter);
            // 
            // lblMoveJa
            // 
            this.lblMoveJa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(87)))), ((int)(((byte)(202)))));
            this.lblMoveJa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMoveJa.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMoveJa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblMoveJa.Location = new System.Drawing.Point(200, 5);
            this.lblMoveJa.Name = "lblMoveJa";
            this.lblMoveJa.Size = new System.Drawing.Size(188, 40);
            this.lblMoveJa.TabIndex = 14;
            this.lblMoveJa.Text = "Moveの使い方の説明です";
            this.lblMoveJa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnScaleUp
            // 
            this.btnScaleUp.Location = new System.Drawing.Point(22, 19);
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
            this.pnlSizeTarget.Location = new System.Drawing.Point(114, 19);
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
            this.pnlMoveSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(87)))), ((int)(((byte)(202)))));
            this.pnlMoveSample.Controls.Add(this.panel1);
            this.pnlMoveSample.Location = new System.Drawing.Point(200, 8);
            this.pnlMoveSample.Name = "pnlMoveSample";
            this.pnlMoveSample.Size = new System.Drawing.Size(188, 70);
            this.pnlMoveSample.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.btnOrgPos);
            this.panel1.Controls.Add(this.btnDoRight);
            this.panel1.Controls.Add(this.btnDoLeft);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nQueryOpacityLabel18);
            this.panel1.Controls.Add(this.nQueryOpacityLabel17);
            this.panel1.Controls.Add(this.nQueryOpacityLabel2);
            this.panel1.Controls.Add(this.nQueryOpacityLabel1);
            this.panel1.Controls.Add(this.butDoup);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.butMoveStop);
            this.panel1.Controls.Add(this.btnDoDown);
            this.panel1.Controls.Add(this.pnlMoveTarget);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 51);
            this.panel1.TabIndex = 13;
            // 
            // btnOrgPos
            // 
            this.btnOrgPos.Location = new System.Drawing.Point(22, 251);
            this.btnOrgPos.Name = "btnOrgPos";
            this.btnOrgPos.Size = new System.Drawing.Size(113, 35);
            this.btnOrgPos.TabIndex = 36;
            this.btnOrgPos.Text = "Original Position";
            this.btnOrgPos.UseVisualStyleBackColor = true;
            this.btnOrgPos.Click += new System.EventHandler(this.btnOrgPos_Click);
            // 
            // btnDoRight
            // 
            this.btnDoRight.Location = new System.Drawing.Point(102, 128);
            this.btnDoRight.Name = "btnDoRight";
            this.btnDoRight.Size = new System.Drawing.Size(35, 35);
            this.btnDoRight.TabIndex = 35;
            this.btnDoRight.Text = "→";
            this.btnDoRight.UseVisualStyleBackColor = true;
            this.btnDoRight.Click += new System.EventHandler(this.btnDoRight_Click);
            // 
            // btnDoLeft
            // 
            this.btnDoLeft.Location = new System.Drawing.Point(22, 128);
            this.btnDoLeft.Name = "btnDoLeft";
            this.btnDoLeft.Size = new System.Drawing.Size(35, 35);
            this.btnDoLeft.TabIndex = 34;
            this.btnDoLeft.Text = "←";
            this.btnDoLeft.UseVisualStyleBackColor = true;
            this.btnDoLeft.Click += new System.EventHandler(this.btnDoLeft_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "(m/s)";
            // 
            // nQueryOpacityLabel18
            // 
            this.nQueryOpacityLabel18.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel18.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nQueryOpacityLabel18.Location = new System.Drawing.Point(19, 385);
            this.nQueryOpacityLabel18.Name = "nQueryOpacityLabel18";
            this.nQueryOpacityLabel18.Size = new System.Drawing.Size(695, 106);
            this.nQueryOpacityLabel18.TabIndex = 32;
            this.nQueryOpacityLabel18.Text = "のように\r\nnQuery.Select(対象のコントロール).Move(移動終了X座標, 移動終了Y座標, 移動スピード(m/s), [option:CallBa" +
                "ck]);\r\nと記述します。\r\n上記の例では、\"TargetControl\"をPoint(100, 200)まで、1秒で動かす\r\nことになります。";
            // 
            // nQueryOpacityLabel17
            // 
            this.nQueryOpacityLabel17.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel17.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nQueryOpacityLabel17.Location = new System.Drawing.Point(20, 360);
            this.nQueryOpacityLabel17.Name = "nQueryOpacityLabel17";
            this.nQueryOpacityLabel17.Size = new System.Drawing.Size(610, 23);
            this.nQueryOpacityLabel17.TabIndex = 31;
            this.nQueryOpacityLabel17.Text = "nQuery.Select(TargetControl).Move(100, 200, 1000);";
            // 
            // nQueryOpacityLabel2
            // 
            this.nQueryOpacityLabel2.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel2.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nQueryOpacityLabel2.Location = new System.Drawing.Point(17, 64);
            this.nQueryOpacityLabel2.Name = "nQueryOpacityLabel2";
            this.nQueryOpacityLabel2.Size = new System.Drawing.Size(610, 20);
            this.nQueryOpacityLabel2.TabIndex = 30;
            this.nQueryOpacityLabel2.Text = "Moveメソッドを使用すると、コントロールの移動が行えます。";
            // 
            // nQueryOpacityLabel1
            // 
            this.nQueryOpacityLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel1.Font = new System.Drawing.Font("HGS明朝E", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel1.ForeColor = System.Drawing.Color.Silver;
            this.nQueryOpacityLabel1.Location = new System.Drawing.Point(7, 7);
            this.nQueryOpacityLabel1.Name = "nQueryOpacityLabel1";
            this.nQueryOpacityLabel1.Size = new System.Drawing.Size(473, 55);
            this.nQueryOpacityLabel1.TabIndex = 29;
            this.nQueryOpacityLabel1.Text = "Moveの使い方";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(70, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 26);
            this.button2.TabIndex = 18;
            this.button2.Text = "Change";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(77, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 93);
            this.label3.TabIndex = 19;
            this.label3.Text = "This text is background";
            // 
            // txtOpacity
            // 
            this.txtOpacity.Location = new System.Drawing.Point(41, 203);
            this.txtOpacity.Name = "txtOpacity";
            this.txtOpacity.Size = new System.Drawing.Size(53, 21);
            this.txtOpacity.TabIndex = 20;
            this.txtOpacity.Text = "100";
            // 
            // txtOpaSpeed
            // 
            this.txtOpaSpeed.Location = new System.Drawing.Point(129, 203);
            this.txtOpaSpeed.Name = "txtOpaSpeed";
            this.txtOpaSpeed.Size = new System.Drawing.Size(53, 21);
            this.txtOpaSpeed.TabIndex = 21;
            this.txtOpaSpeed.Text = "1000";
            // 
            // lblSizeEn
            // 
            this.lblSizeEn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.lblSizeEn.Font = new System.Drawing.Font("HGS明朝E", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSizeEn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblSizeEn.Location = new System.Drawing.Point(388, 5);
            this.lblSizeEn.Name = "lblSizeEn";
            this.lblSizeEn.Size = new System.Drawing.Size(188, 74);
            this.lblSizeEn.TabIndex = 22;
            this.lblSizeEn.Text = "Size Sample";
            this.lblSizeEn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSizeEn.MouseEnter += new System.EventHandler(this.lblTop_MouseEnter);
            // 
            // lblSizeJa
            // 
            this.lblSizeJa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSizeJa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSizeJa.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSizeJa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblSizeJa.Location = new System.Drawing.Point(388, 5);
            this.lblSizeJa.Name = "lblSizeJa";
            this.lblSizeJa.Size = new System.Drawing.Size(188, 40);
            this.lblSizeJa.TabIndex = 23;
            this.lblSizeJa.Text = "Sizeの使い方の説明です";
            this.lblSizeJa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSizeSample
            // 
            this.pnlSizeSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.pnlSizeSample.Controls.Add(this.btnScaleUp);
            this.pnlSizeSample.Controls.Add(this.pnlSizeTarget);
            this.pnlSizeSample.Controls.Add(this.btnScaleDown);
            this.pnlSizeSample.Location = new System.Drawing.Point(388, 5);
            this.pnlSizeSample.Name = "pnlSizeSample";
            this.pnlSizeSample.Size = new System.Drawing.Size(188, 74);
            this.pnlSizeSample.TabIndex = 24;
            // 
            // pnlOpaTarget
            // 
            this.pnlOpaTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(92)))), ((int)(((byte)(91)))));
            this.pnlOpaTarget.Location = new System.Drawing.Point(70, 47);
            this.pnlOpaTarget.Name = "pnlOpaTarget";
            this.pnlOpaTarget.Size = new System.Drawing.Size(165, 151);
            this.pnlOpaTarget.TabIndex = 5;
            this.pnlOpaTarget.Text = "nQueryOpacityPanel1";
            // 
            // lblFadeEn
            // 
            this.lblFadeEn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(178)))), ((int)(((byte)(60)))));
            this.lblFadeEn.Font = new System.Drawing.Font("HGS明朝E", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFadeEn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblFadeEn.Location = new System.Drawing.Point(576, 5);
            this.lblFadeEn.Name = "lblFadeEn";
            this.lblFadeEn.Size = new System.Drawing.Size(188, 74);
            this.lblFadeEn.TabIndex = 25;
            this.lblFadeEn.Text = "Fade Sample";
            this.lblFadeEn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFadeEn.MouseEnter += new System.EventHandler(this.lblTop_MouseEnter);
            // 
            // lblWhatEn
            // 
            this.lblWhatEn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.lblWhatEn.Font = new System.Drawing.Font("HGS明朝E", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblWhatEn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblWhatEn.Location = new System.Drawing.Point(12, 5);
            this.lblWhatEn.Name = "lblWhatEn";
            this.lblWhatEn.Size = new System.Drawing.Size(188, 74);
            this.lblWhatEn.TabIndex = 26;
            this.lblWhatEn.Text = "What\'s nQuery";
            this.lblWhatEn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWhatEn.MouseEnter += new System.EventHandler(this.lblTop_MouseEnter);
            // 
            // lblFadeJa
            // 
            this.lblFadeJa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.lblFadeJa.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFadeJa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblFadeJa.Location = new System.Drawing.Point(576, 5);
            this.lblFadeJa.Name = "lblFadeJa";
            this.lblFadeJa.Size = new System.Drawing.Size(188, 40);
            this.lblFadeJa.TabIndex = 27;
            this.lblFadeJa.Text = "Sizeの使い方の説明です";
            this.lblFadeJa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFadeSample
            // 
            this.pnlFadeSample.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFadeSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.pnlFadeSample.Controls.Add(this.pnlOpaTarget);
            this.pnlFadeSample.Controls.Add(this.button2);
            this.pnlFadeSample.Controls.Add(this.label3);
            this.pnlFadeSample.Controls.Add(this.txtOpaSpeed);
            this.pnlFadeSample.Controls.Add(this.txtOpacity);
            this.pnlFadeSample.Location = new System.Drawing.Point(576, 5);
            this.pnlFadeSample.Name = "pnlFadeSample";
            this.pnlFadeSample.Size = new System.Drawing.Size(188, 74);
            this.pnlFadeSample.TabIndex = 25;
            // 
            // lblQuery
            // 
            this.lblQuery.BackColor = System.Drawing.Color.Transparent;
            this.lblQuery.Font = new System.Drawing.Font("HGS明朝E", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblQuery.ForeColor = System.Drawing.Color.Silver;
            this.lblQuery.Location = new System.Drawing.Point(572, 430);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(203, 55);
            this.lblQuery.TabIndex = 28;
            this.lblQuery.Text = "nQuery";
            // 
            // lblWhatJa
            // 
            this.lblWhatJa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(64)))), ((int)(((byte)(52)))));
            this.lblWhatJa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWhatJa.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblWhatJa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.lblWhatJa.Location = new System.Drawing.Point(12, 5);
            this.lblWhatJa.Name = "lblWhatJa";
            this.lblWhatJa.Size = new System.Drawing.Size(188, 40);
            this.lblWhatJa.TabIndex = 29;
            this.lblWhatJa.Text = "nQueryの基本情報です";
            this.lblWhatJa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWhat
            // 
            this.pnlWhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(64)))), ((int)(((byte)(52)))));
            this.pnlWhat.Controls.Add(this.panel3);
            this.pnlWhat.Location = new System.Drawing.Point(13, 7);
            this.pnlWhat.Name = "pnlWhat";
            this.pnlWhat.Size = new System.Drawing.Size(185, 71);
            this.pnlWhat.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panel3.Controls.Add(this.nQueryOpacityLabel16);
            this.panel3.Controls.Add(this.nQueryOpacityLabel13);
            this.panel3.Controls.Add(this.nQueryOpacityLabel14);
            this.panel3.Controls.Add(this.nQueryOpacityLabel15);
            this.panel3.Controls.Add(this.nQueryOpacityLabel12);
            this.panel3.Controls.Add(this.nQueryOpacityLabel10);
            this.panel3.Controls.Add(this.nQueryOpacityLabel11);
            this.panel3.Controls.Add(this.nQueryOpacityLabel9);
            this.panel3.Controls.Add(this.nQueryOpacityLabel8);
            this.panel3.Controls.Add(this.nQueryOpacityLabel7);
            this.panel3.Controls.Add(this.nQueryOpacityLabel5);
            this.panel3.Controls.Add(this.nQueryOpacityLabel6);
            this.panel3.Controls.Add(this.nQueryOpacityLabel3);
            this.panel3.Controls.Add(this.nQueryOpacityLabel4);
            this.panel3.Location = new System.Drawing.Point(9, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 52);
            this.panel3.TabIndex = 13;
            // 
            // nQueryOpacityLabel16
            // 
            this.nQueryOpacityLabel16.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel16.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nQueryOpacityLabel16.Location = new System.Drawing.Point(10, 613);
            this.nQueryOpacityLabel16.Name = "nQueryOpacityLabel16";
            this.nQueryOpacityLabel16.Size = new System.Drawing.Size(694, 57);
            this.nQueryOpacityLabel16.TabIndex = 43;
            this.nQueryOpacityLabel16.Text = "上部メニューから各サンプルをご覧頂けます。";
            // 
            // nQueryOpacityLabel13
            // 
            this.nQueryOpacityLabel13.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel13.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nQueryOpacityLabel13.Location = new System.Drawing.Point(13, 553);
            this.nQueryOpacityLabel13.Name = "nQueryOpacityLabel13";
            this.nQueryOpacityLabel13.Size = new System.Drawing.Size(694, 57);
            this.nQueryOpacityLabel13.TabIndex = 42;
            this.nQueryOpacityLabel13.Text = "のように、動作完了後のコールバックを実装可能です。\r\nこれにより、複雑なアニメーションも実現可能です。";
            // 
            // nQueryOpacityLabel14
            // 
            this.nQueryOpacityLabel14.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel14.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nQueryOpacityLabel14.Location = new System.Drawing.Point(20, 495);
            this.nQueryOpacityLabel14.Name = "nQueryOpacityLabel14";
            this.nQueryOpacityLabel14.Size = new System.Drawing.Size(694, 52);
            this.nQueryOpacityLabel14.TabIndex = 41;
            this.nQueryOpacityLabel14.Text = "nQuery.Select(targetcontrol).Move(10, 10, new Action(() => {\r\n   動作完了後の処理\r\n});";
            // 
            // nQueryOpacityLabel15
            // 
            this.nQueryOpacityLabel15.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel15.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel15.ForeColor = System.Drawing.Color.Silver;
            this.nQueryOpacityLabel15.Location = new System.Drawing.Point(12, 461);
            this.nQueryOpacityLabel15.Name = "nQueryOpacityLabel15";
            this.nQueryOpacityLabel15.Size = new System.Drawing.Size(694, 40);
            this.nQueryOpacityLabel15.TabIndex = 40;
            this.nQueryOpacityLabel15.Text = "コールバック";
            // 
            // nQueryOpacityLabel12
            // 
            this.nQueryOpacityLabel12.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel12.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nQueryOpacityLabel12.Location = new System.Drawing.Point(14, 404);
            this.nQueryOpacityLabel12.Name = "nQueryOpacityLabel12";
            this.nQueryOpacityLabel12.Size = new System.Drawing.Size(694, 57);
            this.nQueryOpacityLabel12.TabIndex = 39;
            this.nQueryOpacityLabel12.Text = "のように、メソッドを続けて記述できます。\r\nnQueryメソッドは常に自分自身を返却するためです。";
            // 
            // nQueryOpacityLabel10
            // 
            this.nQueryOpacityLabel10.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel10.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nQueryOpacityLabel10.Location = new System.Drawing.Point(21, 376);
            this.nQueryOpacityLabel10.Name = "nQueryOpacityLabel10";
            this.nQueryOpacityLabel10.Size = new System.Drawing.Size(694, 28);
            this.nQueryOpacityLabel10.TabIndex = 38;
            this.nQueryOpacityLabel10.Text = "nQuery.Select(targetcontrol).Move(10, 10, 1000).Size(30, 20, 500);";
            // 
            // nQueryOpacityLabel11
            // 
            this.nQueryOpacityLabel11.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel11.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel11.ForeColor = System.Drawing.Color.Silver;
            this.nQueryOpacityLabel11.Location = new System.Drawing.Point(13, 342);
            this.nQueryOpacityLabel11.Name = "nQueryOpacityLabel11";
            this.nQueryOpacityLabel11.Size = new System.Drawing.Size(694, 40);
            this.nQueryOpacityLabel11.TabIndex = 37;
            this.nQueryOpacityLabel11.Text = "メソッドチェーン";
            // 
            // nQueryOpacityLabel9
            // 
            this.nQueryOpacityLabel9.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel9.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nQueryOpacityLabel9.Location = new System.Drawing.Point(10, 168);
            this.nQueryOpacityLabel9.Name = "nQueryOpacityLabel9";
            this.nQueryOpacityLabel9.Size = new System.Drawing.Size(694, 40);
            this.nQueryOpacityLabel9.TabIndex = 36;
            this.nQueryOpacityLabel9.Text = "主な特徴";
            // 
            // nQueryOpacityLabel8
            // 
            this.nQueryOpacityLabel8.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel8.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nQueryOpacityLabel8.Location = new System.Drawing.Point(12, 125);
            this.nQueryOpacityLabel8.Name = "nQueryOpacityLabel8";
            this.nQueryOpacityLabel8.Size = new System.Drawing.Size(694, 40);
            this.nQueryOpacityLabel8.TabIndex = 35;
            this.nQueryOpacityLabel8.Text = "Windows FormでもWebのようにUIを動作させることができます。";
            // 
            // nQueryOpacityLabel7
            // 
            this.nQueryOpacityLabel7.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel7.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nQueryOpacityLabel7.Location = new System.Drawing.Point(14, 267);
            this.nQueryOpacityLabel7.Name = "nQueryOpacityLabel7";
            this.nQueryOpacityLabel7.Size = new System.Drawing.Size(694, 57);
            this.nQueryOpacityLabel7.TabIndex = 34;
            this.nQueryOpacityLabel7.Text = "のように、nQuery.Select(動作をさせたいコントロール)を指定します。\r\n指定されたコントロールに対してバックグラウンドで処理を行うので、UIスレッドに" +
                "ロックがかかることはありません。";
            // 
            // nQueryOpacityLabel5
            // 
            this.nQueryOpacityLabel5.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel5.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nQueryOpacityLabel5.Location = new System.Drawing.Point(21, 239);
            this.nQueryOpacityLabel5.Name = "nQueryOpacityLabel5";
            this.nQueryOpacityLabel5.Size = new System.Drawing.Size(694, 28);
            this.nQueryOpacityLabel5.TabIndex = 33;
            this.nQueryOpacityLabel5.Text = "nQuery.Select(targetcontrol).Move(10, 10, 1000);";
            // 
            // nQueryOpacityLabel6
            // 
            this.nQueryOpacityLabel6.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel6.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel6.ForeColor = System.Drawing.Color.Silver;
            this.nQueryOpacityLabel6.Location = new System.Drawing.Point(13, 205);
            this.nQueryOpacityLabel6.Name = "nQueryOpacityLabel6";
            this.nQueryOpacityLabel6.Size = new System.Drawing.Size(694, 40);
            this.nQueryOpacityLabel6.TabIndex = 32;
            this.nQueryOpacityLabel6.Text = "セレクタ";
            // 
            // nQueryOpacityLabel3
            // 
            this.nQueryOpacityLabel3.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel3.Font = new System.Drawing.Font("HGSｺﾞｼｯｸE", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.nQueryOpacityLabel3.Location = new System.Drawing.Point(13, 89);
            this.nQueryOpacityLabel3.Name = "nQueryOpacityLabel3";
            this.nQueryOpacityLabel3.Size = new System.Drawing.Size(694, 40);
            this.nQueryOpacityLabel3.TabIndex = 30;
            this.nQueryOpacityLabel3.Text = ".netを使用したWindows Form上でjQueryに似た記述でコントロールを動かすことができるライブラリです。";
            // 
            // nQueryOpacityLabel4
            // 
            this.nQueryOpacityLabel4.BackColor = System.Drawing.Color.Transparent;
            this.nQueryOpacityLabel4.Font = new System.Drawing.Font("HGS明朝E", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nQueryOpacityLabel4.ForeColor = System.Drawing.Color.Silver;
            this.nQueryOpacityLabel4.Location = new System.Drawing.Point(7, 7);
            this.nQueryOpacityLabel4.Name = "nQueryOpacityLabel4";
            this.nQueryOpacityLabel4.Size = new System.Drawing.Size(473, 55);
            this.nQueryOpacityLabel4.TabIndex = 29;
            this.nQueryOpacityLabel4.Text = "nQueryとは";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(775, 774);
            this.Controls.Add(this.lblSizeEn);
            this.Controls.Add(this.lblSizeJa);
            this.Controls.Add(this.pnlSizeSample);
            this.Controls.Add(this.lblFadeEn);
            this.Controls.Add(this.pnlFadeSample);
            this.Controls.Add(this.lblFadeJa);
            this.Controls.Add(this.lblWhatEn);
            this.Controls.Add(this.lblWhatJa);
            this.Controls.Add(this.pnlWhat);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.lblMoveEn);
            this.Controls.Add(this.lblMoveJa);
            this.Controls.Add(this.pnlMoveSample);
            this.Font = new System.Drawing.Font("Utsaah", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMoveSample.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSizeSample.ResumeLayout(false);
            this.pnlFadeSample.ResumeLayout(false);
            this.pnlFadeSample.PerformLayout();
            this.pnlWhat.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblFadeEn;
        private System.Windows.Forms.Label lblWhatEn;
        private System.Windows.Forms.Label lblFadeJa;
        private System.Windows.Forms.Panel pnlFadeSample;
        private nQueryLib.UI.nQueryOpacityLabel lblQuery;
        private System.Windows.Forms.Panel panel1;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel2;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel1;
        private System.Windows.Forms.Label lblWhatJa;
        private System.Windows.Forms.Panel pnlWhat;
        private System.Windows.Forms.Panel panel3;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel6;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel3;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel4;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel5;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel7;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel9;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel8;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel12;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel10;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel11;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel13;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel14;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel15;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel16;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel18;
        private nQueryLib.UI.nQueryOpacityLabel nQueryOpacityLabel17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoRight;
        private System.Windows.Forms.Button btnDoLeft;
        private System.Windows.Forms.Button btnOrgPos;
    }
}

