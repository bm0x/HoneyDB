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
    public partial class Egresados : Form
    {
        public Egresados()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Volver_Agr_Egr_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantenedor_Egresados Man = new Mantenedor_Egresados();
            Man.Show();
        }
    }
}
