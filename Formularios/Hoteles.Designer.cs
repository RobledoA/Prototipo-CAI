namespace Prototipo_CAI
{
    partial class Hoteles
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
            lblHoteles = new Label();
            grpHoteles = new GroupBox();
            btnLimpiarFiltros = new Button();
            btnBuscarHoteles = new Button();
            lblFechaHastaHoteles = new Label();
            lblUbicacionHoteles = new Label();
            dtpFechaHastaHoteles = new DateTimePicker();
            txtUbicacionHoteles = new TextBox();
            lblFechaDesdeHoteles = new Label();
            lblCantHabitacionesHoteles = new Label();
            dtpFechaDesdeHoteles = new DateTimePicker();
            cmbCalificacionHoteles = new ComboBox();
            txtHabitacionesHoteles = new TextBox();
            lblCalificacionHoteles = new Label();
            lsvHoteles = new ListView();
            hdCodHotel = new ColumnHeader();
            hdNombre = new ColumnHeader();
            hdCalificacion = new ColumnHeader();
            hdCiudad = new ColumnHeader();
            hdHabitacion = new ColumnHeader();
            hdTarifa = new ColumnHeader();
            hdCapacidad = new ColumnHeader();
            btnAgregarItinerarioHoteles = new Button();
            lblItinerarioActivo = new Label();
            btnQuitarItinerarioHotel = new Button();
            lsvHotelesAgregados = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            lblHotelEnItinerario = new Label();
            grpHoteles.SuspendLayout();
            SuspendLayout();
            // 
            // lblHoteles
            // 
            lblHoteles.AutoSize = true;
            lblHoteles.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoteles.Location = new Point(10, 7);
            lblHoteles.Name = "lblHoteles";
            lblHoteles.Size = new Size(120, 30);
            lblHoteles.TabIndex = 18;
            lblHoteles.Text = "Disponibles";
            // 
            // grpHoteles
            // 
            grpHoteles.Controls.Add(btnLimpiarFiltros);
            grpHoteles.Controls.Add(btnBuscarHoteles);
            grpHoteles.Controls.Add(lblFechaHastaHoteles);
            grpHoteles.Controls.Add(lblUbicacionHoteles);
            grpHoteles.Controls.Add(dtpFechaHastaHoteles);
            grpHoteles.Controls.Add(txtUbicacionHoteles);
            grpHoteles.Controls.Add(lblFechaDesdeHoteles);
            grpHoteles.Controls.Add(lblCantHabitacionesHoteles);
            grpHoteles.Controls.Add(dtpFechaDesdeHoteles);
            grpHoteles.Controls.Add(cmbCalificacionHoteles);
            grpHoteles.Controls.Add(txtHabitacionesHoteles);
            grpHoteles.Controls.Add(lblCalificacionHoteles);
            grpHoteles.Location = new Point(10, 274);
            grpHoteles.Name = "grpHoteles";
            grpHoteles.Size = new Size(1057, 88);
            grpHoteles.TabIndex = 19;
            grpHoteles.TabStop = false;
            grpHoteles.Text = "Opciones de Búsqueda";
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.Location = new Point(1010, 49);
            btnLimpiarFiltros.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(32, 32);
            btnLimpiarFiltros.TabIndex = 17;
            btnLimpiarFiltros.Text = "\U0001f9f9";
            btnLimpiarFiltros.UseVisualStyleBackColor = true;
            btnLimpiarFiltros.Click += btnLimpiarFiltros_Click;
            // 
            // btnBuscarHoteles
            // 
            btnBuscarHoteles.Location = new Point(1010, 15);
            btnBuscarHoteles.Margin = new Padding(3, 2, 3, 2);
            btnBuscarHoteles.Name = "btnBuscarHoteles";
            btnBuscarHoteles.Size = new Size(32, 32);
            btnBuscarHoteles.TabIndex = 15;
            btnBuscarHoteles.Text = "🔍";
            btnBuscarHoteles.UseVisualStyleBackColor = true;
            btnBuscarHoteles.Click += btnBuscarHoteles_Click;
            // 
            // lblFechaHastaHoteles
            // 
            lblFechaHastaHoteles.AutoSize = true;
            lblFechaHastaHoteles.Location = new Point(630, 28);
            lblFechaHastaHoteles.Name = "lblFechaHastaHoteles";
            lblFechaHastaHoteles.RightToLeft = RightToLeft.Yes;
            lblFechaHastaHoteles.Size = new Size(71, 15);
            lblFechaHastaHoteles.TabIndex = 15;
            lblFechaHastaHoteles.Text = "Fecha Hasta";
            // 
            // lblUbicacionHoteles
            // 
            lblUbicacionHoteles.AutoSize = true;
            lblUbicacionHoteles.Location = new Point(26, 29);
            lblUbicacionHoteles.Name = "lblUbicacionHoteles";
            lblUbicacionHoteles.Size = new Size(60, 15);
            lblUbicacionHoteles.TabIndex = 16;
            lblUbicacionHoteles.Text = "Ubicación";
            // 
            // dtpFechaHastaHoteles
            // 
            dtpFechaHastaHoteles.Format = DateTimePickerFormat.Short;
            dtpFechaHastaHoteles.Location = new Point(630, 47);
            dtpFechaHastaHoteles.Name = "dtpFechaHastaHoteles";
            dtpFechaHastaHoteles.RightToLeft = RightToLeft.No;
            dtpFechaHastaHoteles.Size = new Size(150, 23);
            dtpFechaHastaHoteles.TabIndex = 14;
            dtpFechaHastaHoteles.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // txtUbicacionHoteles
            // 
            txtUbicacionHoteles.Location = new Point(26, 47);
            txtUbicacionHoteles.Name = "txtUbicacionHoteles";
            txtUbicacionHoteles.Size = new Size(150, 23);
            txtUbicacionHoteles.TabIndex = 15;
            // 
            // lblFechaDesdeHoteles
            // 
            lblFechaDesdeHoteles.AutoSize = true;
            lblFechaDesdeHoteles.Location = new Point(429, 29);
            lblFechaDesdeHoteles.Name = "lblFechaDesdeHoteles";
            lblFechaDesdeHoteles.Size = new Size(73, 15);
            lblFechaDesdeHoteles.TabIndex = 13;
            lblFechaDesdeHoteles.Text = "Fecha Desde";
            // 
            // lblCantHabitacionesHoteles
            // 
            lblCantHabitacionesHoteles.AutoSize = true;
            lblCantHabitacionesHoteles.Location = new Point(827, 28);
            lblCantHabitacionesHoteles.Name = "lblCantHabitacionesHoteles";
            lblCantHabitacionesHoteles.Size = new Size(123, 15);
            lblCantHabitacionesHoteles.TabIndex = 13;
            lblCantHabitacionesHoteles.Text = "Cant. de Habitaciones";
            // 
            // dtpFechaDesdeHoteles
            // 
            dtpFechaDesdeHoteles.Format = DateTimePickerFormat.Short;
            dtpFechaDesdeHoteles.Location = new Point(429, 47);
            dtpFechaDesdeHoteles.Name = "dtpFechaDesdeHoteles";
            dtpFechaDesdeHoteles.Size = new Size(150, 23);
            dtpFechaDesdeHoteles.TabIndex = 12;
            dtpFechaDesdeHoteles.Value = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // cmbCalificacionHoteles
            // 
            cmbCalificacionHoteles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCalificacionHoteles.FormattingEnabled = true;
            cmbCalificacionHoteles.Items.AddRange(new object[] { "★", "★★", "★★★", "★★★★", "★★★★★" });
            cmbCalificacionHoteles.Location = new Point(225, 47);
            cmbCalificacionHoteles.Name = "cmbCalificacionHoteles";
            cmbCalificacionHoteles.Size = new Size(150, 23);
            cmbCalificacionHoteles.TabIndex = 14;
            // 
            // txtHabitacionesHoteles
            // 
            txtHabitacionesHoteles.Location = new Point(827, 47);
            txtHabitacionesHoteles.Name = "txtHabitacionesHoteles";
            txtHabitacionesHoteles.Size = new Size(150, 23);
            txtHabitacionesHoteles.TabIndex = 12;
            // 
            // lblCalificacionHoteles
            // 
            lblCalificacionHoteles.AutoSize = true;
            lblCalificacionHoteles.Location = new Point(225, 29);
            lblCalificacionHoteles.Name = "lblCalificacionHoteles";
            lblCalificacionHoteles.Size = new Size(69, 15);
            lblCalificacionHoteles.TabIndex = 13;
            lblCalificacionHoteles.Text = "Calificación";
            // 
            // lsvHoteles
            // 
            lsvHoteles.Columns.AddRange(new ColumnHeader[] { hdCodHotel, hdNombre, hdCalificacion, hdCiudad, hdHabitacion, hdTarifa, hdCapacidad });
            lsvHoteles.FullRowSelect = true;
            lsvHoteles.Location = new Point(10, 40);
            lsvHoteles.MultiSelect = false;
            lsvHoteles.Name = "lsvHoteles";
            lsvHoteles.Size = new Size(459, 228);
            lsvHoteles.TabIndex = 22;
            lsvHoteles.UseCompatibleStateImageBehavior = false;
            lsvHoteles.View = View.Details;
            lsvHoteles.SelectedIndexChanged += lsvHoteles_SelectedIndexChanged;
            // 
            // hdCodHotel
            // 
            hdCodHotel.Width = 1;
            // 
            // hdNombre
            // 
            hdNombre.Text = "Nombre";
            hdNombre.Width = 125;
            // 
            // hdCalificacion
            // 
            hdCalificacion.Text = "Calificacion";
            hdCalificacion.Width = 75;
            // 
            // hdCiudad
            // 
            hdCiudad.Text = "Ciudad";
            hdCiudad.Width = 55;
            // 
            // hdHabitacion
            // 
            hdHabitacion.Text = "Tipo Hab.";
            hdHabitacion.Width = 80;
            // 
            // hdTarifa
            // 
            hdTarifa.Text = "Tarifa";
            hdTarifa.Width = 54;
            // 
            // hdCapacidad
            // 
            hdCapacidad.Text = "Capac.";
            hdCapacidad.Width = 48;
            // 
            // btnAgregarItinerarioHoteles
            // 
            btnAgregarItinerarioHoteles.Enabled = false;
            btnAgregarItinerarioHoteles.Location = new Point(489, 67);
            btnAgregarItinerarioHoteles.Name = "btnAgregarItinerarioHoteles";
            btnAgregarItinerarioHoteles.Size = new Size(102, 26);
            btnAgregarItinerarioHoteles.TabIndex = 25;
            btnAgregarItinerarioHoteles.Text = "Agregar >>>";
            btnAgregarItinerarioHoteles.UseVisualStyleBackColor = true;
            btnAgregarItinerarioHoteles.Click += btnAgregarItinerarioHoteles_Click;
            // 
            // lblItinerarioActivo
            // 
            lblItinerarioActivo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblItinerarioActivo.Location = new Point(854, 11);
            lblItinerarioActivo.Name = "lblItinerarioActivo";
            lblItinerarioActivo.RightToLeft = RightToLeft.No;
            lblItinerarioActivo.Size = new Size(213, 18);
            lblItinerarioActivo.TabIndex = 26;
            lblItinerarioActivo.Text = "NO HAY ITINERARIO ACTIVO";
            lblItinerarioActivo.TextAlign = ContentAlignment.TopRight;
            // 
            // btnQuitarItinerarioHotel
            // 
            btnQuitarItinerarioHotel.Enabled = false;
            btnQuitarItinerarioHotel.Location = new Point(489, 218);
            btnQuitarItinerarioHotel.Name = "btnQuitarItinerarioHotel";
            btnQuitarItinerarioHotel.Size = new Size(102, 26);
            btnQuitarItinerarioHotel.TabIndex = 28;
            btnQuitarItinerarioHotel.Text = "<<< Eliminar";
            btnQuitarItinerarioHotel.UseVisualStyleBackColor = true;
            // 
            // lsvHotelesAgregados
            // 
            lsvHotelesAgregados.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lsvHotelesAgregados.FullRowSelect = true;
            lsvHotelesAgregados.Location = new Point(610, 40);
            lsvHotelesAgregados.MultiSelect = false;
            lsvHotelesAgregados.Name = "lsvHotelesAgregados";
            lsvHotelesAgregados.Size = new Size(459, 228);
            lsvHotelesAgregados.TabIndex = 29;
            lsvHotelesAgregados.UseCompatibleStateImageBehavior = false;
            lsvHotelesAgregados.View = View.Details;
            lsvHotelesAgregados.SelectedIndexChanged += lsvHotelesAgregados_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Calificacion";
            columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ciudad";
            columnHeader4.Width = 55;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tipo Hab.";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tarifa";
            columnHeader6.Width = 54;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Capac.";
            columnHeader7.Width = 48;
            // 
            // lblHotelEnItinerario
            // 
            lblHotelEnItinerario.AutoSize = true;
            lblHotelEnItinerario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHotelEnItinerario.Location = new Point(610, 7);
            lblHotelEnItinerario.Name = "lblHotelEnItinerario";
            lblHotelEnItinerario.Size = new Size(146, 30);
            lblHotelEnItinerario.TabIndex = 31;
            lblHotelEnItinerario.Text = "En el itinerario";
            // 
            // Hoteles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 370);
            Controls.Add(lblHotelEnItinerario);
            Controls.Add(lsvHotelesAgregados);
            Controls.Add(btnQuitarItinerarioHotel);
            Controls.Add(lblItinerarioActivo);
            Controls.Add(btnAgregarItinerarioHoteles);
            Controls.Add(lsvHoteles);
            Controls.Add(grpHoteles);
            Controls.Add(lblHoteles);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Hoteles";
            Text = "Hoteles Disponibles";
            FormClosed += Hoteles_FormClosed;
            Load += Hoteles_Load;
            grpHoteles.ResumeLayout(false);
            grpHoteles.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoteles;
        private GroupBox grpHoteles;
        private Button btnBuscarHoteles;
        private Label lblFechaHastaHoteles;
        private Label lblUbicacionHoteles;
        private DateTimePicker dtpFechaHastaHoteles;
        private TextBox txtUbicacionHoteles;
        private Label lblFechaDesdeHoteles;
        private Label lblCantHabitacionesHoteles;
        private DateTimePicker dtpFechaDesdeHoteles;
        private ComboBox cmbCalificacionHoteles;
        private TextBox txtHabitacionesHoteles;
        private Label lblCalificacionHoteles;
        public ListView lsvHoteles;
        private Button btnAgregarItinerarioHoteles;
        private Label lblItinerarioActivo;
        private ColumnHeader hdNombre;
        private ColumnHeader hdCalificacion;
        private ColumnHeader hdCiudad;
        private ColumnHeader hdHabitacion;
        private ColumnHeader hdTarifa;
        private ColumnHeader hdCapacidad;
        private Button btnQuitarItinerarioHotel;
        private ColumnHeader hdCodHotel;
        public ListView lsvHotelesAgregados;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button btnLimpiarFiltros;
        private Label lblHotelEnItinerario;
    }
}