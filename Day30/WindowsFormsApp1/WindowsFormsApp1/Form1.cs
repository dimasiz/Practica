using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int centerX, centerY;
        private int seconds;

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds = DateTime.Now.Second;

           
            Invalidate();
        }

        public Form1()
        {
            InitializeComponent();
            centerX = ClientSize.Width / 2;
            centerY = ClientSize.Height / 2;
            seconds = DateTime.Now.Second;

     
            timer = new Timer();
            timer.Interval = 1000; 
            timer.Tick += timer1_Tick; 

            timer.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.FillEllipse(Brushes.White, 10, 10, ClientSize.Width - 20, ClientSize.Height - 20);
            e.Graphics.DrawEllipse(Pens.Black, 10, 10, ClientSize.Width - 20, ClientSize.Height - 20);

            double angle = 2 * Math.PI * seconds / 60;
            int handLength = Math.Min(ClientSize.Width, ClientSize.Height) / 2 - 20;
            int handX = (int)(centerX + handLength * Math.Sin(angle));
            int handY = (int)(centerY - handLength * Math.Cos(angle));
            e.Graphics.DrawLine(Pens.Red, centerX, centerY, handX, handY);
        }
    }
}
