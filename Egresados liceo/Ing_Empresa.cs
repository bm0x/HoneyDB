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
    public partial class Ing_Empresa : Form
    {
        public Ing_Empresa()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Empresa M_Empresa = new Mant_Empresa();
            M_Empresa.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Txt_Cod_Empresa.Text = "";
            Txt_Descrip_Empresa.Text = "";
            Txt_Cod_Empresa.Focus();
        }
    }
}
