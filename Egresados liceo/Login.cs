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
    public partial class Login : Form
    {
        int existe;
        public Login()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txt_user.Text = "";
            txt_pass.Text = "";
            txt_user.Focus();
        }

        private void Btn_Entrar_Login_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_user.Text == "")
                {
                    MessageBox.Show("Debe ingresar el usuario");
                    txt_user.Focus();
                    return;
                }

                if (txt_pass.Text == "")
                {
                    MessageBox.Show("Debe ingresar la Password");
                    txt_pass.Focus();
                    return;
                }

                //Aqui se valid que el rut ingresado exista en la tabla clientes
                String query = "select count(*) from Usuarios where username='" + txt_user.Text + "' and pass ='" + txt_pass.Text + "'";
                SqlConnection con = new SqlConnection(db_usuarios.ConexionUsers);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                existe = (int)cmd.ExecuteScalar();

                if (existe != 0)
                {
                    //aquí entramos al menu

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

        private void Btn_Salir_Login_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
