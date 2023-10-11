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

        private void mantenedorEgresadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantenedor_Egresados Man_Egr = new Mantenedor_Egresados();
            Man_Egr.Show();
        }

        private void carreraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Carrera MC = new Mant_Carrera();
            MC.Show();
        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Especialidad M_Especialidad = new Mant_Especialidad();
            M_Especialidad.Show();
        }

        private void empresaDePracticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Empresa_Practica MEP = new Mant_Empresa_Practica();
            MEP.Show();
        }

        private void empresaTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Empresa M_Empresa = new Mant_Empresa();
            M_Empresa.Show();
        }

        private void cargoTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Cargo M_Cargo = new Mant_Cargo();
            M_Cargo.Show();
        }

        private void institucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Institucion M_Institucion = new Mant_Institucion();
            M_Institucion.Show();
        }

        private void estadoEgresadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Est_Egre M_Est_Egre = new Mant_Est_Egre();
            M_Est_Egre.Show();
        }
    }
}
