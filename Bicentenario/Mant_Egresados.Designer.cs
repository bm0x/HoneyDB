
namespace L_TEC_BIC_JFERSOLAR
{
    partial class Mant_Egresados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mant_Egresados));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DGV_Egresado = new System.Windows.Forms.DataGridView();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año_Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario_Act = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Convenio_Arti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trabaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrato_Trab_Practica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Emp_Practica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa_Practica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beneficio_BPTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_Egre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Img_Buscar = new System.Windows.Forms.PictureBox();
            this.Img_Nuevo = new System.Windows.Forms.PictureBox();
            this.Img_Volver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Egresado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Nuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Volver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(232, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mantenedor de Egresados";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(733, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // DGV_Egresado
            // 
            this.DGV_Egresado.AllowUserToAddRows = false;
            this.DGV_Egresado.AllowUserToDeleteRows = false;
            this.DGV_Egresado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Egresado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rut,
            this.Nombre,
            this.Direccion,
            this.Telefono,
            this.Email,
            this.Año_Egreso,
            this.Cod_Especialidad,
            this.Especialidad,
            this.Comentario_Act,
            this.Estudia,
            this.Convenio_Arti,
            this.Trabaja,
            this.Contrato_Trab_Practica,
            this.Observacion,
            this.Cod_Emp_Practica,
            this.Empresa_Practica,
            this.Beneficio_BPTP,
            this.Cod_Estado,
            this.Estado});
            this.DGV_Egresado.Location = new System.Drawing.Point(13, 145);
            this.DGV_Egresado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_Egresado.Name = "DGV_Egresado";
            this.DGV_Egresado.ReadOnly = true;
            this.DGV_Egresado.Size = new System.Drawing.Size(771, 291);
            this.DGV_Egresado.TabIndex = 13;
            this.DGV_Egresado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Egresado_CellContentClick);
            // 
            // Rut
            // 
            this.Rut.DataPropertyName = "Rut_Egre";
            this.Rut.HeaderText = "Rut";
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nom_Egre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Dir_Egre";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Tel_Egre";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email_Egre";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Año_Egreso
            // 
            this.Año_Egreso.DataPropertyName = "Ano_Egre";
            this.Año_Egreso.HeaderText = "Año_Egreso";
            this.Año_Egreso.Name = "Año_Egreso";
            this.Año_Egreso.ReadOnly = true;
            // 
            // Cod_Especialidad
            // 
            this.Cod_Especialidad.DataPropertyName = "Cod_Espe";
            this.Cod_Especialidad.HeaderText = "Cod_Especialidad";
            this.Cod_Especialidad.Name = "Cod_Especialidad";
            this.Cod_Especialidad.ReadOnly = true;
            this.Cod_Especialidad.Visible = false;
            // 
            // Especialidad
            // 
            this.Especialidad.DataPropertyName = "Desc_Espe";
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            // 
            // Comentario_Act
            // 
            this.Comentario_Act.DataPropertyName = "Coment_Act_Actual_Egre";
            this.Comentario_Act.HeaderText = "Comentario_Act";
            this.Comentario_Act.Name = "Comentario_Act";
            this.Comentario_Act.ReadOnly = true;
            // 
            // Estudia
            // 
            this.Estudia.DataPropertyName = "Estudia_Egre";
            this.Estudia.HeaderText = "Estudia";
            this.Estudia.Name = "Estudia";
            this.Estudia.ReadOnly = true;
            // 
            // Convenio_Arti
            // 
            this.Convenio_Arti.DataPropertyName = "Acogio_Conve_Arti_Egre";
            this.Convenio_Arti.HeaderText = "Convenio_Arti";
            this.Convenio_Arti.Name = "Convenio_Arti";
            this.Convenio_Arti.ReadOnly = true;
            // 
            // Trabaja
            // 
            this.Trabaja.DataPropertyName = "Trabaja_Egre";
            this.Trabaja.HeaderText = "Trabaja";
            this.Trabaja.Name = "Trabaja";
            this.Trabaja.ReadOnly = true;
            // 
            // Contrato_Trab_Practica
            // 
            this.Contrato_Trab_Practica.DataPropertyName = "Cont_Trab_Practica_Egre";
            this.Contrato_Trab_Practica.HeaderText = "Contrato_Trab_Practica";
            this.Contrato_Trab_Practica.Name = "Contrato_Trab_Practica";
            this.Contrato_Trab_Practica.ReadOnly = true;
            // 
            // Observacion
            // 
            this.Observacion.DataPropertyName = "Obs_Egre";
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            // 
            // Cod_Emp_Practica
            // 
            this.Cod_Emp_Practica.DataPropertyName = "Cod_Empre_Prac";
            this.Cod_Emp_Practica.HeaderText = "Cod_Emp_Practica";
            this.Cod_Emp_Practica.Name = "Cod_Emp_Practica";
            this.Cod_Emp_Practica.ReadOnly = true;
            this.Cod_Emp_Practica.Visible = false;
            // 
            // Empresa_Practica
            // 
            this.Empresa_Practica.DataPropertyName = "Desc_Empre_Prac";
            this.Empresa_Practica.HeaderText = "Empresa_Practica";
            this.Empresa_Practica.Name = "Empresa_Practica";
            this.Empresa_Practica.ReadOnly = true;
            // 
            // Beneficio_BPTP
            // 
            this.Beneficio_BPTP.DataPropertyName = "Benef_BPTP_Egre";
            this.Beneficio_BPTP.HeaderText = "Beneficio_BPTP";
            this.Beneficio_BPTP.Name = "Beneficio_BPTP";
            this.Beneficio_BPTP.ReadOnly = true;
            // 
            // Cod_Estado
            // 
            this.Cod_Estado.DataPropertyName = "Cod_Est_Egre";
            this.Cod_Estado.HeaderText = "Cod_Estado";
            this.Cod_Estado.Name = "Cod_Estado";
            this.Cod_Estado.ReadOnly = true;
            this.Cod_Estado.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Desc_Est_Egre";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Txt_Egre
            // 
            this.Txt_Egre.Location = new System.Drawing.Point(13, 111);
            this.Txt_Egre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Egre.Name = "Txt_Egre";
            this.Txt_Egre.Size = new System.Drawing.Size(461, 20);
            this.Txt_Egre.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Egresados";
            // 
            // Img_Buscar
            // 
            this.Img_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Img_Buscar.Image")));
            this.Img_Buscar.Location = new System.Drawing.Point(484, 92);
            this.Img_Buscar.Name = "Img_Buscar";
            this.Img_Buscar.Size = new System.Drawing.Size(52, 51);
            this.Img_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Img_Buscar.TabIndex = 14;
            this.Img_Buscar.TabStop = false;
            this.Img_Buscar.Click += new System.EventHandler(this.Img_Buscar_Click);
            // 
            // Img_Nuevo
            // 
            this.Img_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Img_Nuevo.Image")));
            this.Img_Nuevo.Location = new System.Drawing.Point(542, 92);
            this.Img_Nuevo.Name = "Img_Nuevo";
            this.Img_Nuevo.Size = new System.Drawing.Size(52, 51);
            this.Img_Nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Img_Nuevo.TabIndex = 15;
            this.Img_Nuevo.TabStop = false;
            this.Img_Nuevo.Click += new System.EventHandler(this.Img_Nuevo_Click);
            // 
            // Img_Volver
            // 
            this.Img_Volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img_Volver.Image = ((System.Drawing.Image)(resources.GetObject("Img_Volver.Image")));
            this.Img_Volver.Location = new System.Drawing.Point(600, 91);
            this.Img_Volver.Name = "Img_Volver";
            this.Img_Volver.Size = new System.Drawing.Size(52, 52);
            this.Img_Volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Img_Volver.TabIndex = 16;
            this.Img_Volver.TabStop = false;
            this.Img_Volver.Click += new System.EventHandler(this.Img_Volver_Click);
            // 
            // Mant_Egresados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Img_Volver);
            this.Controls.Add(this.Img_Nuevo);
            this.Controls.Add(this.Img_Buscar);
            this.Controls.Add(this.DGV_Egresado);
            this.Controls.Add(this.Txt_Egre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mant_Egresados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Egresados";
            this.Load += new System.EventHandler(this.Mant_Egresados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Egresado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Nuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Volver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView DGV_Egresado;
        private System.Windows.Forms.TextBox Txt_Egre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Img_Buscar;
        private System.Windows.Forms.PictureBox Img_Nuevo;
        private System.Windows.Forms.PictureBox Img_Volver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año_Egreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario_Act;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Convenio_Arti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trabaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrato_Trab_Practica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Emp_Practica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa_Practica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beneficio_BPTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}