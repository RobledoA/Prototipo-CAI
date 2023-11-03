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
            SuspendLayout();
            // 
            // lsvReservas
            // 
            lsvReservas.Columns.AddRange(new ColumnHeader[] { codReserva, nombre, fechaReserva, estadoReserva });
            lsvReservas.FullRowSelect = true;
            lsvReservas.Location = new Point(12, 12);
            lsvReservas.MultiSelect = false;
            lsvReservas.Name = "lsvReservas";
            lsvReservas.Size = new Size(776, 360);
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
            btnConfirmarReserva.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmarReserva.Location = new Point(422, 386);
            btnConfirmarReserva.Name = "btnConfirmarReserva";
            btnConfirmarReserva.Size = new Size(168, 46);
            btnConfirmarReserva.TabIndex = 2;
            btnConfirmarReserva.Text = "Confirmar reserva";
            btnConfirmarReserva.UseVisualStyleBackColor = true;
            // 
            // btnBuscarReserva
            // 
            btnBuscarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarReserva.Location = new Point(213, 394);
            btnBuscarReserva.Name = "btnBuscarReserva";
            btnBuscarReserva.Size = new Size(31, 31);
            btnBuscarReserva.TabIndex = 4;
            btnBuscarReserva.Text = "🔍";
            btnBuscarReserva.UseVisualStyleBackColor = true;
            btnBuscarReserva.Click += btnBuscarReserva_Click;
            // 
            // txtBuscarReserva
            // 
            txtBuscarReserva.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarReserva.Location = new Point(12, 395);
            txtBuscarReserva.Name = "txtBuscarReserva";
            txtBuscarReserva.PlaceholderText = "Ingrese Código de Reserva...";
            txtBuscarReserva.Size = new Size(200, 29);
            txtBuscarReserva.TabIndex = 5;
            txtBuscarReserva.KeyDown += txtBuscarReserva_KeyDown;
            // 
            // btnCancelarReserva
            // 
            btnCancelarReserva.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarReserva.Location = new Point(596, 386);
            btnCancelarReserva.Name = "btnCancelarReserva";
            btnCancelarReserva.Size = new Size(192, 46);
            btnCancelarReserva.TabIndex = 6;
            btnCancelarReserva.Text = "Cancelar Reserva";
            btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // Reservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 444);
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
    }
}