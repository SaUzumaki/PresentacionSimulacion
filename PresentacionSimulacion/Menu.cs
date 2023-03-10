using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentacionSimulacion.Modelos;
using PresentacionSimulacion.Sistemas;

namespace PresentacionSimulacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            this.Hide();
            SistemasMenu sistemasMenu = new SistemasMenu();
            sistemasMenu.Show();
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModelosMenu modelosMenu = new ModelosMenu();
            modelosMenu.Show();
        }
    }
}
