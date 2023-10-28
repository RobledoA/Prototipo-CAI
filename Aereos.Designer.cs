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
            lblTipoPasajeroAereos = new Label();
            cmbTipoPasajeroAereos = new ComboBox();
            cmbClaseAereos = new ComboBox();
            lblClaseAereos = new Label();
            btnBuscarAereos = new Button();
            lblFechaVueltaAereos = new Label();
            dtpFechaVueltaAereos = new DateTimePicker();
            lblFechaIdaAereos = new Label();
            dtFechaDesdeAereos = new DateTimePicker();
            lblDestinoAereos = new Label();
            txtDestinoAereos = new TextBox();
            lblOrigenAereos = new Label();
            txtOrigenAereos = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblAereos = new Label();
            btnAgregarItinerarioAereos = new Button();
            lblItinerarioActivo = new Label();
            grpAereos.SuspendLayout();
            SuspendLayout();
            // 
            // lsvAereos
            // 
            lsvAereos.FullRowSelect = true;
            lsvAereos.Location = new Point(12, 59);
            lsvAereos.MultiSelect = false;
            lsvAereos.Name = "lsvAereos";
            lsvAereos.Size = new Size(979, 228);
            lsvAereos.TabIndex = 0;
            lsvAereos.UseCompatibleStateImageBehavior = false;
            lsvAereos.View = View.Details;
            lsvAereos.SelectedIndexChanged += lsvAereos_SelectedIndexChanged;
            // 
            // grpAereos
            // 
            grpAereos.Controls.Add(lblTipoPasajeroAereos);
            grpAereos.Controls.Add(cmbTipoPasajeroAereos);
            grpAereos.Controls.Add(cmbClaseAereos);
            grpAereos.Controls.Add(lblClaseAereos);
            grpAereos.Controls.Add(btnBuscarAereos);
            grpAereos.Controls.Add(lblFechaVueltaAereos);
            grpAereos.Controls.Add(dtpFechaVueltaAereos);
            grpAereos.Controls.Add(lblFechaIdaAereos);
            grpAereos.Controls.Add(dtFechaDesdeAereos);
            grpAereos.Controls.Add(lblDestinoAereos);
            grpAereos.Controls.Add(txtDestinoAereos);
            grpAereos.Controls.Add(lblOrigenAereos);
            grpAereos.Controls.Add(txtOrigenAereos);
            grpAereos.Location = new Point(22, 331);
            grpAereos.Name = "grpAereos";
            grpAereos.Size = new Size(477, 274);
            grpAereos.TabIndex = 11;
            grpAereos.TabStop = false;
            grpAereos.Text = "Opciones de Búsqueda";
            // 
            // lblTipoPasajeroAereos
            // 
            lblTipoPasajeroAereos.AutoSize = true;
            lblTipoPasajeroAereos.Location = new Point(250, 133);
            lblTipoPasajeroAereos.Name = "lblTipoPasajeroAereos";
            lblTipoPasajeroAereos.Size = new Size(77, 15);
            lblTipoPasajeroAereos.TabIndex = 29;
            lblTipoPasajeroAereos.Text = "Tipo Pasajero";
            // 
            // cmbTipoPasajeroAereos
            // 
            cmbTipoPasajeroAereos.FormattingEnabled = true;
            cmbTipoPasajeroAereos.Location = new Point(251, 151);
            cmbTipoPasajeroAereos.Name = "cmbTipoPasajeroAereos";
            cmbTipoPasajeroAereos.Size = new Size(200, 23);
            cmbTipoPasajeroAereos.TabIndex = 28;
            // 
            // cmbClaseAereos
            // 
            cmbClaseAereos.FormattingEnabled = true;
            cmbClaseAereos.Location = new Point(36, 151);
            cmbClaseAereos.Name = "cmbClaseAereos";
            cmbClaseAereos.Size = new Size(199, 23);
            cmbClaseAereos.TabIndex = 27;
            // 
            // lblClaseAereos
            // 
            lblClaseAereos.AutoSize = true;
            lblClaseAereos.Location = new Point(36, 133);
            lblClaseAereos.Name = "lblClaseAereos";
            lblClaseAereos.Size = new Size(35, 15);
            lblClaseAereos.TabIndex = 26;
            lblClaseAereos.Text = "Clase";
            // 
            // btnBuscarAereos
            // 
            btnBuscarAereos.Location = new Point(420, 197);
            btnBuscarAereos.Margin = new Padding(3, 2, 3, 2);
            btnBuscarAereos.Name = "btnBuscarAereos";
            btnBuscarAereos.Size = new Size(31, 31);
            btnBuscarAereos.TabIndex = 14;
            btnBuscarAereos.Text = "🔍";
            btnBuscarAereos.UseVisualStyleBackColor = true;
            // 
            // lblFechaVueltaAereos
            // 
            lblFechaVueltaAereos.AutoSize = true;
            lblFechaVueltaAereos.Location = new Point(250, 86);
            lblFechaVueltaAereos.Name = "lblFechaVueltaAereos";
            lblFechaVueltaAereos.RightToLeft = RightToLeft.Yes;
            lblFechaVueltaAereos.Size = new Size(74, 15);
            lblFechaVueltaAereos.TabIndex = 9;
            lblFechaVueltaAereos.Text = "Fecha Vuelta";
            // 
            // dtpFechaVueltaAereos
            // 
            dtpFechaVueltaAereos.Location = new Point(251, 104);
            dtpFechaVueltaAereos.Name = "dtpFechaVueltaAereos";
            dtpFechaVueltaAereos.RightToLeft = RightToLeft.Yes;
            dtpFechaVueltaAereos.Size = new Size(200, 23);
            dtpFechaVueltaAereos.TabIndex = 8;
            // 
            // lblFechaIdaAereos
            // 
            lblFechaIdaAereos.AutoSize = true;
            lblFechaIdaAereos.Location = new Point(34, 86);
            lblFechaIdaAereos.Name = "lblFechaIdaAereos";
            lblFechaIdaAereos.Size = new Size(57, 15);
            lblFechaIdaAereos.TabIndex = 7;
            lblFechaIdaAereos.Text = "Fecha Ida";
            // 
            // dtFechaDesdeAereos
            // 
            dtFechaDesdeAereos.Location = new Point(35, 104);
            dtFechaDesdeAereos.Name = "dtFechaDesdeAereos";
            dtFechaDesdeAereos.Size = new Size(200, 23);
            dtFechaDesdeAereos.TabIndex = 6;
            // 
            // lblDestinoAereos
            // 
            lblDestinoAereos.AutoSize = true;
            lblDestinoAereos.Location = new Point(250, 37);
            lblDestinoAereos.Name = "lblDestinoAereos";
            lblDestinoAereos.Size = new Size(47, 15);
            lblDestinoAereos.TabIndex = 5;
            lblDestinoAereos.Text = "Destino";
            // 
            // txtDestinoAereos
            // 
            txtDestinoAereos.Location = new Point(251, 55);
            txtDestinoAereos.Name = "txtDestinoAereos";
            txtDestinoAereos.Size = new Size(200, 23);
            txtDestinoAereos.TabIndex = 4;
            txtDestinoAereos.TextChanged += txtDestino_TextChanged;
            // 
            // lblOrigenAereos
            // 
            lblOrigenAereos.AutoSize = true;
            lblOrigenAereos.Location = new Point(36, 37);
            lblOrigenAereos.Name = "lblOrigenAereos";
            lblOrigenAereos.Size = new Size(43, 15);
            lblOrigenAereos.TabIndex = 3;
            lblOrigenAereos.Text = "Origen";
            // 
            // txtOrigenAereos
            // 
            txtOrigenAereos.Location = new Point(36, 55);
            txtOrigenAereos.Name = "txtOrigenAereos";
            txtOrigenAereos.Size = new Size(199, 23);
            txtOrigenAereos.TabIndex = 2;
            // 
            // lblAereos
            // 
            lblAereos.AutoSize = true;
            lblAereos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAereos.Location = new Point(12, 15);
            lblAereos.Name = "lblAereos";
            lblAereos.Size = new Size(77, 30);
            lblAereos.TabIndex = 17;
            lblAereos.Text = "Aéreos";
            // 
            // btnAgregarItinerarioAereos
            // 
            btnAgregarItinerarioAereos.Location = new Point(883, 293);
            btnAgregarItinerarioAereos.Name = "btnAgregarItinerarioAereos";
            btnAgregarItinerarioAereos.Size = new Size(108, 23);
            btnAgregarItinerarioAereos.TabIndex = 7;
            btnAgregarItinerarioAereos.Text = "Crear Itinerario";
            btnAgregarItinerarioAereos.UseVisualStyleBackColor = true;
            // 
            // lblItinerarioActivo
            // 
            lblItinerarioActivo.AutoSize = true;
            lblItinerarioActivo.Location = new Point(896, 27);
            lblItinerarioActivo.Name = "lblItinerarioActivo";
            lblItinerarioActivo.RightToLeft = RightToLeft.Yes;
            lblItinerarioActivo.Size = new Size(86, 15);
            lblItinerarioActivo.TabIndex = 18;
            lblItinerarioActivo.Text = "itinerario datos";
            // 
            // Aereos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 630);
            Controls.Add(lblItinerarioActivo);
            Controls.Add(lblAereos);
            Controls.Add(grpAereos);
            Controls.Add(btnAgregarItinerarioAereos);
            Controls.Add(lsvAereos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Aereos";
            Text = "Productos Disponibles";
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
        private Label lblFechaVueltaAereos;
        private DateTimePicker dtpFechaVueltaAereos;
        private Label lblFechaIdaAereos;
        private DateTimePicker dtFechaDesdeAereos;
        private Label lblDestinoAereos;
        private TextBox txtDestinoAereos;
        private Label lblOrigenAereos;
        private TextBox txtOrigenAereos;
        private Button btnBuscarAereos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblAereos;
        private ListView lsvAereos;
        private Label lblTipoPasajeroAereos;
        private ComboBox cmbTipoPasajeroAereos;
        private ComboBox cmbClaseAereos;
        private Label lblClaseAereos;
        private Button btnAgregarItinerarioAereos;
        private Label lblItinerarioActivo;
    }
}