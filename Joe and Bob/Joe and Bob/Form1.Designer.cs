namespace Joe_and_Bob
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button button1;
            this.button2 = new System.Windows.Forms.Button();
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(12, 111);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 39);
            button1.TabIndex = 0;
            button1.Text = "Give $10 to Joe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.joesCashLabel.Location = new System.Drawing.Point(12, 9);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(38, 12);
            this.joesCashLabel.TabIndex = 2;
            this.joesCashLabel.Text = "label1";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bobsCashLabel.Location = new System.Drawing.Point(12, 43);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(38, 12);
            this.bobsCashLabel.TabIndex = 3;
            this.bobsCashLabel.Text = "label2";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.bankCashLabel.Location = new System.Drawing.Point(12, 75);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(38, 12);
            this.bankCashLabel.TabIndex = 4;
            this.bankCashLabel.Text = "label3";
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(12, 165);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(75, 39);
            this.joeGivesToBob.TabIndex = 5;
            this.joeGivesToBob.Text = "Joe gives $10 to Bob";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            this.joeGivesToBob.Click += new System.EventHandler(this.joeGivesToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(95, 165);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(75, 39);
            this.bobGivesToJoe.TabIndex = 6;
            this.bobGivesToJoe.Text = "Bob gives $5 to Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 229);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(button1);
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button joeGivesToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
    }
}

