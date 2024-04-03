using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            spWin.Text = "Windows is horizontal";
            spData.Text = Convert.ToString(DateTime.Today.ToLongDateString());
        }

        private void spData_Click(object sender, EventArgs e)
        {

        }
    }
}
