
namespace Project2_3
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
            this.tbKuk = new System.Windows.Forms.TextBox();
            this.tbEng = new System.Windows.Forms.TextBox();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "국어 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "영어 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "수학 :";
            // 
            // tbKuk
            // 
            this.tbKuk.Location = new System.Drawing.Point(127, 35);
            this.tbKuk.Name = "tbKuk";
            this.tbKuk.Size = new System.Drawing.Size(100, 31);
            this.tbKuk.TabIndex = 1;
            // 
            // tbEng
            // 
            this.tbEng.Location = new System.Drawing.Point(347, 35);
            this.tbEng.Name = "tbEng";
            this.tbEng.Size = new System.Drawing.Size(100, 31);
            this.tbEng.TabIndex = 1;
            // 
            // tbMath
            // 
            this.tbMath.Location = new System.Drawing.Point(589, 35);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(100, 31);
            this.tbMath.TabIndex = 1;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(251, 134);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(287, 155);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "결과";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(472, 356);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(152, 25);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "결과가 출력됩니다.";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(215, 356);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(60, 25);
            this.lblAvg.TabIndex = 3;
            this.lblAvg.Text = "평균값";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.tbEng);
            this.Controls.Add(this.tbKuk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKuk;
        private System.Windows.Forms.TextBox tbEng;
        private System.Windows.Forms.TextBox tbMath;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAvg;
    }
}

