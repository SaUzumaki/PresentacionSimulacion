using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentacionSimulacion.Modelos;
using PresentacionSimulacion.Ejemplos;
using System.Windows.Forms;

namespace PresentacionSimulacion.Modelos
{
    public partial class ModeloAnalitico : Form
    {
        public ModeloAnalitico()
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
            ModeloFisico model = new ModeloFisico();
            model.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModelAnaliticoEjem modelAnaliticoEjem = new ModelAnaliticoEjem();
            modelAnaliticoEjem.Show();

        }
    }
}
