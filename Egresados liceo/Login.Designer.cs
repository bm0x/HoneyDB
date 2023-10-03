
namespace Egresados_liceo
{
    partial class Login
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
            this.Btn_Salir_Login = new System.Windows.Forms.Button();
            this.Btn_Entrar_Login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Salir_Login
            // 
            this.Btn_Salir_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Salir_Login.Location = new System.Drawing.Point(329, 278);
            this.Btn_Salir_Login.Name = "Btn_Salir_Login";
            this.Btn_Salir_Login.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salir_Login.TabIndex = 0;
            this.Btn_Salir_Login.Text = "Salir";
            this.Btn_Salir_Login.UseVisualStyleBackColor = true;
            this.Btn_Salir_Login.Click += new System.EventHandler(this.Btn_Salir_Login_Click);
            // 
            // Btn_Entrar_Login
            // 
            this.Btn_Entrar_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Entrar_Login.Location = new System.Drawing.Point(421, 278);
            this.Btn_Entrar_Login.Name = "Btn_Entrar_Login";
            this.Btn_Entrar_Login.Size = new System.Drawing.Size(75, 23);
            this.Btn_Entrar_Login.TabIndex = 1;
            this.Btn_Entrar_Login.Text = "Entrar";
            this.Btn_Entrar_Login.UseVisualStyleBackColor = true;
            this.Btn_Entrar_Login.Click += new System.EventHandler(this.Btn_Entrar_Login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(228, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(228, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(329, 193);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(167, 20);
            this.txt_user.TabIndex = 4;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(329, 235);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(167, 20);
            this.txt_pass.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Egresados_liceo.Properties.Resources.sdfa_removebg_preview__2_;
            this.pictureBox1.Location = new System.Drawing.Point(329, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Egresados_liceo.Properties.Resources.saw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Entrar_Login);
            this.Controls.Add(this.Btn_Salir_Login);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Salir_Login;
        private System.Windows.Forms.Button Btn_Entrar_Login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}