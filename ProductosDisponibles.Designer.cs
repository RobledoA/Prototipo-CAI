namespace Prototipo_CAI
{
    partial class ProductosDisponibles
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
            button4 = new Button();
            grpAereos.SuspendLayout();
            grpHoteles.SuspendLayout();
            SuspendLayout();
            // 
            // lsvProductosDisponibles
            // 
            lsvProductosDisponibles.CheckBoxes = true;
            lsvProductosDisponibles.FullRowSelect = true;
            lsvProductosDisponibles.Location = new Point(12, 12);
            lsvProductosDisponibles.MultiSelect = false;
            lsvProductosDisponibles.Name = "lsvProductosDisponibles";
            lsvProductosDisponibles.Size = new Size(729, 228);
            lsvProductosDisponibles.TabIndex = 0;
            lsvProductosDisponibles.UseCompatibleStateImageBehavior = false;
            lsvProductosDisponibles.View = View.Details;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(747, 12);
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
            button2.Location = new Point(747, 75);
            button2.Name = "button2";
            button2.Size = new Size(115, 47);
            button2.TabIndex = 2;
            button2.Text = "Hotelería";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(766, 208);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(75, 23);
            btnDetalles.TabIndex = 6;
            btnDetalles.Text = "Ver Detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // btnCrearItinerario
            // 
            btnCrearItinerario.Location = new Point(505, 246);
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
            lblPresupuesto.Location = new Point(757, 146);
            lblPresupuesto.Name = "lblPresupuesto";
            lblPresupuesto.Size = new Size(96, 21);
            lblPresupuesto.TabIndex = 8;
            lblPresupuesto.Text = "Presupuesto";
            // 
            // button3
            // 
            button3.Location = new Point(626, 246);
            button3.Name = "button3";
            button3.Size = new Size(115, 47);
            button3.TabIndex = 9;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // grpAereos
            // 
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
            grpAereos.Location = new Point(12, 299);
            grpAereos.Name = "grpAereos";
            grpAereos.Size = new Size(477, 210);
            grpAereos.TabIndex = 11;
            grpAereos.TabStop = false;
            grpAereos.Text = "Opciones de Búsqueda";
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
            grpHoteles.Location = new Point(31, 293);
            grpHoteles.Name = "grpHoteles";
            grpHoteles.Size = new Size(477, 210);
            grpHoteles.TabIndex = 12;
            grpHoteles.TabStop = false;
            grpHoteles.Text = "Opciones de Búsqueda";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(235, 86);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(71, 15);
            label9.TabIndex = 15;
            label9.Text = "Fecha Hasta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 37);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 16;
            label8.Text = "Ubicación";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(236, 104);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.RightToLeft = RightToLeft.Yes;
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 14;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(19, 55);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(200, 23);
            txtUbicacion.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 86);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 13;
            label10.Text = "Fecha Desde";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 136);
            label7.Name = "label7";
            label7.Size = new Size(143, 15);
            label7.TabIndex = 13;
            label7.Text = "Cantidad de Habitaciones";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(20, 104);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 23);
            dateTimePicker3.TabIndex = 12;
            // 
            // cmbCalifiacion
            // 
            cmbCalifiacion.FormattingEnabled = true;
            cmbCalifiacion.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbCalifiacion.Location = new Point(236, 55);
            cmbCalifiacion.Name = "cmbCalifiacion";
            cmbCalifiacion.Size = new Size(199, 23);
            cmbCalifiacion.TabIndex = 14;
            // 
            // txtHabitaciones
            // 
            txtHabitaciones.Location = new Point(18, 154);
            txtHabitaciones.Name = "txtHabitaciones";
            txtHabitaciones.Size = new Size(200, 23);
            txtHabitaciones.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 37);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 13;
            label1.Text = "Calificación";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(452, 246);
            button4.Name = "button4";
            button4.Size = new Size(47, 47);
            button4.TabIndex = 13;
            button4.Text = "\U0001f6d2";
            button4.UseVisualStyleBackColor = true;
            // 
            // ProductosDisponibles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 521);
            Controls.Add(button4);
            Controls.Add(grpHoteles);
            Controls.Add(grpAereos);
            Controls.Add(button3);
            Controls.Add(lblPresupuesto);
            Controls.Add(btnCrearItinerario);
            Controls.Add(btnDetalles);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lsvProductosDisponibles);
            Name = "ProductosDisponibles";
            Text = "Productos Disponibles";
            Load += ProductosDisponibles_Load;
            grpAereos.ResumeLayout(false);
            grpAereos.PerformLayout();
            grpHoteles.ResumeLayout(false);
            grpHoteles.PerformLayout();
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
        private Button button4;
    }
}