using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L_TEC_BIC_JFERSOLAR
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Especialidad M_Espe = new Mant_Especialidad();
            M_Espe.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox2, "Vuelve al Login");
        }

        private void instituciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Institucion M_insti = new Mant_Institucion();
            M_insti.Show();
        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Carrera M_car = new Mant_Carrera();
            M_car.Show();
        }

        private void institucionCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asig_Insti_Carrera Asig_inst_car = new Asig_Insti_Carrera();
            Asig_inst_car.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Empresa M_emp = new Mant_Empresa();
            M_emp.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Cargo M_car = new Mant_Cargo();
            M_car.Show();
        }

        private void empresaCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asig_Emp_Cargo A_Car_Emp = new Asig_Emp_Cargo();
            A_Car_Emp.Show();
        }

        private void empresaDePracticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Empresa_Practica M_ep = new Mant_Empresa_Practica();
            M_ep.Show();
        }

        private void estadoEgresadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Est_Egre M_es = new Mant_Est_Egre();
            M_es.Show();
        }

        private void registroDeEgresadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Egresados M_Egre = new Mant_Egresados();
            M_Egre.Show();
        }

        private void gestionDeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Cuentas mant_Cuentas = new Mant_Cuentas();
            mant_Cuentas.Show();
        }
    }
}
