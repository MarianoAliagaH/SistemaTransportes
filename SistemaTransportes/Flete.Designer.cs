namespace SistemaTransportes
{
    partial class Flete
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
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.btnAbrir_AdjuntarPDF = new System.Windows.Forms.Button();
            this.btnAbrirFleteNuevo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.btnCerrar);
            this.gb2.Controls.Add(this.btnAbrir_AdjuntarPDF);
            this.gb2.Controls.Add(this.btnAbrirFleteNuevo);
            this.gb2.Location = new System.Drawing.Point(12, 312);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(776, 126);
            this.gb2.TabIndex = 5;
            this.gb2.TabStop = false;
            this.gb2.Text = "Opciones";
            // 
            // btnAbrir_AdjuntarPDF
            // 
            this.btnAbrir_AdjuntarPDF.Location = new System.Drawing.Point(209, 26);
            this.btnAbrir_AdjuntarPDF.Name = "btnAbrir_AdjuntarPDF";
            this.btnAbrir_AdjuntarPDF.Size = new System.Drawing.Size(117, 90);
            this.btnAbrir_AdjuntarPDF.TabIndex = 1;
            this.btnAbrir_AdjuntarPDF.Text = "Adjuntar PDF";
            this.btnAbrir_AdjuntarPDF.UseVisualStyleBackColor = true;
            this.btnAbrir_AdjuntarPDF.Click += new System.EventHandler(this.btnAbrir_AdjuntarPDF_Click);
            // 
            // btnAbrirFleteNuevo
            // 
            this.btnAbrirFleteNuevo.Location = new System.Drawing.Point(6, 26);
            this.btnAbrirFleteNuevo.Name = "btnAbrirFleteNuevo";
            this.btnAbrirFleteNuevo.Size = new System.Drawing.Size(90, 90);
            this.btnAbrirFleteNuevo.TabIndex = 0;
            this.btnAbrirFleteNuevo.Text = "Nuevo Flete";
            this.btnAbrirFleteNuevo.UseVisualStyleBackColor = true;
            this.btnAbrirFleteNuevo.Click += new System.EventHandler(this.btnAbrirFleteNuevo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 217);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "R.U.C. N: +";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: +";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightCoral;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(661, 31);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(80, 80);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Flete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Flete";
            this.Text = "Flete";
            this.gb2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.Button btnAbrir_AdjuntarPDF;
        private System.Windows.Forms.Button btnAbrirFleteNuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCerrar;
    }
}