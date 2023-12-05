using System;
using System.Linq;
using System.Numerics;
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
        string[] stIDStack = new string[1000];
        string[] stNameStack = new string[1000];
        double[] stPointStack = new double[1000];
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
            try
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
                double averageBoxTrue = sumOfPoint / (arrayIndex+1);
                averageBox.Text = averageBoxTrue.ToString();
                //double[] result = stPointStack.Concat(stPointStack).ToArray();
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
                if (arrayIndex > 0 && stPointStack[arrayIndex] <= stPointStack[arrayIndex-1])
                {
                    stIDMinBox.Text = stIDStack[arrayIndex];
                    stNameMinBox.Text = stNameStack[arrayIndex];
                    stPointMinBox.Text = stPointBoxImport;
                }
                arrayIndex++;
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
}
