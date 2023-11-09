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
            lsvAereos.FullRowSelect = true;
            lsvAereos.Location = new Point(11, 53);
            lsvAereos.Margin = new Padding(3, 4, 3, 4);
            lsvAereos.MultiSelect = false;
            lsvAereos.Name = "lsvAereos";
            lsvAereos.Size = new Size(524, 303);
            lsvAereos.TabIndex = 0;
            lsvAereos.UseCompatibleStateImageBehavior = false;
            lsvAereos.View = View.Details;
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
            grpAereos.Location = new Point(11, 365);
            grpAereos.Margin = new Padding(3, 4, 3, 4);
            grpAereos.Name = "grpAereos";
            grpAereos.Padding = new Padding(3, 4, 3, 4);
            grpAereos.Size = new Size(1208, 154);
            grpAereos.TabIndex = 11;
            grpAereos.TabStop = false;
            grpAereos.Text = "Opciones de Búsqueda";
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.Location = new Point(1085, 27);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(117, 35);
            btnLimpiarFiltros.TabIndex = 30;
            btnLimpiarFiltros.Text = "\U0001f9f9";
            btnLimpiarFiltros.UseVisualStyleBackColor = true;
            // 
            // lblTipoPasajeroAereos
            // 
            lblTipoPasajeroAereos.AutoSize = true;
            lblTipoPasajeroAereos.Location = new Point(739, 39);
            lblTipoPasajeroAereos.Name = "lblTipoPasajeroAereos";
            lblTipoPasajeroAereos.Size = new Size(98, 20);
            lblTipoPasajeroAereos.TabIndex = 29;
            lblTipoPasajeroAereos.Text = "Tipo Pasajero";
            // 
            // cmbTipoPasajeroAereos
            // 
            cmbTipoPasajeroAereos.FormattingEnabled = true;
            cmbTipoPasajeroAereos.Location = new Point(739, 63);
            cmbTipoPasajeroAereos.Margin = new Padding(3, 4, 3, 4);
            cmbTipoPasajeroAereos.Name = "cmbTipoPasajeroAereos";
            cmbTipoPasajeroAereos.Size = new Size(184, 28);
            cmbTipoPasajeroAereos.TabIndex = 28;
            // 
            // cmbClaseAereos
            // 
            cmbClaseAereos.FormattingEnabled = true;
            cmbClaseAereos.Location = new Point(963, 63);
            cmbClaseAereos.Margin = new Padding(3, 4, 3, 4);
            cmbClaseAereos.Name = "cmbClaseAereos";
            cmbClaseAereos.Size = new Size(184, 28);
            cmbClaseAereos.TabIndex = 27;
            // 
            // lblClaseAereos
            // 
            lblClaseAereos.AutoSize = true;
            lblClaseAereos.Location = new Point(963, 39);
            lblClaseAereos.Name = "lblClaseAereos";
            lblClaseAereos.Size = new Size(44, 20);
            lblClaseAereos.TabIndex = 26;
            lblClaseAereos.Text = "Clase";
            // 
            // btnBuscarAereos
            // 
            btnBuscarAereos.Location = new Point(1091, 98);
            btnBuscarAereos.Name = "btnBuscarAereos";
            btnBuscarAereos.Size = new Size(117, 35);
            btnBuscarAereos.TabIndex = 14;
            btnBuscarAereos.Text = "🔍";
            btnBuscarAereos.UseVisualStyleBackColor = true;
            // 
            // lblFechaIdaAereos
            // 
            lblFechaIdaAereos.AutoSize = true;
            lblFechaIdaAereos.Location = new Point(484, 39);
            lblFechaIdaAereos.Name = "lblFechaIdaAereos";
            lblFechaIdaAereos.Size = new Size(72, 20);
            lblFechaIdaAereos.TabIndex = 7;
            lblFechaIdaAereos.Text = "Fecha Ida";
            // 
            // dtFechaDesdeAereos
            // 
            dtFechaDesdeAereos.Location = new Point(484, 63);
            dtFechaDesdeAereos.Margin = new Padding(3, 4, 3, 4);
            dtFechaDesdeAereos.Name = "dtFechaDesdeAereos";
            dtFechaDesdeAereos.Size = new Size(211, 27);
            dtFechaDesdeAereos.TabIndex = 6;
            // 
            // lblDestinoAereos
            // 
            lblDestinoAereos.AutoSize = true;
            lblDestinoAereos.Location = new Point(259, 39);
            lblDestinoAereos.Name = "lblDestinoAereos";
            lblDestinoAereos.Size = new Size(60, 20);
            lblDestinoAereos.TabIndex = 5;
            lblDestinoAereos.Text = "Destino";
            // 
            // txtDestinoAereos
            // 
            txtDestinoAereos.Location = new Point(259, 63);
            txtDestinoAereos.Margin = new Padding(3, 4, 3, 4);
            txtDestinoAereos.Name = "txtDestinoAereos";
            txtDestinoAereos.Size = new Size(184, 27);
            txtDestinoAereos.TabIndex = 4;
            // 
            // lblOrigenAereos
            // 
            lblOrigenAereos.AutoSize = true;
            lblOrigenAereos.Location = new Point(30, 39);
            lblOrigenAereos.Name = "lblOrigenAereos";
            lblOrigenAereos.Size = new Size(54, 20);
            lblOrigenAereos.TabIndex = 3;
            lblOrigenAereos.Text = "Origen";
            // 
            // txtOrigenAereos
            // 
            txtOrigenAereos.Location = new Point(30, 63);
            txtOrigenAereos.Margin = new Padding(3, 4, 3, 4);
            txtOrigenAereos.Name = "txtOrigenAereos";
            txtOrigenAereos.Size = new Size(184, 27);
            txtOrigenAereos.TabIndex = 2;
            // 
            // btnAgregarItinerarioAereos
            // 
            btnAgregarItinerarioAereos.Location = new Point(559, 89);
            btnAgregarItinerarioAereos.Margin = new Padding(3, 4, 3, 4);
            btnAgregarItinerarioAereos.Name = "btnAgregarItinerarioAereos";
            btnAgregarItinerarioAereos.Size = new Size(117, 35);
            btnAgregarItinerarioAereos.TabIndex = 7;
            btnAgregarItinerarioAereos.Text = "Agregar >>>";
            btnAgregarItinerarioAereos.UseVisualStyleBackColor = true;
            // 
            // lblItinerarioActivo
            // 
            lblItinerarioActivo.Location = new Point(991, 15);
            lblItinerarioActivo.Name = "lblItinerarioActivo";
            lblItinerarioActivo.RightToLeft = RightToLeft.Yes;
            lblItinerarioActivo.Size = new Size(137, 33);
            lblItinerarioActivo.TabIndex = 18;
            lblItinerarioActivo.Text = "itinerario datos";
            // 
            // lblAereosDisponibles
            // 
            lblAereosDisponibles.AutoSize = true;
            lblAereosDisponibles.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAereosDisponibles.Location = new Point(11, 9);
            lblAereosDisponibles.Name = "lblAereosDisponibles";
            lblAereosDisponibles.Size = new Size(156, 37);
            lblAereosDisponibles.TabIndex = 17;
            lblAereosDisponibles.Text = "Disponibles";
            // 
            // lblAereoEnItinerario
            // 
            lblAereoEnItinerario.AutoSize = true;
            lblAereoEnItinerario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAereoEnItinerario.Location = new Point(697, 9);
            lblAereoEnItinerario.Name = "lblAereoEnItinerario";
            lblAereoEnItinerario.Size = new Size(188, 37);
            lblAereoEnItinerario.TabIndex = 20;
            lblAereoEnItinerario.Text = "En el itinerario";
            // 
            // lsvItinerarioAereos
            // 
            lsvItinerarioAereos.FullRowSelect = true;
            lsvItinerarioAereos.Location = new Point(697, 53);
            lsvItinerarioAereos.Margin = new Padding(3, 4, 3, 4);
            lsvItinerarioAereos.MultiSelect = false;
            lsvItinerarioAereos.Name = "lsvItinerarioAereos";
            lsvItinerarioAereos.Size = new Size(524, 303);
            lsvItinerarioAereos.TabIndex = 19;
            lsvItinerarioAereos.UseCompatibleStateImageBehavior = false;
            lsvItinerarioAereos.View = View.Details;
            // 
            // btnQuitarItinerarioAereos
            // 
            btnQuitarItinerarioAereos.Location = new Point(559, 291);
            btnQuitarItinerarioAereos.Margin = new Padding(3, 4, 3, 4);
            btnQuitarItinerarioAereos.Name = "btnQuitarItinerarioAereos";
            btnQuitarItinerarioAereos.Size = new Size(117, 35);
            btnQuitarItinerarioAereos.TabIndex = 21;
            btnQuitarItinerarioAereos.Text = "<<< Quitar";
            btnQuitarItinerarioAereos.UseVisualStyleBackColor = true;
            // 
            // Aereos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 526);
            Controls.Add(btnQuitarItinerarioAereos);
            Controls.Add(lblAereoEnItinerario);
            Controls.Add(lsvItinerarioAereos);
            Controls.Add(lblItinerarioActivo);
            Controls.Add(lblAereosDisponibles);
            Controls.Add(grpAereos);
            Controls.Add(btnAgregarItinerarioAereos);
            Controls.Add(lsvAereos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
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
    }
}