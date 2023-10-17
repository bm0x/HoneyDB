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
    public partial class Ing_Empresa : Form
    {
        Boolean respuesta;
        int existe;
        public Ing_Empresa()
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
            Mant_Empresa M_emp = new Mant_Empresa();
            M_emp.Show();
        }

        private void Ing_Carrera_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox2, "Vuelve al Login");


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
                Txt_codigo.Text = Variables_Globales.Codigo;
                Txt_Desc.Text = Variables_Globales.Descip;
                
                Txt_codigo.Enabled = false;
                Img_Eliminar.Enabled = true;
                Img_Limpiar.Enabled = false;
                Txt_codigo.Focus();
            }
            else
            {
                Txt_codigo.Enabled = true;
                Img_Eliminar.Enabled = false;
                Img_Limpiar.Enabled = true;
                Txt_codigo.Focus();
            }

        }

        private void Img_Grabar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Txt_codigo.Text == "")
                {
                    MessageBox.Show("Debe ingresar el código de la Empresa");
                    Txt_codigo.Focus();
                    return;
                }
                

                if (Txt_Desc.Text == "")
                {
                    MessageBox.Show("Debe ingresar la descripción de la Empresa");
                    Txt_Desc.Focus();
                    return;
                }

               

                //Aquí comienza el código que permitirá guardar los datos en la tabla carrera

                String query = "select count(*) from Empresa where Cod_Empresa='" + Txt_codigo.Text + "'";

                SqlConnection con = new SqlConnection(Conexion.Conec);

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                existe = (int)cmd.ExecuteScalar();

                if (existe == 0)
                {
                    //En esta parte se ingresa la nueva institucion usando la carrera Insert
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO Empresa (Cod_Empresa, Desc_Empresa) " +
                        "VALUES('" + Txt_codigo.Text + "','" + Txt_Desc.Text + "')", con);
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Empresa Ingresada Exitosamente");


                }
                else
                {
                    //En esta parte se editan los datos del cliente usando la carrera Update
                    SqlCommand cmd1 = new SqlCommand("Update Empresa set Desc_Empresa ='" + Txt_Desc.Text + "' " +
                        "where Cod_Empresa ='" + Txt_codigo.Text + "'", con);
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Datos actualizados");
                }
                con.Close();

                if (Variables_Globales.Estado == "Editar")
                {
                    this.Hide();
                    Mant_Empresa M_emp = new Mant_Empresa();
                    M_emp.Show();
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

        private void Limpiar()
        {
            Txt_codigo.Text = "";
            Txt_Desc.Text = "";
            
            Txt_codigo.Focus();

        }

        private void Img_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_codigo.Text == "")
                {
                    MessageBox.Show("Para eliminar una Empresa debe ingresar a lo menos el código");
                    Txt_codigo.Focus();
                    return;
                }
                else
                {
                    //Ahora podemos eliminar el registro del Empresa
                    String query = "select count(*) from Empresa where Cod_Empresa='" + Txt_codigo.Text + "'";
                    SqlConnection con = new SqlConnection(Conexion.Conec);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    existe = (int)cmd.ExecuteScalar();

                    if (existe != 0)
                    {
                        //Aqui validamos si la institucion existe en la tabla Empresa_Cargo
                        String query1 = "select count(*) from Empresa_Cargo where Cod_Empresa='" + Txt_codigo.Text + "'";
                        SqlConnection con1 = new SqlConnection(Conexion.Conec);
                        SqlCommand cmd2 = new SqlCommand(query1, con1);
                        con1.Open();
                        existe = (int)cmd2.ExecuteScalar();
                        if (existe == 0)
                        {
                            //aquí eliminamos al cliente
                            SqlCommand cmd1 = new SqlCommand("Delete From Empresa  where Cod_Empresa ='" + Txt_codigo.Text + "'", con);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Empresa Eliminada Exitosamente");
                        }
                        else
                        {
                            MessageBox.Show("No puede Eliminar la Empresa esta asociado cargos");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Empresa no existe para Eliminar");
                    }
                    con.Close();

                    if (Variables_Globales.Estado == "Editar")
                    {
                        this.Hide();
                        Mant_Empresa M_emp = new Mant_Empresa();
                        M_emp.Show();
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
