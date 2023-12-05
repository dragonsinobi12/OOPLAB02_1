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
            gpaBox = new TextBox();
            gpsText = new Label();
            gABOX = new TextBox();
            gradeF = new Label();
            gradeD = new Label();
            gradeDPlus = new Label();
            gradeC = new Label();
            gradeCPlus = new Label();
            gradeB = new Label();
            gradeBPlus = new Label();
            gradeA = new Label();
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
            gBPLUSBOX = new TextBox();
            gBBOX = new TextBox();
            gCPLUSBOX = new TextBox();
            gCBOX = new TextBox();
            gDPLUSBOX = new TextBox();
            gDBOX = new TextBox();
            gFBOX = new TextBox();
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
            answer.Controls.Add(gFBOX);
            answer.Controls.Add(gDBOX);
            answer.Controls.Add(gDPLUSBOX);
            answer.Controls.Add(gCBOX);
            answer.Controls.Add(gCPLUSBOX);
            answer.Controls.Add(gBBOX);
            answer.Controls.Add(gBPLUSBOX);
            answer.Controls.Add(gpaBox);
            answer.Controls.Add(gpsText);
            answer.Controls.Add(gABOX);
            answer.Controls.Add(gradeF);
            answer.Controls.Add(gradeD);
            answer.Controls.Add(gradeDPlus);
            answer.Controls.Add(gradeC);
            answer.Controls.Add(gradeCPlus);
            answer.Controls.Add(gradeB);
            answer.Controls.Add(gradeBPlus);
            answer.Controls.Add(gradeA);
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
            answer.Size = new Size(832, 404);
            answer.TabIndex = 1;
            answer.TabStop = false;
            answer.Text = "ผลลัพท์";
            answer.Enter += answer_Enter;
            // 
            // gpaBox
            // 
            gpaBox.BackColor = SystemColors.ControlLightLight;
            gpaBox.Location = new Point(122, 357);
            gpaBox.Name = "gpaBox";
            gpaBox.ReadOnly = true;
            gpaBox.Size = new Size(135, 23);
            gpaBox.TabIndex = 34;
            gpaBox.TextChanged += gpaBox_TextChanged;
            // 
            // gpsText
            // 
            gpsText.AutoSize = true;
            gpsText.Location = new Point(35, 360);
            gpsText.Name = "gpsText";
            gpsText.Size = new Size(51, 15);
            gpsText.TabIndex = 33;
            gpsText.Text = "เกรดเฉลี่ย";
            // 
            // gABOX
            // 
            gABOX.Location = new Point(122, 41);
            gABOX.Name = "gABOX";
            gABOX.ReadOnly = true;
            gABOX.Size = new Size(135, 23);
            gABOX.TabIndex = 25;
            // 
            // gradeF
            // 
            gradeF.AutoSize = true;
            gradeF.Location = new Point(53, 314);
            gradeF.Name = "gradeF";
            gradeF.Size = new Size(13, 15);
            gradeF.TabIndex = 24;
            gradeF.Text = "F";
            // 
            // gradeD
            // 
            gradeD.AutoSize = true;
            gradeD.Location = new Point(54, 272);
            gradeD.Name = "gradeD";
            gradeD.Size = new Size(15, 15);
            gradeD.TabIndex = 23;
            gradeD.Text = "D";
            gradeD.Click += gradeD_Click;
            // 
            // gradeDPlus
            // 
            gradeDPlus.AutoSize = true;
            gradeDPlus.Location = new Point(53, 232);
            gradeDPlus.Name = "gradeDPlus";
            gradeDPlus.Size = new Size(23, 15);
            gradeDPlus.TabIndex = 22;
            gradeDPlus.Text = "D+";
            gradeDPlus.Click += gradeDPlus_Click;
            // 
            // gradeC
            // 
            gradeC.AutoSize = true;
            gradeC.Location = new Point(53, 196);
            gradeC.Name = "gradeC";
            gradeC.Size = new Size(15, 15);
            gradeC.TabIndex = 21;
            gradeC.Text = "C";
            // 
            // gradeCPlus
            // 
            gradeCPlus.AutoSize = true;
            gradeCPlus.Location = new Point(53, 160);
            gradeCPlus.Name = "gradeCPlus";
            gradeCPlus.Size = new Size(23, 15);
            gradeCPlus.TabIndex = 20;
            gradeCPlus.Text = "C+";
            // 
            // gradeB
            // 
            gradeB.AutoSize = true;
            gradeB.Location = new Point(55, 122);
            gradeB.Name = "gradeB";
            gradeB.Size = new Size(14, 15);
            gradeB.TabIndex = 19;
            gradeB.Text = "B";
            // 
            // gradeBPlus
            // 
            gradeBPlus.AutoSize = true;
            gradeBPlus.Location = new Point(55, 83);
            gradeBPlus.Name = "gradeBPlus";
            gradeBPlus.Size = new Size(22, 15);
            gradeBPlus.TabIndex = 18;
            gradeBPlus.Text = "B+";
            gradeBPlus.Click += gradeBPlus_Click;
            // 
            // gradeA
            // 
            gradeA.AutoSize = true;
            gradeA.Location = new Point(55, 44);
            gradeA.Name = "gradeA";
            gradeA.Size = new Size(15, 15);
            gradeA.TabIndex = 17;
            gradeA.Text = "A";
            gradeA.Click += label1_Click_4;
            // 
            // averageBox
            // 
            averageBox.BackColor = SystemColors.ControlLightLight;
            averageBox.Location = new Point(691, 119);
            averageBox.Name = "averageBox";
            averageBox.ReadOnly = true;
            averageBox.Size = new Size(135, 23);
            averageBox.TabIndex = 16;
            averageBox.TextChanged += averageBox_TextChanged;
            // 
            // average
            // 
            average.AutoSize = true;
            average.Location = new Point(565, 122);
            average.Name = "average";
            average.Size = new Size(60, 15);
            average.TabIndex = 15;
            average.Text = "คะแนนเฉลี่ย";
            average.Click += label1_Click_3;
            // 
            // stPointMinBox
            // 
            stPointMinBox.Location = new Point(691, 77);
            stPointMinBox.Name = "stPointMinBox";
            stPointMinBox.ReadOnly = true;
            stPointMinBox.Size = new Size(135, 23);
            stPointMinBox.TabIndex = 14;
            stPointMinBox.TextChanged += textBox1_TextChanged_1;
            // 
            // stNameMinBox
            // 
            stNameMinBox.Location = new Point(529, 77);
            stNameMinBox.Name = "stNameMinBox";
            stNameMinBox.ReadOnly = true;
            stNameMinBox.Size = new Size(135, 23);
            stNameMinBox.TabIndex = 13;
            stNameMinBox.TextChanged += stNameMinBox_TextChanged;
            // 
            // stIDMinBox
            // 
            stIDMinBox.Location = new Point(366, 77);
            stIDMinBox.Name = "stIDMinBox";
            stIDMinBox.ReadOnly = true;
            stIDMinBox.Size = new Size(135, 23);
            stIDMinBox.TabIndex = 12;
            stIDMinBox.TextChanged += stIDMinBox_TextChanged;
            // 
            // stPointMaxBox
            // 
            stPointMaxBox.Location = new Point(691, 41);
            stPointMaxBox.Name = "stPointMaxBox";
            stPointMaxBox.ReadOnly = true;
            stPointMaxBox.Size = new Size(135, 23);
            stPointMaxBox.TabIndex = 11;
            // 
            // stNameMaxBox
            // 
            stNameMaxBox.Location = new Point(529, 41);
            stNameMaxBox.Name = "stNameMaxBox";
            stNameMaxBox.ReadOnly = true;
            stNameMaxBox.Size = new Size(135, 23);
            stNameMaxBox.TabIndex = 10;
            stNameMaxBox.TextChanged += textBox1_TextChanged;
            // 
            // stIDMaxBox
            // 
            stIDMaxBox.Location = new Point(366, 41);
            stIDMaxBox.Name = "stIDMaxBox";
            stIDMaxBox.ReadOnly = true;
            stIDMaxBox.Size = new Size(135, 23);
            stIDMaxBox.TabIndex = 7;
            // 
            // pointMin
            // 
            pointMin.AutoSize = true;
            pointMin.Location = new Point(288, 80);
            pointMin.Name = "pointMin";
            pointMin.Size = new Size(63, 15);
            pointMin.TabIndex = 9;
            pointMin.Text = "คะแนนต่ำสุด";
            // 
            // pointMax
            // 
            pointMax.AutoSize = true;
            pointMax.Location = new Point(288, 44);
            pointMax.Name = "pointMax";
            pointMax.Size = new Size(62, 15);
            pointMax.TabIndex = 8;
            pointMax.Text = "คะแนนสูงสุด";
            // 
            // stPoint2
            // 
            stPoint2.AutoSize = true;
            stPoint2.Location = new Point(731, 11);
            stPoint2.Name = "stPoint2";
            stPoint2.Size = new Size(38, 15);
            stPoint2.TabIndex = 7;
            stPoint2.Text = "คะแนน";
            stPoint2.Click += stPoint2_Click;
            // 
            // stName2
            // 
            stName2.AutoSize = true;
            stName2.Location = new Point(555, 11);
            stName2.Name = "stName2";
            stName2.Size = new Size(63, 15);
            stName2.TabIndex = 7;
            stName2.Text = "ชื่อ-นามสกุล";
            // 
            // stID2
            // 
            stID2.AutoSize = true;
            stID2.Location = new Point(397, 11);
            stID2.Name = "stID2";
            stID2.Size = new Size(65, 15);
            stID2.TabIndex = 7;
            stID2.Text = "รหัสนักศึกษา";
            stID2.Click += label1_Click_2;
            // 
            // gBPLUSBOX
            // 
            gBPLUSBOX.Location = new Point(122, 77);
            gBPLUSBOX.Name = "gBPLUSBOX";
            gBPLUSBOX.ReadOnly = true;
            gBPLUSBOX.Size = new Size(135, 23);
            gBPLUSBOX.TabIndex = 35;
            // 
            // gBBOX
            // 
            gBBOX.Location = new Point(122, 115);
            gBBOX.Name = "gBBOX";
            gBBOX.ReadOnly = true;
            gBBOX.Size = new Size(135, 23);
            gBBOX.TabIndex = 36;
            // 
            // gCPLUSBOX
            // 
            gCPLUSBOX.Location = new Point(122, 156);
            gCPLUSBOX.Name = "gCPLUSBOX";
            gCPLUSBOX.ReadOnly = true;
            gCPLUSBOX.Size = new Size(135, 23);
            gCPLUSBOX.TabIndex = 37;
            // 
            // gCBOX
            // 
            gCBOX.Location = new Point(122, 193);
            gCBOX.Name = "gCBOX";
            gCBOX.ReadOnly = true;
            gCBOX.Size = new Size(135, 23);
            gCBOX.TabIndex = 38;
            // 
            // gDPLUSBOX
            // 
            gDPLUSBOX.Location = new Point(122, 229);
            gDPLUSBOX.Name = "gDPLUSBOX";
            gDPLUSBOX.ReadOnly = true;
            gDPLUSBOX.Size = new Size(135, 23);
            gDPLUSBOX.TabIndex = 39;
            // 
            // gDBOX
            // 
            gDBOX.Location = new Point(122, 269);
            gDBOX.Name = "gDBOX";
            gDBOX.ReadOnly = true;
            gDBOX.Size = new Size(135, 23);
            gDBOX.TabIndex = 40;
            // 
            // gFBOX
            // 
            gFBOX.Location = new Point(122, 311);
            gFBOX.Name = "gFBOX";
            gFBOX.ReadOnly = true;
            gFBOX.Size = new Size(135, 23);
            gFBOX.TabIndex = 41;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 803);
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
        private Label gradeA;
        private Label gradeDPlus;
        private Label gradeC;
        private Label gradeCPlus;
        private Label gradeB;
        private Label gradeBPlus;
        private Label gradeD;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox gABOX;
        private Label gradeF;
        private TextBox gpaBox;
        private Label gpsText;
        private TextBox gBPLUSBOX;
        private TextBox gBBOX;
        private TextBox gCPLUSBOX;
        private TextBox gFBOX;
        private TextBox gDBOX;
        private TextBox gDPLUSBOX;
        private TextBox gCBOX;
    }
}
