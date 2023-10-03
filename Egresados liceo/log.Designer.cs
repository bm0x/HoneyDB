namespace Egresados_liceo
{
    partial class log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(log));
            this.log1 = new System.Windows.Forms.Label();
            this.log2 = new System.Windows.Forms.Label();
            this.txt_salir_log = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log1
            // 
            this.log1.AutoSize = true;
            this.log1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log1.Location = new System.Drawing.Point(12, 9);
            this.log1.Name = "log1";
            this.log1.Size = new System.Drawing.Size(231, 25);
            this.log1.TabIndex = 0;
            this.log1.Text = "Changelog BETA 1.0";
            this.log1.Click += new System.EventHandler(this.log1_Click);
            // 
            // log2
            // 
            this.log2.AutoSize = true;
            this.log2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log2.Location = new System.Drawing.Point(12, 50);
            this.log2.Name = "log2";
            this.log2.Size = new System.Drawing.Size(769, 275);
            this.log2.TabIndex = 1;
            this.log2.Text = resources.GetString("log2.Text");
            // 
            // txt_salir_log
            // 
            this.txt_salir_log.Location = new System.Drawing.Point(721, 422);
            this.txt_salir_log.Name = "txt_salir_log";
            this.txt_salir_log.Size = new System.Drawing.Size(75, 23);
            this.txt_salir_log.TabIndex = 2;
            this.txt_salir_log.Text = "Salir a Menu";
            this.txt_salir_log.UseVisualStyleBackColor = true;
            this.txt_salir_log.Click += new System.EventHandler(this.txt_salir_log_Click);
            // 
            // log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_salir_log);
            this.Controls.Add(this.log2);
            this.Controls.Add(this.log1);
            this.Name = "log";
            this.Text = "log";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label log1;
        private System.Windows.Forms.Label log2;
        private System.Windows.Forms.Button txt_salir_log;
    }
}