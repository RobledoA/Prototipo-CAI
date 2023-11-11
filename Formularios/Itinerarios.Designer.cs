namespace Prototipo_CAI
{
    partial class Itinerarios
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
            lsvItinerario = new ListView();
            CodItinerario = new ColumnHeader();
            CUILCUIT = new ColumnHeader();
            Nombre = new ColumnHeader();
            btnNuevoItinerario = new Button();
            btnEstItinerarioActivo = new Button();
            btnEliminarItinerario = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            txtBuscarItinerario = new TextBox();
            btnBuscarItinerario = new Button();
            lblItinerarios = new Label();
            btnCrearReservaItinerario = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // lsvItinerario
            // 
            lsvItinerario.Columns.AddRange(new ColumnHeader[] { CodItinerario, CUILCUIT, Nombre });
            lsvItinerario.FullRowSelect = true;
            lsvItinerario.Location = new Point(14, 63);
            lsvItinerario.Margin = new Padding(3, 4, 3, 4);
            lsvItinerario.MultiSelect = false;
            lsvItinerario.Name = "lsvItinerario";
            lsvItinerario.Size = new Size(539, 323);
            lsvItinerario.TabIndex = 1;
            lsvItinerario.UseCompatibleStateImageBehavior = false;
            lsvItinerario.View = View.Details;
            // 
            // CodItinerario
            // 
            CodItinerario.Text = "Cod.";
            CodItinerario.Width = 150;
            // 
            // CUILCUIT
            // 
            CUILCUIT.Text = "CUIL/CUIT";
            CUILCUIT.Width = 150;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre/Razón Social";
            Nombre.Width = 180;
            // 
            // btnNuevoItinerario
            // 
            btnNuevoItinerario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoItinerario.Location = new Point(565, 12);
            btnNuevoItinerario.Margin = new Padding(3, 4, 3, 4);
            btnNuevoItinerario.Name = "btnNuevoItinerario";
            btnNuevoItinerario.Size = new Size(166, 65);
            btnNuevoItinerario.TabIndex = 2;
            btnNuevoItinerario.Text = "Nuevo";
            btnNuevoItinerario.UseVisualStyleBackColor = true;
            btnNuevoItinerario.Click += btnNuevoItinerario_Click;
            // 
            // btnEstItinerarioActivo
            // 
            btnEstItinerarioActivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstItinerarioActivo.Location = new Point(565, 159);
            btnEstItinerarioActivo.Margin = new Padding(3, 4, 3, 4);
            btnEstItinerarioActivo.Name = "btnEstItinerarioActivo";
            btnEstItinerarioActivo.Size = new Size(166, 87);
            btnEstItinerarioActivo.TabIndex = 4;
            btnEstItinerarioActivo.Text = "Establecer como activo";
            btnEstItinerarioActivo.UseVisualStyleBackColor = true;
            btnEstItinerarioActivo.Click += button2_Click;
            // 
            // btnEliminarItinerario
            // 
            btnEliminarItinerario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarItinerario.Location = new Point(565, 252);
            btnEliminarItinerario.Margin = new Padding(3, 4, 3, 4);
            btnEliminarItinerario.Name = "btnEliminarItinerario";
            btnEliminarItinerario.Size = new Size(166, 65);
            btnEliminarItinerario.TabIndex = 5;
            btnEliminarItinerario.Text = "Eliminar";
            btnEliminarItinerario.UseVisualStyleBackColor = true;
            btnEliminarItinerario.Click += button3_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtBuscarItinerario
            // 
            txtBuscarItinerario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarItinerario.Location = new Point(251, 12);
            txtBuscarItinerario.Margin = new Padding(3, 4, 3, 4);
            txtBuscarItinerario.Name = "txtBuscarItinerario";
            txtBuscarItinerario.PlaceholderText = "Filtrar por...";
            txtBuscarItinerario.Size = new Size(260, 34);
            txtBuscarItinerario.TabIndex = 8;
            // 
            // btnBuscarItinerario
            // 
            btnBuscarItinerario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarItinerario.Location = new Point(519, 11);
            btnBuscarItinerario.Margin = new Padding(3, 4, 3, 4);
            btnBuscarItinerario.Name = "btnBuscarItinerario";
            btnBuscarItinerario.Size = new Size(35, 41);
            btnBuscarItinerario.TabIndex = 7;
            btnBuscarItinerario.Text = "🔍";
            btnBuscarItinerario.UseVisualStyleBackColor = true;
            btnBuscarItinerario.Click += btnBuscarItinerario_Click;
            // 
            // lblItinerarios
            // 
            lblItinerarios.AutoSize = true;
            lblItinerarios.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblItinerarios.Location = new Point(14, 12);
            lblItinerarios.Name = "lblItinerarios";
            lblItinerarios.Size = new Size(135, 37);
            lblItinerarios.TabIndex = 10;
            lblItinerarios.Text = "Itinerarios";
            // 
            // btnCrearReservaItinerario
            // 
            btnCrearReservaItinerario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearReservaItinerario.Location = new Point(565, 325);
            btnCrearReservaItinerario.Margin = new Padding(3, 4, 3, 4);
            btnCrearReservaItinerario.Name = "btnCrearReservaItinerario";
            btnCrearReservaItinerario.Size = new Size(166, 61);
            btnCrearReservaItinerario.TabIndex = 11;
            btnCrearReservaItinerario.Text = "Crear Reserva";
            btnCrearReservaItinerario.UseVisualStyleBackColor = true;
            btnCrearReservaItinerario.Click += btnCrearReserva_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(565, 85);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(166, 65);
            button1.TabIndex = 12;
            button1.Text = "Datos cliente";
            button1.UseVisualStyleBackColor = true;
            // 
            // Itinerarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 405);
            Controls.Add(button1);
            Controls.Add(btnCrearReservaItinerario);
            Controls.Add(lblItinerarios);
            Controls.Add(txtBuscarItinerario);
            Controls.Add(btnBuscarItinerario);
            Controls.Add(btnEliminarItinerario);
            Controls.Add(btnEstItinerarioActivo);
            Controls.Add(btnNuevoItinerario);
            Controls.Add(lsvItinerario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Itinerarios";
            Text = "Itinerarios";
            Load += Itinerarios_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvItinerario;
        private ColumnHeader CUILCUIT;
        private ColumnHeader CodItinerario;
        private Button btnNuevoItinerario;
        private Button btnEstItinerarioActivo;
        private Button btnEliminarItinerario;
        private ColumnHeader Nombre;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox txtBuscarItinerario;
        private Button btnBuscarItinerario;
        private Label lblItinerarios;
        private Button btnCrearReservaItinerario;
        private Button button1;
    }
}