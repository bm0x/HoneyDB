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
    public partial class Mant_Empresa : Form
    {
        String consulta;
        public Mant_Empresa()
        {
            InitializeComponent();
        }

        private void Mant_Empresa_Load(object sender, EventArgs e)
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

                if (Txt_Emp.Text == "")
                {
                    consulta = "select Cod_Empresa, Desc_Empresa from Empresa order by Desc_Empresa asc";
                }
                else
                {
                    consulta = "select Cod_Empresa, Desc_Empresa from Empresa where Desc_Empresa like '%" + Txt_Emp.Text + "%' order by Desc_Empresa asc";
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, con);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                DGV_Empresa.DataSource = ds.Tables[0].DefaultView;
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
            Ing_Empresa Ing_Emp = new Ing_Empresa();
            Ing_Emp.Show();
        }

        private void DGV_Empresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNo;
            RowNo = e.RowIndex;

            Variables_Globales.Codigo = DGV_Empresa.Rows[RowNo].Cells[0].Value.ToString();
            Variables_Globales.Descip = DGV_Empresa.Rows[RowNo].Cells[1].Value.ToString();
            Variables_Globales.Estado = "Editar";

            this.Hide();
            Ing_Empresa Ing_Emp = new Ing_Empresa();
            Ing_Emp.Show();
        }
    }
}
