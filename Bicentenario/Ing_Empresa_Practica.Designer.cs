
namespace L_TEC_BIC_JFERSOLAR
{
    partial class Ing_Empresa_Practica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ing_Empresa_Practica));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Desc = new System.Windows.Forms.TextBox();
            this.Txt_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Img_Limpiar = new System.Windows.Forms.PictureBox();
            this.Img_Eliminar = new System.Windows.Forms.PictureBox();
            this.Img_Grabar = new System.Windows.Forms.PictureBox();
            this.Img_Volver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Limpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Grabar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Volver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(175, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mantenedor de Empresa Para Práctica";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(733, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Txt_Desc);
            this.panel1.Controls.Add(this.Txt_codigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(219, 136);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 111);
            this.panel1.TabIndex = 10;
            // 
            // Txt_Desc
            // 
            this.Txt_Desc.Location = new System.Drawing.Point(113, 60);
            this.Txt_Desc.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Desc.MaxLength = 100;
            this.Txt_Desc.Name = "Txt_Desc";
            this.Txt_Desc.Size = new System.Drawing.Size(219, 20);
            this.Txt_Desc.TabIndex = 13;
            // 
            // Txt_codigo
            // 
            this.Txt_codigo.Location = new System.Drawing.Point(113, 26);
            this.Txt_codigo.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_codigo.MaxLength = 10;
            this.Txt_codigo.Name = "Txt_codigo";
            this.Txt_codigo.Size = new System.Drawing.Size(68, 20);
            this.Txt_codigo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(19, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(19, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Img_Limpiar);
            this.panel2.Controls.Add(this.Img_Eliminar);
            this.panel2.Controls.Add(this.Img_Grabar);
            this.panel2.Controls.Add(this.Img_Volver);
            this.panel2.Location = new System.Drawing.Point(219, 284);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 64);
            this.panel2.TabIndex = 11;
            // 
            // Img_Limpiar
            // 
            this.Img_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Img_Limpiar.Image")));
            this.Img_Limpiar.Location = new System.Drawing.Point(193, 8);
            this.Img_Limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.Img_Limpiar.Name = "Img_Limpiar";
            this.Img_Limpiar.Size = new System.Drawing.Size(52, 48);
            this.Img_Limpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Img_Limpiar.TabIndex = 20;
            this.Img_Limpiar.TabStop = false;
            // 
            // Img_Eliminar
            // 
            this.Img_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Img_Eliminar.Image")));
            this.Img_Eliminar.Location = new System.Drawing.Point(111, 8);
            this.Img_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Img_Eliminar.Name = "Img_Eliminar";
            this.Img_Eliminar.Size = new System.Drawing.Size(52, 48);
            this.Img_Eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Img_Eliminar.TabIndex = 19;
            this.Img_Eliminar.TabStop = false;
            this.Img_Eliminar.Click += new System.EventHandler(this.Img_Eliminar_Click);
            // 
            // Img_Grabar
            // 
            this.Img_Grabar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img_Grabar.Image = ((System.Drawing.Image)(resources.GetObject("Img_Grabar.Image")));
            this.Img_Grabar.Location = new System.Drawing.Point(27, 8);
            this.Img_Grabar.Margin = new System.Windows.Forms.Padding(2);
            this.Img_Grabar.Name = "Img_Grabar";
            this.Img_Grabar.Size = new System.Drawing.Size(52, 50);
            this.Img_Grabar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Img_Grabar.TabIndex = 18;
            this.Img_Grabar.TabStop = false;
            this.Img_Grabar.Click += new System.EventHandler(this.Img_Grabar_Click);
            // 
            // Img_Volver
            // 
            this.Img_Volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img_Volver.Image = ((System.Drawing.Image)(resources.GetObject("Img_Volver.Image")));
            this.Img_Volver.Location = new System.Drawing.Point(281, 8);
            this.Img_Volver.Name = "Img_Volver";
            this.Img_Volver.Size = new System.Drawing.Size(52, 48);
            this.Img_Volver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Img_Volver.TabIndex = 17;
            this.Img_Volver.TabStop = false;
            this.Img_Volver.Click += new System.EventHandler(this.Img_Volver_Click);
            // 
            // Ing_Empresa_Practica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ing_Empresa_Practica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Egresados";
            this.Load += new System.EventHandler(this.Ing_Empresa_Practica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Img_Limpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Grabar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Volver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txt_Desc;
        private System.Windows.Forms.TextBox Txt_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Img_Volver;
        private System.Windows.Forms.PictureBox Img_Grabar;
        private System.Windows.Forms.PictureBox Img_Limpiar;
        private System.Windows.Forms.PictureBox Img_Eliminar;
    }
}