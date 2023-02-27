using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using PresentacionSimulacion.Modelos;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentacionSimulacion.Ejemplos;

namespace PresentacionSimulacion.Modelos
{
    public partial class ModeloFisico : Form
    {
        public ModeloFisico()
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
            ModeloDinamico model = new ModeloDinamico();
            model.Show();
        }

        private void btnEjemplo_ClientSizeChanged(object sender, EventArgs e)
        {
            this.Hide();
            ModelFisEjem ejemp = new ModelFisEjem();
            ejemp.Show();
        }
    }
}
