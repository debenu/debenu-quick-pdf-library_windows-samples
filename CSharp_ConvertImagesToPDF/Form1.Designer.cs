namespace ConvertImageToPDF
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
            this.groupBoxImages = new System.Windows.Forms.GroupBox();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnConvertImages = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.textBoxSaveFiles = new System.Windows.Forms.TextBox();
            this.btnOutputFolder = new System.Windows.Forms.Button();
            this.listBoxImages = new System.Windows.Forms.ListBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBoxLog = new System.Windows.Forms.TextBox();
            this.groupBoxImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxImages
            // 
            this.groupBoxImages.Controls.Add(this.btnRemoveImage);
            this.groupBoxImages.Controls.Add(this.btnConvertImages);
            this.groupBoxImages.Controls.Add(this.btnMerge);
            this.groupBoxImages.Controls.Add(this.textBoxSaveFiles);
            this.groupBoxImages.Controls.Add(this.btnOutputFolder);
            this.groupBoxImages.Controls.Add(this.listBoxImages);
            this.groupBoxImages.Controls.Add(this.btnLoadImage);
            this.groupBoxImages.Location = new System.Drawing.Point(20, 20);
            this.groupBoxImages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxImages.Name = "groupBoxImages";
            this.groupBoxImages.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxImages.Size = new System.Drawing.Size(717, 400);
            this.groupBoxImages.TabIndex = 11;
            this.groupBoxImages.TabStop = false;
            this.groupBoxImages.Text = "Convert Images to PDF";
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Location = new System.Drawing.Point(532, 93);
            this.btnRemoveImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(165, 35);
            this.btnRemoveImage.TabIndex = 15;
            this.btnRemoveImage.Text = "Remove Image";
            this.btnRemoveImage.UseVisualStyleBackColor = true;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnConvertImages
            // 
            this.btnConvertImages.Location = new System.Drawing.Point(532, 232);
            this.btnConvertImages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvertImages.Name = "btnConvertImages";
            this.btnConvertImages.Size = new System.Drawing.Size(165, 35);
            this.btnConvertImages.TabIndex = 10;
            this.btnConvertImages.Text = "Convert Images";
            this.btnConvertImages.UseVisualStyleBackColor = true;
            this.btnConvertImages.Click += new System.EventHandler(this.btnConvertImages_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(532, 277);
            this.btnMerge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(165, 35);
            this.btnMerge.TabIndex = 16;
            this.btnMerge.Text = "Convert and Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // textBoxSaveFiles
            // 
            this.textBoxSaveFiles.Location = new System.Drawing.Point(28, 346);
            this.textBoxSaveFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSaveFiles.Name = "textBoxSaveFiles";
            this.textBoxSaveFiles.Size = new System.Drawing.Size(484, 26);
            this.textBoxSaveFiles.TabIndex = 13;
            // 
            // btnOutputFolder
            // 
            this.btnOutputFolder.Location = new System.Drawing.Point(532, 342);
            this.btnOutputFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOutputFolder.Name = "btnOutputFolder";
            this.btnOutputFolder.Size = new System.Drawing.Size(165, 35);
            this.btnOutputFolder.TabIndex = 14;
            this.btnOutputFolder.Text = "Output Folder";
            this.btnOutputFolder.UseVisualStyleBackColor = true;
            this.btnOutputFolder.Click += new System.EventHandler(this.btnOutputFolder_Click);
            // 
            // listBoxImages
            // 
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.HorizontalScrollbar = true;
            this.listBoxImages.ItemHeight = 20;
            this.listBoxImages.Location = new System.Drawing.Point(28, 48);
            this.listBoxImages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(484, 264);
            this.listBoxImages.TabIndex = 9;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(532, 48);
            this.btnLoadImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(165, 35);
            this.btnLoadImage.TabIndex = 8;
            this.btnLoadImage.Text = "Add Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(593, 603);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBoxLog
            // 
            this.txtBoxLog.Location = new System.Drawing.Point(20, 428);
            this.txtBoxLog.Multiline = true;
            this.txtBoxLog.Name = "txtBoxLog";
            this.txtBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxLog.Size = new System.Drawing.Size(717, 167);
            this.txtBoxLog.TabIndex = 17;
            this.txtBoxLog.Text = "-------------- LOGGER --------------";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 647);
            this.Controls.Add(this.txtBoxLog);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBoxImages);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "[Debenu Sample] Convert Images to PDF";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBoxImages.ResumeLayout(false);
            this.groupBoxImages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxImages;
        private System.Windows.Forms.Button btnConvertImages;
        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.TextBox textBoxSaveFiles;
        private System.Windows.Forms.Button btnOutputFolder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.TextBox txtBoxLog;
    }
}

