using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egresados_liceo
{
    public partial class Mant_Empresa_Practica : Form
    {
        public Mant_Empresa_Practica()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu M = new Menu();
            M.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ing_Empresa_Practica EPractica = new Ing_Empresa_Practica();
            EPractica.Show();
        }
    }
}
