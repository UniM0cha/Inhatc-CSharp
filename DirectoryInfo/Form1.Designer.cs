
namespace DirectoryInfoEx
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
            this.lblDirInfo = new System.Windows.Forms.ListBox();
            this.btnDirInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDirInfo
            // 
            this.lblDirInfo.FormattingEnabled = true;
            this.lblDirInfo.ItemHeight = 32;
            this.lblDirInfo.Location = new System.Drawing.Point(12, 12);
            this.lblDirInfo.Name = "lblDirInfo";
            this.lblDirInfo.Size = new System.Drawing.Size(1054, 612);
            this.lblDirInfo.TabIndex = 0;
            // 
            // btnDirInfo
            // 
            this.btnDirInfo.Location = new System.Drawing.Point(422, 649);
            this.btnDirInfo.Name = "btnDirInfo";
            this.btnDirInfo.Size = new System.Drawing.Size(247, 72);
            this.btnDirInfo.TabIndex = 1;
            this.btnDirInfo.Text = "디렉터리 정보";
            this.btnDirInfo.UseVisualStyleBackColor = true;
            this.btnDirInfo.Click += new System.EventHandler(this.btnDirInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 756);
            this.Controls.Add(this.btnDirInfo);
            this.Controls.Add(this.lblDirInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lblDirInfo;
        private System.Windows.Forms.Button btnDirInfo;
    }
}

