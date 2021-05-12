
namespace MenuStrip
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripNew = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripFont = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripColorTable = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextRed = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripFile,
            this.ToolStripFormat,
            this.ToolStripColor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1537, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripFile
            // 
            this.ToolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripNew,
            this.ToolStripOpen,
            this.toolStripMenuItem2,
            this.ToolStripSave,
            this.ToolStripSaveAs,
            this.toolStripMenuItem3,
            this.ToolStripExit});
            this.ToolStripFile.Name = "ToolStripFile";
            this.ToolStripFile.Size = new System.Drawing.Size(109, 38);
            this.ToolStripFile.Text = "파일(&F)";
            this.ToolStripFile.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ToolStripNew
            // 
            this.ToolStripNew.Name = "ToolStripNew";
            this.ToolStripNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ToolStripNew.Size = new System.Drawing.Size(542, 44);
            this.ToolStripNew.Text = "새로만들기(&N)";
            this.ToolStripNew.Click += new System.EventHandler(this.ToolStripNew_Click);
            // 
            // ToolStripOpen
            // 
            this.ToolStripOpen.Name = "ToolStripOpen";
            this.ToolStripOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ToolStripOpen.Size = new System.Drawing.Size(542, 44);
            this.ToolStripOpen.Text = "열기(&O)...";
            this.ToolStripOpen.Click += new System.EventHandler(this.ToolStripOpen_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(539, 6);
            // 
            // ToolStripSave
            // 
            this.ToolStripSave.Name = "ToolStripSave";
            this.ToolStripSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ToolStripSave.Size = new System.Drawing.Size(542, 44);
            this.ToolStripSave.Text = "저장(&S)";
            this.ToolStripSave.Click += new System.EventHandler(this.ToolStripSave_Click);
            // 
            // ToolStripSaveAs
            // 
            this.ToolStripSaveAs.Name = "ToolStripSaveAs";
            this.ToolStripSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.ToolStripSaveAs.Size = new System.Drawing.Size(542, 44);
            this.ToolStripSaveAs.Text = "다른이름으로 저장(&A)...";
            this.ToolStripSaveAs.Click += new System.EventHandler(this.ToolStripSaveAs_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(539, 6);
            // 
            // ToolStripExit
            // 
            this.ToolStripExit.Name = "ToolStripExit";
            this.ToolStripExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.ToolStripExit.Size = new System.Drawing.Size(542, 44);
            this.ToolStripExit.Text = "종료(&X)";
            this.ToolStripExit.Click += new System.EventHandler(this.ToolStripExit_Click);
            // 
            // ToolStripFormat
            // 
            this.ToolStripFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripWordWrap,
            this.ToolStripFont});
            this.ToolStripFormat.Name = "ToolStripFormat";
            this.ToolStripFormat.Size = new System.Drawing.Size(116, 38);
            this.ToolStripFormat.Text = "서식(&O)";
            // 
            // ToolStripWordWrap
            // 
            this.ToolStripWordWrap.Name = "ToolStripWordWrap";
            this.ToolStripWordWrap.Size = new System.Drawing.Size(322, 44);
            this.ToolStripWordWrap.Text = "자동 줄 바꿈(&W)";
            this.ToolStripWordWrap.Click += new System.EventHandler(this.ToolStripWordWrap_Click);
            // 
            // ToolStripFont
            // 
            this.ToolStripFont.Name = "ToolStripFont";
            this.ToolStripFont.Size = new System.Drawing.Size(322, 44);
            this.ToolStripFont.Text = "글꼴(&F)...";
            this.ToolStripFont.Click += new System.EventHandler(this.ToolStripFont_Click);
            // 
            // ToolStripColor
            // 
            this.ToolStripColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripColorTable});
            this.ToolStripColor.Name = "ToolStripColor";
            this.ToolStripColor.Size = new System.Drawing.Size(88, 38);
            this.ToolStripColor.Text = "색(&C)";
            // 
            // ToolStripColorTable
            // 
            this.ToolStripColorTable.Name = "ToolStripColorTable";
            this.ToolStripColorTable.Size = new System.Drawing.Size(263, 44);
            this.ToolStripColorTable.Text = "색상표(&T)...";
            this.ToolStripColorTable.Click += new System.EventHandler(this.ToolStripColorTable_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1093, 650);
            this.textBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextRed,
            this.ContextGreen,
            this.ContextBlue});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 118);
            // 
            // ContextRed
            // 
            this.ContextRed.Name = "ContextRed";
            this.ContextRed.Size = new System.Drawing.Size(186, 38);
            this.ContextRed.Text = "빨간배경";
            this.ContextRed.Click += new System.EventHandler(this.ContextRed_Click);
            // 
            // ContextGreen
            // 
            this.ContextGreen.Name = "ContextGreen";
            this.ContextGreen.Size = new System.Drawing.Size(186, 38);
            this.ContextGreen.Text = "초록배경";
            this.ContextGreen.Click += new System.EventHandler(this.ContextGreen_Click);
            // 
            // ContextBlue
            // 
            this.ContextBlue.Name = "ContextBlue";
            this.ContextBlue.Size = new System.Drawing.Size(186, 38);
            this.ContextBlue.Text = "파란배경";
            this.ContextBlue.Click += new System.EventHandler(this.ContextBlue_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip2;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1145, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(267, 118);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(266, 38);
            this.toolStripMenuItem1.Text = "이미지 저장";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(266, 38);
            this.toolStripMenuItem4.Text = "이미지 삭제";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(266, 38);
            this.toolStripMenuItem5.Text = "이미지 불러오기";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 927);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripNew;
        private System.Windows.Forms.ToolStripMenuItem ToolStripOpen;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSave;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ToolStripExit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripFormat;
        private System.Windows.Forms.ToolStripMenuItem ToolStripWordWrap;
        private System.Windows.Forms.ToolStripMenuItem ToolStripFont;
        private System.Windows.Forms.ToolStripMenuItem ToolStripColor;
        private System.Windows.Forms.ToolStripMenuItem ToolStripColorTable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ContextRed;
        private System.Windows.Forms.ToolStripMenuItem ContextGreen;
        private System.Windows.Forms.ToolStripMenuItem ContextBlue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

