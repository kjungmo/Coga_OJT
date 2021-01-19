namespace Pyramids
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
            this.printStars = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.shapes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.layers = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.layers)).BeginInit();
            this.SuspendLayout();
            // 
            // printStars
            // 
            this.printStars.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.printStars.Location = new System.Drawing.Point(12, 12);
            this.printStars.Multiline = true;
            this.printStars.Name = "printStars";
            this.printStars.ReadOnly = true;
            this.printStars.Size = new System.Drawing.Size(239, 273);
            this.printStars.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(269, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // shapes
            // 
            this.shapes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shapes.FormattingEnabled = true;
            this.shapes.Items.AddRange(new object[] {
            "Rightsided",
            "Centered",
            "Reversed"});
            this.shapes.Location = new System.Drawing.Point(269, 187);
            this.shapes.Name = "shapes";
            this.shapes.Size = new System.Drawing.Size(99, 20);
            this.shapes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "How many layers?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pyramid Shape?";
            // 
            // layers
            // 
            this.layers.Location = new System.Drawing.Point(269, 136);
            this.layers.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.layers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.layers.Name = "layers";
            this.layers.Size = new System.Drawing.Size(99, 21);
            this.layers.TabIndex = 6;
            this.layers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.layers.ValueChanged += new System.EventHandler(this.layers_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 300);
            this.Controls.Add(this.layers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.printStars);
            this.Name = "Form1";
            this.Text = "Pyramid Constructor";
            ((System.ComponentModel.ISupportInitialize)(this.layers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox printStars;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox shapes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown layers;
    }
}

