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
    public partial class Carreras : Form
    {
        public Carreras()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu M = new Menu();
            M.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Txt_Cod_Carrera.Text = "";
            Txt_Descrip_Carrera.Text = "";
            Txt_Cod_Carrera.Focus();
        }

    }
}
