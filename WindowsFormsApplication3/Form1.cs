using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public int cx = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            if (radioButton1.Checked)
            {
                for (double i = 1; i <= cx; i++)
                {
                    chart1.Series[0].Points.AddXY(i, (Convert.ToInt32(numericUpDown1.Value) * Math.Sin(i * Convert.ToInt32(numericUpDown2.Value) * Math.PI / cx)));
                }
            }
            else if (radioButton2.Checked)
            {
                for (double i = 1; i <= cx; i++)
                {
                    chart1.Series[0].Points.AddXY(i, (Convert.ToInt32(numericUpDown1.Value) * Math.Cos(i * Convert.ToInt32(numericUpDown2.Value) * Math.PI / cx)));
                }
            }
            else if (radioButton3.Checked)
            {
                for (double i = 1; i <= cx; i++)
                {
                    chart1.Series[0].Points.AddXY(i, (Math.Tan(i * Convert.ToInt32(numericUpDown2.Value) * Math.PI / 5)));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            if (radioButton4.Checked)
            {
                for (double i = 0; i <= 9; i++)
                {
                    chart1.Series[0].Points.AddXY(i, (Math.Sqrt(i)));
                }
            }
            if (radioButton5.Checked)
            {
                for (double i = -9; i <= 9; i++)
                {
                    chart1.Series[0].Points.AddXY(i, (Convert.ToInt32(numericUpDown3.Value) * Math.Pow(i,2) + Convert.ToInt32(numericUpDown4.Value) * i + Convert.ToInt32(numericUpDown5.Value)));
                }
            }
            if (radioButton6.Checked)
            {
                for (double i = -9; i <= -1; i++)
                {
                    chart1.Series[0].Points.AddXY(i, Convert.ToInt32(numericUpDown8.Value) / i);
                }
                for (double i = 1; i <= 9; i++)
                {
                    chart1.Series[0].Points.AddXY(i, Convert.ToInt32(numericUpDown8.Value) / i);
                }
            }
            if (radioButton7.Checked)
            {
                for (double i = -9; i <= 9; i++)
                {
                    chart1.Series[0].Points.AddXY(i, Math.Pow(Convert.ToInt32(numericUpDown6.Value), i));
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
            panel4.Visible = false;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }
    }
}
