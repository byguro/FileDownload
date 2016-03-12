namespace FileDownloader
{
    partial class frmAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAna));
            this.btnDownload = new System.Windows.Forms.Button();
            this.drmProgress = new System.Windows.Forms.ProgressBar();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.txtFiles = new System.Windows.Forms.RichTextBox();
            this.txtImageServerUrl = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSaveFilePath = new System.Windows.Forms.TextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDownload.Location = new System.Drawing.Point(454, 454);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(174, 90);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // drmProgress
            // 
            this.drmProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drmProgress.Location = new System.Drawing.Point(0, 552);
            this.drmProgress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.drmProgress.Name = "drmProgress";
            this.drmProgress.Size = new System.Drawing.Size(628, 32);
            this.drmProgress.TabIndex = 1;
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgi.Location = new System.Drawing.Point(8, 497);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(104, 18);
            this.lblBilgi.TabIndex = 2;
            this.lblBilgi.Text = "File Downloader";
            // 
            // txtFiles
            // 
            this.txtFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFiles.Location = new System.Drawing.Point(0, 0);
            this.txtFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.Size = new System.Drawing.Size(628, 410);
            this.txtFiles.TabIndex = 3;
            this.txtFiles.Text = "";
            // 
            // txtImageServerUrl
            // 
            this.txtImageServerUrl.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtImageServerUrl.Location = new System.Drawing.Point(0, 415);
            this.txtImageServerUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImageServerUrl.Name = "txtImageServerUrl";
            this.txtImageServerUrl.Size = new System.Drawing.Size(627, 25);
            this.txtImageServerUrl.TabIndex = 4;
            // 
            // txtSaveFilePath
            // 
            this.txtSaveFilePath.Enabled = false;
            this.txtSaveFilePath.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSaveFilePath.Location = new System.Drawing.Point(0, 454);
            this.txtSaveFilePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSaveFilePath.Name = "txtSaveFilePath";
            this.txtSaveFilePath.Size = new System.Drawing.Size(317, 25);
            this.txtSaveFilePath.TabIndex = 5;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveFile.Location = new System.Drawing.Point(325, 454);
            this.btnSaveFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(121, 35);
            this.btnSaveFile.TabIndex = 6;
            this.btnSaveFile.Text = "Save File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // frmAna
            // 
            this.AcceptButton = this.btnDownload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 584);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.txtSaveFilePath);
            this.Controls.Add(this.txtImageServerUrl);
            this.Controls.Add(this.txtFiles);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.drmProgress);
            this.Controls.Add(this.btnDownload);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAna";
            this.Text = "File Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ProgressBar drmProgress;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.RichTextBox txtFiles;
        private System.Windows.Forms.TextBox txtImageServerUrl;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtSaveFilePath;
        private System.Windows.Forms.Button btnSaveFile;
    }
}