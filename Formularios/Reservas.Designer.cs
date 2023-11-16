namespace Prototipo_CAI
{
    partial class Reservas
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
            lsvReservas = new ListView();
            codReserva = new ColumnHeader();
            nombre = new ColumnHeader();
            fechaReserva = new ColumnHeader();
            estadoReserva = new ColumnHeader();
            btnConfirmarReserva = new Button();
            btnBuscarReserva = new Button();
            txtBuscarReserva = new TextBox();
            btnCancelarReserva = new Button();
            iconbtnBuscarItinerario = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // lsvReservas
            // 
            lsvReservas.BackColor = Color.White;
            lsvReservas.Columns.AddRange(new ColumnHeader[] { codReserva, nombre, fechaReserva, estadoReserva });
            lsvReservas.FullRowSelect = true;
            lsvReservas.Location = new Point(12, 12);
            lsvReservas.MultiSelect = false;
            lsvReservas.Name = "lsvReservas";
            lsvReservas.Size = new Size(776, 387);
            lsvReservas.TabIndex = 0;
            lsvReservas.UseCompatibleStateImageBehavior = false;
            lsvReservas.View = View.Details;
            // 
            // codReserva
            // 
            codReserva.Text = "Código";
            codReserva.Width = 150;
            // 
            // nombre
            // 
            nombre.Text = "Nombre/Razón Social";
            nombre.Width = 150;
            // 
            // fechaReserva
            // 
            fechaReserva.Text = "Fecha";
            fechaReserva.Width = 150;
            // 
            // estadoReserva
            // 
            estadoReserva.Text = "Estado";
            estadoReserva.Width = 150;
            // 
            // btnConfirmarReserva
            // 
            btnConfirmarReserva.BackColor = Color.FromArgb(8, 32, 50);
            btnConfirmarReserva.FlatAppearance.BorderSize = 0;
            btnConfirmarReserva.FlatStyle = FlatStyle.Flat;
            btnConfirmarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmarReserva.ForeColor = Color.White;
            btnConfirmarReserva.Location = new Point(524, 405);
            btnConfirmarReserva.Name = "btnConfirmarReserva";
            btnConfirmarReserva.Size = new Size(129, 35);
            btnConfirmarReserva.TabIndex = 2;
            btnConfirmarReserva.Text = "Confirmar reserva";
            btnConfirmarReserva.UseVisualStyleBackColor = false;
            btnConfirmarReserva.Click += btnConfirmarReserva_Click;
            // 
            // btnBuscarReserva
            // 
            btnBuscarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarReserva.Location = new Point(218, 406);
            btnBuscarReserva.Name = "btnBuscarReserva";
            btnBuscarReserva.Size = new Size(29, 25);
            btnBuscarReserva.TabIndex = 4;
            btnBuscarReserva.Text = "🔍";
            btnBuscarReserva.UseVisualStyleBackColor = true;
            btnBuscarReserva.Click += btnBuscarReserva_Click;
            // 
            // txtBuscarReserva
            // 
            txtBuscarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarReserva.Location = new Point(12, 407);
            txtBuscarReserva.Name = "txtBuscarReserva";
            txtBuscarReserva.PlaceholderText = "Ingrese Código de Reserva...";
            txtBuscarReserva.Size = new Size(200, 25);
            txtBuscarReserva.TabIndex = 5;
            txtBuscarReserva.KeyDown += txtBuscarReserva_KeyDown;
            // 
            // btnCancelarReserva
            // 
            btnCancelarReserva.BackColor = Color.FromArgb(8, 32, 50);
            btnCancelarReserva.FlatAppearance.BorderSize = 0;
            btnCancelarReserva.FlatStyle = FlatStyle.Flat;
            btnCancelarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarReserva.ForeColor = Color.White;
            btnCancelarReserva.Location = new Point(659, 405);
            btnCancelarReserva.Name = "btnCancelarReserva";
            btnCancelarReserva.Size = new Size(129, 35);
            btnCancelarReserva.TabIndex = 6;
            btnCancelarReserva.Text = "Cancelar Reserva";
            btnCancelarReserva.UseVisualStyleBackColor = false;
            btnCancelarReserva.Click += btnCancelarReserva_Click;
            // 
            // iconbtnBuscarItinerario
            // 
            iconbtnBuscarItinerario.BackColor = Color.White;
            iconbtnBuscarItinerario.FlatStyle = FlatStyle.Flat;
            iconbtnBuscarItinerario.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconbtnBuscarItinerario.IconColor = Color.Black;
            iconbtnBuscarItinerario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconbtnBuscarItinerario.IconSize = 20;
            iconbtnBuscarItinerario.Location = new Point(253, 406);
            iconbtnBuscarItinerario.Name = "iconbtnBuscarItinerario";
            iconbtnBuscarItinerario.Size = new Size(25, 25);
            iconbtnBuscarItinerario.TabIndex = 17;
            iconbtnBuscarItinerario.UseVisualStyleBackColor = false;
            // 
            // Reservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(86, 124, 153);
            ClientSize = new Size(800, 444);
            Controls.Add(iconbtnBuscarItinerario);
            Controls.Add(btnCancelarReserva);
            Controls.Add(txtBuscarReserva);
            Controls.Add(btnBuscarReserva);
            Controls.Add(btnConfirmarReserva);
            Controls.Add(lsvReservas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Reservas";
            Text = "Reservas";
            Load += Reservas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvReservas;
        private Button btnConfirmarReserva;
        private Button btnBuscarReserva;
        private TextBox txtBuscarReserva;
        private ColumnHeader codReserva;
        private ColumnHeader nombre;
        private ColumnHeader fechaReserva;
        private ColumnHeader estadoReserva;
        private Button btnCancelarReserva;
        private FontAwesome.Sharp.IconButton iconbtnBuscarItinerario;
    }
}