﻿
namespace StringBuilderMethod
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
            this.btnBase = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBase
            // 
            this.btnBase.Location = new System.Drawing.Point(38, 100);
            this.btnBase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(186, 58);
            this.btnBase.TabIndex = 0;
            this.btnBase.Text = "기본출력";
            this.btnBase.UseVisualStyleBackColor = true;
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(291, 100);
            this.btnAppend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(186, 58);
            this.btnAppend.TabIndex = 1;
            this.btnAppend.Text = "추가";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(544, 100);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(186, 58);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(797, 100);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(186, 58);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "삽입";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult.Location = new System.Drawing.Point(27, 301);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(211, 63);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "기본출력";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 522);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnBase);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBase;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblResult;
    }
}

