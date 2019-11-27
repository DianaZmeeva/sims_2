using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sims_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal y0 = 0;
        decimal angle = 45;
        decimal v  = 10;
        decimal t = 0;
        decimal cosa, sina;
        decimal x, y;

        decimal dt = 0.01M;
        const decimal g = 9.81M;

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                timer1.Enabled = false;
            else
                timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += dt;
            label1.Text = "Time: " + t;
            var x = v * t * cosa;
            var y = y0 + v * t * sina - (g * t * t) / 2;
            chart1.Series[0].Points.AddXY(x, y);
            if(y>(decimal)chart1.ChartAreas[0].AxisY.Maximum)
            {
                chart1.ChartAreas[0].AxisY.Maximum =(double)((int)y+1);
            }

            if (x > (decimal)chart1.ChartAreas[0].AxisX.Maximum)
            {
                chart1.ChartAreas[0].AxisX.Maximum = (double)((int)x + 1);
            }

            if (y <= 0)
            {
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                y0 = input_height.Value;
                angle = input_angle.Value;
                v = input_speed.Value;
                t = 0;
                cosa = (decimal)Math.Cos((double)angle*Math.PI/180);
                sina = (decimal)Math.Sin((double)angle * Math.PI / 180);
                chart1.Series[0].Points.Clear();
                chart1.Series[0].Points.AddXY(0, y0);
                timer1.Start();
            }
        }
    }
}
