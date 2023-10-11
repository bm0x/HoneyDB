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
    public partial class Ing_Cargo : Form
    {
        public Ing_Cargo()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Txt_Cod_Cargo.Text = "";
            Txt_Descrip_Cargo.Text = "";
            Txt_Cod_Cargo.Focus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Cargo M_Cargo = new Mant_Cargo();
            M_Cargo.Show();
        }
    }
}
