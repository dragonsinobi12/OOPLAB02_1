using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Numerics;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab2_1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int arrayIndex = 0;
        string[] stIDStack = new string[10000];
        string[] stNameStack = new string[10000];
        double[] stPointStack = new double[10000];
        int sumA = 0;
        int sumBPlus = 0;
        int sumB = 0;
        int sumCPlus = 0;
        int sumC = 0;
        int sumDPlus = 0;
        int sumD = 0;
        int sumF = 0;
        double gpa = 0;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void stPoint2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void stIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void averageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void stIDMinBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stNameMinBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (stIDBox.Text == "" || stNameBox.Text == "" || stPointBox.Text == "" )
            {
                string message = "กรุณาพิมพ์ให้ครบทุกช่อง";
                string title = "เกิดข้อผิดพลาด";
                MessageBox.Show(message, title);
            }
            else
            {
                try 
                { 
                
                    int stPointCheck = int.Parse(stPointBox.Text);

                    if (stPointCheck < 0 || stPointCheck > 100)
                    {
                        string message = "กรุณาพิมพ์ตัวเลขคะเเนนให้อยู่ในช่วงตั้งเเต่ 0-100!";
                        string title = "เกิดข้อผิดพลาด";
                        MessageBox.Show(message, title);
                    }
                    else
                    {
                        string stIDBoxImport = stIDBox.Text;
                        string stNameBoxImport = stNameBox.Text;
                        string stPointBoxImport = stPointBox.Text;
                        stIDStack[arrayIndex] = stIDBoxImport;
                        stNameStack[arrayIndex] = stNameBoxImport;
                        stPointStack[arrayIndex] = double.Parse(stPointBoxImport);
                        stIDBox.Text = string.Empty;
                        stNameBox.Text = string.Empty;
                        stPointBox.Text = string.Empty;
                        double stPointStackMax = stPointStack.Max();
                        double stPointStackMin = stPointStack.Min();
                        double sumOfPoint = stPointStack.Sum();
                        double averageBoxTrue = sumOfPoint / (arrayIndex + 1);
                        averageBox.Text = averageBoxTrue.ToString();
                        double min = stPointStack[0];
                        for (int i = 0; i < arrayIndex; i++)
                        {
                            if (stPointStack[i] < min)
                            {
                                min = stPointStack[i];
                            }
                        }
                        if (arrayIndex == 0)
                        {
                            stIDMinBox.Text = stIDStack[arrayIndex];
                            stNameMinBox.Text = stNameStack[arrayIndex];
                            stPointMinBox.Text = stPointStackMax.ToString();
                        }
                        if (stPointStack[arrayIndex] == stPointStackMax)
                        {
                            stIDMaxBox.Text = stIDStack[arrayIndex];
                            stNameMaxBox.Text = stNameStack[arrayIndex];
                            stPointMaxBox.Text = stPointStackMax.ToString();
                        }
                        if (arrayIndex > 0 && stPointStack[arrayIndex] < min)
                        {
                            stIDMinBox.Text = stIDStack[arrayIndex];
                            stNameMinBox.Text = stNameStack[arrayIndex];
                            stPointMinBox.Text = stPointBoxImport;
                        }
                        if (stPointStack[arrayIndex] >= 80 && stPointStack[arrayIndex] <= 100)
                        {
                            sumA++;
                        }
                        if (stPointStack[arrayIndex] >= 75 && stPointStack[arrayIndex] <= 79)
                        {
                            sumBPlus++;
                        }
                        if (stPointStack[arrayIndex] >= 70 && stPointStack[arrayIndex] <= 74)
                        {
                            sumB++;
                        }
                        if (stPointStack[arrayIndex] >= 65 && stPointStack[arrayIndex] <= 69)
                        {
                            sumCPlus++;
                        }
                        if (stPointStack[arrayIndex] >= 60 && stPointStack[arrayIndex] <= 64)
                        {
                            sumC++;
                        }
                        if (stPointStack[arrayIndex] >= 55 && stPointStack[arrayIndex] <= 59)
                        {
                            sumDPlus++;
                        }
                        if (stPointStack[arrayIndex] >= 50 && stPointStack[arrayIndex] <= 54)
                        {
                            sumD++;
                        }
                        if (stPointStack[arrayIndex] >= 0 && stPointStack[arrayIndex] <= 49)
                        {
                            sumF++;
                        }
                        gpa = ((sumA * 4.0) + (sumBPlus * 3.5) + (sumB * 3.0) + (sumCPlus * 2.5) + (sumC * 2.0) + (sumDPlus * 1.5) + (sumD * 1.0)) / (arrayIndex + 1);
                        gABOX.Text = sumA.ToString();
                        gBPLUSBOX.Text = sumBPlus.ToString();
                        gBBOX.Text = sumB.ToString();
                        gCPLUSBOX.Text = sumCPlus.ToString();
                        gCBOX.Text = sumC.ToString();
                        gDPLUSBOX.Text = sumDPlus.ToString();
                        gDBOX.Text = sumD.ToString();
                        gFBOX.Text = sumF.ToString();
                        gpaBox.Text = gpa.ToString();
                        arrayIndex++;

                    }
                }
                catch (FormatException)
                {
                    string message = "กรุณาพิมพ์ตัวเลขในช่องคะแนน เเละ ห้ามใช้ตัวอักษร!";
                    string title = "เกิดข้อผิดพลาด";
                    MessageBox.Show(message, title);
                }
                catch (IndexOutOfRangeException)
                {
                    string message = "ข้อความของคุณยาวเกินไป!";
                    string title = "เกิดข้อผิดพลาด";
                    MessageBox.Show(message, title);
                }

            }


        }

        private void label1_Click_4(object sender, EventArgs e)
        {

        }

        private void gradeDPlus_Click(object sender, EventArgs e)
        {

        }

        private void gradeD_Click(object sender, EventArgs e)
        {

        }

        private void gradeBPlus_Click(object sender, EventArgs e)
        {

        }

        private void answer_Enter(object sender, EventArgs e)
        {

        }

        private void gpaBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
