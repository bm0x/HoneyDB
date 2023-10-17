namespace L_TEC_BIC_JFERSOLAR
{
    partial class Mant_Cuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mant_Cuentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Img_Buscar = new System.Windows.Forms.PictureBox();
            this.Img_Volver = new System.Windows.Forms.PictureBox();
            this.Img_Nuevo = new System.Windows.Forms.PictureBox();
            this.DGV_Usuarios = new System.Windows.Forms.DataGridView();
            this.Txt_Usuarios = new System.Windows.Forms.TextBox();
            this.Label_Usuarios = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.User_U = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Volver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Nuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Img_Buscar
            // 
            this.Img_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Img_Buscar.Image")));
            this.Img_Buscar.Location = new System.Drawing.Point(262, 87);
            this.Img_Buscar.Name = "Img_Buscar";
            this.Img_Buscar.Size = new System.Drawing.Size(52, 51);
            this.Img_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Img_Buscar.TabIndex = 25;
            this.Img_Buscar.TabStop = false;
            // 
            // Img_Volver
            // 
            this.Img_Volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img_Volver.Image = ((System.Drawing.Image)(resources.GetObject("Img_Volver.Image")));
            this.Img_Volver.Location = new System.Drawing.Point(380, 87);
            this.Img_Volver.Name = "Img_Volver";
            this.Img_Volver.Size = new System.Drawing.Size(54, 52);
            this.Img_Volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Img_Volver.TabIndex = 24;
            this.Img_Volver.TabStop = false;
            this.Img_Volver.Click += new System.EventHandler(this.Img_Volver_Click);
            // 
            // Img_Nuevo
            // 
            this.Img_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("Img_Nuevo.Image")));
            this.Img_Nuevo.Location = new System.Drawing.Point(320, 87);
            this.Img_Nuevo.Name = "Img_Nuevo";
            this.Img_Nuevo.Size = new System.Drawing.Size(54, 52);
            this.Img_Nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Img_Nuevo.TabIndex = 23;
            this.Img_Nuevo.TabStop = false;
            this.Img_Nuevo.Click += new System.EventHandler(this.Img_Nuevo_Click);
            // 
            // DGV_Usuarios
            // 
            this.DGV_Usuarios.AllowUserToAddRows = false;
            this.DGV_Usuarios.AllowUserToDeleteRows = false;
            this.DGV_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_U,
            this.Pass_User});
            this.DGV_Usuarios.Location = new System.Drawing.Point(14, 146);
            this.DGV_Usuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGV_Usuarios.Name = "DGV_Usuarios";
            this.DGV_Usuarios.ReadOnly = true;
            this.DGV_Usuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_Usuarios.Size = new System.Drawing.Size(461, 290);
            this.DGV_Usuarios.TabIndex = 22;
            this.DGV_Usuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Usuarios_CellContentClick);
            // 
            // Txt_Usuarios
            // 
            this.Txt_Usuarios.Location = new System.Drawing.Point(14, 112);
            this.Txt_Usuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Usuarios.Name = "Txt_Usuarios";
            this.Txt_Usuarios.Size = new System.Drawing.Size(241, 20);
            this.Txt_Usuarios.TabIndex = 21;
            // 
            // Label_Usuarios
            // 
            this.Label_Usuarios.AutoSize = true;
            this.Label_Usuarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Usuarios.ForeColor = System.Drawing.Color.DarkGreen;
            this.Label_Usuarios.Location = new System.Drawing.Point(14, 93);
            this.Label_Usuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Usuarios.Name = "Label_Usuarios";
            this.Label_Usuarios.Size = new System.Drawing.Size(70, 18);
            this.Label_Usuarios.TabIndex = 20;
            this.Label_Usuarios.Text = "Usuarios";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(423, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(106, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mantenedor de Usuarios";
            // 
            // User_U
            // 
            this.User_U.DataPropertyName = "User_U";
            dataGridViewCellStyle1.NullValue = null;
            this.User_U.DefaultCellStyle = dataGridViewCellStyle1;
            this.User_U.HeaderText = "Usuario";
            this.User_U.MaxInputLength = 15;
            this.User_U.Name = "User_U";
            this.User_U.ReadOnly = true;
            this.User_U.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.User_U.Width = 200;
            // 
            // Pass_User
            // 
            this.Pass_User.DataPropertyName = "Pass_User";
            this.Pass_User.HeaderText = "Contraseña";
            this.Pass_User.MaxInputLength = 15;
            this.Pass_User.Name = "Pass_User";
            this.Pass_User.ReadOnly = true;
            this.Pass_User.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pass_User.Width = 200;
            // 
            // Mant_Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 444);
            this.Controls.Add(this.Img_Buscar);
            this.Controls.Add(this.Img_Volver);
            this.Controls.Add(this.Img_Nuevo);
            this.Controls.Add(this.DGV_Usuarios);
            this.Controls.Add(this.Txt_Usuarios);
            this.Controls.Add(this.Label_Usuarios);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mant_Cuentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mant_Cuentas";
            this.Load += new System.EventHandler(this.Mant_Cuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Img_Buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Volver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Nuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Img_Buscar;
        private System.Windows.Forms.PictureBox Img_Volver;
        private System.Windows.Forms.PictureBox Img_Nuevo;
        private System.Windows.Forms.DataGridView DGV_Usuarios;
        private System.Windows.Forms.TextBox Txt_Usuarios;
        private System.Windows.Forms.Label Label_Usuarios;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_U;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass_User;
    }
}