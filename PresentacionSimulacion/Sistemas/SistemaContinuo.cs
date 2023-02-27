using PresentacionSimulacion.Ejemplos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionSimulacion.Sistemas
{
    public partial class SistemaContinuo : Form
    {
        public SistemaContinuo()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Hide();
            SistemaCerrado sistemaCerrado = new SistemaCerrado();
            sistemaCerrado.Show();
        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            this.Hide();
            SistemaContinuoEjemp ejem = new SistemaContinuoEjemp();
            ejem.Show();
        }
    }
}
