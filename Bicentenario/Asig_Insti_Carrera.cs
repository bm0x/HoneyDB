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
    public partial class Asig_Insti_Carrera : Form
    {
        String consulta, consulta1;
        public Asig_Insti_Carrera()
        {
            InitializeComponent();
        }

        private void Asig_Insti_Carrera_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pictureBox2, "Vuelve al Login");

            ToolTip GriNoAsig = new ToolTip();
            GriNoAsig.SetToolTip(this.DGV_No_Asig, "Asignar Carrera");

            ToolTip GriAsig = new ToolTip();
            GriAsig.SetToolTip(this.DGV_Asig, "Desasignar Carrera");

            ToolTip Vol = new ToolTip();
            Vol.SetToolTip(this.Img_Volver, "Salir");

            llena_Institucion();
        }

        private void llena_Institucion()
        {
            SqlConnection con = new SqlConnection(Conexion.Conec);


            consulta = "select Cod_Inst,Desc_Inst from Institucion order by Desc_Inst asc";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, con);
            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            CbInstituciones.DisplayMember = "Desc_Inst";
            CbInstituciones.ValueMember = "Cod_Inst";
            CbInstituciones.DataSource = ds;

        }

        private void CbInstituciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_Cod_Inst.Text = CbInstituciones.SelectedValue.ToString();
            Carga_Grillas();
        }

        private void DGV_No_Asig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNo;
            String codigo_car;
            RowNo = e.RowIndex;

            codigo_car = DGV_No_Asig.Rows[RowNo].Cells[0].Value.ToString();

            SqlConnection con = new SqlConnection(Conexion.Conec);

            con.Open();

            SqlCommand cmd1 = new SqlCommand("INSERT INTO Institucion_Carrera (Cod_Carrera, Cod_Inst) " +
                        "VALUES('" + codigo_car + "','" + Txt_Cod_Inst.Text + "')", con);
            cmd1.ExecuteNonQuery();

            Carga_Grillas();
        }

        private void DGV_Asig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int RowNo;
            String codigo_car;
            RowNo = e.RowIndex;

            codigo_car = DGV_Asig.Rows[RowNo].Cells[0].Value.ToString();

            SqlConnection con = new SqlConnection(Conexion.Conec);

            con.Open();
            
            SqlCommand cmd1 = new SqlCommand("Delete From Institucion_Carrera where Cod_Carrera ='"+ codigo_car + "' and Cod_Inst ='" + Txt_Cod_Inst.Text + "'", con);
            cmd1.ExecuteNonQuery();

            Carga_Grillas();
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

        private void Carga_Grillas()
        {
            try
            {

                SqlConnection con = new SqlConnection(Conexion.Conec);

                
                consulta = "select cod_carrera, desc_carrera from carrera where Cod_Carrera not in (Select Cod_Carrera from Institucion_Carrera where Cod_Inst ='"+ Txt_Cod_Inst.Text +"')";
               
                consulta1 = "select cod_carrera, desc_carrera from carrera where Cod_Carrera in (Select Cod_Carrera from Institucion_Carrera where Cod_Inst ='" + Txt_Cod_Inst.Text + "')";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, con);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                DGV_No_Asig.DataSource = ds.Tables[0].DefaultView;

                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(consulta1, con);
                DataSet ds1 = new DataSet();
                dataAdapter1.Fill(ds1);
                DGV_Asig.DataSource = ds1.Tables[0].DefaultView;


            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
