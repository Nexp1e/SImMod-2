using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SImMod_2
{
    public partial class Form1 : Form
    {
        const double k = 0.02;

        bool isActive = false;
        Random rnd = new Random();

        double price1 = 0;
        double price2 = 0;
        int daysPassed = 0;
        public Form1()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            daysPassed++;
            price1 *= 1 + k * (rnd.NextDouble() - 0.5);
            price2 *= 1 + k * (rnd.NextDouble() - 0.5);

            chart1.Series[0].Points.AddXY(daysPassed, Math.Round(price1, 3));
            chart1.Series[1].Points.AddXY(daysPassed, Math.Round(price2, 3));

            if (daysPassed > 0)
            {
                chart1.ChartAreas[0].AxisX.Maximum = daysPassed;
            }
            if (checkbox1.Checked && daysPassed >= 10)
            {
                chart1.ChartAreas[0].AxisX.Minimum = daysPassed - 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isActive)
            {
                isActive = false;
                timer1.Stop();
            }
            else
            {
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();

                price1 = (double)inputCur1.Value;
                price2 = (double)inputCur2.Value;
                daysPassed = 0;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Maximum = 1;

                chart1.Series[0].Points.AddXY(daysPassed, price1);
                chart1.Series[1].Points.AddXY(daysPassed, price2);
                
                timer1.Start();
                isActive = true;
            }
        }

        private void checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox1.Checked && daysPassed >= 10)
            {
                chart1.ChartAreas[0].AxisX.Minimum = daysPassed - 10;
            }
            if (!checkbox1.Checked)
            {
                chart1.ChartAreas[0].AxisX.Minimum = 0;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].IsValueShownAsLabel = checkboxDisplayValues.Checked;
            chart1.Series[1].IsValueShownAsLabel = checkboxDisplayValues.Checked;
        }
    }
}
