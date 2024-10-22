namespace SistemaTransportes
{
    partial class Personal
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnDni = new System.Windows.Forms.Button();
            this.textDni = new System.Windows.Forms.TextBox();
            this.lbOpciones = new System.Windows.Forms.Label();
            this.btnNuevoPersonal = new System.Windows.Forms.Button();
            this.btnEditarPersonal = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnDocumentos = new System.Windows.Forms.Button();
            this.dataGridPersonal = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDni
            // 
            this.btnDni.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDni.Location = new System.Drawing.Point(33, 21);
            this.btnDni.Name = "btnDni";
            this.btnDni.Size = new System.Drawing.Size(152, 37);
            this.btnDni.TabIndex = 1;
            this.btnDni.Text = "Buscar por N°DNI ";
            this.btnDni.UseVisualStyleBackColor = true;
            this.btnDni.Click += new System.EventHandler(this.button2_Click);
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(203, 28);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(190, 22);
            this.textDni.TabIndex = 2;
            // 
            // lbOpciones
            // 
            this.lbOpciones.AutoSize = true;
            this.lbOpciones.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpciones.Location = new System.Drawing.Point(28, 423);
            this.lbOpciones.Name = "lbOpciones";
            this.lbOpciones.Size = new System.Drawing.Size(173, 24);
            this.lbOpciones.TabIndex = 4;
            this.lbOpciones.Text = "Opciones Personal";
            // 
            // btnNuevoPersonal
            // 
            this.btnNuevoPersonal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPersonal.Location = new System.Drawing.Point(88, 36);
            this.btnNuevoPersonal.Name = "btnNuevoPersonal";
            this.btnNuevoPersonal.Size = new System.Drawing.Size(174, 57);
            this.btnNuevoPersonal.TabIndex = 5;
            this.btnNuevoPersonal.Text = "Nuevo Personal";
            this.btnNuevoPersonal.UseVisualStyleBackColor = true;
            this.btnNuevoPersonal.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditarPersonal
            // 
            this.btnEditarPersonal.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPersonal.Location = new System.Drawing.Point(361, 36);
            this.btnEditarPersonal.Name = "btnEditarPersonal";
            this.btnEditarPersonal.Size = new System.Drawing.Size(172, 57);
            this.btnEditarPersonal.TabIndex = 6;
            this.btnEditarPersonal.Text = "Editar Personal";
            this.btnEditarPersonal.UseVisualStyleBackColor = true;
            // 
            // btnBaja
            // 
            this.btnBaja.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaja.Location = new System.Drawing.Point(612, 36);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(153, 57);
            this.btnBaja.TabIndex = 7;
            this.btnBaja.Text = "Dar de Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocumentos.Location = new System.Drawing.Point(831, 36);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Size = new System.Drawing.Size(172, 57);
            this.btnDocumentos.TabIndex = 8;
            this.btnDocumentos.Text = "Historial Documentos";
            this.btnDocumentos.UseVisualStyleBackColor = true;
            this.btnDocumentos.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridPersonal
            // 
            this.dataGridPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPersonal.Location = new System.Drawing.Point(33, 88);
            this.dataGridPersonal.Name = "dataGridPersonal";
            this.dataGridPersonal.RowHeadersWidth = 51;
            this.dataGridPersonal.RowTemplate.Height = 24;
            this.dataGridPersonal.Size = new System.Drawing.Size(1093, 313);
            this.dataGridPersonal.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevoPersonal);
            this.groupBox1.Controls.Add(this.btnEditarPersonal);
            this.groupBox1.Controls.Add(this.btnDocumentos);
            this.groupBox1.Controls.Add(this.btnBaja);
            this.groupBox1.Location = new System.Drawing.Point(33, 463);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1061, 117);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 592);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridPersonal);
            this.Controls.Add(this.lbOpciones);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.btnDni);
            this.Controls.Add(this.button1);
            this.Name = "Personal";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersonal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDni;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Label lbOpciones;
        private System.Windows.Forms.Button btnNuevoPersonal;
        private System.Windows.Forms.Button btnEditarPersonal;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnDocumentos;
        private System.Windows.Forms.DataGridView dataGridPersonal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}