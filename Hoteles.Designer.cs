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
            grpHoteles.SuspendLayout();
            grpAgregarHoteles.SuspendLayout();
            grpTarifa.SuspendLayout();
            SuspendLayout();
            // 
            // lblHoteles
            // 
            lblHoteles.AutoSize = true;
            lblHoteles.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoteles.Location = new Point(12, 9);
            lblHoteles.Name = "lblHoteles";
            lblHoteles.Size = new Size(107, 37);
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
            grpHoteles.Location = new Point(24, 407);
            grpHoteles.Margin = new Padding(3, 4, 3, 4);
            grpHoteles.Name = "grpHoteles";
            grpHoteles.Padding = new Padding(3, 4, 3, 4);
            grpHoteles.Size = new Size(545, 280);
            grpHoteles.TabIndex = 19;
            grpHoteles.TabStop = false;
            grpHoteles.Text = "Opciones de Búsqueda";
            // 
            // btnBuscarHoteles
            // 
            btnBuscarHoteles.Location = new Point(277, 200);
            btnBuscarHoteles.Name = "btnBuscarHoteles";
            btnBuscarHoteles.Size = new Size(35, 41);
            btnBuscarHoteles.TabIndex = 15;
            btnBuscarHoteles.Text = "🔍";
            btnBuscarHoteles.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(286, 116);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(89, 20);
            label9.TabIndex = 15;
            label9.Text = "Fecha Hasta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 50);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 16;
            label8.Text = "Ubicación";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(287, 139);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.RightToLeft = RightToLeft.Yes;
            dateTimePicker2.Size = new Size(228, 27);
            dateTimePicker2.TabIndex = 14;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(40, 73);
            txtUbicacion.Margin = new Padding(3, 4, 3, 4);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(228, 27);
            txtUbicacion.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 116);
            label10.Name = "label10";
            label10.Size = new Size(93, 20);
            label10.TabIndex = 13;
            label10.Text = "Fecha Desde";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 184);
            label7.Name = "label7";
            label7.Size = new Size(181, 20);
            label7.TabIndex = 13;
            label7.Text = "Cantidad de Habitaciones";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(40, 139);
            dateTimePicker3.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(228, 27);
            dateTimePicker3.TabIndex = 12;
            // 
            // cmbCalifiacion
            // 
            cmbCalifiacion.FormattingEnabled = true;
            cmbCalifiacion.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbCalifiacion.Location = new Point(286, 73);
            cmbCalifiacion.Margin = new Padding(3, 4, 3, 4);
            cmbCalifiacion.Name = "cmbCalifiacion";
            cmbCalifiacion.Size = new Size(227, 28);
            cmbCalifiacion.TabIndex = 14;
            // 
            // txtHabitaciones
            // 
            txtHabitaciones.Location = new Point(40, 207);
            txtHabitaciones.Margin = new Padding(3, 4, 3, 4);
            txtHabitaciones.Name = "txtHabitaciones";
            txtHabitaciones.Size = new Size(228, 27);
            txtHabitaciones.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 50);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
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
            grpAgregarHoteles.Location = new Point(593, 376);
            grpAgregarHoteles.Name = "grpAgregarHoteles";
            grpAgregarHoteles.Size = new Size(256, 376);
            grpAgregarHoteles.TabIndex = 20;
            grpAgregarHoteles.TabStop = false;
            grpAgregarHoteles.Text = "Carrito";
            // 
            // lblContadorHabitaciones
            // 
            lblContadorHabitaciones.AutoSize = true;
            lblContadorHabitaciones.Location = new Point(93, 145);
            lblContadorHabitaciones.Name = "lblContadorHabitaciones";
            lblContadorHabitaciones.Size = new Size(17, 20);
            lblContadorHabitaciones.TabIndex = 21;
            lblContadorHabitaciones.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 144);
            label12.Name = "label12";
            label12.Size = new Size(90, 20);
            label12.TabIndex = 20;
            label12.Text = "Disponibles:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 156);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 19;
            // 
            // lblTHabitacion
            // 
            lblTHabitacion.AutoSize = true;
            lblTHabitacion.Location = new Point(15, 81);
            lblTHabitacion.Name = "lblTHabitacion";
            lblTHabitacion.Size = new Size(143, 20);
            lblTHabitacion.TabIndex = 17;
            lblTHabitacion.Text = "Tipos de Habitación";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(15, 107);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(223, 28);
            comboBox2.TabIndex = 16;
            // 
            // lblHuespedes
            // 
            lblHuespedes.AutoSize = true;
            lblHuespedes.Location = new Point(15, 195);
            lblHuespedes.Name = "lblHuespedes";
            lblHuespedes.Size = new Size(167, 20);
            lblHuespedes.TabIndex = 15;
            lblHuespedes.Text = "Cantidad de Huespedes";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 220);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(223, 28);
            comboBox1.TabIndex = 14;
            // 
            // btnAgregarHoteles
            // 
            btnAgregarHoteles.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarHoteles.Location = new Point(15, 324);
            btnAgregarHoteles.Margin = new Padding(3, 4, 3, 4);
            btnAgregarHoteles.Name = "btnAgregarHoteles";
            btnAgregarHoteles.Size = new Size(224, 35);
            btnAgregarHoteles.TabIndex = 13;
            btnAgregarHoteles.Text = "Agregar al Carrito \U0001f6d2";
            btnAgregarHoteles.UseVisualStyleBackColor = true;
            // 
            // grpTarifa
            // 
            grpTarifa.Controls.Add(lsvTarifas);
            grpTarifa.Location = new Point(865, 407);
            grpTarifa.Margin = new Padding(3, 4, 3, 4);
            grpTarifa.Name = "grpTarifa";
            grpTarifa.Padding = new Padding(3, 4, 3, 4);
            grpTarifa.Size = new Size(431, 299);
            grpTarifa.TabIndex = 21;
            grpTarifa.TabStop = false;
            grpTarifa.Text = "Tarifas";
            // 
            // lsvTarifas
            // 
            lsvTarifas.Columns.AddRange(new ColumnHeader[] { hdCodProd, hdTipoProducto, hdTarifa });
            lsvTarifas.Location = new Point(6, 39);
            lsvTarifas.Margin = new Padding(3, 4, 3, 4);
            lsvTarifas.Name = "lsvTarifas";
            lsvTarifas.Size = new Size(419, 240);
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
            lsvHoteles.Location = new Point(12, 66);
            lsvHoteles.Margin = new Padding(3, 4, 3, 4);
            lsvHoteles.MultiSelect = false;
            lsvHoteles.Name = "lsvHoteles";
            lsvHoteles.Size = new Size(1118, 303);
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
            button3.Location = new Point(1159, 306);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(131, 63);
            button3.TabIndex = 23;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // Hoteles
            // 
            AcceptButton = btnAgregarHoteles;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 764);
            Controls.Add(button3);
            Controls.Add(lsvHoteles);
            Controls.Add(grpTarifa);
            Controls.Add(grpAgregarHoteles);
            Controls.Add(grpHoteles);
            Controls.Add(lblHoteles);
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
    }
}