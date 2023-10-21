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
            grpAgregarHoteles = new GroupBox();
            lblContadorHabitaciones = new Label();
            label12 = new Label();
            label11 = new Label();
            lblTHabitacion = new Label();
            comboBox2 = new ComboBox();
            lblHuespedes = new Label();
            comboBox1 = new ComboBox();
            btnAgregarHoteles = new Button();
            grpTarifa = new GroupBox();
            lsvTarifas = new ListView();
            hdCodProd = new ColumnHeader();
            hdTipoProducto = new ColumnHeader();
            hdTarifa = new ColumnHeader();
            lsvHoteles = new ListView();
            hdCodigo = new ColumnHeader();
            hdNombre = new ColumnHeader();
            hdCiudad = new ColumnHeader();
            hdDireccion = new ColumnHeader();
            hdCalificacion = new ColumnHeader();
            hdDisponibilidad = new ColumnHeader();
            button3 = new Button();
            btnDetalles = new Button();
            grpHoteles.SuspendLayout();
            grpAgregarHoteles.SuspendLayout();
            grpTarifa.SuspendLayout();
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
            grpHoteles.Location = new Point(12, 341);
            grpHoteles.Name = "grpHoteles";
            grpHoteles.Size = new Size(477, 210);
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(250, 87);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(71, 15);
            label9.TabIndex = 15;
            label9.Text = "Fecha Hasta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 38);
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
            label10.Location = new Point(34, 87);
            label10.Name = "label10";
            label10.Size = new Size(73, 15);
            label10.TabIndex = 13;
            label10.Text = "Fecha Desde";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 138);
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
            label1.Location = new Point(247, 38);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 13;
            label1.Text = "Calificación";
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
            grpAgregarHoteles.Location = new Point(519, 282);
            grpAgregarHoteles.Margin = new Padding(3, 2, 3, 2);
            grpAgregarHoteles.Name = "grpAgregarHoteles";
            grpAgregarHoteles.Padding = new Padding(3, 2, 3, 2);
            grpAgregarHoteles.Size = new Size(224, 282);
            grpAgregarHoteles.TabIndex = 20;
            grpAgregarHoteles.TabStop = false;
            grpAgregarHoteles.Text = "Carrito";
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
            // btnAgregarHoteles
            // 
            btnAgregarHoteles.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarHoteles.Location = new Point(13, 243);
            btnAgregarHoteles.Name = "btnAgregarHoteles";
            btnAgregarHoteles.Size = new Size(196, 26);
            btnAgregarHoteles.TabIndex = 13;
            btnAgregarHoteles.Text = "Agregar al Carrito \U0001f6d2";
            btnAgregarHoteles.UseVisualStyleBackColor = true;
            btnAgregarHoteles.Click += btnAgregarHoteles_Click;
            // 
            // grpTarifa
            // 
            grpTarifa.Controls.Add(lsvTarifas);
            grpTarifa.Location = new Point(757, 305);
            grpTarifa.Name = "grpTarifa";
            grpTarifa.Size = new Size(377, 224);
            grpTarifa.TabIndex = 21;
            grpTarifa.TabStop = false;
            grpTarifa.Text = "Tarifas";
            // 
            // lsvTarifas
            // 
            lsvTarifas.Columns.AddRange(new ColumnHeader[] { hdCodProd, hdTipoProducto, hdTarifa });
            lsvTarifas.Location = new Point(5, 29);
            lsvTarifas.Name = "lsvTarifas";
            lsvTarifas.Size = new Size(367, 181);
            lsvTarifas.TabIndex = 0;
            lsvTarifas.UseCompatibleStateImageBehavior = false;
            lsvTarifas.View = View.Details;
            // 
            // hdCodProd
            // 
            hdCodProd.Text = "Código Producto";
            hdCodProd.Width = 150;
            // 
            // hdTipoProducto
            // 
            hdTipoProducto.Text = "Producto";
            hdTipoProducto.Width = 120;
            // 
            // hdTarifa
            // 
            hdTarifa.Text = "Tarifa";
            hdTarifa.Width = 120;
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
            // button3
            // 
            button3.Location = new Point(1014, 230);
            button3.Name = "button3";
            button3.Size = new Size(115, 47);
            button3.TabIndex = 23;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(10, 284);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(89, 23);
            btnDetalles.TabIndex = 24;
            btnDetalles.Text = "Ver Detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            btnDetalles.Click += btnDetalles_Click;
            // 
            // Hoteles
            // 
            AcceptButton = btnAgregarHoteles;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 573);
            Controls.Add(btnDetalles);
            Controls.Add(button3);
            Controls.Add(lsvHoteles);
            Controls.Add(grpTarifa);
            Controls.Add(grpAgregarHoteles);
            Controls.Add(grpHoteles);
            Controls.Add(lblHoteles);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Hoteles";
            Text = "Hoteles";
            Load += Hoteles_Load;
            grpHoteles.ResumeLayout(false);
            grpHoteles.PerformLayout();
            grpAgregarHoteles.ResumeLayout(false);
            grpAgregarHoteles.PerformLayout();
            grpTarifa.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoteles;
        private GroupBox grpHoteles;
        private Button btnBuscarHoteles;
        private Label label9;
        private Label label8;
        private DateTimePicker dateTimePicker2;
        private TextBox txtUbicacion;
        private Label label10;
        private Label label7;
        private DateTimePicker dateTimePicker3;
        private ComboBox cmbCalifiacion;
        private TextBox txtHabitaciones;
        private Label label1;
        private GroupBox grpAgregarHoteles;
        private Label lblContadorHabitaciones;
        private Label label12;
        private Label label11;
        private Label lblTHabitacion;
        private ComboBox comboBox2;
        private Label lblHuespedes;
        private ComboBox comboBox1;
        private Button btnAgregarHoteles;
        private GroupBox grpTarifa;
        private ListView lsvTarifas;
        private ColumnHeader hdCodProd;
        private ColumnHeader hdTipoProducto;
        private ColumnHeader hdTarifa;
        private ListView lsvHoteles;
        private Button button3;
        private ColumnHeader hdCodigo;
        private ColumnHeader hdNombre;
        private ColumnHeader hdCiudad;
        private ColumnHeader hdDireccion;
        private ColumnHeader hdCalificacion;
        private ColumnHeader hdDisponibilidad;
        private Button btnDetalles;
    }
}