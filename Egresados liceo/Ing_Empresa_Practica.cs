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
    public partial class Ing_Empresa_Practica : Form
    {
        public Ing_Empresa_Practica()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Empresa_Practica MEP = new Mant_Empresa_Practica();
            MEP.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Txt_Cod_Emp_Prac.Text = "";
            Txt_Descrip_Empr_Prac.Text = "";
            Txt_Cod_Emp_Prac.Focus();
        }
    }
}
