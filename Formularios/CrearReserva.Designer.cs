namespace Prototipo_CAI
{
    partial class CrearReserva
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
            lblNombrePasajero = new Label();
            txtNombrePasajero = new TextBox();
            txtDNIPasajero = new TextBox();
            lblDNIPasajero = new Label();
            txtPasaportePasajero = new TextBox();
            lblPasaportePasajero = new Label();
            dtpNacimientoP = new DateTimePicker();
            lblFechaNacPasajero = new Label();
            lblNacionalidadPasajero = new Label();
            lblGeneroPasajero = new Label();
            cmbNacionalidad = new ComboBox();
            cmbGenero = new ComboBox();
            btnConfirmarGuardarReserva = new Button();
            chklbTarifasAsignadas = new CheckedListBox();
            btnAgregarPasajero = new Button();
            lsvTarifasReserva = new ListView();
            gpbDatosPasajero = new GroupBox();
            lblTarifasAsignadas = new Label();
            button1 = new Button();
            button2 = new Button();
            gpbDatosPasajero.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombrePasajero
            // 
            lblNombrePasajero.AutoSize = true;
            lblNombrePasajero.Location = new Point(17, 29);
            lblNombrePasajero.Name = "lblNombrePasajero";
            lblNombrePasajero.Size = new Size(107, 15);
            lblNombrePasajero.TabIndex = 0;
            lblNombrePasajero.Text = "Nombre y Apellido";
            // 
            // txtNombrePasajero
            // 
            txtNombrePasajero.BackColor = Color.White;
            txtNombrePasajero.Location = new Point(17, 47);
            txtNombrePasajero.Name = "txtNombrePasajero";
            txtNombrePasajero.Size = new Size(216, 23);
            txtNombrePasajero.TabIndex = 1;
            txtNombrePasajero.TextChanged += txtNombrePasajero_TextChanged;
            // 
            // txtDNIPasajero
            // 
            txtDNIPasajero.BackColor = Color.White;
            txtDNIPasajero.Location = new Point(250, 47);
            txtDNIPasajero.Name = "txtDNIPasajero";
            txtDNIPasajero.Size = new Size(216, 23);
            txtDNIPasajero.TabIndex = 3;
            // 
            // lblDNIPasajero
            // 
            lblDNIPasajero.AutoSize = true;
            lblDNIPasajero.Location = new Point(250, 29);
            lblDNIPasajero.Name = "lblDNIPasajero";
            lblDNIPasajero.Size = new Size(27, 15);
            lblDNIPasajero.TabIndex = 2;
            lblDNIPasajero.Text = "DNI";
            // 
            // txtPasaportePasajero
            // 
            txtPasaportePasajero.BackColor = Color.White;
            txtPasaportePasajero.Location = new Point(17, 101);
            txtPasaportePasajero.Name = "txtPasaportePasajero";
            txtPasaportePasajero.Size = new Size(216, 23);
            txtPasaportePasajero.TabIndex = 5;
            // 
            // lblPasaportePasajero
            // 
            lblPasaportePasajero.AutoSize = true;
            lblPasaportePasajero.Location = new Point(17, 83);
            lblPasaportePasajero.Name = "lblPasaportePasajero";
            lblPasaportePasajero.Size = new Size(174, 15);
            lblPasaportePasajero.TabIndex = 4;
            lblPasaportePasajero.Text = "N° Pasaporte (De corresponder)";
            // 
            // dtpNacimientoP
            // 
            dtpNacimientoP.CalendarMonthBackground = Color.White;
            dtpNacimientoP.Location = new Point(250, 101);
            dtpNacimientoP.Name = "dtpNacimientoP";
            dtpNacimientoP.Size = new Size(216, 23);
            dtpNacimientoP.TabIndex = 6;
            // 
            // lblFechaNacPasajero
            // 
            lblFechaNacPasajero.AutoSize = true;
            lblFechaNacPasajero.Location = new Point(249, 83);
            lblFechaNacPasajero.Name = "lblFechaNacPasajero";
            lblFechaNacPasajero.Size = new Size(119, 15);
            lblFechaNacPasajero.TabIndex = 7;
            lblFechaNacPasajero.Text = "Fecha de Nacimiento";
            // 
            // lblNacionalidadPasajero
            // 
            lblNacionalidadPasajero.AutoSize = true;
            lblNacionalidadPasajero.Location = new Point(14, 131);
            lblNacionalidadPasajero.Name = "lblNacionalidadPasajero";
            lblNacionalidadPasajero.Size = new Size(77, 15);
            lblNacionalidadPasajero.TabIndex = 8;
            lblNacionalidadPasajero.Text = "Nacionalidad";
            // 
            // lblGeneroPasajero
            // 
            lblGeneroPasajero.AutoSize = true;
            lblGeneroPasajero.Location = new Point(249, 131);
            lblGeneroPasajero.Name = "lblGeneroPasajero";
            lblGeneroPasajero.Size = new Size(45, 15);
            lblGeneroPasajero.TabIndex = 10;
            lblGeneroPasajero.Text = "Género";
            // 
            // cmbNacionalidad
            // 
            cmbNacionalidad.BackColor = Color.White;
            cmbNacionalidad.FormattingEnabled = true;
            cmbNacionalidad.Items.AddRange(new object[] { "Afganistán", "Albania", "Alemania", "Andorra", "Angola", "Antigua y Barbuda", "Arabia Saudita", "Argelia", "Argentina", "Armenia", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bahréin", "Bangladesh", "Barbados", "Bélgica", "Belice", "Benín", "Bielorrusia", "Birmania (Myanmar)", "Bolivia", "Bosnia y Herzegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Catar", "Chad", "Chile", "China", "Chipre", "Ciudad del Vaticano", "Colombia", "Comoras", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Eswatini", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Georgia", "Ghana", "Granada", "Grecia", "Guatemala", "Guyana", "Guinea", "Guinea-Bissau", "Guinea Ecuatorial", "Haití", "Honduras", "Hungría", "India", "Indonesia", "Irak", "Irán", "Irlanda", "Islandia", "Islas Marshall", "Islas Salomón", "Israel", "Italia", "Jamaica", "Japón", "Jordania", "Kazajistán", "Kenia", "Kirguistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Macedonia del Norte", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Marruecos", "Mauricio", "Mauritania", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Mozambique", "Namibia", "Nauru", "Nepal", "Nicaragua", "Níger", "Nigeria", "Noruega", "Nueva Zelanda", "Omán", "Países Bajos", "Pakistán", "Palaos", "Panamá", "Papúa Nueva Guinea", "Paraguay", "Perú", "Polonia", "Portugal", "Reino Unido", "República Centroafricana", "República Checa", "República Democrática del Congo", "República Dominicana", "Ruanda", "Rumanía", "Rusia", "Samoa", "San Cristóbal y Nieves", "San Marino", "San Vicente y las Granadinas", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Serbia", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Sri Lanka", "Suazilandia", "Sudáfrica", "Sudán", "Sudán del Sur", "Suecia", "Suiza", "Surinam", "Tailandia", "Tanzania", "Tayikistán", "Timor Oriental", "Togo", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Uruguay", "Uzbekistán", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Yibuti", "Zambia", "Zimbabue" });
            cmbNacionalidad.Location = new Point(17, 149);
            cmbNacionalidad.Name = "cmbNacionalidad";
            cmbNacionalidad.Size = new Size(216, 23);
            cmbNacionalidad.TabIndex = 11;
            // 
            // cmbGenero
            // 
            cmbGenero.BackColor = Color.White;
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro..." });
            cmbGenero.Location = new Point(250, 149);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(216, 23);
            cmbGenero.TabIndex = 12;
            // 
            // btnConfirmarGuardarReserva
            // 
            btnConfirmarGuardarReserva.BackColor = Color.FromArgb(8, 32, 50);
            btnConfirmarGuardarReserva.FlatAppearance.BorderSize = 0;
            btnConfirmarGuardarReserva.FlatStyle = FlatStyle.Flat;
            btnConfirmarGuardarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmarGuardarReserva.ForeColor = Color.White;
            btnConfirmarGuardarReserva.Location = new Point(684, 545);
            btnConfirmarGuardarReserva.Name = "btnConfirmarGuardarReserva";
            btnConfirmarGuardarReserva.Size = new Size(155, 34);
            btnConfirmarGuardarReserva.TabIndex = 18;
            btnConfirmarGuardarReserva.Text = "Cerrar";
            btnConfirmarGuardarReserva.UseVisualStyleBackColor = false;
            // 
            // chklbTarifasAsignadas
            // 
            chklbTarifasAsignadas.BackColor = Color.FromArgb(156, 184, 205);
            chklbTarifasAsignadas.BorderStyle = BorderStyle.None;
            chklbTarifasAsignadas.FormattingEnabled = true;
            chklbTarifasAsignadas.Location = new Point(491, 42);
            chklbTarifasAsignadas.Name = "chklbTarifasAsignadas";
            chklbTarifasAsignadas.Size = new Size(320, 180);
            chklbTarifasAsignadas.TabIndex = 20;
            // 
            // btnAgregarPasajero
            // 
            btnAgregarPasajero.BackColor = Color.FromArgb(8, 32, 50);
            btnAgregarPasajero.FlatAppearance.BorderSize = 0;
            btnAgregarPasajero.FlatStyle = FlatStyle.Flat;
            btnAgregarPasajero.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarPasajero.ForeColor = Color.White;
            btnAgregarPasajero.Location = new Point(12, 274);
            btnAgregarPasajero.Name = "btnAgregarPasajero";
            btnAgregarPasajero.Size = new Size(393, 34);
            btnAgregarPasajero.TabIndex = 21;
            btnAgregarPasajero.Text = "Agregar v v v";
            btnAgregarPasajero.UseVisualStyleBackColor = false;
            btnAgregarPasajero.Click += btnAgregarPasajero_Click;
            // 
            // lsvTarifasReserva
            // 
            lsvTarifasReserva.BackColor = Color.FromArgb(156, 184, 205);
            lsvTarifasReserva.Location = new Point(12, 330);
            lsvTarifasReserva.Name = "lsvTarifasReserva";
            lsvTarifasReserva.Size = new Size(827, 209);
            lsvTarifasReserva.TabIndex = 22;
            lsvTarifasReserva.UseCompatibleStateImageBehavior = false;
            // 
            // gpbDatosPasajero
            // 
            gpbDatosPasajero.Controls.Add(lblTarifasAsignadas);
            gpbDatosPasajero.Controls.Add(txtDNIPasajero);
            gpbDatosPasajero.Controls.Add(lblNombrePasajero);
            gpbDatosPasajero.Controls.Add(txtNombrePasajero);
            gpbDatosPasajero.Controls.Add(chklbTarifasAsignadas);
            gpbDatosPasajero.Controls.Add(lblDNIPasajero);
            gpbDatosPasajero.Controls.Add(lblPasaportePasajero);
            gpbDatosPasajero.Controls.Add(txtPasaportePasajero);
            gpbDatosPasajero.Controls.Add(dtpNacimientoP);
            gpbDatosPasajero.Controls.Add(cmbGenero);
            gpbDatosPasajero.Controls.Add(lblFechaNacPasajero);
            gpbDatosPasajero.Controls.Add(cmbNacionalidad);
            gpbDatosPasajero.Controls.Add(lblNacionalidadPasajero);
            gpbDatosPasajero.Controls.Add(lblGeneroPasajero);
            gpbDatosPasajero.Location = new Point(12, 12);
            gpbDatosPasajero.Name = "gpbDatosPasajero";
            gpbDatosPasajero.Size = new Size(827, 242);
            gpbDatosPasajero.TabIndex = 24;
            gpbDatosPasajero.TabStop = false;
            gpbDatosPasajero.Text = "Datos Pasajero";
            // 
            // lblTarifasAsignadas
            // 
            lblTarifasAsignadas.AutoSize = true;
            lblTarifasAsignadas.Location = new Point(491, 24);
            lblTarifasAsignadas.Name = "lblTarifasAsignadas";
            lblTarifasAsignadas.Size = new Size(97, 15);
            lblTarifasAsignadas.TabIndex = 22;
            lblTarifasAsignadas.Text = "Tarifas Asignadas";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(8, 32, 50);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(446, 274);
            button1.Name = "button1";
            button1.Size = new Size(393, 34);
            button1.TabIndex = 25;
            button1.Text = "Eliminar ^ ^ ^";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(8, 32, 50);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(523, 545);
            button2.Name = "button2";
            button2.Size = new Size(155, 34);
            button2.TabIndex = 26;
            button2.Text = "Crear reserva";
            button2.UseVisualStyleBackColor = false;
            // 
            // CrearReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(86, 124, 153);
            ClientSize = new Size(851, 586);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(gpbDatosPasajero);
            Controls.Add(lsvTarifasReserva);
            Controls.Add(btnConfirmarGuardarReserva);
            Controls.Add(btnAgregarPasajero);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CrearReserva";
            Text = "Crear Reserva";
            Load += CrearReserva_Load;
            gpbDatosPasajero.ResumeLayout(false);
            gpbDatosPasajero.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombrePasajero;
        private TextBox txtNombrePasajero;
        private TextBox txtDNIPasajero;
        private Label lblDNIPasajero;
        private TextBox txtPasaportePasajero;
        private Label lblPasaportePasajero;
        private DateTimePicker dtpNacimientoP;
        private Label lblFechaNacPasajero;
        private Label lblNacionalidadPasajero;
        private Label lblGeneroPasajero;
        private ComboBox cmbNacionalidad;
        private ComboBox cmbGenero;
        private Button btnConfirmarGuardarReserva;
        private CheckedListBox chklbTarifasAsignadas;
        private Button btnAgregarPasajero;
        private ListView lsvTarifasReserva;
        private GroupBox gpbDatosPasajero;
        private Label lblTarifasAsignadas;
        private Button button1;
        private Button button2;
    }
}