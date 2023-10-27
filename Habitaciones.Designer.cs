namespace Prototipo_CAI
{
    partial class Habitaciones
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
            lblDireccion = new Label();
            lblNombreHotel = new Label();
            lsvServExtraHoteles = new ListView();
            hdServicio = new ColumnHeader();
            hdTarifaServ = new ColumnHeader();
            hdPorPersona = new ColumnHeader();
            lblEstrellas = new Label();
            lsvHabitaciones = new ListView();
            hdHabitacion = new ColumnHeader();
            hdTarifa = new ColumnHeader();
            hdDisponibilidad = new ColumnHeader();
            hdCapacidad = new ColumnHeader();
            hdAdultos = new ColumnHeader();
            hdMenores = new ColumnHeader();
            hdInfantes = new ColumnHeader();
            hdFechaDesde = new ColumnHeader();
            hdFechaHasta = new ColumnHeader();
            lblHabitaciones = new Label();
            lblServExtra = new Label();
            SuspendLayout();
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.Location = new Point(12, 81);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(111, 28);
            lblDireccion.TabIndex = 72;
            lblDireccion.Text = "DIRECCIÓN";
            // 
            // lblNombreHotel
            // 
            lblNombreHotel.AutoSize = true;
            lblNombreHotel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreHotel.Location = new Point(12, 12);
            lblNombreHotel.Name = "lblNombreHotel";
            lblNombreHotel.Size = new Size(155, 28);
            lblNombreHotel.TabIndex = 71;
            lblNombreHotel.Text = "NOMBRE HOTEL";
            // 
            // lsvServExtraHoteles
            // 
            lsvServExtraHoteles.Columns.AddRange(new ColumnHeader[] { hdServicio, hdTarifaServ, hdPorPersona });
            lsvServExtraHoteles.Location = new Point(236, 299);
            lsvServExtraHoteles.Name = "lsvServExtraHoteles";
            lsvServExtraHoteles.Size = new Size(425, 171);
            lsvServExtraHoteles.TabIndex = 64;
            lsvServExtraHoteles.UseCompatibleStateImageBehavior = false;
            lsvServExtraHoteles.View = View.Details;
            // 
            // hdServicio
            // 
            hdServicio.Text = "Servicio";
            hdServicio.Width = 200;
            // 
            // hdTarifaServ
            // 
            hdTarifaServ.Text = "Tarifa";
            hdTarifaServ.Width = 100;
            // 
            // hdPorPersona
            // 
            hdPorPersona.Text = "Por Persona?";
            hdPorPersona.Width = 120;
            // 
            // lblEstrellas
            // 
            lblEstrellas.AutoSize = true;
            lblEstrellas.BackColor = SystemColors.Control;
            lblEstrellas.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstrellas.ForeColor = SystemColors.ActiveCaptionText;
            lblEstrellas.Location = new Point(12, 40);
            lblEstrellas.Name = "lblEstrellas";
            lblEstrellas.Size = new Size(143, 41);
            lblEstrellas.TabIndex = 74;
            lblEstrellas.Text = "★★★★★";
            // 
            // lsvHabitaciones
            // 
            lsvHabitaciones.Columns.AddRange(new ColumnHeader[] { hdHabitacion, hdTarifa, hdDisponibilidad, hdCapacidad, hdAdultos, hdMenores, hdInfantes, hdFechaDesde, hdFechaHasta });
            lsvHabitaciones.Location = new Point(236, 57);
            lsvHabitaciones.Name = "lsvHabitaciones";
            lsvHabitaciones.Size = new Size(685, 171);
            lsvHabitaciones.TabIndex = 83;
            lsvHabitaciones.UseCompatibleStateImageBehavior = false;
            lsvHabitaciones.View = View.Details;
            // 
            // hdHabitacion
            // 
            hdHabitacion.Text = "Habitación";
            hdHabitacion.Width = 100;
            // 
            // hdTarifa
            // 
            hdTarifa.Text = "Tarifa";
            // 
            // hdDisponibilidad
            // 
            hdDisponibilidad.Text = "Disponibilidad";
            hdDisponibilidad.Width = 88;
            // 
            // hdCapacidad
            // 
            hdCapacidad.Text = "Capacidad";
            hdCapacidad.Width = 68;
            // 
            // hdAdultos
            // 
            hdAdultos.Text = "Adultos";
            hdAdultos.Width = 53;
            // 
            // hdMenores
            // 
            hdMenores.Text = "Menores";
            hdMenores.Width = 58;
            // 
            // hdInfantes
            // 
            hdInfantes.Text = "Infantes";
            hdInfantes.Width = 54;
            // 
            // hdFechaDesde
            // 
            hdFechaDesde.Text = "Fecha Desde";
            hdFechaDesde.Width = 100;
            // 
            // hdFechaHasta
            // 
            hdFechaHasta.Text = "Fecha Hasta";
            hdFechaHasta.Width = 100;
            // 
            // lblHabitaciones
            // 
            lblHabitaciones.AutoSize = true;
            lblHabitaciones.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblHabitaciones.Location = new Point(236, 26);
            lblHabitaciones.Name = "lblHabitaciones";
            lblHabitaciones.Size = new Size(125, 28);
            lblHabitaciones.TabIndex = 84;
            lblHabitaciones.Text = "Habitaciones";
            // 
            // lblServExtra
            // 
            lblServExtra.AutoSize = true;
            lblServExtra.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblServExtra.Location = new Point(236, 268);
            lblServExtra.Name = "lblServExtra";
            lblServExtra.Size = new Size(137, 28);
            lblServExtra.TabIndex = 85;
            lblServExtra.Text = "Servicios Extra";
            // 
            // Habitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 533);
            Controls.Add(lblServExtra);
            Controls.Add(lblHabitaciones);
            Controls.Add(lsvHabitaciones);
            Controls.Add(lblEstrellas);
            Controls.Add(lblDireccion);
            Controls.Add(lblNombreHotel);
            Controls.Add(lsvServExtraHoteles);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Habitaciones";
            Text = "Habitaciones";
            Load += Habitaciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDireccion;
        private Label lblNombreHotel;
        private ListView lsvTarifas;
        private ColumnHeader hdTarifaAdulto;
        private ColumnHeader hdTarifaMenor;
        private ColumnHeader hdTarifaInfante;
        private ListView lsvServExtraHoteles;
        private ColumnHeader hdServicio;
        private ColumnHeader hdTarifaServ;
        private ColumnHeader hdPorPersona;
        private TextBox txtNombreHabitacion;
        private Label lblEstrellas;
        private ListView lsvHabitaciones;
        private ColumnHeader hdHabitacion;
        private ColumnHeader hdTarifa;
        private ColumnHeader hdDisponibilidad;
        private ColumnHeader hdCapacidad;
        private ColumnHeader hdAdultos;
        private ColumnHeader hdMenores;
        private ColumnHeader hdInfantes;
        private Label lblHabitaciones;
        private Label lblServExtra;
        private ColumnHeader hdFechaDesde;
        private ColumnHeader hdFechaHasta;
    }
}