
namespace AudioDownloader
{
    partial class AudioDownloader
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this._txtUrl = new System.Windows.Forms.TextBox();
            this._btnSaveAs = new System.Windows.Forms.Button();
            this._txtFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._btnDownload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL:";
            // 
            // _txtUrl
            // 
            this._txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtUrl.Location = new System.Drawing.Point(78, 12);
            this._txtUrl.Name = "_txtUrl";
            this._txtUrl.Size = new System.Drawing.Size(710, 39);
            this._txtUrl.TabIndex = 1;
            // 
            // _btnSaveAs
            // 
            this._btnSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSaveAs.Location = new System.Drawing.Point(638, 57);
            this._btnSaveAs.Name = "_btnSaveAs";
            this._btnSaveAs.Size = new System.Drawing.Size(150, 46);
            this._btnSaveAs.TabIndex = 2;
            this._btnSaveAs.Text = "Save As...";
            this._btnSaveAs.UseVisualStyleBackColor = true;
            this._btnSaveAs.Click += new System.EventHandler(this._btnSaveAs_Click);
            // 
            // _txtFilePath
            // 
            this._txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtFilePath.Location = new System.Drawing.Point(78, 61);
            this._txtFilePath.Name = "_txtFilePath";
            this._txtFilePath.Size = new System.Drawing.Size(554, 39);
            this._txtFilePath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "File:";
            // 
            // _btnDownload
            // 
            this._btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnDownload.Location = new System.Drawing.Point(12, 127);
            this._btnDownload.Name = "_btnDownload";
            this._btnDownload.Size = new System.Drawing.Size(776, 46);
            this._btnDownload.TabIndex = 5;
            this._btnDownload.Text = "DOWNLOAD";
            this._btnDownload.UseVisualStyleBackColor = true;
            this._btnDownload.Click += new System.EventHandler(this._btnDownload_Click);
            // 
            // AudioDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 185);
            this.Controls.Add(this._btnDownload);
            this.Controls.Add(this._txtFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._btnSaveAs);
            this.Controls.Add(this._txtUrl);
            this.Controls.Add(this.label1);
            this.Name = "AudioDownloader";
            this.Text = "Audio Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtUrl;
        private System.Windows.Forms.Button _btnSaveAs;
        private System.Windows.Forms.TextBox _txtFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnDownload;
    }
}

