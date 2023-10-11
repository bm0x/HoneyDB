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
    public partial class Ing_Est_Egre : Form
    {
        public Ing_Est_Egre()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Est_Egre M_Est_Egre = new Mant_Est_Egre();
            M_Est_Egre.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Txt_Cod_Est_Egre.Text = "";
            Txt_Descrip_Est_Egre.Text = "";
            Txt_Cod_Est_Egre.Focus();
        }
    }
}
