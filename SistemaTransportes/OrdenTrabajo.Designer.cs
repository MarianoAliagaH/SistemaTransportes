namespace SistemaTransportes
{
    partial class OrdenTrabajo
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
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumeroDocumento);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(524, 60);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numero Documento";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumeroDocumento.Location = new System.Drawing.Point(168, 23);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(244, 23);
            this.txtNumeroDocumento.TabIndex = 2;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscarCliente.Location = new System.Drawing.Point(420, 22);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(88, 24);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "D.N.I.",
            "R.U.C."});
            this.comboBox1.Location = new System.Drawing.Point(16, 23);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Seleccionar";
            // 
            // OrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 701);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrdenTrabajo";
            this.Text = "Ordenes de Trabajo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}