namespace SistemaTransportes
{
    partial class Cliente
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAbrirFlete = new System.Windows.Forms.Button();
            this.btnClientesDeshabilitados = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClienteInformacion = new System.Windows.Forms.Button();
            this.btnDeshabilitarCliente = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAbrirClienteNuevo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCerrar);
            this.groupBox3.Controls.Add(this.btnAbrirFlete);
            this.groupBox3.Controls.Add(this.btnClientesDeshabilitados);
            this.groupBox3.Location = new System.Drawing.Point(758, 566);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(614, 106);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones Adicionales";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(446, 19);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 75);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAbrirFlete
            // 
            this.btnAbrirFlete.Location = new System.Drawing.Point(34, 22);
            this.btnAbrirFlete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAbrirFlete.Name = "btnAbrirFlete";
            this.btnAbrirFlete.Size = new System.Drawing.Size(75, 75);
            this.btnAbrirFlete.TabIndex = 4;
            this.btnAbrirFlete.Text = "Fletes por Ruta del Cliente";
            this.btnAbrirFlete.UseVisualStyleBackColor = true;
            this.btnAbrirFlete.Click += new System.EventHandler(this.btnAbrirFlete_Click);
            // 
            // btnClientesDeshabilitados
            // 
            this.btnClientesDeshabilitados.Location = new System.Drawing.Point(241, 19);
            this.btnClientesDeshabilitados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClientesDeshabilitados.Name = "btnClientesDeshabilitados";
            this.btnClientesDeshabilitados.Size = new System.Drawing.Size(75, 75);
            this.btnClientesDeshabilitados.TabIndex = 3;
            this.btnClientesDeshabilitados.Text = "Clientes Deshabilitados";
            this.btnClientesDeshabilitados.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClienteInformacion);
            this.groupBox2.Controls.Add(this.btnDeshabilitarCliente);
            this.groupBox2.Controls.Add(this.btnActualizar);
            this.groupBox2.Controls.Add(this.btnAbrirClienteNuevo);
            this.groupBox2.Location = new System.Drawing.Point(14, 560);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(736, 112);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones [Clientes]";
            // 
            // btnClienteInformacion
            // 
            this.btnClienteInformacion.Location = new System.Drawing.Point(540, 22);
            this.btnClienteInformacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClienteInformacion.Name = "btnClienteInformacion";
            this.btnClienteInformacion.Size = new System.Drawing.Size(75, 75);
            this.btnClienteInformacion.TabIndex = 4;
            this.btnClienteInformacion.Text = "Informacion Cliente";
            this.btnClienteInformacion.UseVisualStyleBackColor = true;
            this.btnClienteInformacion.Click += new System.EventHandler(this.btnClienteInformacion_Click);
            // 
            // btnDeshabilitarCliente
            // 
            this.btnDeshabilitarCliente.Location = new System.Drawing.Point(374, 22);
            this.btnDeshabilitarCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeshabilitarCliente.Name = "btnDeshabilitarCliente";
            this.btnDeshabilitarCliente.Size = new System.Drawing.Size(75, 75);
            this.btnDeshabilitarCliente.TabIndex = 2;
            this.btnDeshabilitarCliente.Text = "Deshabilitar Cliente";
            this.btnDeshabilitarCliente.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(207, 22);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 75);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar Cliente";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAbrirClienteNuevo
            // 
            this.btnAbrirClienteNuevo.Location = new System.Drawing.Point(51, 22);
            this.btnAbrirClienteNuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAbrirClienteNuevo.Name = "btnAbrirClienteNuevo";
            this.btnAbrirClienteNuevo.Size = new System.Drawing.Size(75, 75);
            this.btnAbrirClienteNuevo.TabIndex = 0;
            this.btnAbrirClienteNuevo.Text = "Nuevo Cliente";
            this.btnAbrirClienteNuevo.UseVisualStyleBackColor = true;
            this.btnAbrirClienteNuevo.Click += new System.EventHandler(this.btnAbrirClienteNuevo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1547, 476);
            this.dataGridView1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumeroDocumento);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(524, 60);
            this.groupBox1.TabIndex = 5;
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
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 701);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAbrirFlete;
        private System.Windows.Forms.Button btnClientesDeshabilitados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClienteInformacion;
        private System.Windows.Forms.Button btnDeshabilitarCliente;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAbrirClienteNuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCerrar;
    }
}