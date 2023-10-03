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
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        private void log1_Click(object sender, EventArgs e)
        {

        }

        private void txt_salir_log_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu Men = new Menu();
            Men.Show();
        }
    }
}
