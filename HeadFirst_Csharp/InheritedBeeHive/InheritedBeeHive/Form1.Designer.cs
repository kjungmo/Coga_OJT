namespace InheritedBeeHive
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
            this.assignJob = new System.Windows.Forms.Button();
            this.nextShift = new System.Windows.Forms.Button();
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupbox1 = new System.Windows.Forms.GroupBox();
            this.report = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.groupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // assignJob
            // 
            this.assignJob.AutoSize = true;
            this.assignJob.Location = new System.Drawing.Point(15, 84);
            this.assignJob.Name = "assignJob";
            this.assignJob.Size = new System.Drawing.Size(328, 23);
            this.assignJob.TabIndex = 0;
            this.assignJob.Text = "Assign this job to a bee";
            this.assignJob.UseVisualStyleBackColor = true;
            this.assignJob.Click += new System.EventHandler(this.assignJob_Click);
            // 
            // nextShift
            // 
            this.nextShift.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nextShift.Location = new System.Drawing.Point(388, 12);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(264, 127);
            this.nextShift.TabIndex = 1;
            this.nextShift.Text = "Work the next shift";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.workerBeeJob.Location = new System.Drawing.Point(15, 50);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(224, 20);
            this.workerBeeJob.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Job";
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(245, 49);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(98, 21);
            this.shifts.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shifts";
            // 
            // groupbox1
            // 
            this.groupbox1.Controls.Add(this.label2);
            this.groupbox1.Controls.Add(this.shifts);
            this.groupbox1.Controls.Add(this.label1);
            this.groupbox1.Controls.Add(this.workerBeeJob);
            this.groupbox1.Controls.Add(this.assignJob);
            this.groupbox1.Location = new System.Drawing.Point(12, 12);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(358, 127);
            this.groupbox1.TabIndex = 6;
            this.groupbox1.TabStop = false;
            this.groupbox1.Text = "Worker Bee Assignments";
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(12, 153);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(640, 312);
            this.report.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(664, 477);
            this.Controls.Add(this.report);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.nextShift);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.groupbox1.ResumeLayout(false);
            this.groupbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button assignJob;
        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupbox1;
        private System.Windows.Forms.TextBox report;

    }
}

