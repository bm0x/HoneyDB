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
    public partial class Ing_Institucion : Form
    {
        public Ing_Institucion()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Institucion M_Institucion = new Mant_Institucion();
            M_Institucion.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Txt_Cod_Institu.Text = "";
            Txt_Descrip_Institu.Text = "";
            Txt_Cod_Institu.Focus();
        }
    }
}
