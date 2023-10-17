using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace L_TEC_BIC_JFERSOLAR
{
    public partial class Login : Form
    {
        int existe;

        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        

        private void Limpiar()
        {
            Txt_User.Text = "";
            Txt_Pass.Text = "";
            Txt_User.Focus();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Txt_User.Text == "")
                {
                    MessageBox.Show("Debe ingresar el usuario");
                    Txt_User.Focus();
                    return;
                }

                if (Txt_Pass.Text == "")
                {
                    MessageBox.Show("Debe ingresar la Password");
                    Txt_Pass.Focus();
                    return;
                }

                String query = "select count(*) from Usuarios where User_U='" + Txt_User.Text + "' and Pass_User ='" + Txt_Pass.Text + "'";
                SqlConnection con = new SqlConnection(Conexion.Conec);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                existe = (int)cmd.ExecuteScalar();

                if (existe != 0)
                {

                    this.Hide();
                    Menu M = new Menu();
                    M.Show();

                }
                else
                {
                    MessageBox.Show("Credenciales ingresadas no son válidas");
                    Limpiar();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void Btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txt_User_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
