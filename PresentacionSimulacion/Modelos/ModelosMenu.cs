using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionSimulacion.Modelos
{
    public partial class ModelosMenu : Form
    {
        public ModelosMenu()
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

        private void btnModeloMat_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModeloMatematico modeloMatematico = new ModeloMatematico();
            modeloMatematico.Show();
        }

        private void btnModeloFis_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModeloFisico mode = new ModeloFisico();
            mode.Show();
        }

        private void btnModeloMent_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModeloMental modeloMental = new ModeloMental();
            modeloMental.Show();
        }

        private void btnModeloDin_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModeloDinamico modeloDinamico = new ModeloDinamico();   
            modeloDinamico.Show();
        }

        private void btnModeloEstat_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModeloEstatico modeloEstatico = new ModeloEstatico();
            modeloEstatico.Show();
        }

       

        private void btnModeloAn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModeloAnalitico modeloAnalitico = new ModeloAnalitico();
            modeloAnalitico.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModeloMatematico modeloMatematico = new ModeloMatematico();
            modeloMatematico.Show();
        }

        private void btnModeloNum_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModeloNumerico modeloNumerico = new ModeloNumerico();
            modeloNumerico.Show();
        }
    }
}
