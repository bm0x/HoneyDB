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
    public partial class Mant_Especialidad : Form
    {
        String consulta;
        public Mant_Especialidad()
        {
            InitializeComponent();
        }

        private void Mant_Especialidad_Load(object sender, EventArgs e)
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

                if (Txt_Espe.Text == "")
                {
                    consulta = "select Cod_Espe, Desc_Espe from Especialidad order by Desc_Espe asc";
                }
                else
                {
                    consulta = "select Cod_Espe, Desc_Espe from Especialidad where Desc_Espe like '%" + Txt_Espe.Text + "%' order by Desc_Espe asc";
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, con);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                DGV_Espe.DataSource = ds.Tables[0].DefaultView;
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
            Ing_Especialidad Ing_Espe = new Ing_Especialidad();
            Ing_Espe.Show();
        }

        private void DGV_Espe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNo;
            RowNo = e.RowIndex;

            Variables_Globales.Codigo = DGV_Espe.Rows[RowNo].Cells[0].Value.ToString();
            Variables_Globales.Descip = DGV_Espe.Rows[RowNo].Cells[1].Value.ToString();
            Variables_Globales.Estado = "Editar";

            this.Hide();
            Ing_Especialidad Ing_Espe = new Ing_Especialidad();
            Ing_Espe.Show();
        }
    }
}
