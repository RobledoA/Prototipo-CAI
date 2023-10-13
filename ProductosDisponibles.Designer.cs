namespace Prototipo_CAI
{
    partial class ClasesVuelo
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
            lsvProductosDisponibles = new ListView();
            button1 = new Button();
            button2 = new Button();
            btnDetalles = new Button();
            btnCrearItinerario = new Button();
            lblPresupuesto = new Label();
            button3 = new Button();
            grpAereos = new GroupBox();
            chkIdaVuelta = new CheckBox();
            btnBuscarAereos = new Button();
            label6 = new Label();
            txtPasajeros = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dtFechaDesde = new DateTimePicker();
            label4 = new Label();
            txtDestino = new TextBox();
            label3 = new Label();
            txtOrigen = new TextBox();
            grpHoteles = new GroupBox();
            btnBuscarHoteles = new Button();
            label9 = new Label();
            label8 = new Label();
            dateTimePicker2 = new DateTimePicker();
            txtUbicacion = new TextBox();
            label10 = new Label();
            label7 = new Label();
            dateTimePicker3 = new DateTimePicker();
            cmbCalifiacion = new ComboBox();
            txtHabitaciones = new TextBox();
            label1 = new Label();
            btnAgregarHoteles = new Button();
            grpAgregarHoteles = new GroupBox();
            lblContadorHabitaciones = new Label();
            label12 = new Label();
            label11 = new Label();
            lblTHabitacion = new Label();
            comboBox2 = new ComboBox();
            lblHuespedes = new Label();
            comboBox1 = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpAgregarVuelos = new GroupBox();
            lblinfantes = new Label();
            comboBox6 = new ComboBox();
            lblMenores = new Label();
            comboBox5 = new ComboBox();
            label13 = new Label();
            comboBox4 = new ComboBox();
            lblContadorasientos = new Label();
            label15 = new Label();
            label17 = new Label();
            label14 = new Label();
            button4 = new Button();
            comboBox3 = new ComboBox();
            grpTarifa = new GroupBox();
            listView1 = new ListView();
            hdCodProd = new ColumnHeader();
            hdPrecio = new ColumnHeader();
            grpAereos.SuspendLayout();
            grpHoteles.SuspendLayout();
            grpAgregarHoteles.SuspendLayout();
            grpAgregarVuelos.SuspendLayout();
            grpTarifa.SuspendLayout();
            SuspendLayout();
            // 
            // lsvProductosDisponibles
            // 
            lsvProductosDisponibles.FullRowSelect = true;
            lsvProductosDisponibles.Location = new Point(12, 12);
            lsvProductosDisponibles.MultiSelect = false;
            lsvProductosDisponibles.Name = "lsvProductosDisponibles";
            lsvProductosDisponibles.Size = new Size(979, 228);
            lsvProductosDisponibles.TabIndex = 0;
            lsvProductosDisponibles.UseCompatibleStateImageBehavior = false;
            lsvProductosDisponibles.View = View.Details;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(997, 12);
            button1.Name = "button1";
            button1.Size = new Size(115, 47);
            button1.TabIndex = 1;
            button1.Text = "Aéreos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(997, 75);
            button2.Name = "button2";
            button2.Size = new Size(115, 47);
            button2.TabIndex = 2;
            button2.Text = "Hotelería";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(1018, 170);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(75, 23);
            btnDetalles.TabIndex = 6;
            btnDetalles.Text = "Ver Detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // btnCrearItinerario
            // 
            btnCrearItinerario.Location = new Point(755, 535);
            btnCrearItinerario.Name = "btnCrearItinerario";
            btnCrearItinerario.Size = new Size(115, 47);
            btnCrearItinerario.TabIndex = 7;
            btnCrearItinerario.Text = "Crear Itinerario";
            btnCrearItinerario.UseVisualStyleBackColor = true;
            // 
            // lblPresupuesto
            // 
            lblPresupuesto.AutoSize = true;
            lblPresupuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPresupuesto.Location = new Point(1007, 146);
            lblPresupuesto.Name = "lblPresupuesto";
            lblPresupuesto.Size = new Size(96, 21);
            lblPresupuesto.TabIndex = 8;
            lblPresupuesto.Text = "Presupuesto";
            // 
            // button3
            // 
            button3.Location = new Point(877, 535);
            button3.Name = "button3";
            button3.Size = new Size(115, 47);
            button3.TabIndex = 9;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // grpAereos
            // 
            grpAereos.Controls.Add(chkIdaVuelta);
            grpAereos.Controls.Add(btnBuscarAereos);
            grpAereos.Controls.Add(label6);
            grpAereos.Controls.Add(txtPasajeros);
            grpAereos.Controls.Add(label5);
            grpAereos.Controls.Add(dateTimePicker1);
            grpAereos.Controls.Add(label2);
            grpAereos.Controls.Add(dtFechaDesde);
            grpAereos.Controls.Add(label4);
            grpAereos.Controls.Add(txtDestino);
            grpAereos.Controls.Add(label3);
            grpAereos.Controls.Add(txtOrigen);
            grpAereos.Location = new Point(22, 302);
            grpAereos.Name = "grpAereos";
            grpAereos.Size = new Size(477, 210);
            grpAereos.TabIndex = 11;
            grpAereos.TabStop = false;
            grpAereos.Text = "Opciones de Búsqueda";
            // 
            // chkIdaVuelta
            // 
            chkIdaVuelta.AutoSize = true;
            chkIdaVuelta.Location = new Point(36, 180);
            chkIdaVuelta.Name = "chkIdaVuelta";
            chkIdaVuelta.Size = new Size(87, 19);
            chkIdaVuelta.TabIndex = 24;
            chkIdaVuelta.Text = "Ida y Vuelta";
            chkIdaVuelta.UseVisualStyleBackColor = true;
            chkIdaVuelta.CheckedChanged += chkIdaVuelta_CheckedChanged;
            // 
            // btnBuscarAereos
            // 
            btnBuscarAereos.Location = new Point(242, 150);
            btnBuscarAereos.Margin = new Padding(3, 2, 3, 2);
            btnBuscarAereos.Name = "btnBuscarAereos";
            btnBuscarAereos.Size = new Size(31, 31);
            btnBuscarAereos.TabIndex = 14;
            btnBuscarAereos.Text = "🔍";
            btnBuscarAereos.UseVisualStyleBackColor = true;
            btnBuscarAereos.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 136);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 11;
            label6.Text = "Cantidad de Pasajeros";
            // 
            // txtPasajeros
            // 
            txtPasajeros.Location = new Point(35, 154);
            txtPasajeros.Name = "txtPasajeros";
            txtPasajeros.Size = new Size(200, 23);
            txtPasajeros.TabIndex = 10;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(251, 104);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.Yes;
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
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
            // grpHoteles
            // 
            grpHoteles.Controls.Add(btnBuscarHoteles);
            grpHoteles.Controls.Add(label9);
            grpHoteles.Controls.Add(label8);
            grpHoteles.Controls.Add(dateTimePicker2);
            grpHoteles.Controls.Add(txtUbicacion);
            grpHoteles.Controls.Add(label10);
            grpHoteles.Controls.Add(label7);
            grpHoteles.Controls.Add(dateTimePicker3);
            grpHoteles.Controls.Add(cmbCalifiacion);
            grpHoteles.Controls.Add(txtHabitaciones);
            grpHoteles.Controls.Add(label1);
            grpHoteles.Location = new Point(22, 302);
            grpHoteles.Name = "grpHoteles";
            grpHoteles.Size = new Size(477, 210);
            grpHoteles.TabIndex = 12;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(250, 86);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(71, 15);
            label9.TabIndex = 15;
            label9.Text = "Fecha Hasta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 37);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 16;
            label8.Text = "Ubicación";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(251, 104);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.RightToLeft = RightToLeft.Yes;
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 14;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(35, 55);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(200, 23);
            txtUbicacion.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 86);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 13;
            label10.Text = "Fecha Desde";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 137);
            label7.Name = "label7";
            label7.Size = new Size(143, 15);
            label7.TabIndex = 13;
            label7.Text = "Cantidad de Habitaciones";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(35, 104);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 12;
            // 
            // cmbCalifiacion
            // 
            cmbCalifiacion.FormattingEnabled = true;
            cmbCalifiacion.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbCalifiacion.Location = new Point(250, 55);
            cmbCalifiacion.Name = "cmbCalifiacion";
            cmbCalifiacion.Size = new Size(199, 23);
            cmbCalifiacion.TabIndex = 14;
            // 
            // txtHabitaciones
            // 
            txtHabitaciones.Location = new Point(35, 155);
            txtHabitaciones.Name = "txtHabitaciones";
            txtHabitaciones.Size = new Size(200, 23);
            txtHabitaciones.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 37);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 13;
            label1.Text = "Calificación";
            label1.Click += label1_Click;
            // 
            // btnAgregarHoteles
            // 
            btnAgregarHoteles.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarHoteles.Location = new Point(13, 243);
            btnAgregarHoteles.Name = "btnAgregarHoteles";
            btnAgregarHoteles.Size = new Size(196, 26);
            btnAgregarHoteles.TabIndex = 13;
            btnAgregarHoteles.Text = "Agregar al Carrito \U0001f6d2";
            btnAgregarHoteles.UseVisualStyleBackColor = true;
            // 
            // grpAgregarHoteles
            // 
            grpAgregarHoteles.Controls.Add(lblContadorHabitaciones);
            grpAgregarHoteles.Controls.Add(label12);
            grpAgregarHoteles.Controls.Add(label11);
            grpAgregarHoteles.Controls.Add(lblTHabitacion);
            grpAgregarHoteles.Controls.Add(comboBox2);
            grpAgregarHoteles.Controls.Add(lblHuespedes);
            grpAgregarHoteles.Controls.Add(comboBox1);
            grpAgregarHoteles.Controls.Add(btnAgregarHoteles);
            grpAgregarHoteles.Location = new Point(505, 302);
            grpAgregarHoteles.Margin = new Padding(3, 2, 3, 2);
            grpAgregarHoteles.Name = "grpAgregarHoteles";
            grpAgregarHoteles.Padding = new Padding(3, 2, 3, 2);
            grpAgregarHoteles.Size = new Size(224, 282);
            grpAgregarHoteles.TabIndex = 14;
            grpAgregarHoteles.TabStop = false;
            grpAgregarHoteles.Text = "Carrito";
            grpAgregarHoteles.Enter += grpAgregarHoteles_Enter;
            // 
            // lblContadorHabitaciones
            // 
            lblContadorHabitaciones.AutoSize = true;
            lblContadorHabitaciones.Location = new Point(81, 109);
            lblContadorHabitaciones.Name = "lblContadorHabitaciones";
            lblContadorHabitaciones.Size = new Size(13, 15);
            lblContadorHabitaciones.TabIndex = 21;
            lblContadorHabitaciones.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 108);
            label12.Name = "label12";
            label12.Size = new Size(71, 15);
            label12.TabIndex = 20;
            label12.Text = "Disponibles:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 117);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 19;
            // 
            // lblTHabitacion
            // 
            lblTHabitacion.AutoSize = true;
            lblTHabitacion.Location = new Point(13, 61);
            lblTHabitacion.Name = "lblTHabitacion";
            lblTHabitacion.Size = new Size(112, 15);
            lblTHabitacion.TabIndex = 17;
            lblTHabitacion.Text = "Tipos de Habitación";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(13, 80);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(196, 23);
            comboBox2.TabIndex = 16;
            // 
            // lblHuespedes
            // 
            lblHuespedes.AutoSize = true;
            lblHuespedes.Location = new Point(13, 146);
            lblHuespedes.Name = "lblHuespedes";
            lblHuespedes.Size = new Size(132, 15);
            lblHuespedes.TabIndex = 15;
            lblHuespedes.Text = "Cantidad de Huespedes";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 165);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(196, 23);
            comboBox1.TabIndex = 14;
            // 
            // grpAgregarVuelos
            // 
            grpAgregarVuelos.Controls.Add(lblinfantes);
            grpAgregarVuelos.Controls.Add(comboBox6);
            grpAgregarVuelos.Controls.Add(lblMenores);
            grpAgregarVuelos.Controls.Add(comboBox5);
            grpAgregarVuelos.Controls.Add(label13);
            grpAgregarVuelos.Controls.Add(comboBox4);
            grpAgregarVuelos.Controls.Add(lblContadorasientos);
            grpAgregarVuelos.Controls.Add(label15);
            grpAgregarVuelos.Controls.Add(label17);
            grpAgregarVuelos.Controls.Add(label14);
            grpAgregarVuelos.Controls.Add(button4);
            grpAgregarVuelos.Controls.Add(comboBox3);
            grpAgregarVuelos.Location = new Point(505, 302);
            grpAgregarVuelos.Margin = new Padding(3, 2, 3, 2);
            grpAgregarVuelos.Name = "grpAgregarVuelos";
            grpAgregarVuelos.Padding = new Padding(3, 2, 3, 2);
            grpAgregarVuelos.Size = new Size(224, 282);
            grpAgregarVuelos.TabIndex = 15;
            grpAgregarVuelos.TabStop = false;
            grpAgregarVuelos.Text = "Carrito";
            grpAgregarVuelos.Enter += grpAgregarVuelos_Enter;
            // 
            // lblinfantes
            // 
            lblinfantes.AutoSize = true;
            lblinfantes.Location = new Point(13, 192);
            lblinfantes.Name = "lblinfantes";
            lblinfantes.Size = new Size(49, 15);
            lblinfantes.TabIndex = 29;
            lblinfantes.Text = "Infantes";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(13, 211);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(196, 23);
            comboBox6.TabIndex = 28;
            // 
            // lblMenores
            // 
            lblMenores.AutoSize = true;
            lblMenores.Location = new Point(13, 145);
            lblMenores.Name = "lblMenores";
            lblMenores.Size = new Size(53, 15);
            lblMenores.TabIndex = 27;
            lblMenores.Text = "Menores";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(13, 164);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(196, 23);
            comboBox5.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 96);
            label13.Name = "label13";
            label13.Size = new Size(52, 15);
            label13.TabIndex = 25;
            label13.Text = "Mayores";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(13, 115);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(196, 23);
            comboBox4.TabIndex = 24;
            comboBox4.Text = "1";
            // 
            // lblContadorasientos
            // 
            lblContadorasientos.AutoSize = true;
            lblContadorasientos.Location = new Point(125, 75);
            lblContadorasientos.Name = "lblContadorasientos";
            lblContadorasientos.Size = new Size(13, 15);
            lblContadorasientos.TabIndex = 23;
            lblContadorasientos.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 83);
            label15.Name = "label15";
            label15.Size = new Size(0, 15);
            label15.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(10, 74);
            label17.Name = "label17";
            label17.Size = new Size(119, 15);
            label17.TabIndex = 22;
            label17.Text = "Asientos Disponibles:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(13, 29);
            label14.Name = "label14";
            label14.Size = new Size(40, 15);
            label14.TabIndex = 23;
            label14.Text = "Clases";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(13, 243);
            button4.Name = "button4";
            button4.Size = new Size(196, 26);
            button4.TabIndex = 13;
            button4.Text = "Agregar al Carrito \U0001f6d2";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Economy", "Premium", "Business", "First" });
            comboBox3.Location = new Point(13, 48);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(196, 23);
            comboBox3.TabIndex = 22;
            // 
            // grpTarifa
            // 
            grpTarifa.Controls.Add(listView1);
            grpTarifa.Location = new Point(735, 305);
            grpTarifa.Name = "grpTarifa";
            grpTarifa.Size = new Size(256, 224);
            grpTarifa.TabIndex = 16;
            grpTarifa.TabStop = false;
            grpTarifa.Text = "Tarifas";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { hdCodProd, hdPrecio });
            listView1.Location = new Point(14, 29);
            listView1.Name = "listView1";
            listView1.Size = new Size(236, 181);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // hdCodProd
            // 
            hdCodProd.Text = "Código Producto";
            hdCodProd.Width = 120;
            // 
            // hdPrecio
            // 
            hdPrecio.Text = "Precio";
            hdPrecio.Width = 120;
            // 
            // ClasesVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 613);
            Controls.Add(grpTarifa);
            Controls.Add(grpHoteles);
            Controls.Add(grpAgregarVuelos);
            Controls.Add(grpAgregarHoteles);
            Controls.Add(grpAereos);
            Controls.Add(button3);
            Controls.Add(lblPresupuesto);
            Controls.Add(btnCrearItinerario);
            Controls.Add(btnDetalles);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lsvProductosDisponibles);
            Name = "ClasesVuelo";
            Text = "Productos Disponibles";
            Load += ProductosDisponibles_Load;
            grpAereos.ResumeLayout(false);
            grpAereos.PerformLayout();
            grpHoteles.ResumeLayout(false);
            grpHoteles.PerformLayout();
            grpAgregarHoteles.ResumeLayout(false);
            grpAgregarHoteles.PerformLayout();
            grpAgregarVuelos.ResumeLayout(false);
            grpAgregarVuelos.PerformLayout();
            grpTarifa.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvProductosDisponibles;
        private Button button1;
        private Button button2;
        private Button btnDetalles;
        private Button btnCrearItinerario;
        private Label lblPresupuesto;
        private Button button3;
        private GroupBox grpAereos;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DateTimePicker dtFechaDesde;
        private Label label4;
        private TextBox txtDestino;
        private Label label3;
        private TextBox txtOrigen;
        private Label label6;
        private TextBox txtPasajeros;
        private GroupBox grpHoteles;
        private Label label1;
        private ComboBox cmbCalifiacion;
        private Label label9;
        private DateTimePicker dateTimePicker2;
        private Label label10;
        private DateTimePicker dateTimePicker3;
        private Label label8;
        private TextBox txtUbicacion;
        private Label label7;
        private TextBox txtHabitaciones;
        private Button btnAgregarHoteles;
        private Button btnBuscarAereos;
        private Button btnBuscarHoteles;
        private GroupBox grpAgregarHoteles;
        private Label label11;
        private Label lblTHabitacion;
        private ComboBox comboBox2;
        private Label lblHuespedes;
        private ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grpAgregarVuelos;
        private Button button4;
        private Label lblContadorHabitaciones;
        private Label label12;
        private Label label14;
        private ComboBox comboBox3;
        private Label label15;
        private Label lblContadorasientos;
        private Label label17;
        private CheckBox chkIdaVuelta;
        private Label label13;
        private ComboBox comboBox4;
        private Label lblMenores;
        private ComboBox comboBox5;
        private Label lblinfantes;
        private ComboBox comboBox6;
        private GroupBox grpTarifa;
        private ListView listView1;
        private ColumnHeader hdCodProd;
        private ColumnHeader hdPrecio;
    }
}