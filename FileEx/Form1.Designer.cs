
namespace FileEx
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
            this.btnFileCopy = new System.Windows.Forms.Button();
            this.lbFileInfo = new System.Windows.Forms.ListBox();
            this.btnFileInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFileCopy
            // 
            this.btnFileCopy.Location = new System.Drawing.Point(12, 12);
            this.btnFileCopy.Name = "btnFileCopy";
            this.btnFileCopy.Size = new System.Drawing.Size(433, 90);
            this.btnFileCopy.TabIndex = 0;
            this.btnFileCopy.Text = "파일 복사";
            this.btnFileCopy.UseVisualStyleBackColor = true;
            this.btnFileCopy.Click += new System.EventHandler(this.btnFileCopy_Click);
            // 
            // lbFileInfo
            // 
            this.lbFileInfo.FormattingEnabled = true;
            this.lbFileInfo.ItemHeight = 32;
            this.lbFileInfo.Location = new System.Drawing.Point(12, 108);
            this.lbFileInfo.Name = "lbFileInfo";
            this.lbFileInfo.Size = new System.Drawing.Size(872, 516);
            this.lbFileInfo.TabIndex = 2;
            // 
            // btnFileInfo
            // 
            this.btnFileInfo.Location = new System.Drawing.Point(451, 12);
            this.btnFileInfo.Name = "btnFileInfo";
            this.btnFileInfo.Size = new System.Drawing.Size(433, 90);
            this.btnFileInfo.TabIndex = 3;
            this.btnFileInfo.Text = "파일 정보";
            this.btnFileInfo.UseVisualStyleBackColor = true;
            this.btnFileInfo.Click += new System.EventHandler(this.btnFileInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 651);
            this.Controls.Add(this.btnFileInfo);
            this.Controls.Add(this.lbFileInfo);
            this.Controls.Add(this.btnFileCopy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFileCopy;
        private System.Windows.Forms.ListBox lbFileInfo;
        private System.Windows.Forms.Button btnFileInfo;
    }
}

