
namespace Project2_2
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
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.ptnMinus = new System.Windows.Forms.Button();
            this.ptnMultiple = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(53, 40);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(282, 31);
            this.txtInput1.TabIndex = 0;
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(426, 40);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(282, 31);
            this.txtInput2.TabIndex = 1;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(79, 130);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(234, 76);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "더하기";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(440, 232);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(234, 76);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.Text = "나누기";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // ptnMinus
            // 
            this.ptnMinus.Location = new System.Drawing.Point(440, 130);
            this.ptnMinus.Name = "ptnMinus";
            this.ptnMinus.Size = new System.Drawing.Size(234, 76);
            this.ptnMinus.TabIndex = 4;
            this.ptnMinus.Text = "빼기";
            this.ptnMinus.UseVisualStyleBackColor = true;
            this.ptnMinus.Click += new System.EventHandler(this.ptnMinus_Click);
            // 
            // ptnMultiple
            // 
            this.ptnMultiple.Location = new System.Drawing.Point(79, 232);
            this.ptnMultiple.Name = "ptnMultiple";
            this.ptnMultiple.Size = new System.Drawing.Size(234, 76);
            this.ptnMultiple.TabIndex = 5;
            this.ptnMultiple.Text = "곱하기";
            this.ptnMultiple.UseVisualStyleBackColor = true;
            this.ptnMultiple.Click += new System.EventHandler(this.ptnMultiple_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(347, 366);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(70, 25);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.ptnMultiple);
            this.Controls.Add(this.ptnMinus);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtInput1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button ptnMinus;
        private System.Windows.Forms.Button ptnMultiple;
        private System.Windows.Forms.Label lblResult;
    }
}

