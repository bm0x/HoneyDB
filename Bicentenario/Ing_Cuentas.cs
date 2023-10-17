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

namespace L_TEC_BIC_JFERSOLAR
{
    public partial class Ing_Cuentas : Form
    {
        Boolean respuesta;
        int existe;
        public Ing_Cuentas()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }

        private void Img_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mant_Cuentas mant_Cuentas = new Mant_Cuentas();
            mant_Cuentas.Show();
        }

        private void Ing_Cuentas_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.Img_Inicio, "Vuelve al Login");


            ToolTip Gr = new ToolTip();
            Gr.SetToolTip(this.Img_Grabar, "Grabar");

            ToolTip El = new ToolTip();
            El.SetToolTip(this.Img_Eliminar, "Eliminar");

            ToolTip Lim = new ToolTip();
            Lim.SetToolTip(this.Img_Limpiar, "Limpiar");

            ToolTip Vol = new ToolTip();
            Vol.SetToolTip(this.Img_Volver, "Salir");



            if (Variables_Globales.Estado == "Editar")
            {
                Txt_Usuario.Text = Variables_Globales.Codigo;
                Txt_Contrasena.Text = Variables_Globales.Descip;

                Txt_Usuario.Enabled = false;
                Img_Eliminar.Enabled = true;
                Img_Limpiar.Enabled = false;
                Txt_Usuario.Focus();
            }
            else
            {
                Txt_Usuario.Enabled = true;
                Img_Eliminar.Enabled = false;
                Img_Limpiar.Enabled = true;
                Txt_Usuario.Focus();
            }
        }

        private void Img_Grabar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Txt_Usuario.Text == "")
                {
                    MessageBox.Show("Debe ingresar el Usuario");
                    Txt_Usuario.Focus();
                    return;
                }


                if (Txt_Contrasena.Text == "")
                {
                    MessageBox.Show("Debe ingresar la Contraseña");
                    Txt_Contrasena.Focus();
                    return;
                }



                //Aquí comienza el código que permitirá guardar los datos en la tabla _Usuarios

                String query = "select count(*) from Usuarios where User_U='" + Txt_Usuario.Text + "'";

                SqlConnection con = new SqlConnection(Conexion.Conec);

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                
                existe = (int)cmd.ExecuteScalar();

                if (existe == 0)
                {
                    //En esta parte se ingresa el nuevo usuario Insert
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO Usuarios (User_U, Pass_User) " +
                        "VALUES('" + Txt_Usuario.Text + "','" + Txt_Contrasena.Text + "')", con);
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Usuario Ingresado Exitosamente");


                }
                else
                {
                    //En esta parte se editan los datos del Usuario Update
                    SqlCommand cmd1 = new SqlCommand("Update Usuario set User_U ='" + Txt_Usuario.Text + "' " +
                        "where User_U ='" + Txt_Usuario.Text + "'", con);
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Usuario actualizado");
                }
                con.Close();

                if (Variables_Globales.Estado == "Editar")
                {
                    this.Hide();
                    Mant_Cuentas M_cuent = new Mant_Cuentas();
                    M_cuent.Show();
                }
                else
                {
                    Limpiar();
                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void Img_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_Usuario.Text = "";
            Txt_Contrasena.Text = "";

            Txt_Usuario.Focus();
        }
        private void Limpiar()
        {
            Txt_Usuario.Text = "";
            Txt_Contrasena.Text = "";

            Txt_Usuario.Focus();

        }
        private void Img_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Usuario.Text == "")
                {
                    MessageBox.Show("Para eliminar un Usuario debe ingresar a lo menos el nombre de Usuario");
                    Txt_Usuario.Focus();
                    return;
                }
                else
                {
                    //Ahora podemos eliminar el Usuario
                    //Aqui se valida que el Usuario ingresado exista en la tabla clientes
                    String query = "select count(*) from Usuarios where User_U='" + Txt_Usuario.Text + "'";
                    SqlConnection con = new SqlConnection(Conexion.Conec);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    existe = (int)cmd.ExecuteScalar();

                    if (existe != 0)
                    {
                        //Aqui validamos si el Usuario existe en la tabla Usuarios
                        String query1 = "select count(*) from Usuarios where User_U='" + Txt_Usuario.Text + "'";
                        SqlConnection con1 = new SqlConnection(Conexion.Conec);
                        SqlCommand cmd2 = new SqlCommand(query1, con1);
                        con1.Open();
                        existe = (int)cmd2.ExecuteScalar();
                        if (existe == 0)
                        {
                            //aquí eliminamos al cliente
                            SqlCommand cmd1 = new SqlCommand("Delete From Usuarios where User_U ='" + Txt_Usuario.Text + "'", con);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Usuario Eliminado Exitosamente");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Eliminar el Usuario");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Usuario no existe para Eliminar");
                    }
                    con.Close();

                    if (Variables_Globales.Estado == "Editar")
                    {
                        this.Hide();
                        Mant_Cuentas M_cuents = new Mant_Cuentas();
                        M_cuents.Show();
                    }
                    else
                    {
                        Limpiar();
                    }
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
