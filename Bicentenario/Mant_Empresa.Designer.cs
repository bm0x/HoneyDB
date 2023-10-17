
namespace L_TEC_BIC_JFERSOLAR
{
    partial class Mant_Empresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mant_Empresa));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DGV_Empresa = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txt_Emp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Img_Buscar = new System.Windows.Forms.PictureBox();
            this.Img_Nuevo = new System.Windows.Forms.PictureBox();
            this.Img_Volver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Empresa)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(277, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mantenedor de Empresa";
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
            // DGV_Empresa
            // 
            this.DGV_Empresa.AllowUserToAddRows = false;
            this.DGV_Empresa.AllowUserToDeleteRows = false;
            this.DGV_Empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Empresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Empresa});
            this.DGV_Empresa.Location = new System.Drawing.Point(13, 145);
            this.DGV_Empresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_Empresa.Name = "DGV_Empresa";
            this.DGV_Empresa.ReadOnly = true;
            this.DGV_Empresa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_Empresa.Size = new System.Drawing.Size(771, 291);
            this.DGV_Empresa.TabIndex = 13;
            this.DGV_Empresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Empresa_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Cod_Empresa";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Empresa
            // 
            this.Empresa.DataPropertyName = "Desc_Empresa";
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.ReadOnly = true;
            this.Empresa.Width = 600;
            // 
            // Txt_Emp
            // 
            this.Txt_Emp.Location = new System.Drawing.Point(13, 111);
            this.Txt_Emp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Emp.Name = "Txt_Emp";
            this.Txt_Emp.Size = new System.Drawing.Size(461, 20);
            this.Txt_Emp.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(13, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Empresa";
            // 
            // Img_Buscar
            // 
            this.Img_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Img_Buscar.Image")));
            this.Img_Buscar.Location = new System.Drawing.Point(481, 92);
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
            this.Img_Nuevo.Location = new System.Drawing.Point(539, 92);
            this.Img_Nuevo.Name = "Img_Nuevo";
            this.Img_Nuevo.Size = new System.Drawing.Size(52, 52);
            this.Img_Nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Img_Nuevo.TabIndex = 15;
            this.Img_Nuevo.TabStop = false;
            this.Img_Nuevo.Click += new System.EventHandler(this.Img_Nuevo_Click);
            // 
            // Img_Volver
            // 
            this.Img_Volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img_Volver.Image = ((System.Drawing.Image)(resources.GetObject("Img_Volver.Image")));
            this.Img_Volver.Location = new System.Drawing.Point(597, 91);
            this.Img_Volver.Name = "Img_Volver";
            this.Img_Volver.Size = new System.Drawing.Size(52, 53);
            this.Img_Volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Img_Volver.TabIndex = 16;
            this.Img_Volver.TabStop = false;
            this.Img_Volver.Click += new System.EventHandler(this.Img_Volver_Click);
            // 
            // Mant_Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Img_Volver);
            this.Controls.Add(this.Img_Nuevo);
            this.Controls.Add(this.Img_Buscar);
            this.Controls.Add(this.DGV_Empresa);
            this.Controls.Add(this.Txt_Emp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mant_Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Egresados";
            this.Load += new System.EventHandler(this.Mant_Empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Empresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Nuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Volver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView DGV_Empresa;
        private System.Windows.Forms.TextBox Txt_Emp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Img_Buscar;
        private System.Windows.Forms.PictureBox Img_Nuevo;
        private System.Windows.Forms.PictureBox Img_Volver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
    }
}