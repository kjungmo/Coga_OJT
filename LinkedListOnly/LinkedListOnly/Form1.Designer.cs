namespace LinkedListOnly
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
            this.deleteIndex = new System.Windows.Forms.TextBox();
            this.updateIndex = new System.Windows.Forms.TextBox();
            this.readIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createIndex = new System.Windows.Forms.TextBox();
            this.updateValue = new System.Windows.Forms.TextBox();
            this.readValue = new System.Windows.Forms.TextBox();
            this.showLinkedList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.createValue = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // deleteIndex
            // 
            this.deleteIndex.Location = new System.Drawing.Point(303, 384);
            this.deleteIndex.Name = "deleteIndex";
            this.deleteIndex.Size = new System.Drawing.Size(59, 21);
            this.deleteIndex.TabIndex = 34;
            // 
            // updateIndex
            // 
            this.updateIndex.Location = new System.Drawing.Point(302, 344);
            this.updateIndex.Name = "updateIndex";
            this.updateIndex.Size = new System.Drawing.Size(59, 21);
            this.updateIndex.TabIndex = 33;
            // 
            // readIndex
            // 
            this.readIndex.Location = new System.Drawing.Point(303, 302);
            this.readIndex.Name = "readIndex";
            this.readIndex.Size = new System.Drawing.Size(58, 21);
            this.readIndex.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "Index";
            // 
            // createIndex
            // 
            this.createIndex.Location = new System.Drawing.Point(302, 257);
            this.createIndex.Name = "createIndex";
            this.createIndex.Size = new System.Drawing.Size(59, 21);
            this.createIndex.TabIndex = 30;
            // 
            // updateValue
            // 
            this.updateValue.Location = new System.Drawing.Point(399, 344);
            this.updateValue.Name = "updateValue";
            this.updateValue.Size = new System.Drawing.Size(59, 21);
            this.updateValue.TabIndex = 29;
            // 
            // readValue
            // 
            this.readValue.Location = new System.Drawing.Point(400, 302);
            this.readValue.Name = "readValue";
            this.readValue.ReadOnly = true;
            this.readValue.Size = new System.Drawing.Size(58, 21);
            this.readValue.TabIndex = 28;
            // 
            // showLinkedList
            // 
            this.showLinkedList.FormattingEnabled = true;
            this.showLinkedList.ItemHeight = 12;
            this.showLinkedList.Location = new System.Drawing.Point(41, 65);
            this.showLinkedList.Name = "showLinkedList";
            this.showLinkedList.Size = new System.Drawing.Size(238, 304);
            this.showLinkedList.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "Value";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(480, 380);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 25;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(480, 340);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 24;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(480, 298);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 23;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(480, 253);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 22;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // createValue
            // 
            this.createValue.Location = new System.Drawing.Point(399, 257);
            this.createValue.Name = "createValue";
            this.createValue.Size = new System.Drawing.Size(59, 21);
            this.createValue.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "한국어",
            "영어"});
            this.comboBox1.Location = new System.Drawing.Point(379, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 20);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(305, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(70, 14);
            this.textBox1.TabIndex = 36;
            this.textBox1.Text = "Language :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(331, 123);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(210, 96);
            this.richTextBox1.TabIndex = 37;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 434);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.deleteIndex);
            this.Controls.Add(this.updateIndex);
            this.Controls.Add(this.readIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createIndex);
            this.Controls.Add(this.updateValue);
            this.Controls.Add(this.readValue);
            this.Controls.Add(this.showLinkedList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.createValue);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Meine Liste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deleteIndex;
        private System.Windows.Forms.TextBox updateIndex;
        private System.Windows.Forms.TextBox readIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox createIndex;
        private System.Windows.Forms.TextBox updateValue;
        private System.Windows.Forms.TextBox readValue;
        private System.Windows.Forms.ListBox showLinkedList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox createValue;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

