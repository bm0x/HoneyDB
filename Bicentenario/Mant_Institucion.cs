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
    public partial class Mant_Institucion : Form
    {
        String consulta;
        public Mant_Institucion()
        {
            InitializeComponent();
        }

        private void Mant_Institucion_Load(object sender, EventArgs e)
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

                if (Txt_Inst.Text == "")
                {
                    consulta = "select Cod_Inst, Desc_Inst from Institucion order by Desc_Inst asc";
                }
                else
                {
                    consulta = "select Cod_Inst, Desc_Inst from Institucion where Desc_Inst like '%" + Txt_Inst.Text + "%' order by Desc_Inst asc";
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, con);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                DGV_Insti.DataSource = ds.Tables[0].DefaultView;
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
            Ing_Institucion Ing_insti = new Ing_Institucion();
            Ing_insti.Show();
        }

        private void DGV_Insti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNo;
            RowNo = e.RowIndex;

            Variables_Globales.Codigo = DGV_Insti.Rows[RowNo].Cells[0].Value.ToString();
            Variables_Globales.Descip = DGV_Insti.Rows[RowNo].Cells[1].Value.ToString();
            Variables_Globales.Estado = "Editar";

            this.Hide();
            Ing_Institucion Ing_insti = new Ing_Institucion();
            Ing_insti.Show();
        }
    }
}
