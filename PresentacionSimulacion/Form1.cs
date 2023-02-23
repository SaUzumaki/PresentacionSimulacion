using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionSimulacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = " ";
            timer1.Interval = 3000;
            timer1.Enabled = false;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Visible = false;
            timer1.Enabled = false;

            Menu form2 = new Menu();
            form2.Show();
        }
    }
}
