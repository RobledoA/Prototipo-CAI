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
            hdCodigo = new ColumnHeader();
            hdNombre = new ColumnHeader();
            hdCiudad = new ColumnHeader();
            hdDireccion = new ColumnHeader();
            hdCalificacion = new ColumnHeader();
            hdDisponibilidad = new ColumnHeader();
            btnAgregarItinerarioHoteles = new Button();
            lblItinerarioActivo = new Label();
            grpHoteles.SuspendLayout();
            SuspendLayout();
            // 
            // lblHoteles
            // 
            lblHoteles.AutoSize = true;
            lblHoteles.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoteles.Location = new Point(10, 7);
            lblHoteles.Name = "lblHoteles";
            lblHoteles.Size = new Size(83, 30);
            lblHoteles.TabIndex = 18;
            lblHoteles.Text = "Hoteles";
            // 
            // grpHoteles
            // 
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
            grpHoteles.Location = new Point(12, 339);
            grpHoteles.Name = "grpHoteles";
            grpHoteles.Size = new Size(477, 212);
            grpHoteles.TabIndex = 19;
            grpHoteles.TabStop = false;
            grpHoteles.Text = "Opciones de Búsqueda";
            // 
            // btnBuscarHoteles
            // 
            btnBuscarHoteles.Location = new Point(242, 150);
            btnBuscarHoteles.Margin = new Padding(3, 2, 3, 2);
            btnBuscarHoteles.Name = "btnBuscarHoteles";
            btnBuscarHoteles.Size = new Size(31, 31);
            btnBuscarHoteles.TabIndex = 15;
            btnBuscarHoteles.Text = "🔍";
            btnBuscarHoteles.UseVisualStyleBackColor = true;
            // 
            // lblFechaHastaHoteles
            // 
            lblFechaHastaHoteles.AutoSize = true;
            lblFechaHastaHoteles.Location = new Point(250, 87);
            lblFechaHastaHoteles.Name = "lblFechaHastaHoteles";
            lblFechaHastaHoteles.RightToLeft = RightToLeft.Yes;
            lblFechaHastaHoteles.Size = new Size(71, 15);
            lblFechaHastaHoteles.TabIndex = 15;
            lblFechaHastaHoteles.Text = "Fecha Hasta";
            // 
            // lblUbicacionHoteles
            // 
            lblUbicacionHoteles.AutoSize = true;
            lblUbicacionHoteles.Location = new Point(34, 38);
            lblUbicacionHoteles.Name = "lblUbicacionHoteles";
            lblUbicacionHoteles.Size = new Size(60, 15);
            lblUbicacionHoteles.TabIndex = 16;
            lblUbicacionHoteles.Text = "Ubicación";
            // 
            // dtpFechaHastaHoteles
            // 
            dtpFechaHastaHoteles.Location = new Point(251, 104);
            dtpFechaHastaHoteles.Name = "dtpFechaHastaHoteles";
            dtpFechaHastaHoteles.RightToLeft = RightToLeft.Yes;
            dtpFechaHastaHoteles.Size = new Size(200, 23);
            dtpFechaHastaHoteles.TabIndex = 14;
            // 
            // txtUbicacionHoteles
            // 
            txtUbicacionHoteles.Location = new Point(35, 55);
            txtUbicacionHoteles.Name = "txtUbicacionHoteles";
            txtUbicacionHoteles.Size = new Size(200, 23);
            txtUbicacionHoteles.TabIndex = 15;
            // 
            // lblFechaDesdeHoteles
            // 
            lblFechaDesdeHoteles.AutoSize = true;
            lblFechaDesdeHoteles.Location = new Point(34, 87);
            lblFechaDesdeHoteles.Name = "lblFechaDesdeHoteles";
            lblFechaDesdeHoteles.Size = new Size(73, 15);
            lblFechaDesdeHoteles.TabIndex = 13;
            lblFechaDesdeHoteles.Text = "Fecha Desde";
            // 
            // lblCantHabitacionesHoteles
            // 
            lblCantHabitacionesHoteles.AutoSize = true;
            lblCantHabitacionesHoteles.Location = new Point(34, 138);
            lblCantHabitacionesHoteles.Name = "lblCantHabitacionesHoteles";
            lblCantHabitacionesHoteles.Size = new Size(143, 15);
            lblCantHabitacionesHoteles.TabIndex = 13;
            lblCantHabitacionesHoteles.Text = "Cantidad de Habitaciones";
            // 
            // dtpFechaDesdeHoteles
            // 
            dtpFechaDesdeHoteles.Location = new Point(35, 104);
            dtpFechaDesdeHoteles.Name = "dtpFechaDesdeHoteles";
            dtpFechaDesdeHoteles.Size = new Size(200, 23);
            dtpFechaDesdeHoteles.TabIndex = 12;
            // 
            // cmbCalificacionHoteles
            // 
            cmbCalificacionHoteles.FormattingEnabled = true;
            cmbCalificacionHoteles.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbCalificacionHoteles.Location = new Point(250, 55);
            cmbCalificacionHoteles.Name = "cmbCalificacionHoteles";
            cmbCalificacionHoteles.Size = new Size(199, 23);
            cmbCalificacionHoteles.TabIndex = 14;
            // 
            // txtHabitacionesHoteles
            // 
            txtHabitacionesHoteles.Location = new Point(35, 155);
            txtHabitacionesHoteles.Name = "txtHabitacionesHoteles";
            txtHabitacionesHoteles.Size = new Size(200, 23);
            txtHabitacionesHoteles.TabIndex = 12;
            // 
            // lblCalificacionHoteles
            // 
            lblCalificacionHoteles.AutoSize = true;
            lblCalificacionHoteles.Location = new Point(247, 38);
            lblCalificacionHoteles.Name = "lblCalificacionHoteles";
            lblCalificacionHoteles.Size = new Size(69, 15);
            lblCalificacionHoteles.TabIndex = 13;
            lblCalificacionHoteles.Text = "Calificación";
            // 
            // lsvHoteles
            // 
            lsvHoteles.Columns.AddRange(new ColumnHeader[] { hdCodigo, hdNombre, hdCiudad, hdDireccion, hdCalificacion, hdDisponibilidad });
            lsvHoteles.FullRowSelect = true;
            lsvHoteles.Location = new Point(10, 50);
            lsvHoteles.MultiSelect = false;
            lsvHoteles.Name = "lsvHoteles";
            lsvHoteles.Size = new Size(979, 228);
            lsvHoteles.TabIndex = 22;
            lsvHoteles.UseCompatibleStateImageBehavior = false;
            lsvHoteles.View = View.Details;
            // 
            // hdCodigo
            // 
            hdCodigo.Text = "Código";
            hdCodigo.Width = 65;
            // 
            // hdNombre
            // 
            hdNombre.Text = "Nombre";
            hdNombre.Width = 200;
            // 
            // hdCiudad
            // 
            hdCiudad.Text = "Ciudad";
            // 
            // hdDireccion
            // 
            hdDireccion.Text = "Dirección";
            hdDireccion.Width = 200;
            // 
            // hdCalificacion
            // 
            hdCalificacion.Text = "Calificación";
            hdCalificacion.Width = 90;
            // 
            // hdDisponibilidad
            // 
            hdDisponibilidad.Text = "Disponibilidad";
            hdDisponibilidad.Width = 110;
            // 
            // btnAgregarItinerarioHoteles
            // 
            btnAgregarItinerarioHoteles.Location = new Point(887, 293);
            btnAgregarItinerarioHoteles.Name = "btnAgregarItinerarioHoteles";
            btnAgregarItinerarioHoteles.Size = new Size(102, 26);
            btnAgregarItinerarioHoteles.TabIndex = 25;
            btnAgregarItinerarioHoteles.Text = "Crear Itinerario";
            btnAgregarItinerarioHoteles.UseVisualStyleBackColor = true;

            // 
            // lblItinerarioActivo
            // 
            lblItinerarioActivo.AutoSize = true;
            lblItinerarioActivo.Location = new Point(903, 19);
            lblItinerarioActivo.Name = "lblItinerarioActivo";
            lblItinerarioActivo.Size = new Size(86, 15);
            lblItinerarioActivo.TabIndex = 26;
            lblItinerarioActivo.Text = "itinerario datos";
            // 
            // Hoteles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 653);
            Controls.Add(lblItinerarioActivo);
            Controls.Add(btnAgregarItinerarioHoteles);
            Controls.Add(lsvHoteles);
            Controls.Add(grpHoteles);
            Controls.Add(lblHoteles);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Hoteles";
            Text = "Hoteles";
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
        private ColumnHeader hdCodigo;
        private ColumnHeader hdNombre;
        private ColumnHeader hdCiudad;
        private ColumnHeader hdDireccion;
        private ColumnHeader hdCalificacion;
        private ColumnHeader hdDisponibilidad;
        public ListView lsvHoteles;
        private Button btnAgregarItinerarioHoteles;
        private Label lblItinerarioActivo;
    }
}