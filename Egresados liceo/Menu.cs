using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Egresados_liceo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda Ayu_da = new Ayuda();
            Ayu_da.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void changelogProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            log change = new log();
            change.Show();
        }

        private void cUENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
