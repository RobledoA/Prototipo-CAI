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
            btnEstablecerActivoItinerario = new Button();
            btnEliminarItinerario = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            txtBuscarItinerario = new TextBox();
            btnBuscarItinerario = new Button();
            lblItinerarios = new Label();
            btnCrearReservaItinerario = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // lsvItinerario
            // 
            lsvItinerario.Columns.AddRange(new ColumnHeader[] { CodItinerario, CUILCUIT, Nombre });
            lsvItinerario.FullRowSelect = true;
            lsvItinerario.Location = new Point(26, 47);
            lsvItinerario.MultiSelect = false;
            lsvItinerario.Name = "lsvItinerario";
            lsvItinerario.Size = new Size(472, 175);
            lsvItinerario.TabIndex = 1;
            lsvItinerario.UseCompatibleStateImageBehavior = false;
            lsvItinerario.View = View.Details;
            lsvItinerario.SelectedIndexChanged += lsvItinerario_SelectedIndexChanged_1;
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
            Nombre.Width = 150;
            // 
            // btnNuevoItinerario
            // 
            btnNuevoItinerario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoItinerario.Location = new Point(514, 47);
            btnNuevoItinerario.Name = "btnNuevoItinerario";
            btnNuevoItinerario.Size = new Size(145, 49);
            btnNuevoItinerario.TabIndex = 2;
            btnNuevoItinerario.Text = "Nuevo";
            btnNuevoItinerario.UseVisualStyleBackColor = true;
            btnNuevoItinerario.Click += btnNuevoItinerario_Click;
            // 
            // btnEstablecerActivoItinerario
            // 
            btnEstablecerActivoItinerario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEstablecerActivoItinerario.Location = new Point(514, 102);
            btnEstablecerActivoItinerario.Name = "btnEstablecerActivoItinerario";
            btnEstablecerActivoItinerario.Size = new Size(145, 65);
            btnEstablecerActivoItinerario.TabIndex = 4;
            btnEstablecerActivoItinerario.Text = "Establecer como activo";
            btnEstablecerActivoItinerario.UseVisualStyleBackColor = true;
            btnEstablecerActivoItinerario.Click += button2_Click;
            // 
            // btnEliminarItinerario
            // 
            btnEliminarItinerario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarItinerario.Location = new Point(514, 173);
            btnEliminarItinerario.Name = "btnEliminarItinerario";
            btnEliminarItinerario.Size = new Size(145, 49);
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
            txtBuscarItinerario.Location = new Point(26, 228);
            txtBuscarItinerario.Name = "txtBuscarItinerario";
            txtBuscarItinerario.PlaceholderText = "Filtrar por...";
            txtBuscarItinerario.Size = new Size(228, 29);
            txtBuscarItinerario.TabIndex = 8;
            // 
            // btnBuscarItinerario
            // 
            btnBuscarItinerario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarItinerario.Location = new Point(260, 227);
            btnBuscarItinerario.Name = "btnBuscarItinerario";
            btnBuscarItinerario.Size = new Size(31, 31);
            btnBuscarItinerario.TabIndex = 7;
            btnBuscarItinerario.Text = "🔍";
            btnBuscarItinerario.UseVisualStyleBackColor = true;
            btnBuscarItinerario.Click += btnBuscarItinerario_Click;
            // 
            // lblItinerarios
            // 
            lblItinerarios.AutoSize = true;
            lblItinerarios.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblItinerarios.Location = new Point(26, 9);
            lblItinerarios.Name = "lblItinerarios";
            lblItinerarios.Size = new Size(105, 30);
            lblItinerarios.TabIndex = 10;
            lblItinerarios.Text = "Itinerarios";
            lblItinerarios.Click += label1_Click;
            // 
            // btnCrearReservaItinerario
            // 
            btnCrearReservaItinerario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearReservaItinerario.Location = new Point(378, 229);
            btnCrearReservaItinerario.Name = "btnCrearReservaItinerario";
            btnCrearReservaItinerario.Size = new Size(130, 28);
            btnCrearReservaItinerario.TabIndex = 11;
            btnCrearReservaItinerario.Text = "Crear Reserva";
            btnCrearReservaItinerario.UseVisualStyleBackColor = true;
            btnCrearReservaItinerario.Click += btnCrearReserva_Click;
            // 
            // Itinerarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 264);
            Controls.Add(btnCrearReservaItinerario);
            Controls.Add(lblItinerarios);
            Controls.Add(txtBuscarItinerario);
            Controls.Add(btnBuscarItinerario);
            Controls.Add(btnEliminarItinerario);
            Controls.Add(btnEstablecerActivoItinerario);
            Controls.Add(btnNuevoItinerario);
            Controls.Add(lsvItinerario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Button btnEstablecerActivoItinerario;
        private Button btnEliminarItinerario;
        private ColumnHeader Nombre;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox txtBuscarItinerario;
        private Button btnBuscarItinerario;
        private Label lblItinerarios;
        private Button btnCrearReservaItinerario;
    }
}