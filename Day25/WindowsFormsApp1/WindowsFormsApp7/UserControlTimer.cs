using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class UserControlTimer : UserControl
    {
        public UserControlTimer()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            g.FillEllipse(Brushes.Blue, 0, 0, this.Width,
            this.Height);
            pe.Graphics.DrawString(DateTime.Now.ToLongTimeString(),
this.Font, new SolidBrush(this.ForeColor), 0, 0);
        }

        private void UserControlTimer_Load(object sender, EventArgs e)
        {

        }
    }
}
