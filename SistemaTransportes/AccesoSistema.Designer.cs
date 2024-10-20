namespace SistemaTransportes
{
    partial class AccesoSistema
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLLenarDatos = new System.Windows.Forms.Label();
            this.btnAccederSistema = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lblLLenarDatos);
            this.groupBox1.Controls.Add(this.btnAccederSistema);
            this.groupBox1.Location = new System.Drawing.Point(499, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 216);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(30, 55);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(210, 27);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(30, 92);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(210, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblLLenarDatos
            // 
            this.lblLLenarDatos.AutoSize = true;
            this.lblLLenarDatos.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLLenarDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(150)))), ((int)(((byte)(229)))));
            this.lblLLenarDatos.Location = new System.Drawing.Point(95, 185);
            this.lblLLenarDatos.Name = "lblLLenarDatos";
            this.lblLLenarDatos.Size = new System.Drawing.Size(81, 13);
            this.lblLLenarDatos.TabIndex = 1;
            this.lblLLenarDatos.Text = "LLenar Datos";
            this.lblLLenarDatos.Click += new System.EventHandler(this.lblLLenarDatos_Click);
            // 
            // btnAccederSistema
            // 
            this.btnAccederSistema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.btnAccederSistema.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(166)))), ((int)(((byte)(229)))));
            this.btnAccederSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccederSistema.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAccederSistema.Location = new System.Drawing.Point(30, 141);
            this.btnAccederSistema.Name = "btnAccederSistema";
            this.btnAccederSistema.Size = new System.Drawing.Size(210, 27);
            this.btnAccederSistema.TabIndex = 0;
            this.btnAccederSistema.Text = "Acceder";
            this.btnAccederSistema.UseVisualStyleBackColor = false;
            this.btnAccederSistema.Click += new System.EventHandler(this.btnAccederSistema_Click);
            // 
            // AccesoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AccesoSistema";
            this.Text = "Acceso al Sistema";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblLLenarDatos;
        private System.Windows.Forms.Button btnAccederSistema;
    }
}