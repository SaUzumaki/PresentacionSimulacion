using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentacionSimulacion.Modelos;
using System.Windows.Forms;
using PresentacionSimulacion.Ejemplos;

namespace PresentacionSimulacion.Modelos
{
    public partial class ModeloMatematico : Form
    {
        public ModeloMatematico()
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
            ModeloMental modelo = new ModeloMental();
            modelo.Show();
        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModelMatEjem ejemp = new ModelMatEjem();
            ejemp.Show();
        }
    }
}
