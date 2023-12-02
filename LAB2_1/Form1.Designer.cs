namespace Lab2_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainInput = new GroupBox();
            saveBotton = new Button();
            stPointBox = new TextBox();
            stNameBox = new TextBox();
            stIDBox = new TextBox();
            stPoint = new Label();
            stName = new Label();
            stID = new Label();
            answer = new GroupBox();
            averageBox = new TextBox();
            average = new Label();
            stPointMinBox = new TextBox();
            stNameMinBox = new TextBox();
            stIDMinBox = new TextBox();
            stPointMaxBox = new TextBox();
            stNameMaxBox = new TextBox();
            stIDMaxBox = new TextBox();
            pointMin = new Label();
            pointMax = new Label();
            stPoint2 = new Label();
            stName2 = new Label();
            stID2 = new Label();
            mainInput.SuspendLayout();
            answer.SuspendLayout();
            SuspendLayout();
            // 
            // mainInput
            // 
            mainInput.Controls.Add(saveBotton);
            mainInput.Controls.Add(stPointBox);
            mainInput.Controls.Add(stNameBox);
            mainInput.Controls.Add(stIDBox);
            mainInput.Controls.Add(stPoint);
            mainInput.Controls.Add(stName);
            mainInput.Controls.Add(stID);
            mainInput.Location = new Point(82, 68);
            mainInput.Name = "mainInput";
            mainInput.Size = new Size(288, 211);
            mainInput.TabIndex = 0;
            mainInput.TabStop = false;
            mainInput.Text = "กรอกข้อมูล";
            mainInput.Enter += groupBox1_Enter;
            // 
            // saveBotton
            // 
            saveBotton.BackColor = SystemColors.Window;
            saveBotton.Location = new Point(117, 159);
            saveBotton.Name = "saveBotton";
            saveBotton.Size = new Size(135, 23);
            saveBotton.TabIndex = 6;
            saveBotton.Text = "บันทึก";
            saveBotton.UseVisualStyleBackColor = false;
            saveBotton.Click += button1_Click;
            // 
            // stPointBox
            // 
            stPointBox.Location = new Point(117, 118);
            stPointBox.Name = "stPointBox";
            stPointBox.Size = new Size(135, 23);
            stPointBox.TabIndex = 5;
            // 
            // stNameBox
            // 
            stNameBox.Location = new Point(117, 80);
            stNameBox.Name = "stNameBox";
            stNameBox.Size = new Size(135, 23);
            stNameBox.TabIndex = 4;
            // 
            // stIDBox
            // 
            stIDBox.Location = new Point(117, 44);
            stIDBox.Name = "stIDBox";
            stIDBox.Size = new Size(135, 23);
            stIDBox.TabIndex = 1;
            stIDBox.TextChanged += stIDBox_TextChanged;
            // 
            // stPoint
            // 
            stPoint.AutoSize = true;
            stPoint.Location = new Point(30, 121);
            stPoint.Name = "stPoint";
            stPoint.Size = new Size(38, 15);
            stPoint.TabIndex = 3;
            stPoint.Text = "คะแนน";
            // 
            // stName
            // 
            stName.AutoSize = true;
            stName.Location = new Point(30, 83);
            stName.Name = "stName";
            stName.Size = new Size(63, 15);
            stName.TabIndex = 2;
            stName.Text = "ชื่อ-นามสกุล";
            // 
            // stID
            // 
            stID.AutoSize = true;
            stID.Location = new Point(30, 47);
            stID.Name = "stID";
            stID.Size = new Size(65, 15);
            stID.TabIndex = 1;
            stID.Text = "รหัสนักศึกษา";
            stID.Click += label1_Click_1;
            // 
            // answer
            // 
            answer.Controls.Add(averageBox);
            answer.Controls.Add(average);
            answer.Controls.Add(stPointMinBox);
            answer.Controls.Add(stNameMinBox);
            answer.Controls.Add(stIDMinBox);
            answer.Controls.Add(stPointMaxBox);
            answer.Controls.Add(stNameMaxBox);
            answer.Controls.Add(stIDMaxBox);
            answer.Controls.Add(pointMin);
            answer.Controls.Add(pointMax);
            answer.Controls.Add(stPoint2);
            answer.Controls.Add(stName2);
            answer.Controls.Add(stID2);
            answer.Location = new Point(447, 71);
            answer.Name = "answer";
            answer.Size = new Size(617, 208);
            answer.TabIndex = 1;
            answer.TabStop = false;
            answer.Text = "ผลลัพท์";
            // 
            // averageBox
            // 
            averageBox.Location = new Point(446, 157);
            averageBox.Name = "averageBox";
            averageBox.ReadOnly = true;
            averageBox.Size = new Size(135, 23);
            averageBox.TabIndex = 16;
            averageBox.TextChanged += averageBox_TextChanged;
            // 
            // average
            // 
            average.AutoSize = true;
            average.Location = new Point(320, 160);
            average.Name = "average";
            average.Size = new Size(60, 15);
            average.TabIndex = 15;
            average.Text = "คะแนนเฉลี่ย";
            average.Click += label1_Click_3;
            // 
            // stPointMinBox
            // 
            stPointMinBox.Location = new Point(446, 115);
            stPointMinBox.Name = "stPointMinBox";
            stPointMinBox.ReadOnly = true;
            stPointMinBox.Size = new Size(135, 23);
            stPointMinBox.TabIndex = 14;
            stPointMinBox.TextChanged += textBox1_TextChanged_1;
            // 
            // stNameMinBox
            // 
            stNameMinBox.Location = new Point(284, 115);
            stNameMinBox.Name = "stNameMinBox";
            stNameMinBox.ReadOnly = true;
            stNameMinBox.Size = new Size(135, 23);
            stNameMinBox.TabIndex = 13;
            stNameMinBox.TextChanged += stNameMinBox_TextChanged;
            // 
            // stIDMinBox
            // 
            stIDMinBox.Location = new Point(121, 115);
            stIDMinBox.Name = "stIDMinBox";
            stIDMinBox.ReadOnly = true;
            stIDMinBox.Size = new Size(135, 23);
            stIDMinBox.TabIndex = 12;
            stIDMinBox.TextChanged += stIDMinBox_TextChanged;
            // 
            // stPointMaxBox
            // 
            stPointMaxBox.Location = new Point(446, 74);
            stPointMaxBox.Name = "stPointMaxBox";
            stPointMaxBox.ReadOnly = true;
            stPointMaxBox.Size = new Size(135, 23);
            stPointMaxBox.TabIndex = 11;
            // 
            // stNameMaxBox
            // 
            stNameMaxBox.Location = new Point(284, 74);
            stNameMaxBox.Name = "stNameMaxBox";
            stNameMaxBox.ReadOnly = true;
            stNameMaxBox.Size = new Size(135, 23);
            stNameMaxBox.TabIndex = 10;
            stNameMaxBox.TextChanged += textBox1_TextChanged;
            // 
            // stIDMaxBox
            // 
            stIDMaxBox.Location = new Point(121, 74);
            stIDMaxBox.Name = "stIDMaxBox";
            stIDMaxBox.ReadOnly = true;
            stIDMaxBox.Size = new Size(135, 23);
            stIDMaxBox.TabIndex = 7;
            // 
            // pointMin
            // 
            pointMin.AutoSize = true;
            pointMin.Location = new Point(43, 118);
            pointMin.Name = "pointMin";
            pointMin.Size = new Size(63, 15);
            pointMin.TabIndex = 9;
            pointMin.Text = "คะแนนต่ำสุด";
            // 
            // pointMax
            // 
            pointMax.AutoSize = true;
            pointMax.Location = new Point(43, 77);
            pointMax.Name = "pointMax";
            pointMax.Size = new Size(62, 15);
            pointMax.TabIndex = 8;
            pointMax.Text = "คะแนนสูงสุด";
            // 
            // stPoint2
            // 
            stPoint2.AutoSize = true;
            stPoint2.Location = new Point(493, 41);
            stPoint2.Name = "stPoint2";
            stPoint2.Size = new Size(38, 15);
            stPoint2.TabIndex = 7;
            stPoint2.Text = "คะแนน";
            stPoint2.Click += stPoint2_Click;
            // 
            // stName2
            // 
            stName2.AutoSize = true;
            stName2.Location = new Point(317, 41);
            stName2.Name = "stName2";
            stName2.Size = new Size(63, 15);
            stName2.TabIndex = 7;
            stName2.Text = "ชื่อ-นามสกุล";
            // 
            // stID2
            // 
            stID2.AutoSize = true;
            stID2.Location = new Point(159, 41);
            stID2.Name = "stID2";
            stID2.Size = new Size(65, 15);
            stID2.TabIndex = 7;
            stID2.Text = "รหัสนักศึกษา";
            stID2.Click += label1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 450);
            Controls.Add(answer);
            Controls.Add(mainInput);
            Name = "Form1";
            Text = "Form1";
            mainInput.ResumeLayout(false);
            mainInput.PerformLayout();
            answer.ResumeLayout(false);
            answer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox mainInput;
        private Label stID;
        private Label stPoint;
        private Label stName;
        private Button saveBotton;
        private TextBox stPointBox;
        private TextBox stNameBox;
        private TextBox stIDBox;
        private GroupBox answer;
        private Label stPoint2;
        private Label stName2;
        private Label stID2;
        private TextBox stNameMaxBox;
        private TextBox stIDMaxBox;
        private Label pointMin;
        private Label pointMax;
        private TextBox stPointMaxBox;
        private TextBox stPointMinBox;
        private TextBox stNameMinBox;
        private TextBox stIDMinBox;
        private Label average;
        private TextBox averageBox;
    }
}
