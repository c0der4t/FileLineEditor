namespace FileLineEditor
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.edtBeforeLine = new System.Windows.Forms.TextBox();
            this.edtAfterLine = new System.Windows.Forms.TextBox();
            this.edtTargetFile = new System.Windows.Forms.TextBox();
            this.lblTargetFile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAddAfter = new System.Windows.Forms.Label();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.dlgBrowseTarget = new System.Windows.Forms.OpenFileDialog();
            this.btnProcess = new System.Windows.Forms.Button();
            this.chckbxMakeBackup = new System.Windows.Forms.CheckBox();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.lblProgressMenu = new System.Windows.Forms.Label();
            this.worker_FileProcessor = new System.ComponentModel.BackgroundWorker();
            this.imgLicenseKey = new System.Windows.Forms.PictureBox();
            this.imgComCenLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLicenseKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComCenLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // edtBeforeLine
            // 
            this.edtBeforeLine.Location = new System.Drawing.Point(125, 88);
            this.edtBeforeLine.Name = "edtBeforeLine";
            this.edtBeforeLine.Size = new System.Drawing.Size(549, 20);
            this.edtBeforeLine.TabIndex = 1;
            // 
            // edtAfterLine
            // 
            this.edtAfterLine.Location = new System.Drawing.Point(125, 137);
            this.edtAfterLine.Name = "edtAfterLine";
            this.edtAfterLine.Size = new System.Drawing.Size(549, 20);
            this.edtAfterLine.TabIndex = 2;
            // 
            // edtTargetFile
            // 
            this.edtTargetFile.Location = new System.Drawing.Point(125, 37);
            this.edtTargetFile.Name = "edtTargetFile";
            this.edtTargetFile.Size = new System.Drawing.Size(518, 20);
            this.edtTargetFile.TabIndex = 3;
            // 
            // lblTargetFile
            // 
            this.lblTargetFile.AutoSize = true;
            this.lblTargetFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTargetFile.Location = new System.Drawing.Point(111, 19);
            this.lblTargetFile.Name = "lblTargetFile";
            this.lblTargetFile.Size = new System.Drawing.Size(65, 15);
            this.lblTargetFile.TabIndex = 4;
            this.lblTargetFile.Text = "Target File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Before Each Line";
            // 
            // lblAddAfter
            // 
            this.lblAddAfter.AutoSize = true;
            this.lblAddAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblAddAfter.Location = new System.Drawing.Point(111, 119);
            this.lblAddAfter.Name = "lblAddAfter";
            this.lblAddAfter.Size = new System.Drawing.Size(113, 15);
            this.lblAddAfter.TabIndex = 6;
            this.lblAddAfter.Text = "Add After Each Line";
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.BackColor = System.Drawing.Color.White;
            this.btnBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFile.Location = new System.Drawing.Point(649, 37);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(25, 20);
            this.btnBrowseFile.TabIndex = 7;
            this.btnBrowseFile.Text = "...";
            this.btnBrowseFile.UseVisualStyleBackColor = false;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // dlgBrowseTarget
            // 
            this.dlgBrowseTarget.Title = "Select a Target File";
            // 
            // btnProcess
            // 
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(565, 163);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(109, 26);
            this.btnProcess.TabIndex = 8;
            this.btnProcess.Text = "Process File";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // chckbxMakeBackup
            // 
            this.chckbxMakeBackup.AutoSize = true;
            this.chckbxMakeBackup.Checked = true;
            this.chckbxMakeBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckbxMakeBackup.Location = new System.Drawing.Point(125, 170);
            this.chckbxMakeBackup.Name = "chckbxMakeBackup";
            this.chckbxMakeBackup.Size = new System.Drawing.Size(306, 17);
            this.chckbxMakeBackup.TabIndex = 9;
            this.chckbxMakeBackup.Text = "Backup File to Documents\\FLE\\Backup Before Processing";
            this.chckbxMakeBackup.UseVisualStyleBackColor = true;
            // 
            // progressbar
            // 
            this.progressbar.BackColor = System.Drawing.Color.White;
            this.progressbar.Location = new System.Drawing.Point(114, 192);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(560, 23);
            this.progressbar.TabIndex = 10;
            // 
            // lblProgressMenu
            // 
            this.lblProgressMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblProgressMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProgressMenu.Location = new System.Drawing.Point(330, 196);
            this.lblProgressMenu.Name = "lblProgressMenu";
            this.lblProgressMenu.Size = new System.Drawing.Size(129, 15);
            this.lblProgressMenu.TabIndex = 11;
            this.lblProgressMenu.Text = "Creating Backup";
            this.lblProgressMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProgressMenu.Visible = false;
            // 
            // worker_FileProcessor
            // 
            this.worker_FileProcessor.WorkerReportsProgress = true;
            this.worker_FileProcessor.WorkerSupportsCancellation = true;
            this.worker_FileProcessor.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_FileProcessor_DoWork);
            this.worker_FileProcessor.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_FileProcessor_ProgressChanged);
            this.worker_FileProcessor.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_FileProcessor_RunWorkerCompleted);
            // 
            // imgLicenseKey
            // 
            this.imgLicenseKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgLicenseKey.Image = ((System.Drawing.Image)(resources.GetObject("imgLicenseKey.Image")));
            this.imgLicenseKey.Location = new System.Drawing.Point(20, 170);
            this.imgLicenseKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgLicenseKey.Name = "imgLicenseKey";
            this.imgLicenseKey.Size = new System.Drawing.Size(44, 45);
            this.imgLicenseKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLicenseKey.TabIndex = 12;
            this.imgLicenseKey.TabStop = false;
            this.imgLicenseKey.Click += new System.EventHandler(this.imgLicenseKey_Click);
            // 
            // imgComCenLogo
            // 
            this.imgComCenLogo.Location = new System.Drawing.Point(0, 4);
            this.imgComCenLogo.Name = "imgComCenLogo";
            this.imgComCenLogo.Size = new System.Drawing.Size(108, 211);
            this.imgComCenLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgComCenLogo.TabIndex = 0;
            this.imgComCenLogo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(706, 224);
            this.Controls.Add(this.imgLicenseKey);
            this.Controls.Add(this.lblProgressMenu);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.chckbxMakeBackup);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.lblAddAfter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTargetFile);
            this.Controls.Add(this.edtTargetFile);
            this.Controls.Add(this.edtAfterLine);
            this.Controls.Add(this.edtBeforeLine);
            this.Controls.Add(this.imgComCenLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(722, 263);
            this.MinimumSize = new System.Drawing.Size(722, 263);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Line Editor (Version BETA 1.0)";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.imgLicenseKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComCenLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgComCenLogo;
        private System.Windows.Forms.TextBox edtBeforeLine;
        private System.Windows.Forms.TextBox edtAfterLine;
        private System.Windows.Forms.TextBox edtTargetFile;
        private System.Windows.Forms.Label lblTargetFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddAfter;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.OpenFileDialog dlgBrowseTarget;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.CheckBox chckbxMakeBackup;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.Label lblProgressMenu;
        private System.ComponentModel.BackgroundWorker worker_FileProcessor;
        private System.Windows.Forms.PictureBox imgLicenseKey;
    }
}

