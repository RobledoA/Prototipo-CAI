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
            label1 = new Label();
            label2 = new Label();
            listView2 = new ListView();
            button1 = new Button();
            grpAereos.SuspendLayout();
            SuspendLayout();
            // 
            // lsvAereos
            // 
            lsvAereos.FullRowSelect = true;
            lsvAereos.Location = new Point(12, 59);
            lsvAereos.MultiSelect = false;
            lsvAereos.Name = "lsvAereos";
            lsvAereos.Size = new Size(441, 228);
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
            grpAereos.Controls.Add(lblFechaIdaAereos);
            grpAereos.Controls.Add(dtFechaDesdeAereos);
            grpAereos.Controls.Add(lblDestinoAereos);
            grpAereos.Controls.Add(txtDestinoAereos);
            grpAereos.Controls.Add(lblOrigenAereos);
            grpAereos.Controls.Add(txtOrigenAereos);
            grpAereos.Location = new Point(12, 303);
            grpAereos.Name = "grpAereos";
            grpAereos.Size = new Size(980, 148);
            grpAereos.TabIndex = 11;
            grpAereos.TabStop = false;
            grpAereos.Text = "Opciones de Búsqueda";
            // 
            // lblTipoPasajeroAereos
            // 
            lblTipoPasajeroAereos.AutoSize = true;
            lblTipoPasajeroAereos.Location = new Point(662, 37);
            lblTipoPasajeroAereos.Name = "lblTipoPasajeroAereos";
            lblTipoPasajeroAereos.Size = new Size(77, 15);
            lblTipoPasajeroAereos.TabIndex = 29;
            lblTipoPasajeroAereos.Text = "Tipo Pasajero";
            // 
            // cmbTipoPasajeroAereos
            // 
            cmbTipoPasajeroAereos.FormattingEnabled = true;
            cmbTipoPasajeroAereos.Location = new Point(663, 55);
            cmbTipoPasajeroAereos.Name = "cmbTipoPasajeroAereos";
            cmbTipoPasajeroAereos.Size = new Size(112, 23);
            cmbTipoPasajeroAereos.TabIndex = 28;
            // 
            // cmbClaseAereos
            // 
            cmbClaseAereos.FormattingEnabled = true;
            cmbClaseAereos.Location = new Point(853, 55);
            cmbClaseAereos.Name = "cmbClaseAereos";
            cmbClaseAereos.Size = new Size(117, 23);
            cmbClaseAereos.TabIndex = 27;
            // 
            // lblClaseAereos
            // 
            lblClaseAereos.AutoSize = true;
            lblClaseAereos.Location = new Point(853, 37);
            lblClaseAereos.Name = "lblClaseAereos";
            lblClaseAereos.Size = new Size(35, 15);
            lblClaseAereos.TabIndex = 26;
            lblClaseAereos.Text = "Clase";
            // 
            // btnBuscarAereos
            // 
            btnBuscarAereos.Location = new Point(6, 97);
            btnBuscarAereos.Margin = new Padding(3, 2, 3, 2);
            btnBuscarAereos.Name = "btnBuscarAereos";
            btnBuscarAereos.Size = new Size(964, 31);
            btnBuscarAereos.TabIndex = 14;
            btnBuscarAereos.Text = "🔍";
            btnBuscarAereos.UseVisualStyleBackColor = true;
            // 
            // lblFechaIdaAereos
            // 
            lblFechaIdaAereos.AutoSize = true;
            lblFechaIdaAereos.Location = new Point(456, 37);
            lblFechaIdaAereos.Name = "lblFechaIdaAereos";
            lblFechaIdaAereos.Size = new Size(57, 15);
            lblFechaIdaAereos.TabIndex = 7;
            lblFechaIdaAereos.Text = "Fecha Ida";
            // 
            // dtFechaDesdeAereos
            // 
            dtFechaDesdeAereos.Location = new Point(457, 55);
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
            lblOrigenAereos.Location = new Point(6, 40);
            lblOrigenAereos.Name = "lblOrigenAereos";
            lblOrigenAereos.Size = new Size(43, 15);
            lblOrigenAereos.TabIndex = 3;
            lblOrigenAereos.Text = "Origen";
            // 
            // txtOrigenAereos
            // 
            txtOrigenAereos.Location = new Point(6, 58);
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
            lblAereos.Size = new Size(120, 30);
            lblAereos.TabIndex = 17;
            lblAereos.Text = "Disponibles";
            // 
            // btnAgregarItinerarioAereos
            // 
            btnAgregarItinerarioAereos.Location = new Point(468, 59);
            btnAgregarItinerarioAereos.Name = "btnAgregarItinerarioAereos";
            btnAgregarItinerarioAereos.Size = new Size(108, 47);
            btnAgregarItinerarioAereos.TabIndex = 7;
            btnAgregarItinerarioAereos.Text = "Agregar >>>";
            btnAgregarItinerarioAereos.UseVisualStyleBackColor = true;
            // 
            // lblItinerarioActivo
            // 
            lblItinerarioActivo.Location = new Point(862, 27);
            lblItinerarioActivo.Name = "lblItinerarioActivo";
            lblItinerarioActivo.RightToLeft = RightToLeft.Yes;
            lblItinerarioActivo.Size = new Size(120, 25);
            lblItinerarioActivo.TabIndex = 18;
            lblItinerarioActivo.Text = "itinerario datos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(120, 30);
            label1.TabIndex = 17;
            label1.Text = "Disponibles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(593, 15);
            label2.Name = "label2";
            label2.Size = new Size(146, 30);
            label2.TabIndex = 20;
            label2.Text = "En el itinerario";
            // 
            // listView2
            // 
            listView2.FullRowSelect = true;
            listView2.Location = new Point(593, 59);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(399, 228);
            listView2.TabIndex = 19;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // button1
            // 
            button1.Location = new Point(468, 234);
            button1.Name = "button1";
            button1.Size = new Size(108, 53);
            button1.TabIndex = 21;
            button1.Text = "<<< Quitar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Aereos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 460);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(listView2);
            Controls.Add(lblItinerarioActivo);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private ListView listView2;
        private Button button1;
    }
}