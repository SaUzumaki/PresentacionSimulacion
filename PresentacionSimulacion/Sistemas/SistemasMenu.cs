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
    public partial class SistemasMenu : Form
    {
        public SistemasMenu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void btnSistemaAbierto_Click(object sender, EventArgs e)
        {
            this.Hide();
            SistemaAbierto sistemaAbierto = new SistemaAbierto();
            sistemaAbierto.Show();
        }        
        private void btnSisDisc_Click(object sender, EventArgs e)
        {
            this.Hide();
            SistemaDiscreto sistemaDiscreto = new SistemaDiscreto();
            sistemaDiscreto.Show();
        }

        private void btnSisCont_Click(object sender, EventArgs e)
        {
            this.Hide();
            SistemaContinuo sistemaContinuo = new SistemaContinuo();
            sistemaContinuo.Show();
        }

        private void btnSisCerr_Click(object sender, EventArgs e)
        {
            this.Hide();
            SistemaCerrado sistemaCerrado = new SistemaCerrado();
            sistemaCerrado.Show();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Hide();
            SistemaDiscreto sistemaDiscreto = new SistemaDiscreto();
            sistemaDiscreto.Show();
        }
    }
}
