namespace VPGNewOne
{
    partial class VPGConnection
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
            this.grpIDU = new System.Windows.Forms.GroupBox();
            this.grpIDUParameter = new System.Windows.Forms.GroupBox();
            this.pnlPORT = new System.Windows.Forms.Panel();
            this.txtPORT = new System.Windows.Forms.TextBox();
            this.lblTSet = new System.Windows.Forms.Label();
            this.pnlIIPMode = new System.Windows.Forms.Panel();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grpIDU.SuspendLayout();
            this.grpIDUParameter.SuspendLayout();
            this.pnlPORT.SuspendLayout();
            this.pnlIIPMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIDU
            // 
            this.grpIDU.Controls.Add(this.grpIDUParameter);
            this.grpIDU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIDU.Location = new System.Drawing.Point(25, 12);
            this.grpIDU.Name = "grpIDU";
            this.grpIDU.Size = new System.Drawing.Size(366, 259);
            this.grpIDU.TabIndex = 53;
            this.grpIDU.TabStop = false;
            this.grpIDU.Text = "CONNECT";
            // 
            // grpIDUParameter
            // 
            this.grpIDUParameter.Controls.Add(this.btnConnect);
            this.grpIDUParameter.Controls.Add(this.pnlPORT);
            this.grpIDUParameter.Controls.Add(this.pnlIIPMode);
            this.grpIDUParameter.Location = new System.Drawing.Point(6, 16);
            this.grpIDUParameter.Name = "grpIDUParameter";
            this.grpIDUParameter.Size = new System.Drawing.Size(354, 230);
            this.grpIDUParameter.TabIndex = 57;
            this.grpIDUParameter.TabStop = false;
            // 
            // pnlPORT
            // 
            this.pnlPORT.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlPORT.Controls.Add(this.txtPORT);
            this.pnlPORT.Controls.Add(this.lblTSet);
            this.pnlPORT.ForeColor = System.Drawing.Color.Black;
            this.pnlPORT.Location = new System.Drawing.Point(8, 73);
            this.pnlPORT.Name = "pnlPORT";
            this.pnlPORT.Size = new System.Drawing.Size(332, 28);
            this.pnlPORT.TabIndex = 68;
            // 
            // txtPORT
            // 
            this.txtPORT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtPORT.Location = new System.Drawing.Point(71, 1);
            this.txtPORT.Name = "txtPORT";
            this.txtPORT.Size = new System.Drawing.Size(258, 26);
            this.txtPORT.TabIndex = 64;
            this.txtPORT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTSet
            // 
            this.lblTSet.AutoSize = true;
            this.lblTSet.BackColor = System.Drawing.Color.Transparent;
            this.lblTSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSet.Location = new System.Drawing.Point(4, 6);
            this.lblTSet.Name = "lblTSet";
            this.lblTSet.Size = new System.Drawing.Size(45, 16);
            this.lblTSet.TabIndex = 63;
            this.lblTSet.Text = "PORT";
            // 
            // pnlIIPMode
            // 
            this.pnlIIPMode.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlIIPMode.Controls.Add(this.txtIP);
            this.pnlIIPMode.Controls.Add(this.lblMode);
            this.pnlIIPMode.ForeColor = System.Drawing.Color.Black;
            this.pnlIIPMode.Location = new System.Drawing.Point(8, 17);
            this.pnlIIPMode.Name = "pnlIIPMode";
            this.pnlIIPMode.Size = new System.Drawing.Size(332, 28);
            this.pnlIIPMode.TabIndex = 67;
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.txtIP.Location = new System.Drawing.Point(71, 1);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(258, 26);
            this.txtIP.TabIndex = 62;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.BackColor = System.Drawing.Color.Transparent;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(4, 6);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(19, 16);
            this.lblMode.TabIndex = 61;
            this.lblMode.Text = "IP";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.SkyBlue;
            this.btnConnect.Location = new System.Drawing.Point(15, 161);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(325, 28);
            this.btnConnect.TabIndex = 69;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // VPGConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 280);
            this.Controls.Add(this.grpIDU);
            this.Name = "VPGConnection";
            this.Text = "VPGConnection";
            this.grpIDU.ResumeLayout(false);
            this.grpIDUParameter.ResumeLayout(false);
            this.pnlPORT.ResumeLayout(false);
            this.pnlPORT.PerformLayout();
            this.pnlIIPMode.ResumeLayout(false);
            this.pnlIIPMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIDU;
        private System.Windows.Forms.GroupBox grpIDUParameter;
        private System.Windows.Forms.Panel pnlPORT;
        private System.Windows.Forms.TextBox txtPORT;
        private System.Windows.Forms.Label lblTSet;
        private System.Windows.Forms.Panel pnlIIPMode;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnConnect;
    }
}