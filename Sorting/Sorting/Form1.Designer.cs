namespace Sorting
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.algorithm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(22, 83);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(172, 21);
            this.inputText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "user input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "result";
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(22, 152);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(172, 21);
            this.outputText.TabIndex = 3;
            // 
            // sortButton
            // 
            this.sortButton.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sortButton.Location = new System.Drawing.Point(214, 83);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(121, 99);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Sort!";
            this.sortButton.UseVisualStyleBackColor = true;
            // 
            // algorithm
            // 
            this.algorithm.FormattingEnabled = true;
            this.algorithm.Location = new System.Drawing.Point(214, 57);
            this.algorithm.Name = "algorithm";
            this.algorithm.Size = new System.Drawing.Size(121, 20);
            this.algorithm.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Algorithm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 194);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.algorithm);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputText);
            this.Name = "Form1";
            this.Text = "Sorting Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.ComboBox algorithm;
        private System.Windows.Forms.Label label3;
    }
}

