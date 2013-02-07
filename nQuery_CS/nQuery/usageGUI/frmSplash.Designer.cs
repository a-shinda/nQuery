namespace usageGUI
{
    partial class frmSplash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuery = new nQueryLib.UI.nQueryOpacityLabel();
            this.lblN = new nQueryLib.UI.nQueryOpacityLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuery
            // 
            this.lblQuery.BackColor = System.Drawing.Color.Transparent;
            this.lblQuery.Font = new System.Drawing.Font("Trebuchet MS", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblQuery.ForeColor = System.Drawing.Color.Silver;
            this.lblQuery.Location = new System.Drawing.Point(274, 100);
            this.lblQuery.Name = "lblQuery";
            this.lblQuery.Size = new System.Drawing.Size(244, 55);
            this.lblQuery.TabIndex = 1;
            this.lblQuery.Text = "Query";
            // 
            // lblN
            // 
            this.lblN.BackColor = System.Drawing.Color.Transparent;
            this.lblN.Font = new System.Drawing.Font("Trebuchet MS", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(112)))), ((int)(((byte)(111)))));
            this.lblN.Location = new System.Drawing.Point(-33, 100);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(39, 59);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(374, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change Boring to Fun";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(100, 250);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblQuery);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private nQueryLib.UI.nQueryOpacityLabel lblN;
        private nQueryLib.UI.nQueryOpacityLabel lblQuery;
        private System.Windows.Forms.Label label1;

    }
}