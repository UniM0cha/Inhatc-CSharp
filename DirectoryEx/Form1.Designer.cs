
namespace DirectoryEx
{
    partial class Form1
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
            this.lblDir = new System.Windows.Forms.ListBox();
            this.lblFiles = new System.Windows.Forms.ListBox();
            this.btnDirList = new System.Windows.Forms.Button();
            this.btnFileList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDir
            // 
            this.lblDir.FormattingEnabled = true;
            this.lblDir.ItemHeight = 32;
            this.lblDir.Location = new System.Drawing.Point(12, 12);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(755, 388);
            this.lblDir.TabIndex = 0;
            // 
            // lblFiles
            // 
            this.lblFiles.FormattingEnabled = true;
            this.lblFiles.ItemHeight = 32;
            this.lblFiles.Location = new System.Drawing.Point(12, 406);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(755, 388);
            this.lblFiles.TabIndex = 1;
            // 
            // btnDirList
            // 
            this.btnDirList.Location = new System.Drawing.Point(828, 12);
            this.btnDirList.Name = "btnDirList";
            this.btnDirList.Size = new System.Drawing.Size(307, 89);
            this.btnDirList.TabIndex = 2;
            this.btnDirList.Text = "디렉터리 목록";
            this.btnDirList.UseVisualStyleBackColor = true;
            this.btnDirList.Click += new System.EventHandler(this.btnDirList_Click);
            // 
            // btnFileList
            // 
            this.btnFileList.Location = new System.Drawing.Point(828, 406);
            this.btnFileList.Name = "btnFileList";
            this.btnFileList.Size = new System.Drawing.Size(307, 89);
            this.btnFileList.TabIndex = 3;
            this.btnFileList.Text = "파일 목록";
            this.btnFileList.UseVisualStyleBackColor = true;
            this.btnFileList.Click += new System.EventHandler(this.btnFileList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 826);
            this.Controls.Add(this.btnFileList);
            this.Controls.Add(this.btnDirList);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.lblDir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lblDir;
        private System.Windows.Forms.ListBox lblFiles;
        private System.Windows.Forms.Button btnDirList;
        private System.Windows.Forms.Button btnFileList;
    }
}

