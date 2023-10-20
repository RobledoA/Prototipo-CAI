namespace Prototipo_CAI
{
    partial class Aereos
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
            ComboBox comboBox4;
            lsvAereos = new ListView();
            btnDetalles = new Button();
            btnCrearItinerario = new Button();
            button3 = new Button();
            grpAereos = new GroupBox();
            chkIdaVuelta = new CheckBox();
            btnBuscarAereos = new Button();
            label6 = new Label();
            txtPasajeros = new TextBox();
            label5 = new Label();
            dtpFechaVuelta = new DateTimePicker();
            label2 = new Label();
            dtFechaDesde = new DateTimePicker();
            label4 = new Label();
            txtDestino = new TextBox();
            label3 = new Label();
            txtOrigen = new TextBox();
            grpAgregarVuelos = new GroupBox();
            lblinfantes = new Label();
            comboBox6 = new ComboBox();
            lblMenores = new Label();
            comboBox5 = new ComboBox();
            label13 = new Label();
            lblContadorasientos = new Label();
            label15 = new Label();
            label17 = new Label();
            label14 = new Label();
            button4 = new Button();
            comboBox3 = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpTarifa = new GroupBox();
            lsvTarifas = new ListView();
            hdCodProd = new ColumnHeader();
            hdTipoProducto = new ColumnHeader();
            hdTarifa = new ColumnHeader();
            lbTitleProdDisponibles = new Label();
            comboBox4 = new ComboBox();
            grpAereos.SuspendLayout();
            grpAgregarVuelos.SuspendLayout();
            grpTarifa.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox4
            // 
            comboBox4.Cursor = Cursors.Hand;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(15, 153);
            comboBox4.Margin = new Padding(3, 4, 3, 4);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(223, 28);
            comboBox4.TabIndex = 24;
            // 
            // lsvAereos
            // 
            lsvAereos.FullRowSelect = true;
            lsvAereos.Location = new Point(14, 79);
            lsvAereos.Margin = new Padding(3, 4, 3, 4);
            lsvAereos.MultiSelect = false;
            lsvAereos.Name = "lsvAereos";
            lsvAereos.Size = new Size(1118, 303);
            lsvAereos.TabIndex = 0;
            lsvAereos.UseCompatibleStateImageBehavior = false;
            lsvAereos.View = View.Details;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(14, 391);
            btnDetalles.Margin = new Padding(3, 4, 3, 4);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(86, 31);
            btnDetalles.TabIndex = 6;
            btnDetalles.Text = "Ver Detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // btnCrearItinerario
            // 
            btnCrearItinerario.Location = new Point(1133, 748);
            btnCrearItinerario.Margin = new Padding(3, 4, 3, 4);
            btnCrearItinerario.Name = "btnCrearItinerario";
            btnCrearItinerario.Size = new Size(131, 35);
            btnCrearItinerario.TabIndex = 7;
            btnCrearItinerario.Text = "Crear Itinerario";
            btnCrearItinerario.UseVisualStyleBackColor = true;
            btnCrearItinerario.Click += btnCrearItinerario_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1139, 320);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(131, 63);
            button3.TabIndex = 9;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // grpAereos
            // 
            grpAereos.Controls.Add(chkIdaVuelta);
            grpAereos.Controls.Add(btnBuscarAereos);
            grpAereos.Controls.Add(label6);
            grpAereos.Controls.Add(txtPasajeros);
            grpAereos.Controls.Add(label5);
            grpAereos.Controls.Add(dtpFechaVuelta);
            grpAereos.Controls.Add(label2);
            grpAereos.Controls.Add(dtFechaDesde);
            grpAereos.Controls.Add(label4);
            grpAereos.Controls.Add(txtDestino);
            grpAereos.Controls.Add(label3);
            grpAereos.Controls.Add(txtOrigen);
            grpAereos.Location = new Point(25, 441);
            grpAereos.Margin = new Padding(3, 4, 3, 4);
            grpAereos.Name = "grpAereos";
            grpAereos.Padding = new Padding(3, 4, 3, 4);
            grpAereos.Size = new Size(545, 280);
            grpAereos.TabIndex = 11;
            grpAereos.TabStop = false;
            grpAereos.Text = "Opciones de Búsqueda";
            // 
            // chkIdaVuelta
            // 
            chkIdaVuelta.AutoSize = true;
            chkIdaVuelta.Location = new Point(41, 240);
            chkIdaVuelta.Margin = new Padding(3, 4, 3, 4);
            chkIdaVuelta.Name = "chkIdaVuelta";
            chkIdaVuelta.Size = new Size(109, 24);
            chkIdaVuelta.TabIndex = 24;
            chkIdaVuelta.Text = "Ida y Vuelta";
            chkIdaVuelta.UseVisualStyleBackColor = true;
            chkIdaVuelta.CheckedChanged += chkIdaVuelta_CheckedChanged;
            // 
            // btnBuscarAereos
            // 
            btnBuscarAereos.Location = new Point(277, 200);
            btnBuscarAereos.Name = "btnBuscarAereos";
            btnBuscarAereos.Size = new Size(35, 41);
            btnBuscarAereos.TabIndex = 14;
            btnBuscarAereos.Text = "🔍";
            btnBuscarAereos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 181);
            label6.Name = "label6";
            label6.Size = new Size(155, 20);
            label6.TabIndex = 11;
            label6.Text = "Cantidad de Pasajeros";
            // 
            // txtPasajeros
            // 
            txtPasajeros.Location = new Point(40, 205);
            txtPasajeros.Margin = new Padding(3, 4, 3, 4);
            txtPasajeros.Name = "txtPasajeros";
            txtPasajeros.Size = new Size(228, 27);
            txtPasajeros.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(286, 115);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(93, 20);
            label5.TabIndex = 9;
            label5.Text = "Fecha Vuelta";
            // 
            // dtpFechaVuelta
            // 
            dtpFechaVuelta.Location = new Point(287, 139);
            dtpFechaVuelta.Margin = new Padding(3, 4, 3, 4);
            dtpFechaVuelta.Name = "dtpFechaVuelta";
            dtpFechaVuelta.RightToLeft = RightToLeft.Yes;
            dtpFechaVuelta.Size = new Size(228, 27);
            dtpFechaVuelta.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 115);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 7;
            label2.Text = "Fecha Ida";
            // 
            // dtFechaDesde
            // 
            dtFechaDesde.Location = new Point(40, 139);
            dtFechaDesde.Margin = new Padding(3, 4, 3, 4);
            dtFechaDesde.Name = "dtFechaDesde";
            dtFechaDesde.Size = new Size(228, 27);
            dtFechaDesde.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 49);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 5;
            label4.Text = "Destino";
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(287, 73);
            txtDestino.Margin = new Padding(3, 4, 3, 4);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(228, 27);
            txtDestino.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 49);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 3;
            label3.Text = "Origen";
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(41, 73);
            txtOrigen.Margin = new Padding(3, 4, 3, 4);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(227, 27);
            txtOrigen.TabIndex = 2;
            // 
            // grpAgregarVuelos
            // 
            grpAgregarVuelos.Controls.Add(lblinfantes);
            grpAgregarVuelos.Controls.Add(comboBox6);
            grpAgregarVuelos.Controls.Add(lblMenores);
            grpAgregarVuelos.Controls.Add(comboBox5);
            grpAgregarVuelos.Controls.Add(label13);
            grpAgregarVuelos.Controls.Add(comboBox4);
            grpAgregarVuelos.Controls.Add(lblContadorasientos);
            grpAgregarVuelos.Controls.Add(label15);
            grpAgregarVuelos.Controls.Add(label17);
            grpAgregarVuelos.Controls.Add(label14);
            grpAgregarVuelos.Controls.Add(button4);
            grpAgregarVuelos.Controls.Add(comboBox3);
            grpAgregarVuelos.Location = new Point(576, 428);
            grpAgregarVuelos.Name = "grpAgregarVuelos";
            grpAgregarVuelos.Size = new Size(256, 376);
            grpAgregarVuelos.TabIndex = 15;
            grpAgregarVuelos.TabStop = false;
            grpAgregarVuelos.Text = "Carrito";
            grpAgregarVuelos.Enter += grpAgregarVuelos_Enter;
            // 
            // lblinfantes
            // 
            lblinfantes.AutoSize = true;
            lblinfantes.Location = new Point(15, 256);
            lblinfantes.Name = "lblinfantes";
            lblinfantes.Size = new Size(61, 20);
            lblinfantes.TabIndex = 29;
            lblinfantes.Text = "Infantes";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(15, 281);
            comboBox6.Margin = new Padding(3, 4, 3, 4);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(223, 28);
            comboBox6.TabIndex = 28;
            // 
            // lblMenores
            // 
            lblMenores.AutoSize = true;
            lblMenores.Location = new Point(15, 193);
            lblMenores.Name = "lblMenores";
            lblMenores.Size = new Size(66, 20);
            lblMenores.TabIndex = 27;
            lblMenores.Text = "Menores";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(15, 219);
            comboBox5.Margin = new Padding(3, 4, 3, 4);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(223, 28);
            comboBox5.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 128);
            label13.Name = "label13";
            label13.Size = new Size(65, 20);
            label13.TabIndex = 25;
            label13.Text = "Mayores";
            // 
            // lblContadorasientos
            // 
            lblContadorasientos.AutoSize = true;
            lblContadorasientos.Location = new Point(143, 100);
            lblContadorasientos.Name = "lblContadorasientos";
            lblContadorasientos.Size = new Size(17, 20);
            lblContadorasientos.TabIndex = 23;
            lblContadorasientos.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(15, 111);
            label15.Name = "label15";
            label15.Size = new Size(0, 20);
            label15.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(11, 99);
            label17.Name = "label17";
            label17.Size = new Size(150, 20);
            label17.TabIndex = 22;
            label17.Text = "Asientos Disponibles:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 39);
            label14.Name = "label14";
            label14.Size = new Size(50, 20);
            label14.TabIndex = 23;
            label14.Text = "Clases";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(15, 324);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(224, 35);
            button4.TabIndex = 13;
            button4.Text = "Agregar al Carrito \U0001f6d2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Economy", "Premium", "Business", "First" });
            comboBox3.Location = new Point(15, 64);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(223, 28);
            comboBox3.TabIndex = 22;
            // 
            // grpTarifa
            // 
            grpTarifa.Controls.Add(lsvTarifas);
            grpTarifa.Location = new Point(850, 438);
            grpTarifa.Margin = new Padding(3, 4, 3, 4);
            grpTarifa.Name = "grpTarifa";
            grpTarifa.Padding = new Padding(3, 4, 3, 4);
            grpTarifa.Size = new Size(431, 299);
            grpTarifa.TabIndex = 16;
            grpTarifa.TabStop = false;
            grpTarifa.Text = "Tarifas";
            // 
            // lsvTarifas
            // 
            lsvTarifas.Columns.AddRange(new ColumnHeader[] { hdCodProd, hdTipoProducto, hdTarifa });
            lsvTarifas.Location = new Point(6, 39);
            lsvTarifas.Margin = new Padding(3, 4, 3, 4);
            lsvTarifas.Name = "lsvTarifas";
            lsvTarifas.Size = new Size(419, 240);
            lsvTarifas.TabIndex = 0;
            lsvTarifas.UseCompatibleStateImageBehavior = false;
            lsvTarifas.View = View.Details;
            // 
            // hdCodProd
            // 
            hdCodProd.Text = "Código Producto";
            hdCodProd.Width = 150;
            // 
            // hdTipoProducto
            // 
            hdTipoProducto.Text = "Producto";
            hdTipoProducto.Width = 120;
            // 
            // hdTarifa
            // 
            hdTarifa.Text = "Tarifa";
            hdTarifa.Width = 120;
            // 
            // lbTitleProdDisponibles
            // 
            lbTitleProdDisponibles.AutoSize = true;
            lbTitleProdDisponibles.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitleProdDisponibles.Location = new Point(14, 20);
            lbTitleProdDisponibles.Name = "lbTitleProdDisponibles";
            lbTitleProdDisponibles.Size = new Size(98, 37);
            lbTitleProdDisponibles.TabIndex = 17;
            lbTitleProdDisponibles.Text = "Aéreos";
            // 
            // Aereos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 840);
            Controls.Add(lbTitleProdDisponibles);
            Controls.Add(grpTarifa);
            Controls.Add(grpAgregarVuelos);
            Controls.Add(grpAereos);
            Controls.Add(button3);
            Controls.Add(btnCrearItinerario);
            Controls.Add(btnDetalles);
            Controls.Add(lsvAereos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Aereos";
            Text = "Productos Disponibles";
            Load += Aereos_Load;
            grpAereos.ResumeLayout(false);
            grpAereos.PerformLayout();
            grpAgregarVuelos.ResumeLayout(false);
            grpAgregarVuelos.PerformLayout();
            grpTarifa.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvProductosDisponibles;
        private Button btnDetalles;
        private Button btnCrearItinerario;
        private Button button3;
        private GroupBox grpAereos;
        private Label label5;
        private DateTimePicker dtpFechaVuelta;
        private Label label2;
        private DateTimePicker dtFechaDesde;
        private Label label4;
        private TextBox txtDestino;
        private Label label3;
        private TextBox txtOrigen;
        private Label label6;
        private TextBox txtPasajeros;
        private Button btnBuscarAereos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grpAgregarVuelos;
        private Button button4;
        private Label label14;
        private ComboBox comboBox3;
        private Label label15;
        private Label lblContadorasientos;
        private Label label17;
        private CheckBox chkIdaVuelta;
        private Label label13;
        private ComboBox comboBox4;
        private Label lblMenores;
        private ComboBox comboBox5;
        private Label lblinfantes;
        private ComboBox comboBox6;
        private GroupBox grpTarifa;
        private ListView lsvTarifas;
        private ColumnHeader hdCodProd;
        private Label lbTitleProdDisponibles;
        private ColumnHeader hdTipoProducto;
        private ColumnHeader hdTarifa;
        private ListView lsvAereos;
    }
}