namespace 연산자_실습
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
            this.textBox_Print = new System.Windows.Forms.TextBox();
            this.textBox_print2 = new System.Windows.Forms.TextBox();
            this.textBox_print3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Print
            // 
            this.textBox_Print.Location = new System.Drawing.Point(12, 26);
            this.textBox_Print.Multiline = true;
            this.textBox_Print.Name = "textBox_Print";
            this.textBox_Print.Size = new System.Drawing.Size(253, 386);
            this.textBox_Print.TabIndex = 0;
            this.textBox_Print.TextChanged += new System.EventHandler(this.textBox_Print_TextChanged);
            // 
            // textBox_print2
            // 
            this.textBox_print2.Location = new System.Drawing.Point(271, 26);
            this.textBox_print2.Multiline = true;
            this.textBox_print2.Name = "textBox_print2";
            this.textBox_print2.Size = new System.Drawing.Size(256, 386);
            this.textBox_print2.TabIndex = 1;
            this.textBox_print2.TextChanged += new System.EventHandler(this.textBox_print2_TextChanged);
            // 
            // textBox_print3
            // 
            this.textBox_print3.Location = new System.Drawing.Point(533, 26);
            this.textBox_print3.Multiline = true;
            this.textBox_print3.Name = "textBox_print3";
            this.textBox_print3.Size = new System.Drawing.Size(255, 386);
            this.textBox_print3.TabIndex = 2;
            this.textBox_print3.TextChanged += new System.EventHandler(this.textBox_print3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_print3);
            this.Controls.Add(this.textBox_print2);
            this.Controls.Add(this.textBox_Print);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Print;
        private System.Windows.Forms.TextBox textBox_print2;
        private System.Windows.Forms.TextBox textBox_print3;
    }
}

