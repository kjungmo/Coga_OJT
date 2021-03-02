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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            resources.ApplyResources(this.deleteIndex, "deleteIndex");
            this.deleteIndex.Name = "deleteIndex";
            // 
            // updateIndex
            // 
            resources.ApplyResources(this.updateIndex, "updateIndex");
            this.updateIndex.Name = "updateIndex";
            // 
            // readIndex
            // 
            resources.ApplyResources(this.readIndex, "readIndex");
            this.readIndex.Name = "readIndex";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // createIndex
            // 
            resources.ApplyResources(this.createIndex, "createIndex");
            this.createIndex.Name = "createIndex";
            // 
            // updateValue
            // 
            resources.ApplyResources(this.updateValue, "updateValue");
            this.updateValue.Name = "updateValue";
            // 
            // readValue
            // 
            resources.ApplyResources(this.readValue, "readValue");
            this.readValue.Name = "readValue";
            this.readValue.ReadOnly = true;
            // 
            // showLinkedList
            // 
            resources.ApplyResources(this.showLinkedList, "showLinkedList");
            this.showLinkedList.FormattingEnabled = true;
            this.showLinkedList.Name = "showLinkedList";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // DeleteButton
            // 
            resources.ApplyResources(this.DeleteButton, "DeleteButton");
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // updateButton
            // 
            resources.ApplyResources(this.updateButton, "updateButton");
            this.updateButton.Name = "updateButton";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // readButton
            // 
            resources.ApplyResources(this.readButton, "readButton");
            this.readButton.Name = "readButton";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // createButton
            // 
            resources.ApplyResources(this.createButton, "createButton");
            this.createButton.Name = "createButton";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // createValue
            // 
            resources.ApplyResources(this.createValue, "createValue");
            this.createValue.Name = "createValue";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

