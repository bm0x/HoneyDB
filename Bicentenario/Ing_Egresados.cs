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
using System.Text.RegularExpressions;

namespace L_TEC_BIC_JFERSOLAR
{
    public partial class Ing_Egresados : Form
    {
        Boolean respuesta;
        int existe;
        string WSCKEA, WSCKCA, WSCKTA, WSCKCTEP, WSCKBB;
        string consulta;

        public Ing_Egresados()
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
            Mant_Egresados Me = new Mant_Egresados();
            Me.Show();
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

            llena_combobox_CbEspe();
            llena_combobox_CBERP();
            llena_combobox_CBEsta();

            if (Vari_Egresados.Estado == "Editar")
            {

                Txt_Rut.Text = Vari_Egresados.Rut_Egre;
                Txt_Nom.Text = Vari_Egresados.Nom_Egre;

                Txt_Dir.Text = Vari_Egresados.Dir_Egre;
                Txt_Tel.Text = Vari_Egresados.Tel_Egre;
                Txt_Email.Text = Vari_Egresados.Email_Egre;
                Txt_AE.Text = Vari_Egresados.Ano_Egre;
                CbEspe.SelectedValue = Vari_Egresados.Cod_Espe;
                Txt_Com_Act_Egre.Text = Vari_Egresados.Coment_Act_Actual_Egre;

                if (Vari_Egresados.Estudia_Egre == "N")
                {  CKEA.Checked = false;}
                else
                { CKEA.Checked = true; }

                if (Vari_Egresados.Acogio_Conve_Arti_Egre == "N")
                { CKCA.Checked = false; }
                else
                { CKCA.Checked = true; }

                if (Vari_Egresados.Trabaja_Egre == "N")
                { CKTA.Checked = false; }
                else
                { CKTA.Checked = true; }

                if (Vari_Egresados.Cont_Trab_Practica_Egre == "N")
                { CKCTEP.Checked = false; }
                else
                { CKCTEP.Checked = true; }

                Txt_Obs_Egre.Text = Vari_Egresados.Obs_Egre;
                CBERP.SelectedValue = Vari_Egresados.Cod_Empre_Prac;

                if (Vari_Egresados.Benef_BPTP_Egre == "N")
                { CKBB.Checked = false; }
                else
                { CKBB.Checked = true; }

                CBEsta.SelectedValue = Vari_Egresados.Cod_Est_Egre;

                Txt_Rut.Enabled = false;
                Img_Eliminar.Enabled = true;
                Img_Limpiar.Enabled = false;
                Txt_Rut.Focus();
            }
            else
            {
                Txt_Rut.Enabled = true;
                Img_Eliminar.Enabled = false;
                Img_Limpiar.Enabled = true;
                Txt_Rut.Focus();
            }

        }

