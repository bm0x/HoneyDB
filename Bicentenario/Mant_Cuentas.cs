using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace L_TEC_BIC_JFERSOLAR
{
    public partial class Mant_Cuentas : Form
    {
        String consulta;
        public Mant_Cuentas()
        {
            InitializeComponent();
        }
        private void Mant_Cuentas_Load(object sender, EventArgs e)
        {
            Carga_Grilla();

            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox2, "Vuelve al Login");

            ToolTip Busc = new ToolTip();
            Busc.SetToolTip(this.Img_Buscar, "Busca Especialidad");

            ToolTip Agre = new ToolTip();
            Agre.SetToolTip(this.Img_Nuevo, "Agrega Especialidad");

            ToolTip Vol = new ToolTip();
            Vol.SetToolTip(this.Img_Volver, "Salir");
        }
        private void Carga_Grilla()
        {
            try
            {

                SqlConnection con = new SqlConnection(Conexion.Conec);

                if (Txt_Usuarios.Text == "")
                {
                    consulta = "select User_U, Pass_User from Usuarios order by User_U asc";
                }
                else
                {
                    consulta = "select User_U, Pass_User from Usuarios where User_U like '%" + Txt_Usuarios.Text + "%' order by User_U asc";
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, con);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                DGV_Usuarios.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
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
            Menu M = new Menu();
            M.Show();
        }

        private void Img_Nuevo_Click(object sender, EventArgs e)
        {
            Variables_Globales.Estado = "Nuevo";
            Variables_Globales.Codigo = "";
            Variables_Globales.Descip = "";
            
            this.Hide();
            Ing_Cuentas ing_Cuentas = new Ing_Cuentas();
            ing_Cuentas.Show();
        }

        private void DGV_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNo;
            RowNo = e.RowIndex;

            Variables_Globales.Codigo = DGV_Usuarios.Rows[RowNo].Cells[0].Value.ToString();
            Variables_Globales.Descip = DGV_Usuarios.Rows[RowNo].Cells[1].Value.ToString();
            Variables_Globales.Estado = "Editar";

            this.Hide();
            Ing_Cuentas Ing_Accounts = new Ing_Cuentas();
            Ing_Accounts.Show();
        }
    }
}
