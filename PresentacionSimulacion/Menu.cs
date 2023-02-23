using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentacionSimulacion.Opciones;
using System.Windows.Forms;

namespace PresentacionSimulacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frontera frontera = new Frontera();
            frontera.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sistema sistema = new Sistema();
            sistema.Show();
        }
    }
}
