using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using PresentacionSimulacion.Ejemplos;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionSimulacion.Modelos
{
    public partial class ModeloDinamico : Form
    {
        public ModeloDinamico()
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
            ModeloNumerico model = new ModeloNumerico();
            model.Show();
        }

        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModelDinEjem ejemp = new ModelDinEjem();
            ejemp.Show();
        }
    }
}
