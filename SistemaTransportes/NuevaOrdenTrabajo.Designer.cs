namespace SistemaTransportes
{
    partial class NuevaOrdenTrabajo
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.txtChofer = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.lblChofer = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClienteOS = new System.Windows.Forms.TextBox();
            this.lblClienteAut = new System.Windows.Forms.Label();
            this.txtClienteAut = new System.Windows.Forms.TextBox();
            this.lblClienteOS = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblFlete = new System.Windows.Forms.Label();
            this.txtFlete = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.lblActasPoliciales = new System.Windows.Forms.Label();
            this.lblIGV = new System.Windows.Forms.Label();
            this.txtActasPoliciales = new System.Windows.Forms.TextBox();
            this.txtMontoIGV = new System.Windows.Forms.TextBox();
            this.lblAyudaCarga = new System.Windows.Forms.Label();
            this.lblMontoIGV = new System.Windows.Forms.Label();
            this.txtAyudaCarga = new System.Windows.Forms.TextBox();
            this.txtRetor = new System.Windows.Forms.TextBox();
            this.lblRetor = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCambiarFlete = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminarGRT = new System.Windows.Forms.Button();
            this.btnAgregarGRT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(37, 44);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 24);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(37, 79);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(72, 24);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(37, 119);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(85, 24);
            this.lblVehiculo.TabIndex = 3;
            this.lblVehiculo.Text = "Vehículo";
            this.lblVehiculo.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(128, 83);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(548, 22);
            this.txtCliente.TabIndex = 5;
            this.txtCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Location = new System.Drawing.Point(128, 123);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(548, 22);
            this.txtVehiculo.TabIndex = 6;
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(128, 238);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(548, 22);
            this.txtRuta.TabIndex = 11;
            // 
            // txtChofer
            // 
            this.txtChofer.Location = new System.Drawing.Point(128, 198);
            this.txtChofer.Name = "txtChofer";
            this.txtChofer.Size = new System.Drawing.Size(548, 22);
            this.txtChofer.TabIndex = 10;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(37, 234);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(51, 24);
            this.lblRuta.TabIndex = 9;
            this.lblRuta.Text = "Ruta";
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChofer.Location = new System.Drawing.Point(37, 198);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(68, 24);
            this.lblChofer.TabIndex = 8;
            this.lblChofer.Text = "Chofer";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(184, 275);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(117, 22);
            this.txtDistancia.TabIndex = 13;
            this.txtDistancia.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(37, 271);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(141, 24);
            this.lblDistancia.TabIndex = 12;
            this.lblDistancia.Text = "Distancia (km)";
            this.lblDistancia.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(128, 312);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(681, 131);
            this.txtDetalle.TabIndex = 14;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(37, 312);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(81, 24);
            this.lblDetalle.TabIndex = 15;
            this.lblDetalle.Text = "Detalle:";
            this.lblDetalle.Click += new System.EventHandler(this.label9_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(854, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(472, 430);
            this.dataGridView1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClienteOS);
            this.groupBox1.Controls.Add(this.lblClienteAut);
            this.groupBox1.Controls.Add(this.txtClienteAut);
            this.groupBox1.Controls.Add(this.lblClienteOS);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 527);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Orden de Trabajo";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtClienteOS
            // 
            this.txtClienteOS.Location = new System.Drawing.Point(146, 487);
            this.txtClienteOS.Name = "txtClienteOS";
            this.txtClienteOS.Size = new System.Drawing.Size(120, 28);
            this.txtClienteOS.TabIndex = 21;
            this.txtClienteOS.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lblClienteAut
            // 
            this.lblClienteAut.AutoSize = true;
            this.lblClienteAut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteAut.Location = new System.Drawing.Point(31, 447);
            this.lblClienteAut.Name = "lblClienteAut";
            this.lblClienteAut.Size = new System.Drawing.Size(108, 24);
            this.lblClienteAut.TabIndex = 18;
            this.lblClienteAut.Text = "Cliente Aut";
            this.lblClienteAut.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtClienteAut
            // 
            this.txtClienteAut.Location = new System.Drawing.Point(145, 451);
            this.txtClienteAut.Name = "txtClienteAut";
            this.txtClienteAut.Size = new System.Drawing.Size(121, 28);
            this.txtClienteAut.TabIndex = 20;
            this.txtClienteAut.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // lblClienteOS
            // 
            this.lblClienteOS.AutoSize = true;
            this.lblClienteOS.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteOS.Location = new System.Drawing.Point(31, 483);
            this.lblClienteOS.Name = "lblClienteOS";
            this.lblClienteOS.Size = new System.Drawing.Size(109, 24);
            this.lblClienteOS.TabIndex = 19;
            this.lblClienteOS.Text = "Cliente O.S";
            this.lblClienteOS.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCambiarFlete);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.txtRetor);
            this.groupBox2.Controls.Add(this.lblRetor);
            this.groupBox2.Controls.Add(this.txtMontoIGV);
            this.groupBox2.Controls.Add(this.lblAyudaCarga);
            this.groupBox2.Controls.Add(this.lblMontoIGV);
            this.groupBox2.Controls.Add(this.txtAyudaCarga);
            this.groupBox2.Controls.Add(this.txtIGV);
            this.groupBox2.Controls.Add(this.lblActasPoliciales);
            this.groupBox2.Controls.Add(this.lblIGV);
            this.groupBox2.Controls.Add(this.txtActasPoliciales);
            this.groupBox2.Controls.Add(this.txtSubTotal);
            this.groupBox2.Controls.Add(this.lblFlete);
            this.groupBox2.Controls.Add(this.lblSubTotal);
            this.groupBox2.Controls.Add(this.txtFlete);
            this.groupBox2.Location = new System.Drawing.Point(7, 545);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(919, 132);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Serie y Nº";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tramo";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(110, 61);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(120, 22);
            this.txtSubTotal.TabIndex = 25;
            // 
            // lblFlete
            // 
            this.lblFlete.AutoSize = true;
            this.lblFlete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlete.Location = new System.Drawing.Point(12, 19);
            this.lblFlete.Name = "lblFlete";
            this.lblFlete.Size = new System.Drawing.Size(54, 24);
            this.lblFlete.TabIndex = 22;
            this.lblFlete.Text = "Flete";
            // 
            // txtFlete
            // 
            this.txtFlete.Location = new System.Drawing.Point(110, 23);
            this.txtFlete.Name = "txtFlete";
            this.txtFlete.Size = new System.Drawing.Size(121, 22);
            this.txtFlete.TabIndex = 24;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(12, 55);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(95, 24);
            this.lblSubTotal.TabIndex = 23;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Especificación del Servicio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtIGV
            // 
            this.txtIGV.Location = new System.Drawing.Point(338, 57);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(120, 22);
            this.txtIGV.TabIndex = 29;
            // 
            // lblActasPoliciales
            // 
            this.lblActasPoliciales.AutoSize = true;
            this.lblActasPoliciales.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActasPoliciales.Location = new System.Drawing.Point(246, 18);
            this.lblActasPoliciales.Name = "lblActasPoliciales";
            this.lblActasPoliciales.Size = new System.Drawing.Size(146, 24);
            this.lblActasPoliciales.TabIndex = 26;
            this.lblActasPoliciales.Text = "Actas Policiales";
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGV.Location = new System.Drawing.Point(246, 54);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(86, 24);
            this.lblIGV.TabIndex = 27;
            this.lblIGV.Text = "% I.G.V.";
            // 
            // txtActasPoliciales
            // 
            this.txtActasPoliciales.Location = new System.Drawing.Point(398, 20);
            this.txtActasPoliciales.Name = "txtActasPoliciales";
            this.txtActasPoliciales.Size = new System.Drawing.Size(121, 22);
            this.txtActasPoliciales.TabIndex = 28;
            // 
            // txtMontoIGV
            // 
            this.txtMontoIGV.Location = new System.Drawing.Point(603, 61);
            this.txtMontoIGV.Name = "txtMontoIGV";
            this.txtMontoIGV.Size = new System.Drawing.Size(120, 22);
            this.txtMontoIGV.TabIndex = 33;
            // 
            // lblAyudaCarga
            // 
            this.lblAyudaCarga.AutoSize = true;
            this.lblAyudaCarga.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyudaCarga.Location = new System.Drawing.Point(540, 16);
            this.lblAyudaCarga.Name = "lblAyudaCarga";
            this.lblAyudaCarga.Size = new System.Drawing.Size(118, 24);
            this.lblAyudaCarga.TabIndex = 30;
            this.lblAyudaCarga.Text = "Ayud. Carga";
            this.lblAyudaCarga.Click += new System.EventHandler(this.label15_Click);
            // 
            // lblMontoIGV
            // 
            this.lblMontoIGV.AutoSize = true;
            this.lblMontoIGV.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoIGV.Location = new System.Drawing.Point(482, 59);
            this.lblMontoIGV.Name = "lblMontoIGV";
            this.lblMontoIGV.Size = new System.Drawing.Size(115, 24);
            this.lblMontoIGV.TabIndex = 31;
            this.lblMontoIGV.Text = "Monto I.G.V";
            this.lblMontoIGV.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtAyudaCarga
            // 
            this.txtAyudaCarga.Location = new System.Drawing.Point(664, 20);
            this.txtAyudaCarga.Name = "txtAyudaCarga";
            this.txtAyudaCarga.Size = new System.Drawing.Size(121, 22);
            this.txtAyudaCarga.TabIndex = 32;
            this.txtAyudaCarga.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // txtRetor
            // 
            this.txtRetor.Location = new System.Drawing.Point(340, 96);
            this.txtRetor.Name = "txtRetor";
            this.txtRetor.Size = new System.Drawing.Size(120, 22);
            this.txtRetor.TabIndex = 35;
            this.txtRetor.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // lblRetor
            // 
            this.lblRetor.AutoSize = true;
            this.lblRetor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetor.Location = new System.Drawing.Point(248, 93);
            this.lblRetor.Name = "lblRetor";
            this.lblRetor.Size = new System.Drawing.Size(84, 24);
            this.lblRetor.TabIndex = 34;
            this.lblRetor.Text = "% Retor";
            this.lblRetor.Click += new System.EventHandler(this.label17_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(603, 104);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(120, 22);
            this.txtTotal.TabIndex = 37;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(515, 93);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 36);
            this.lblTotal.TabIndex = 36;
            this.lblTotal.Text = "Total";
            // 
            // btnCambiarFlete
            // 
            this.btnCambiarFlete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarFlete.Location = new System.Drawing.Point(740, 71);
            this.btnCambiarFlete.Name = "btnCambiarFlete";
            this.btnCambiarFlete.Size = new System.Drawing.Size(162, 46);
            this.btnCambiarFlete.TabIndex = 38;
            this.btnCambiarFlete.Text = "Cambiar Flete";
            this.btnCambiarFlete.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(1128, 617);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(139, 46);
            this.btnBorrar.TabIndex = 39;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(983, 616);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(139, 46);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminarGRT);
            this.groupBox3.Controls.Add(this.btnAgregarGRT);
            this.groupBox3.Location = new System.Drawing.Point(844, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 507);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            // 
            // btnEliminarGRT
            // 
            this.btnEliminarGRT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGRT.Location = new System.Drawing.Point(267, 456);
            this.btnEliminarGRT.Name = "btnEliminarGRT";
            this.btnEliminarGRT.Size = new System.Drawing.Size(181, 38);
            this.btnEliminarGRT.TabIndex = 42;
            this.btnEliminarGRT.Text = "Eliminar G.R.T";
            this.btnEliminarGRT.UseVisualStyleBackColor = true;
            this.btnEliminarGRT.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAgregarGRT
            // 
            this.btnAgregarGRT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGRT.Location = new System.Drawing.Point(72, 456);
            this.btnAgregarGRT.Name = "btnAgregarGRT";
            this.btnAgregarGRT.Size = new System.Drawing.Size(162, 38);
            this.btnAgregarGRT.TabIndex = 43;
            this.btnAgregarGRT.Text = "Agregar G.R.T";
            this.btnAgregarGRT.UseVisualStyleBackColor = true;
            // 
            // NuevaOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 751);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.txtRuta);
            this.Controls.Add(this.txtChofer);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.lblChofer);
            this.Controls.Add(this.txtVehiculo);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "NuevaOrdenTrabajo";
            this.Text = "NuevaOrdenTrabajo";
            this.Load += new System.EventHandler(this.NuevaOrdenTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.TextBox txtChofer;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClienteOS;
        private System.Windows.Forms.TextBox txtClienteAut;
        private System.Windows.Forms.Label lblClienteOS;
        private System.Windows.Forms.Label lblClienteAut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblFlete;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtFlete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMontoIGV;
        private System.Windows.Forms.Label lblAyudaCarga;
        private System.Windows.Forms.Label lblMontoIGV;
        private System.Windows.Forms.TextBox txtAyudaCarga;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.Label lblActasPoliciales;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.TextBox txtActasPoliciales;
        private System.Windows.Forms.TextBox txtRetor;
        private System.Windows.Forms.Label lblRetor;
        private System.Windows.Forms.Button btnCambiarFlete;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminarGRT;
        private System.Windows.Forms.Button btnAgregarGRT;
    }
}