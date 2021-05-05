
namespace SerializeEx
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
            this.Label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.tbMobile = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(29, 47);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(37, 12);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "이름 :";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(106, 44);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(179, 21);
            this.tbName.TabIndex = 1;
            // 
            // btnSerialize
            // 
            this.btnSerialize.Location = new System.Drawing.Point(312, 42);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(175, 165);
            this.btnSerialize.TabIndex = 5;
            this.btnSerialize.Text = "직렬화";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Location = new System.Drawing.Point(312, 213);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(175, 165);
            this.btnDeserialize.TabIndex = 5;
            this.btnDeserialize.Text = "역직렬화";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(29, 74);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(49, 12);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "휴대폰 :";
            // 
            // tbMobile
            // 
            this.tbMobile.Location = new System.Drawing.Point(106, 71);
            this.tbMobile.Name = "tbMobile";
            this.tbMobile.Size = new System.Drawing.Size(179, 21);
            this.tbMobile.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(29, 101);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(49, 12);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "이메일 :";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(106, 98);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(179, 21);
            this.tbEmail.TabIndex = 3;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(29, 128);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(37, 12);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "주소 :";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(106, 125);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(179, 21);
            this.tbAddress.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "역직렬화 결과";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(106, 241);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(179, 137);
            this.tbResult.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.tbMobile);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox tbMobile;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbResult;
    }
}

