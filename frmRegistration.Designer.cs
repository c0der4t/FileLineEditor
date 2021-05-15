namespace FileLineEditor
{
    partial class frmRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistration));
            this.imgComCenLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtRegSendCode = new System.Windows.Forms.TextBox();
            this.edtRegReturnCode = new System.Windows.Forms.TextBox();
            this.btnActivateReg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgComCenLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgComCenLogo
            // 
            this.imgComCenLogo.Image = global::FileLineEditor.Properties.Resources.activation;
            this.imgComCenLogo.Location = new System.Drawing.Point(12, 33);
            this.imgComCenLogo.Name = "imgComCenLogo";
            this.imgComCenLogo.Size = new System.Drawing.Size(61, 67);
            this.imgComCenLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgComCenLogo.TabIndex = 1;
            this.imgComCenLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serial Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Key";
            // 
            // edtRegSendCode
            // 
            this.edtRegSendCode.Enabled = false;
            this.edtRegSendCode.Location = new System.Drawing.Point(109, 33);
            this.edtRegSendCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edtRegSendCode.Name = "edtRegSendCode";
            this.edtRegSendCode.PasswordChar = '*';
            this.edtRegSendCode.Size = new System.Drawing.Size(204, 20);
            this.edtRegSendCode.TabIndex = 4;
            this.edtRegSendCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edtRegReturnCode
            // 
            this.edtRegReturnCode.Location = new System.Drawing.Point(109, 80);
            this.edtRegReturnCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edtRegReturnCode.Name = "edtRegReturnCode";
            this.edtRegReturnCode.Size = new System.Drawing.Size(204, 20);
            this.edtRegReturnCode.TabIndex = 5;
            this.edtRegReturnCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnActivateReg
            // 
            this.btnActivateReg.CausesValidation = false;
            this.btnActivateReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivateReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivateReg.Location = new System.Drawing.Point(146, 112);
            this.btnActivateReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActivateReg.Name = "btnActivateReg";
            this.btnActivateReg.Size = new System.Drawing.Size(125, 25);
            this.btnActivateReg.TabIndex = 6;
            this.btnActivateReg.Text = "Register Software";
            this.btnActivateReg.UseVisualStyleBackColor = true;
            this.btnActivateReg.Click += new System.EventHandler(this.btnActivateReg_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 165);
            this.Controls.Add(this.btnActivateReg);
            this.Controls.Add(this.edtRegReturnCode);
            this.Controls.Add(this.edtRegSendCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgComCenLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgComCenLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgComCenLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtRegSendCode;
        private System.Windows.Forms.TextBox edtRegReturnCode;
        private System.Windows.Forms.Button btnActivateReg;
    }
}