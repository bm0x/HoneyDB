
namespace L_TEC_BIC_JFERSOLAR
{
    partial class Asig_Insti_Carrera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asig_Insti_Carrera));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbInstituciones = new System.Windows.Forms.ComboBox();
            this.Txt_Cod_Inst = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV_No_Asig = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGV_Asig = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Img_Volver = new System.Windows.Forms.PictureBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_No_Asig)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Asig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Volver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(195, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Asignación de Carreras a Instituciones";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(733, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(273, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Instituciones";
            // 
            // CbInstituciones
            // 
            this.CbInstituciones.BackColor = System.Drawing.Color.White;
            this.CbInstituciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbInstituciones.FormattingEnabled = true;
            this.CbInstituciones.Location = new System.Drawing.Point(273, 103);
            this.CbInstituciones.Name = "CbInstituciones";
            this.CbInstituciones.Size = new System.Drawing.Size(280, 21);
            this.CbInstituciones.TabIndex = 13;
            this.CbInstituciones.SelectedIndexChanged += new System.EventHandler(this.CbInstituciones_SelectedIndexChanged);
            // 
            // Txt_Cod_Inst
            // 
            this.Txt_Cod_Inst.Location = new System.Drawing.Point(8, 8);
            this.Txt_Cod_Inst.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Cod_Inst.Name = "Txt_Cod_Inst";
            this.Txt_Cod_Inst.Size = new System.Drawing.Size(68, 20);
            this.Txt_Cod_Inst.TabIndex = 14;
            this.Txt_Cod_Inst.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DGV_No_Asig);
            this.panel1.Location = new System.Drawing.Point(57, 197);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 188);
            this.panel1.TabIndex = 15;
            // 
            // DGV_No_Asig
            // 
            this.DGV_No_Asig.AllowUserToAddRows = false;
            this.DGV_No_Asig.AllowUserToDeleteRows = false;
            this.DGV_No_Asig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_No_Asig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Carrera});
            this.DGV_No_Asig.Location = new System.Drawing.Point(4, 3);
            this.DGV_No_Asig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_No_Asig.Name = "DGV_No_Asig";
            this.DGV_No_Asig.ReadOnly = true;
            this.DGV_No_Asig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_No_Asig.Size = new System.Drawing.Size(270, 178);
            this.DGV_No_Asig.TabIndex = 14;
            this.DGV_No_Asig.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_No_Asig_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(55, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Carreras no Asignadas";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DGV_Asig);
            this.panel2.Location = new System.Drawing.Point(433, 197);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 188);
            this.panel2.TabIndex = 16;
            // 
            // DGV_Asig
            // 
            this.DGV_Asig.AllowUserToAddRows = false;
            this.DGV_Asig.AllowUserToDeleteRows = false;
            this.DGV_Asig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Asig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DGV_Asig.Location = new System.Drawing.Point(19, 4);
            this.DGV_Asig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_Asig.Name = "DGV_Asig";
            this.DGV_Asig.ReadOnly = true;
            this.DGV_Asig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_Asig.Size = new System.Drawing.Size(270, 178);
            this.DGV_Asig.TabIndex = 15;
            this.DGV_Asig.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Asig_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(431, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Carreras  Asignadas";
            // 
            // Img_Volver
            // 
            this.Img_Volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img_Volver.Image = ((System.Drawing.Image)(resources.GetObject("Img_Volver.Image")));
            this.Img_Volver.Location = new System.Drawing.Point(675, 12);
            this.Img_Volver.Name = "Img_Volver";
            this.Img_Volver.Size = new System.Drawing.Size(52, 51);
            this.Img_Volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Img_Volver.TabIndex = 18;
            this.Img_Volver.TabStop = false;
            this.Img_Volver.Click += new System.EventHandler(this.Img_Volver_Click);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Cod_Carrera";
            this.Codigo.HeaderText = "Código";
            this.Codigo.MaxInputLength = 10;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Carrera
            // 
            this.Carrera.DataPropertyName = "Desc_Carrera";
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.MaxInputLength = 100;
            this.Carrera.Name = "Carrera";
            this.Carrera.ReadOnly = true;
            this.Carrera.Width = 600;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Cod_Carrera";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Desc_Carrera";
            this.dataGridViewTextBoxColumn2.HeaderText = "Carrera";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 100;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 600;
            // 
            // Asig_Insti_Carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Img_Volver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Txt_Cod_Inst);
            this.Controls.Add(this.CbInstituciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Asig_Insti_Carrera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Egresados";
            this.Load += new System.EventHandler(this.Asig_Insti_Carrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_No_Asig)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Asig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Volver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbInstituciones;
        private System.Windows.Forms.TextBox Txt_Cod_Inst;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_No_Asig;
        private System.Windows.Forms.DataGridView DGV_Asig;
        private System.Windows.Forms.PictureBox Img_Volver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}