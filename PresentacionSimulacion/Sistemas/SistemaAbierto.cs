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
    public partial class SistemaAbierto : Form
    {
        public SistemaAbierto()
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
            SistemaContinuo sistemaContinuo = new SistemaContinuo();
            sistemaContinuo.Show();
        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            this.Hide();
            SistemaAbiertoEjem ejem = new SistemaAbiertoEjem();
            ejem.Show();
        }
    }
}
