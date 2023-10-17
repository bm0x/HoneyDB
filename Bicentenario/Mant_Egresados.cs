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
    public partial class Mant_Egresados : Form
    {
        String consulta;
        public Mant_Egresados()
        {
            InitializeComponent();
        }

        private void Mant_Egresados_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox2, "Vuelve al Login");

            ToolTip Busc = new ToolTip();
            Busc.SetToolTip(this.Img_Buscar, "Busca Especialidad");

            ToolTip Agre = new ToolTip();
            Agre.SetToolTip(this.Img_Nuevo, "Agrega Especialidad");

            ToolTip Vol = new ToolTip();
            Vol.SetToolTip(this.Img_Volver, "Salir");

            Carga_Grilla();
        }

        private void Carga_Grilla()
        {
            try
            {

                SqlConnection con = new SqlConnection(Conexion.Conec);

                if (Txt_Egre.Text == "")
                {
                    consulta = "SELECT E.Rut_Egre,E.Nom_Egre,E.Dir_Egre,E.Tel_Egre,E.Email_Egre,E.Ano_Egre,EP.Cod_Espe,EP.Desc_Espe, "+
                               "E.Coment_Act_Actual_Egre,E.Estudia_Egre,E.Acogio_Conve_Arti_Egre,E.Trabaja_Egre,E.Cont_Trab_Practica_Egre,E.Obs_Egre, "+
                               "EPR.Cod_Empre_Prac, EPR.Desc_Empre_Prac,E.Benef_BPTP_Egre,EE.Cod_Est_Egre, EE.Desc_Est_Egre FROM Egresado E, Especialidad EP, Empresa_Practica EPR, Estado_Egresado EE " +
                               "where EP.Cod_Espe = E.Cod_Espe and EPR.Cod_Empre_Prac = E.Cod_Empre_Prac and EE.Cod_Est_Egre = E.Cod_Est_Egre order by E.Nom_Egre asc";
                }
                else
                {
                    consulta = "SELECT E.Rut_Egre,E.Nom_Egre,E.Dir_Egre,E.Tel_Egre,E.Email_Egre,E.Ano_Egre,EP.Cod_Espe,EP.Desc_Espe, " +
                               "E.Coment_Act_Actual_Egre,E.Estudia_Egre,E.Acogio_Conve_Arti_Egre,E.Trabaja_Egre,E.Cont_Trab_Practica_Egre,E.Obs_Egre, " +
                               "EPR.Cod_Empre_Prac, EPR.Desc_Empre_Prac,E.Benef_BPTP_Egre,EE.Cod_Est_Egre, EE.Desc_Est_Egre FROM Egresado E, Especialidad EP, Empresa_Practica EPR, Estado_Egresado EE " +
                               "where EP.Cod_Espe = E.Cod_Espe and EPR.Cod_Empre_Prac = E.Cod_Empre_Prac and EE.Cod_Est_Egre = E.Cod_Est_Egre and E.Nom_Egre like '%" + Txt_Egre.Text + "%' order by E.Nom_Egre asc";
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, con);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                DGV_Egresado.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void Img_Buscar_Click(object sender, EventArgs e)
        {
            Carga_Grilla();
        }

        private void Img_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu M = new Menu();
            M.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login L = new Login();
            L.Show();
        }

        private void Img_Nuevo_Click(object sender, EventArgs e)
        {
            Vari_Egresados.Estado = "Nuevo";
            Vari_Egresados.Rut_Egre = ""; 
            Vari_Egresados.Nom_Egre = "";
            Vari_Egresados.Dir_Egre = "";
            Vari_Egresados.Tel_Egre = "";
            Vari_Egresados.Email_Egre = "";
            Vari_Egresados.Ano_Egre = "";
            Vari_Egresados.Cod_Espe = "";
            Vari_Egresados.Coment_Act_Actual_Egre = "";
            Vari_Egresados.Estudia_Egre = "";
            Vari_Egresados.Acogio_Conve_Arti_Egre = "";
            Vari_Egresados.Trabaja_Egre = "";
            Vari_Egresados.Cont_Trab_Practica_Egre = "";
            Vari_Egresados.Obs_Egre = "";
            Vari_Egresados.Cod_Empre_Prac = "";
            Vari_Egresados.Benef_BPTP_Egre = "";
            Vari_Egresados.Cod_Est_Egre = "";


            this.Hide();
            Ing_Egresados Ie = new Ing_Egresados();
            Ie.Show();

        }

        private void DGV_Egresado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNo;
            RowNo = e.RowIndex;

            Vari_Egresados.Rut_Egre = DGV_Egresado.Rows[RowNo].Cells[0].Value.ToString();
            Vari_Egresados.Nom_Egre = DGV_Egresado.Rows[RowNo].Cells[1].Value.ToString();
            Vari_Egresados.Dir_Egre = DGV_Egresado.Rows[RowNo].Cells[2].Value.ToString();
            Vari_Egresados.Tel_Egre = DGV_Egresado.Rows[RowNo].Cells[3].Value.ToString();
            Vari_Egresados.Email_Egre = DGV_Egresado.Rows[RowNo].Cells[4].Value.ToString();
            Vari_Egresados.Ano_Egre = DGV_Egresado.Rows[RowNo].Cells[5].Value.ToString();
            Vari_Egresados.Cod_Espe = DGV_Egresado.Rows[RowNo].Cells[6].Value.ToString();
            Vari_Egresados.Coment_Act_Actual_Egre = DGV_Egresado.Rows[RowNo].Cells[8].Value.ToString();
            Vari_Egresados.Estudia_Egre = DGV_Egresado.Rows[RowNo].Cells[9].Value.ToString();
            Vari_Egresados.Acogio_Conve_Arti_Egre = DGV_Egresado.Rows[RowNo].Cells[10].Value.ToString();
            Vari_Egresados.Trabaja_Egre = DGV_Egresado.Rows[RowNo].Cells[11].Value.ToString();
            Vari_Egresados.Cont_Trab_Practica_Egre = DGV_Egresado.Rows[RowNo].Cells[12].Value.ToString();
            Vari_Egresados.Obs_Egre = DGV_Egresado.Rows[RowNo].Cells[13].Value.ToString();
            Vari_Egresados.Cod_Empre_Prac = DGV_Egresado.Rows[RowNo].Cells[14].Value.ToString();
            Vari_Egresados.Benef_BPTP_Egre = DGV_Egresado.Rows[RowNo].Cells[16].Value.ToString();
            Vari_Egresados.Cod_Est_Egre = DGV_Egresado.Rows[RowNo].Cells[17].Value.ToString();





            Vari_Egresados.Estado = "Editar";

            this.Hide();
            Ing_Egresados Ie = new Ing_Egresados();
            Ie.Show();

        }
    }
}
