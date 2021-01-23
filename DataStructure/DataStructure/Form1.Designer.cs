namespace DataStructure
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deleteIndex = new System.Windows.Forms.TextBox();
            this.updateIndex = new System.Windows.Forms.TextBox();
            this.readIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createIndex = new System.Windows.Forms.TextBox();
            this.deleteValue = new System.Windows.Forms.TextBox();
            this.updateValue = new System.Windows.Forms.TextBox();
            this.readValue = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.createValue = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.popValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pushValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pop = new System.Windows.Forms.Button();
            this.push = new System.Windows.Forms.Button();
            this.showStack = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.showDequeue = new System.Windows.Forms.TextBox();
            this.dequeue = new System.Windows.Forms.Button();
            this.enqueue = new System.Windows.Forms.Button();
            this.valueQueue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.showQueue = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(20, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.deleteIndex);
            this.tabPage1.Controls.Add(this.updateIndex);
            this.tabPage1.Controls.Add(this.readIndex);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.createIndex);
            this.tabPage1.Controls.Add(this.deleteValue);
            this.tabPage1.Controls.Add(this.updateValue);
            this.tabPage1.Controls.Add(this.readValue);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.DeleteButton);
            this.tabPage1.Controls.Add(this.updateButton);
            this.tabPage1.Controls.Add(this.readButton);
            this.tabPage1.Controls.Add(this.createButton);
            this.tabPage1.Controls.Add(this.createValue);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(569, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Linked List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // deleteIndex
            // 
            this.deleteIndex.Location = new System.Drawing.Point(299, 299);
            this.deleteIndex.Name = "deleteIndex";
            this.deleteIndex.Size = new System.Drawing.Size(59, 21);
            this.deleteIndex.TabIndex = 20;
            // 
            // updateIndex
            // 
            this.updateIndex.Location = new System.Drawing.Point(298, 259);
            this.updateIndex.Name = "updateIndex";
            this.updateIndex.Size = new System.Drawing.Size(59, 21);
            this.updateIndex.TabIndex = 19;
            // 
            // readIndex
            // 
            this.readIndex.Location = new System.Drawing.Point(299, 217);
            this.readIndex.Name = "readIndex";
            this.readIndex.Size = new System.Drawing.Size(58, 21);
            this.readIndex.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "Index";
            // 
            // createIndex
            // 
            this.createIndex.Location = new System.Drawing.Point(298, 172);
            this.createIndex.Name = "createIndex";
            this.createIndex.Size = new System.Drawing.Size(59, 21);
            this.createIndex.TabIndex = 16;
            // 
            // deleteValue
            // 
            this.deleteValue.Location = new System.Drawing.Point(396, 299);
            this.deleteValue.Name = "deleteValue";
            this.deleteValue.ReadOnly = true;
            this.deleteValue.Size = new System.Drawing.Size(59, 21);
            this.deleteValue.TabIndex = 15;
            // 
            // updateValue
            // 
            this.updateValue.Location = new System.Drawing.Point(395, 259);
            this.updateValue.Name = "updateValue";
            this.updateValue.Size = new System.Drawing.Size(59, 21);
            this.updateValue.TabIndex = 9;
            // 
            // readValue
            // 
            this.readValue.Location = new System.Drawing.Point(396, 217);
            this.readValue.Name = "readValue";
            this.readValue.ReadOnly = true;
            this.readValue.Size = new System.Drawing.Size(58, 21);
            this.readValue.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(24, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(238, 304);
            this.listBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Value";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(476, 295);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(476, 255);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(476, 213);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(75, 23);
            this.readButton.TabIndex = 2;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(476, 168);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // createValue
            // 
            this.createValue.Location = new System.Drawing.Point(395, 172);
            this.createValue.Name = "createValue";
            this.createValue.Size = new System.Drawing.Size(59, 21);
            this.createValue.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.popValue);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.pushValue);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pop);
            this.tabPage2.Controls.Add(this.push);
            this.tabPage2.Controls.Add(this.showStack);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(569, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stack";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // popValue
            // 
            this.popValue.Location = new System.Drawing.Point(257, 213);
            this.popValue.Name = "popValue";
            this.popValue.ReadOnly = true;
            this.popValue.Size = new System.Drawing.Size(100, 21);
            this.popValue.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Value";
            // 
            // pushValue
            // 
            this.pushValue.Location = new System.Drawing.Point(255, 165);
            this.pushValue.Name = "pushValue";
            this.pushValue.Size = new System.Drawing.Size(100, 21);
            this.pushValue.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stack";
            // 
            // pop
            // 
            this.pop.Location = new System.Drawing.Point(367, 213);
            this.pop.Name = "pop";
            this.pop.Size = new System.Drawing.Size(75, 23);
            this.pop.TabIndex = 2;
            this.pop.Text = "pop";
            this.pop.UseVisualStyleBackColor = true;
            this.pop.Click += new System.EventHandler(this.pop_Click);
            // 
            // push
            // 
            this.push.Location = new System.Drawing.Point(367, 164);
            this.push.Name = "push";
            this.push.Size = new System.Drawing.Size(75, 23);
            this.push.TabIndex = 1;
            this.push.Text = "push";
            this.push.UseVisualStyleBackColor = true;
            this.push.Click += new System.EventHandler(this.push_Click);
            // 
            // showStack
            // 
            this.showStack.FormattingEnabled = true;
            this.showStack.ItemHeight = 12;
            this.showStack.Location = new System.Drawing.Point(80, 27);
            this.showStack.Name = "showStack";
            this.showStack.Size = new System.Drawing.Size(121, 292);
            this.showStack.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.showDequeue);
            this.tabPage3.Controls.Add(this.dequeue);
            this.tabPage3.Controls.Add(this.enqueue);
            this.tabPage3.Controls.Add(this.valueQueue);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.showQueue);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(569, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Queue";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // showDequeue
            // 
            this.showDequeue.Location = new System.Drawing.Point(251, 217);
            this.showDequeue.Name = "showDequeue";
            this.showDequeue.ReadOnly = true;
            this.showDequeue.Size = new System.Drawing.Size(100, 21);
            this.showDequeue.TabIndex = 6;
            // 
            // dequeue
            // 
            this.dequeue.Location = new System.Drawing.Point(366, 217);
            this.dequeue.Name = "dequeue";
            this.dequeue.Size = new System.Drawing.Size(75, 23);
            this.dequeue.TabIndex = 5;
            this.dequeue.Text = "Dequeue";
            this.dequeue.UseVisualStyleBackColor = true;
            this.dequeue.Click += new System.EventHandler(this.dequeue_Click);
            // 
            // enqueue
            // 
            this.enqueue.Location = new System.Drawing.Point(366, 162);
            this.enqueue.Name = "enqueue";
            this.enqueue.Size = new System.Drawing.Size(75, 23);
            this.enqueue.TabIndex = 4;
            this.enqueue.Text = "Enqueue";
            this.enqueue.UseVisualStyleBackColor = true;
            this.enqueue.Click += new System.EventHandler(this.enqueue_Click);
            // 
            // valueQueue
            // 
            this.valueQueue.Location = new System.Drawing.Point(251, 164);
            this.valueQueue.Name = "valueQueue";
            this.valueQueue.Size = new System.Drawing.Size(100, 21);
            this.valueQueue.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "Queue";
            // 
            // showQueue
            // 
            this.showQueue.Location = new System.Drawing.Point(36, 69);
            this.showQueue.Name = "showQueue";
            this.showQueue.ReadOnly = true;
            this.showQueue.Size = new System.Drawing.Size(489, 21);
            this.showQueue.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 434);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Data structure";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox createValue;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox deleteValue;
        private System.Windows.Forms.TextBox updateValue;
        private System.Windows.Forms.TextBox readValue;
        private System.Windows.Forms.TextBox deleteIndex;
        private System.Windows.Forms.TextBox updateIndex;
        private System.Windows.Forms.TextBox readIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox createIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pushValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pop;
        private System.Windows.Forms.Button push;
        private System.Windows.Forms.ListBox showStack;
        private System.Windows.Forms.Button dequeue;
        private System.Windows.Forms.Button enqueue;
        private System.Windows.Forms.TextBox valueQueue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox showQueue;
        private System.Windows.Forms.TextBox showDequeue;
        private System.Windows.Forms.TextBox popValue;
    }
}

