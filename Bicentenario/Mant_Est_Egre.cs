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
    public partial class Mant_Est_Egre : Form
    {
        String consulta;
        public Mant_Est_Egre()
        {
            InitializeComponent();
        }

        private void Mant_Est_Egre_Load(object sender, EventArgs e)
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

                if (Txt_Estado.Text == "")
                {
                    consulta = "select Cod_Est_Egre, Desc_Est_Egre from Estado_Egresado order by Desc_Est_Egre asc";
                }
                else
                {
                    consulta = "select Cod_Est_Egre, Desc_Est_Egre from Estado_Egresado where Desc_Est_Egre like '%" + Txt_Estado.Text + "%' order by Desc_Est_Egre asc";
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, con);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                DGV_Estado.DataSource = ds.Tables[0].DefaultView;
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
            Variables_Globales.Estado = "Nuevo";
            Variables_Globales.Codigo = "";
            Variables_Globales.Descip = "";


            this.Hide();
            Ing_Est_Egre Ing_est= new Ing_Est_Egre();
            Ing_est.Show();
        }

        private void DGV_Estado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNo;
            RowNo = e.RowIndex;

            Variables_Globales.Codigo = DGV_Estado.Rows[RowNo].Cells[0].Value.ToString();
            Variables_Globales.Descip = DGV_Estado.Rows[RowNo].Cells[1].Value.ToString();
            Variables_Globales.Estado = "Editar";

            this.Hide();
            Ing_Est_Egre Ing_est = new Ing_Est_Egre();
            Ing_est.Show();
        }

        private void Img_Buscar_Click_1(object sender, EventArgs e)
        {
            Carga_Grilla();
        }
    }
}
