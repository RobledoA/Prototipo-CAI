﻿namespace Prototipo_CAI
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            txtBuscarItinerario = new TextBox();
            btnBuscarItinerario = new Button();
            lblItinerarios = new Label();
            btnCrearReserva = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // lsvItinerario
            // 
            lsvItinerario.Columns.AddRange(new ColumnHeader[] { CodItinerario, CUILCUIT, Nombre });
            lsvItinerario.FullRowSelect = true;
            lsvItinerario.Location = new Point(26, 53);
            lsvItinerario.MultiSelect = false;
            lsvItinerario.Name = "lsvItinerario";
            lsvItinerario.Size = new Size(457, 159);
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
            Nombre.Width = 150;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(489, 53);
            button1.Name = "button1";
            button1.Size = new Size(145, 49);
            button1.TabIndex = 2;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(489, 108);
            button2.Name = "button2";
            button2.Size = new Size(145, 49);
            button2.TabIndex = 4;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(489, 163);
            button3.Name = "button3";
            button3.Size = new Size(145, 49);
            button3.TabIndex = 5;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtBuscarItinerario
            // 
            txtBuscarItinerario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarItinerario.Location = new Point(26, 218);
            txtBuscarItinerario.Name = "txtBuscarItinerario";
            txtBuscarItinerario.PlaceholderText = "Filtrar por...";
            txtBuscarItinerario.Size = new Size(228, 29);
            txtBuscarItinerario.TabIndex = 8;
            // 
            // btnBuscarItinerario
            // 
            btnBuscarItinerario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarItinerario.Location = new Point(260, 218);
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
            // btnCrearReserva
            // 
            btnCrearReserva.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearReserva.Location = new Point(354, 218);
            btnCrearReserva.Name = "btnCrearReserva";
            btnCrearReserva.Size = new Size(130, 28);
            btnCrearReserva.TabIndex = 11;
            btnCrearReserva.Text = "Crear Reserva";
            btnCrearReserva.UseVisualStyleBackColor = true;
            btnCrearReserva.Click += btnCrearReserva_Click;
            // 
            // Itinerarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 269);
            Controls.Add(btnCrearReserva);
            Controls.Add(lblItinerarios);
            Controls.Add(txtBuscarItinerario);
            Controls.Add(btnBuscarItinerario);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private ColumnHeader Nombre;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox txtBuscarItinerario;
        private Button btnBuscarItinerario;
        private Label lblItinerarios;
        private Button btnCrearReserva;
    }
}