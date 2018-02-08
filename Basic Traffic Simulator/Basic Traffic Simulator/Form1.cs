using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Traffic_Simulator
{
    public partial class main : Form
    {
        static int TimeElapsed=0;
        public static int timestamp = 5;
        public main()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath Path = new System.Drawing.Drawing2D.GraphicsPath();
            Path.AddEllipse(0, 0, redlight.Width, redlight.Height);
            redlight.Region = new Region(Path);
            yellowlight.Region = new Region(Path);
            greenlight.Region = new Region(Path);
            lbl_remTime.Text=timestamp.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            redlight.BackColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeElapsed++;
            if (TimeElapsed == timestamp)
            {
                if (redlight.BackColor == Color.Red)
                {
                    redlight.BackColor = Color.FromName(this.BackColor.ToString());
                    yellowlight.BackColor = Color.Yellow;
                    TimeElapsed = 0;
                }
                else if (yellowlight.BackColor == Color.Yellow)
                {
                    yellowlight.BackColor = Color.FromName(this.BackColor.ToString());
                    greenlight.BackColor = Color.Green;
                    TimeElapsed = 0;
                }
                else if (greenlight.BackColor == Color.Green)
                {
                    greenlight.BackColor = Color.FromName(this.BackColor.ToString());
                    redlight.BackColor = Color.Red;
                    TimeElapsed = 0;
                }
            }
            lbl_remTime.Text = (timestamp-TimeElapsed).ToString();
        }
    }
}
