
namespace WindowsFormsApp
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
            this.lblOrder = new System.Windows.Forms.Label();
            this.ckbSoon = new System.Windows.Forms.CheckBox();
            this.ckbPasta = new System.Windows.Forms.CheckBox();
            this.ckbSteak = new System.Windows.Forms.CheckBox();
            this.ckbTang = new System.Windows.Forms.CheckBox();
            this.btnEvent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioDisagree = new System.Windows.Forms.RadioButton();
            this.radioAgree = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRecipt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbArea = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPay = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "주문하세요.";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(423, 27);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(124, 17);
            this.lblOrder.TabIndex = 1;
            this.lblOrder.Text = "텍스트를 출력합니다.";
            // 
            // ckbSoon
            // 
            this.ckbSoon.AutoSize = true;
            this.ckbSoon.Location = new System.Drawing.Point(39, 60);
            this.ckbSoon.Margin = new System.Windows.Forms.Padding(1);
            this.ckbSoon.Name = "ckbSoon";
            this.ckbSoon.Size = new System.Drawing.Size(63, 21);
            this.ckbSoon.TabIndex = 2;
            this.ckbSoon.Text = "순대국";
            this.ckbSoon.UseVisualStyleBackColor = true;
            // 
            // ckbPasta
            // 
            this.ckbPasta.AutoSize = true;
            this.ckbPasta.Location = new System.Drawing.Point(136, 60);
            this.ckbPasta.Margin = new System.Windows.Forms.Padding(1);
            this.ckbPasta.Name = "ckbPasta";
            this.ckbPasta.Size = new System.Drawing.Size(63, 21);
            this.ckbPasta.TabIndex = 3;
            this.ckbPasta.Text = "파스타";
            this.ckbPasta.UseVisualStyleBackColor = true;
            // 
            // ckbSteak
            // 
            this.ckbSteak.AutoSize = true;
            this.ckbSteak.Location = new System.Drawing.Point(227, 60);
            this.ckbSteak.Margin = new System.Windows.Forms.Padding(1);
            this.ckbSteak.Name = "ckbSteak";
            this.ckbSteak.Size = new System.Drawing.Size(75, 21);
            this.ckbSteak.TabIndex = 4;
            this.ckbSteak.Text = "스테이크";
            this.ckbSteak.UseVisualStyleBackColor = true;
            // 
            // ckbTang
            // 
            this.ckbTang.AutoSize = true;
            this.ckbTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ckbTang.Location = new System.Drawing.Point(328, 60);
            this.ckbTang.Margin = new System.Windows.Forms.Padding(1);
            this.ckbTang.Name = "ckbTang";
            this.ckbTang.Size = new System.Drawing.Size(63, 21);
            this.ckbTang.TabIndex = 5;
            this.ckbTang.Text = "탕수육";
            this.ckbTang.UseVisualStyleBackColor = true;
            // 
            // btnEvent
            // 
            this.btnEvent.Location = new System.Drawing.Point(39, 101);
            this.btnEvent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(352, 41);
            this.btnEvent.TabIndex = 6;
            this.btnEvent.Text = "주문";
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "이벤트에 응모하려면 개인정보 동의해주세요";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDisagree);
            this.groupBox1.Controls.Add(this.radioAgree);
            this.groupBox1.Location = new System.Drawing.Point(40, 213);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(351, 98);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "개인정보동의";
            // 
            // radioDisagree
            // 
            this.radioDisagree.AutoSize = true;
            this.radioDisagree.Location = new System.Drawing.Point(154, 50);
            this.radioDisagree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioDisagree.Name = "radioDisagree";
            this.radioDisagree.Size = new System.Drawing.Size(74, 21);
            this.radioDisagree.TabIndex = 1;
            this.radioDisagree.TabStop = true;
            this.radioDisagree.Text = "동의안함";
            this.radioDisagree.UseVisualStyleBackColor = true;
            // 
            // radioAgree
            // 
            this.radioAgree.AutoSize = true;
            this.radioAgree.Location = new System.Drawing.Point(25, 50);
            this.radioAgree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioAgree.Name = "radioAgree";
            this.radioAgree.Size = new System.Drawing.Size(50, 21);
            this.radioAgree.TabIndex = 0;
            this.radioAgree.TabStop = true;
            this.radioAgree.Text = "동의";
            this.radioAgree.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(415, 231);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(143, 53);
            this.btnEnter.TabIndex = 9;
            this.btnEnter.Text = "응모";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "주문 시 요구사항";
            // 
            // btnRecipt
            // 
            this.btnRecipt.Location = new System.Drawing.Point(415, 377);
            this.btnRecipt.Name = "btnRecipt";
            this.btnRecipt.Size = new System.Drawing.Size(143, 53);
            this.btnRecipt.TabIndex = 11;
            this.btnRecipt.Text = "접수";
            this.btnRecipt.UseVisualStyleBackColor = true;
            this.btnRecipt.Click += new System.EventHandler(this.btnRecipt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 365);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 80);
            this.textBox1.TabIndex = 12;
            // 
            // lbArea
            // 
            this.lbArea.FormattingEnabled = true;
            this.lbArea.ItemHeight = 16;
            this.lbArea.Items.AddRange(new object[] {
            "일시불",
            "3개월 할부",
            "6개월 할부"});
            this.lbArea.Location = new System.Drawing.Point(218, 515);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(173, 84);
            this.lbArea.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "결제방법";
            // 
            // cbPay
            // 
            this.cbPay.FormattingEnabled = true;
            this.cbPay.Items.AddRange(new object[] {
            "신용카드",
            "무통장입금",
            "포인트"});
            this.cbPay.Location = new System.Drawing.Point(39, 515);
            this.cbPay.Name = "cbPay";
            this.cbPay.Size = new System.Drawing.Size(145, 24);
            this.cbPay.TabIndex = 18;
            this.cbPay.Text = "신용카드";
            this.cbPay.SelectedIndexChanged += new System.EventHandler(this.cbPay_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 478);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "결제정보";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(415, 527);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(143, 53);
            this.btnPay.TabIndex = 20;
            this.btnPay.Text = "결제";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 642);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRecipt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEvent);
            this.Controls.Add(this.ckbTang);
            this.Controls.Add(this.ckbSteak);
            this.Controls.Add(this.ckbPasta);
            this.Controls.Add(this.ckbSoon);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.CheckBox ckbSoon;
        private System.Windows.Forms.CheckBox ckbPasta;
        private System.Windows.Forms.CheckBox ckbSteak;
        private System.Windows.Forms.CheckBox ckbTang;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioDisagree;
        private System.Windows.Forms.RadioButton radioAgree;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRecipt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lbArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

