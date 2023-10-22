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
            lsvTarifas = new ListView();
            hdTarifaAdulto = new ColumnHeader();
            hdTarifaMenor = new ColumnHeader();
            hdTarifaInfante = new ColumnHeader();
            lblTarifas = new Label();
            lblInfantes = new Label();
            lblMenores = new Label();
            lsvServExtraHoteles = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            txtNombreHabitacion = new TextBox();
            lblServiciosExtra = new Label();
            lblCapacidad = new Label();
            txtCapacidad = new TextBox();
            lblDisponibilidad = new Label();
            lblAdultos = new Label();
            lblEstrellas = new Label();
            lblHabitacion = new Label();
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
            // lsvTarifas
            // 
            lsvTarifas.Columns.AddRange(new ColumnHeader[] { hdTarifaAdulto, hdTarifaMenor, hdTarifaInfante });
            lsvTarifas.Location = new Point(314, 52);
            lsvTarifas.Name = "lsvTarifas";
            lsvTarifas.Size = new Size(453, 55);
            lsvTarifas.TabIndex = 70;
            lsvTarifas.UseCompatibleStateImageBehavior = false;
            lsvTarifas.View = View.Details;
            // 
            // hdTarifaAdulto
            // 
            hdTarifaAdulto.Text = "Tarifa Adulto";
            hdTarifaAdulto.Width = 120;
            // 
            // hdTarifaMenor
            // 
            hdTarifaMenor.Text = "Tarifa Menor";
            hdTarifaMenor.Width = 120;
            // 
            // hdTarifaInfante
            // 
            hdTarifaInfante.Text = "Tarifa Infante";
            hdTarifaInfante.Width = 120;
            // 
            // lblTarifas
            // 
            lblTarifas.AutoSize = true;
            lblTarifas.Location = new Point(224, 52);
            lblTarifas.Name = "lblTarifas";
            lblTarifas.Size = new Size(40, 15);
            lblTarifas.TabIndex = 69;
            lblTarifas.Text = "Tarifas";
            // 
            // lblInfantes
            // 
            lblInfantes.AutoSize = true;
            lblInfantes.Location = new Point(224, 280);
            lblInfantes.Name = "lblInfantes";
            lblInfantes.Size = new Size(49, 15);
            lblInfantes.TabIndex = 67;
            lblInfantes.Text = "Infantes";
            // 
            // lblMenores
            // 
            lblMenores.AutoSize = true;
            lblMenores.Location = new Point(223, 253);
            lblMenores.Name = "lblMenores";
            lblMenores.Size = new Size(53, 15);
            lblMenores.TabIndex = 65;
            lblMenores.Text = "Menores";
            // 
            // lsvServExtraHoteles
            // 
            lsvServExtraHoteles.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8 });
            lsvServExtraHoteles.Location = new Point(314, 390);
            lsvServExtraHoteles.Name = "lsvServExtraHoteles";
            lsvServExtraHoteles.Size = new Size(453, 97);
            lsvServExtraHoteles.TabIndex = 64;
            lsvServExtraHoteles.UseCompatibleStateImageBehavior = false;
            lsvServExtraHoteles.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Código";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Descripción";
            columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Tarifa ";
            columnHeader8.Width = 120;
            // 
            // txtNombreHabitacion
            // 
            txtNombreHabitacion.Location = new Point(314, 12);
            txtNombreHabitacion.Name = "txtNombreHabitacion";
            txtNombreHabitacion.Size = new Size(186, 23);
            txtNombreHabitacion.TabIndex = 55;
            // 
            // lblServiciosExtra
            // 
            lblServiciosExtra.AutoSize = true;
            lblServiciosExtra.Location = new Point(224, 390);
            lblServiciosExtra.Name = "lblServiciosExtra";
            lblServiciosExtra.Size = new Size(56, 30);
            lblServiciosExtra.TabIndex = 63;
            lblServiciosExtra.Text = "Servicios \r\nExtra";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(224, 160);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(63, 15);
            lblCapacidad.TabIndex = 56;
            lblCapacidad.Text = "Capacidad";
            // 
            // txtCapacidad
            // 
            txtCapacidad.Location = new Point(314, 157);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(453, 23);
            txtCapacidad.TabIndex = 57;
            // 
            // lblDisponibilidad
            // 
            lblDisponibilidad.AutoSize = true;
            lblDisponibilidad.Location = new Point(224, 323);
            lblDisponibilidad.Name = "lblDisponibilidad";
            lblDisponibilidad.Size = new Size(83, 15);
            lblDisponibilidad.TabIndex = 61;
            lblDisponibilidad.Text = "Disponibilidad";
            // 
            // lblAdultos
            // 
            lblAdultos.AutoSize = true;
            lblAdultos.Location = new Point(224, 225);
            lblAdultos.Name = "lblAdultos";
            lblAdultos.Size = new Size(48, 15);
            lblAdultos.TabIndex = 58;
            lblAdultos.Text = "Adultos";
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
            // lblHabitacion
            // 
            lblHabitacion.AutoSize = true;
            lblHabitacion.Location = new Point(224, 15);
            lblHabitacion.Name = "lblHabitacion";
            lblHabitacion.Size = new Size(65, 15);
            lblHabitacion.TabIndex = 75;
            lblHabitacion.Text = "Habitacion";
            // 
            // Habitaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 533);
            Controls.Add(lblHabitacion);
            Controls.Add(lblEstrellas);
            Controls.Add(lblDireccion);
            Controls.Add(lblNombreHotel);
            Controls.Add(lsvTarifas);
            Controls.Add(lblTarifas);
            Controls.Add(lblInfantes);
            Controls.Add(lblMenores);
            Controls.Add(lsvServExtraHoteles);
            Controls.Add(txtNombreHabitacion);
            Controls.Add(lblServiciosExtra);
            Controls.Add(lblCapacidad);
            Controls.Add(txtCapacidad);
            Controls.Add(lblDisponibilidad);
            Controls.Add(lblAdultos);
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
        private Label lblTarifas;
        private Label lblInfantes;
        private Label lblMenores;
        private ListView lsvServExtraHoteles;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private TextBox txtNombreHabitacion;
        private Label lblServiciosExtra;
        private Label lblCapacidad;
        private TextBox txtCapacidad;
        private Label lblDisponibilidad;
        private Label lblAdultos;
        private Label lblEstrellas;
        private Label lblHabitacion;
    }
}