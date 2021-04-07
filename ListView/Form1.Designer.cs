
namespace ListView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbOrg = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cbName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbOrg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "휴대폰 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "소속 :";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(86, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(332, 23);
            this.tbName.TabIndex = 3;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(86, 66);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(332, 23);
            this.tbPhone.TabIndex = 4;
            // 
            // tbOrg
            // 
            this.tbOrg.Location = new System.Drawing.Point(86, 107);
            this.tbOrg.Name = "tbOrg";
            this.tbOrg.Size = new System.Drawing.Size(332, 23);
            this.tbOrg.TabIndex = 5;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(456, 29);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "입력";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(456, 66);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cbName,
            this.cbPhone,
            this.cbOrg});
            this.listView1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 153);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(503, 223);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cbName
            // 
            this.cbName.Text = "이름";
            this.cbName.Width = 200;
            // 
            // cbPhone
            // 
            this.cbPhone.Text = "휴대폰";
            this.cbPhone.Width = 150;
            // 
            // cbOrg
            // 
            this.cbOrg.Text = "소속";
            this.cbOrg.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 401);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbOrg);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbOrg;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cbName;
        private System.Windows.Forms.ColumnHeader cbPhone;
        private System.Windows.Forms.ColumnHeader cbOrg;
    }
}

