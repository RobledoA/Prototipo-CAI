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
            lsvAereos = new ListView();
            hdCodVuelo = new ColumnHeader();
            hdDestino = new ColumnHeader();
            hdFechaSalida = new ColumnHeader();
            hdFechaLlegada = new ColumnHeader();
            hdOrigen = new ColumnHeader();
            hdTiempoVuelo = new ColumnHeader();
            hdAerolinea = new ColumnHeader();
            grpAereos = new GroupBox();
            btnLimpiarFiltros = new Button();
            lblTipoPasajeroAereos = new Label();
            cmbTipoPasajeroAereos = new ComboBox();
            cmbClaseAereos = new ComboBox();
            lblClaseAereos = new Label();
            btnBuscarAereos = new Button();
            lblFechaIdaAereos = new Label();
            dtFechaDesdeAereos = new DateTimePicker();
            lblDestinoAereos = new Label();
            txtDestinoAereos = new TextBox();
            lblOrigenAereos = new Label();
            txtOrigenAereos = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnAgregarItinerarioAereos = new Button();
            lblItinerarioActivo = new Label();
            lblAereosDisponibles = new Label();
            lblAereoEnItinerario = new Label();
            lsvItinerarioAereos = new ListView();
            btnQuitarItinerarioAereos = new Button();
            grpAereos.SuspendLayout();
            SuspendLayout();
            // 
            // lsvAereos
            // 
            lsvAereos.Columns.AddRange(new ColumnHeader[] { hdCodVuelo, hdDestino, hdFechaSalida, hdFechaLlegada, hdOrigen, hdTiempoVuelo, hdAerolinea });
            lsvAereos.FullRowSelect = true;
            lsvAereos.Location = new Point(10, 40);
            lsvAereos.MultiSelect = false;
            lsvAereos.Name = "lsvAereos";
            lsvAereos.Size = new Size(459, 228);
            lsvAereos.TabIndex = 0;
            lsvAereos.UseCompatibleStateImageBehavior = false;
            lsvAereos.View = View.Details;
            // 
            // hdCodVuelo
            // 
            hdCodVuelo.Text = "Cod. Vuelo";
            hdCodVuelo.Width = 70;
            // 
            // hdDestino
            // 
            hdDestino.Text = "Destino";
            hdDestino.Width = 52;
            // 
            // hdFechaSalida
            // 
            hdFechaSalida.Text = "Fecha Salida";
            hdFechaSalida.Width = 77;
            // 
            // hdFechaLlegada
            // 
            hdFechaLlegada.Text = "Fecha Llegada";
            hdFechaLlegada.Width = 87;
            // 
            // hdOrigen
            // 
            hdOrigen.Text = "Origen";
            hdOrigen.Width = 48;
            // 
            // hdTiempoVuelo
            // 
            hdTiempoVuelo.Text = "Tiempo Vuelo";
            hdTiempoVuelo.Width = 85;
            // 
            // hdAerolinea
            // 
            hdAerolinea.Text = "Aerolinea";
            // 
            // grpAereos
            // 
            grpAereos.Controls.Add(btnLimpiarFiltros);
            grpAereos.Controls.Add(lblTipoPasajeroAereos);
            grpAereos.Controls.Add(cmbTipoPasajeroAereos);
            grpAereos.Controls.Add(cmbClaseAereos);
            grpAereos.Controls.Add(lblClaseAereos);
            grpAereos.Controls.Add(btnBuscarAereos);
            grpAereos.Controls.Add(lblFechaIdaAereos);
            grpAereos.Controls.Add(dtFechaDesdeAereos);
            grpAereos.Controls.Add(lblDestinoAereos);
            grpAereos.Controls.Add(txtDestinoAereos);
            grpAereos.Controls.Add(lblOrigenAereos);
            grpAereos.Controls.Add(txtOrigenAereos);
            grpAereos.Location = new Point(10, 274);
            grpAereos.Name = "grpAereos";
            grpAereos.Size = new Size(1057, 116);
            grpAereos.TabIndex = 11;
            grpAereos.TabStop = false;
            grpAereos.Text = "Opciones de Búsqueda";
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.Location = new Point(949, 20);
            btnLimpiarFiltros.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(102, 26);
            btnLimpiarFiltros.TabIndex = 30;
            btnLimpiarFiltros.Text = "\U0001f9f9";
            btnLimpiarFiltros.UseVisualStyleBackColor = true;
            // 
            // lblTipoPasajeroAereos
            // 
            lblTipoPasajeroAereos.AutoSize = true;
            lblTipoPasajeroAereos.Location = new Point(647, 29);
            lblTipoPasajeroAereos.Name = "lblTipoPasajeroAereos";
            lblTipoPasajeroAereos.Size = new Size(77, 15);
            lblTipoPasajeroAereos.TabIndex = 29;
            lblTipoPasajeroAereos.Text = "Tipo Pasajero";
            // 
            // cmbTipoPasajeroAereos
            // 
            cmbTipoPasajeroAereos.FormattingEnabled = true;
            cmbTipoPasajeroAereos.Location = new Point(647, 47);
            cmbTipoPasajeroAereos.Name = "cmbTipoPasajeroAereos";
            cmbTipoPasajeroAereos.Size = new Size(162, 23);
            cmbTipoPasajeroAereos.TabIndex = 28;
            // 
            // cmbClaseAereos
            // 
            cmbClaseAereos.FormattingEnabled = true;
            cmbClaseAereos.Location = new Point(843, 47);
            cmbClaseAereos.Name = "cmbClaseAereos";
            cmbClaseAereos.Size = new Size(162, 23);
            cmbClaseAereos.TabIndex = 27;
            // 
            // lblClaseAereos
            // 
            lblClaseAereos.AutoSize = true;
            lblClaseAereos.Location = new Point(843, 29);
            lblClaseAereos.Name = "lblClaseAereos";
            lblClaseAereos.Size = new Size(35, 15);
            lblClaseAereos.TabIndex = 26;
            lblClaseAereos.Text = "Clase";
            // 
            // btnBuscarAereos
            // 
            btnBuscarAereos.Location = new Point(955, 74);
            btnBuscarAereos.Margin = new Padding(3, 2, 3, 2);
            btnBuscarAereos.Name = "btnBuscarAereos";
            btnBuscarAereos.Size = new Size(102, 26);
            btnBuscarAereos.TabIndex = 14;
            btnBuscarAereos.Text = "🔍";
            btnBuscarAereos.UseVisualStyleBackColor = true;
            // 
            // lblFechaIdaAereos
            // 
            lblFechaIdaAereos.AutoSize = true;
            lblFechaIdaAereos.Location = new Point(424, 29);
            lblFechaIdaAereos.Name = "lblFechaIdaAereos";
            lblFechaIdaAereos.Size = new Size(57, 15);
            lblFechaIdaAereos.TabIndex = 7;
            lblFechaIdaAereos.Text = "Fecha Ida";
            // 
            // dtFechaDesdeAereos
            // 
            dtFechaDesdeAereos.Location = new Point(424, 47);
            dtFechaDesdeAereos.Name = "dtFechaDesdeAereos";
            dtFechaDesdeAereos.Size = new Size(185, 23);
            dtFechaDesdeAereos.TabIndex = 6;
            // 
            // lblDestinoAereos
            // 
            lblDestinoAereos.AutoSize = true;
            lblDestinoAereos.Location = new Point(227, 29);
            lblDestinoAereos.Name = "lblDestinoAereos";
            lblDestinoAereos.Size = new Size(47, 15);
            lblDestinoAereos.TabIndex = 5;
            lblDestinoAereos.Text = "Destino";
            // 
            // txtDestinoAereos
            // 
            txtDestinoAereos.Location = new Point(227, 47);
            txtDestinoAereos.Name = "txtDestinoAereos";
            txtDestinoAereos.Size = new Size(162, 23);
            txtDestinoAereos.TabIndex = 4;
            // 
            // lblOrigenAereos
            // 
            lblOrigenAereos.AutoSize = true;
            lblOrigenAereos.Location = new Point(26, 29);
            lblOrigenAereos.Name = "lblOrigenAereos";
            lblOrigenAereos.Size = new Size(43, 15);
            lblOrigenAereos.TabIndex = 3;
            lblOrigenAereos.Text = "Origen";
            // 
            // txtOrigenAereos
            // 
            txtOrigenAereos.Location = new Point(26, 47);
            txtOrigenAereos.Name = "txtOrigenAereos";
            txtOrigenAereos.Size = new Size(162, 23);
            txtOrigenAereos.TabIndex = 2;
            // 
            // btnAgregarItinerarioAereos
            // 
            btnAgregarItinerarioAereos.Location = new Point(489, 67);
            btnAgregarItinerarioAereos.Name = "btnAgregarItinerarioAereos";
            btnAgregarItinerarioAereos.Size = new Size(102, 26);
            btnAgregarItinerarioAereos.TabIndex = 7;
            btnAgregarItinerarioAereos.Text = "Agregar >>>";
            btnAgregarItinerarioAereos.UseVisualStyleBackColor = true;
            // 
            // lblItinerarioActivo
            // 
            lblItinerarioActivo.Location = new Point(867, 11);
            lblItinerarioActivo.Name = "lblItinerarioActivo";
            lblItinerarioActivo.RightToLeft = RightToLeft.Yes;
            lblItinerarioActivo.Size = new Size(120, 25);
            lblItinerarioActivo.TabIndex = 18;
            lblItinerarioActivo.Text = "itinerario datos";
            // 
            // lblAereosDisponibles
            // 
            lblAereosDisponibles.AutoSize = true;
            lblAereosDisponibles.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAereosDisponibles.Location = new Point(10, 7);
            lblAereosDisponibles.Name = "lblAereosDisponibles";
            lblAereosDisponibles.Size = new Size(120, 30);
            lblAereosDisponibles.TabIndex = 17;
            lblAereosDisponibles.Text = "Disponibles";
            // 
            // lblAereoEnItinerario
            // 
            lblAereoEnItinerario.AutoSize = true;
            lblAereoEnItinerario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAereoEnItinerario.Location = new Point(610, 7);
            lblAereoEnItinerario.Name = "lblAereoEnItinerario";
            lblAereoEnItinerario.Size = new Size(146, 30);
            lblAereoEnItinerario.TabIndex = 20;
            lblAereoEnItinerario.Text = "En el itinerario";
            // 
            // lsvItinerarioAereos
            // 
            lsvItinerarioAereos.FullRowSelect = true;
            lsvItinerarioAereos.Location = new Point(610, 40);
            lsvItinerarioAereos.MultiSelect = false;
            lsvItinerarioAereos.Name = "lsvItinerarioAereos";
            lsvItinerarioAereos.Size = new Size(459, 228);
            lsvItinerarioAereos.TabIndex = 19;
            lsvItinerarioAereos.UseCompatibleStateImageBehavior = false;
            lsvItinerarioAereos.View = View.Details;
            // 
            // btnQuitarItinerarioAereos
            // 
            btnQuitarItinerarioAereos.Location = new Point(489, 218);
            btnQuitarItinerarioAereos.Name = "btnQuitarItinerarioAereos";
            btnQuitarItinerarioAereos.Size = new Size(102, 26);
            btnQuitarItinerarioAereos.TabIndex = 21;
            btnQuitarItinerarioAereos.Text = "<<< Quitar";
            btnQuitarItinerarioAereos.UseVisualStyleBackColor = true;
            // 
            // Aereos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 394);
            Controls.Add(btnQuitarItinerarioAereos);
            Controls.Add(lblAereoEnItinerario);
            Controls.Add(lsvItinerarioAereos);
            Controls.Add(lblItinerarioActivo);
            Controls.Add(lblAereosDisponibles);
            Controls.Add(grpAereos);
            Controls.Add(btnAgregarItinerarioAereos);
            Controls.Add(lsvAereos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Aereos";
            Text = "Aéreos Disponibles";
            Load += Aereos_Load;
            grpAereos.ResumeLayout(false);
            grpAereos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvProductosDisponibles;
        private Button btnDetalles;
        private GroupBox grpAereos;
        private Label lblFechaIdaAereos;
        private DateTimePicker dtFechaDesdeAereos;
        private Label lblDestinoAereos;
        private TextBox txtDestinoAereos;
        private Label lblOrigenAereos;
        private TextBox txtOrigenAereos;
        private Button btnBuscarAereos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListView lsvAereos;
        private Label lblTipoPasajeroAereos;
        private ComboBox cmbTipoPasajeroAereos;
        private ComboBox cmbClaseAereos;
        private Label lblClaseAereos;
        private Button btnAgregarItinerarioAereos;
        private Label lblItinerarioActivo;
        private Label lblAereosDisponibles;
        private Label lblAereoEnItinerario;
        private ListView lsvItinerarioAereos;
        private Button btnQuitarItinerarioAereos;
        private Button btnLimpiarFiltros;
        private ColumnHeader hdCodVuelo;
        private ColumnHeader hdDestino;
        private ColumnHeader hdFechaSalida;
        private ColumnHeader hdFechaLlegada;
        private ColumnHeader hdOrigen;
        private ColumnHeader hdTiempoVuelo;
        private ColumnHeader hdAerolinea;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}