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
            btnDetalles = new Button();
            grpAereos = new GroupBox();
            btnBuscarAereos = new Button();
            label5 = new Label();
            dtpFechaVuelta = new DateTimePicker();
            label2 = new Label();
            dtFechaDesde = new DateTimePicker();
            label4 = new Label();
            txtDestino = new TextBox();
            label3 = new Label();
            txtOrigen = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lbTitleProdDisponibles = new Label();
            btnAgregarItinerario = new Button();
            cbClase = new ComboBox();
            lblClase = new Label();
            cbTipoPasajero = new ComboBox();
            lblTipoPasajero = new Label();
            label1 = new Label();
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
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(12, 293);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(89, 23);
            btnDetalles.TabIndex = 6;
            btnDetalles.Text = "Ver Detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // grpAereos
            // 
            grpAereos.Controls.Add(lblTipoPasajero);
            grpAereos.Controls.Add(cbTipoPasajero);
            grpAereos.Controls.Add(cbClase);
            grpAereos.Controls.Add(lblClase);
            grpAereos.Controls.Add(label5);
            grpAereos.Controls.Add(dtpFechaVuelta);
            grpAereos.Controls.Add(label2);
            grpAereos.Controls.Add(dtFechaDesde);
            grpAereos.Controls.Add(label4);
            grpAereos.Controls.Add(txtDestino);
            grpAereos.Controls.Add(label3);
            grpAereos.Controls.Add(txtOrigen);
            grpAereos.Location = new Point(22, 331);
            grpAereos.Name = "grpAereos";
            grpAereos.Size = new Size(477, 274);
            grpAereos.TabIndex = 11;
            grpAereos.TabStop = false;
            grpAereos.Text = "Opciones de Búsqueda";
            // 
            // btnBuscarAereos
            // 
            btnBuscarAereos.Location = new Point(505, 433);
            btnBuscarAereos.Margin = new Padding(3, 2, 3, 2);
            btnBuscarAereos.Name = "btnBuscarAereos";
            btnBuscarAereos.Size = new Size(31, 31);
            btnBuscarAereos.TabIndex = 14;
            btnBuscarAereos.Text = "🔍";
            btnBuscarAereos.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 86);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(74, 15);
            label5.TabIndex = 9;
            label5.Text = "Fecha Vuelta";
            // 
            // dtpFechaVuelta
            // 
            dtpFechaVuelta.Location = new Point(251, 104);
            dtpFechaVuelta.Name = "dtpFechaVuelta";
            dtpFechaVuelta.RightToLeft = RightToLeft.Yes;
            dtpFechaVuelta.Size = new Size(200, 23);
            dtpFechaVuelta.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 86);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 7;
            label2.Text = "Fecha Ida";
            // 
            // dtFechaDesde
            // 
            dtFechaDesde.Location = new Point(35, 104);
            dtFechaDesde.Name = "dtFechaDesde";
            dtFechaDesde.Size = new Size(200, 23);
            dtFechaDesde.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 37);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 5;
            label4.Text = "Destino";
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(251, 55);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(200, 23);
            txtDestino.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 37);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "Origen";
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(36, 55);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(199, 23);
            txtOrigen.TabIndex = 2;
            // 
            // lbTitleProdDisponibles
            // 
            lbTitleProdDisponibles.AutoSize = true;
            lbTitleProdDisponibles.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitleProdDisponibles.Location = new Point(12, 15);
            lbTitleProdDisponibles.Name = "lbTitleProdDisponibles";
            lbTitleProdDisponibles.Size = new Size(77, 30);
            lbTitleProdDisponibles.TabIndex = 17;
            lbTitleProdDisponibles.Text = "Aéreos";
            // 
            // btnAgregarItinerario
            // 
            btnAgregarItinerario.Location = new Point(107, 293);
            btnAgregarItinerario.Name = "btnAgregarItinerario";
            btnAgregarItinerario.Size = new Size(108, 23);
            btnAgregarItinerario.TabIndex = 7;
            btnAgregarItinerario.Text = "Agregar Itinerario";
            btnAgregarItinerario.UseVisualStyleBackColor = true;
            btnAgregarItinerario.Click += btnCrearItinerario_Click;
            // 
            // cbClase
            // 
            cbClase.FormattingEnabled = true;
            cbClase.Location = new Point(36, 151);
            cbClase.Name = "cbClase";
            cbClase.Size = new Size(199, 23);
            cbClase.TabIndex = 27;
            // 
            // lblClase
            // 
            lblClase.AutoSize = true;
            lblClase.Location = new Point(36, 133);
            lblClase.Name = "lblClase";
            lblClase.Size = new Size(35, 15);
            lblClase.TabIndex = 26;
            lblClase.Text = "Clase";
            // 
            // cbTipoPasajero
            // 
            cbTipoPasajero.FormattingEnabled = true;
            cbTipoPasajero.Location = new Point(251, 151);
            cbTipoPasajero.Name = "cbTipoPasajero";
            cbTipoPasajero.Size = new Size(200, 23);
            cbTipoPasajero.TabIndex = 28;
            // 
            // lblTipoPasajero
            // 
            lblTipoPasajero.AutoSize = true;
            lblTipoPasajero.Location = new Point(250, 133);
            lblTipoPasajero.Name = "lblTipoPasajero";
            lblTipoPasajero.Size = new Size(77, 15);
            lblTipoPasajero.TabIndex = 29;
            lblTipoPasajero.Text = "Tipo Pasajero";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(896, 27);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(86, 15);
            label1.TabIndex = 18;
            label1.Text = "itinerario datos";
            // 
            // Aereos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 630);
            Controls.Add(label1);
            Controls.Add(lbTitleProdDisponibles);
            Controls.Add(grpAereos);
            Controls.Add(btnAgregarItinerario);
            Controls.Add(btnBuscarAereos);
            Controls.Add(btnDetalles);
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
        private Label label5;
        private DateTimePicker dtpFechaVuelta;
        private Label label2;
        private DateTimePicker dtFechaDesde;
        private Label label4;
        private TextBox txtDestino;
        private Label label3;
        private TextBox txtOrigen;
        private Button btnBuscarAereos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lbTitleProdDisponibles;
        private ListView lsvAereos;
        private Label lblTipoPasajero;
        private ComboBox cbTipoPasajero;
        private ComboBox cbClase;
        private Label lblClase;
        private Button btnAgregarItinerario;
        private Label label1;
    }
}