        private void Img_Grabar_Click(object sender, EventArgs e)
        {
            try
            {

                if (Txt_Rut.Text == "")
                {
                    MessageBox.Show("Debe ingresar el Rut del Egresado");
                    Txt_Rut.Focus();
                    return;
                }
                else
                {
                    //Aqui se valida el Rut Cliente
                    respuesta = validarRut(Txt_Rut.Text);
                    if (respuesta == false)
                    {
                        MessageBox.Show("Rut ingresado no es valido");
                        Txt_Rut.Focus();
                        return;
                    }

                }

                if (Txt_Nom.Text == "")
                {
                    MessageBox.Show("Debe ingresar el Nombre del Egresado");
                    Txt_Nom.Focus();
                    return;
                }


                if (Txt_Email.Text != "")
                {
                    //Aqui se valida la estructura del Email
                    respuesta = email_bien_escrito(Txt_Email.Text);
                    if (respuesta == false)
                    {
                        MessageBox.Show("Email ingresado no tiene una estructura valida");
                        Txt_Email.Focus();
                        return;
                    }
                }


                if (CKEA.Checked == false)
                { WSCKEA = "N"; }
                else
                { WSCKEA = "S"; }

                if (CKCA.Checked == false)
                { WSCKCA = "N"; }
                else
                { WSCKCA = "S"; }

                if (CKTA.Checked == false)
                { WSCKTA = "N"; }
                else
                { WSCKTA = "S"; }

                if (CKCTEP.Checked == false)
                { WSCKCTEP = "N"; }
                else
                { WSCKCTEP = "S"; }

                if (CKBB.Checked == false)
                { WSCKBB = "N"; }
                else
                { WSCKBB = "S"; }


                //Aquí comienza el código que permitirá guardar los datos en la tabla carrera

                String query = "select count(*) from Egresado where Rut_Egre='" + Txt_Rut.Text + "'";

                SqlConnection con = new SqlConnection(Conexion.Conec);

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                existe = (int)cmd.ExecuteScalar();

                if (existe == 0)
                {
                    //En esta parte se ingresa la nueva institucion usando la carrera Insert
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO Egresado (Rut_Egre, Nom_Egre, Dir_Egre, Tel_Egre, Email_Egre, Ano_Egre, Cod_Espe, Coment_Act_Actual_Egre " +
                                                     ", Estudia_Egre, Acogio_Conve_Arti_Egre, Trabaja_Egre, Cont_Trab_Practica_Egre, Obs_Egre, Cod_Empre_Prac " +
                                                     ", Benef_BPTP_Egre, Cod_Est_Egre) VALUES "+
                                                     "('" + Txt_Rut.Text + "', '" + Txt_Nom.Text +"', '"+ Txt_Dir.Text +"', '"+ Txt_Tel.Text +"', '"+ Txt_Email.Text  + "', '" + 
                                                     Txt_AE.Text  +"', '"+ CbEspe.SelectedValue  +"', '"+ Txt_Com_Act_Egre.Text  +"', '"+ WSCKEA  +"', '"+ WSCKCA  +"', '"+ 
                                                     WSCKTA  +"', '"+ WSCKCTEP  +"', '"+ Txt_Obs_Egre.Text  +"', '"+ CBERP.SelectedValue  +"', '"+ WSCKBB  +"', '"+ CBEsta.SelectedValue + "')", con);
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Egresado Ingresado Exitosamente");


                }
                else
                {
                    //En esta parte se editan los datos del cliente usando la carrera Update
                    SqlCommand cmd1 = new SqlCommand("UPDATE Egresado SET Nom_Egre = '"+ Txt_Nom.Text +"', "+
                                                     "Dir_Egre = '" + Txt_Dir.Text + "', " +
                                                     "Tel_Egre = '" + Txt_Tel.Text + "', " +
                                                     "Email_Egre = '" + Txt_Email.Text + "', " +
                                                     "Ano_Egre = '" + Txt_AE.Text + "', " +
                                                     "Cod_Espe = '" + CbEspe.SelectedValue + "', " +
                                                     "Coment_Act_Actual_Egre = '" + Txt_Com_Act_Egre.Text + "', " +
                                                     "Estudia_Egre = '" + WSCKEA + "', " +
                                                     "Acogio_Conve_Arti_Egre = '" + WSCKCA + "', " +
                                                     "Trabaja_Egre = '" + WSCKTA + "', " +
                                                     "Cont_Trab_Practica_Egre = '" + WSCKCTEP + "', " +
                                                     "Obs_Egre = '" + Txt_Obs_Egre.Text + "', " +
                                                     "Cod_Empre_Prac = '" + CBERP.SelectedValue + "', " +
                                                     "Benef_BPTP_Egre = '" + WSCKBB + "', " +
                                                     "Cod_Est_Egre = '" + CBEsta.SelectedValue + "' WHERE Rut_Egre = '" + Txt_Rut.Text + "'", con);
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Datos actualizados");
                }
                con.Close();

                if (Vari_Egresados.Estado == "Editar")
                {
                    this.Hide();
                    Mant_Egresados Me = new Mant_Egresados();
                    Me.Show();
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
            llena_combobox_CbEspe();
            llena_combobox_CBERP();
            llena_combobox_CBEsta();

            Txt_Rut.Text = "";
            Txt_Nom.Text = "";
            Txt_Dir.Text = "";
            Txt_Tel.Text = "";
            Txt_Email.Text = "";
            Txt_AE.Text = "";
            
            Txt_Com_Act_Egre.Text = "";

            CKEA.Checked = false; 
            CKCA.Checked = false; 
            CKTA.Checked = false; 
            CKCTEP.Checked = false; 
            Txt_Obs_Egre.Text = "";
            CKBB.Checked = false; 

            Txt_Rut.Focus();

        }

        private void Img_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txt_Rut.Text == "")
                {
                    MessageBox.Show("Para eliminar un Egresado debe ingresar a lo menos el Rut");
                    Txt_Rut.Focus();
                    return;
                }
                else
                {
                    //Ahora podemos eliminar el registro del Empresa
                    String query = "select count(*) from Egresado where Rut_Egre='" + Txt_Rut.Text + "'";
                    SqlConnection con = new SqlConnection(Conexion.Conec);
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    existe = (int)cmd.ExecuteScalar();

                    if (existe != 0)
                    {
                        //Aqui validamos si la institucion existe en la tabla Empresa_Cargo
                        String query1 = "select count(*) from Trabajo_Egresado where Rut_Egre='" + Txt_Rut.Text + "'";
                        SqlConnection con1 = new SqlConnection(Conexion.Conec);
                        SqlCommand cmd2 = new SqlCommand(query1, con1);
                        con1.Open();
                        existe = (int)cmd2.ExecuteScalar();
                        if (existe != 0)
                        {
                            MessageBox.Show("No puede Eliminar al Egresado Tiene Trabajos Asociados");
                        }
                        else
                        {
                            //Aqui validamos si la institucion existe en la tabla Empresa_Cargo
                            String query2 = "select count(*) from Estudia_Egresado where Rut_Egre='" + Txt_Rut.Text + "'";
                            SqlConnection con2 = new SqlConnection(Conexion.Conec);
                            SqlCommand cmd3 = new SqlCommand(query2, con2);
                            con1.Open();
                            existe = (int)cmd3.ExecuteScalar();
                            if (existe != 0)
                            {
                                MessageBox.Show("No puede Eliminar al Egresado Tiene Estudios Asociados");
                            }
                            else
                            {
                                //aquí eliminamos al cliente
                                SqlCommand cmd1 = new SqlCommand("Delete From Empresa  where Cod_Empresa ='" + Txt_Rut.Text + "'", con);
                                cmd1.ExecuteNonQuery();
                                MessageBox.Show("Egresado Eliminado Exitosamente");
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Egresado no existe para Eliminar");
                    }
                    con.Close();

                    if (Vari_Egresados.Estado == "Editar")
                    {
                        this.Hide();
                        Mant_Egresados Me = new Mant_Egresados();
                        Me.Show();
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




        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void CKEA_CheckedChanged(object sender, EventArgs e)
        {
            if (Vari_Egresados.Estado == "Nuevo")
            {
                if (CKEA.Checked == true)
                { MessageBox.Show("Aqui debe llamar al mantenedor que permite ingresar donde estudia"); }
            }
        }

        private void CKTA_CheckedChanged(object sender, EventArgs e)
        {
            if (Vari_Egresados.Estado == "Nuevo")
            {
                if (CKTA.Checked == true)
                { MessageBox.Show("Aqui debe llamar al mantenedor que permite ingresar donde trabaja"); }
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void CBEsta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool validarRut(string rut)
        {

            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));

                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        
        private void llena_combobox_CbEspe()
        {
            SqlConnection con = new SqlConnection(Conexion.Conec);


            consulta = "select Cod_Espe,Desc_Espe from Especialidad order by Desc_Espe asc";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            CbEspe.DisplayMember = "Desc_Espe";
            CbEspe.ValueMember = "Cod_Espe";
            CbEspe.DataSource = ds;

        }


        private void llena_combobox_CBERP()
        {
            SqlConnection con = new SqlConnection(Conexion.Conec);


            consulta = "select Cod_Empre_Prac,Desc_Empre_Prac from Empresa_Practica order by Desc_Empre_Prac asc";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            CBERP.DisplayMember = "Desc_Empre_Prac";
            CBERP.ValueMember = "Cod_Empre_Prac";
            CBERP.DataSource = ds;

        }


        private void llena_combobox_CBEsta()
        {
            SqlConnection con = new SqlConnection(Conexion.Conec);


            consulta = "select Cod_Est_Egre,Desc_Est_Egre from Estado_Egresado order by Desc_Est_Egre asc";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            CBEsta.DisplayMember = "Desc_Est_Egre";
            CBEsta.ValueMember = "Cod_Est_Egre";
            CBEsta.DataSource = ds;

        }




    }
}
