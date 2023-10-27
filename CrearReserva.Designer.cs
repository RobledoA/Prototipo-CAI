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
            components = new System.ComponentModel.Container();
            btnConfirmarGuardarReserva = new Button();
            btnCancelarGenerarReserva = new Button();
            lsvGenerarReserva = new ListView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnAgregarPasajero = new Button();
            lblDatapasajeros = new Label();
            btnRefrescar = new Button();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfirmarGuardarReserva
            // 
            btnConfirmarGuardarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmarGuardarReserva.Location = new Point(690, 267);
            btnConfirmarGuardarReserva.Name = "btnConfirmarGuardarReserva";
            btnConfirmarGuardarReserva.Size = new Size(155, 34);
            btnConfirmarGuardarReserva.TabIndex = 15;
            btnConfirmarGuardarReserva.Text = "Confirmar y Guardar";
            btnConfirmarGuardarReserva.UseVisualStyleBackColor = true;
            btnConfirmarGuardarReserva.Click += btnConfirmarGuardarReserva_Click;
            // 
            // btnCancelarGenerarReserva
            // 
            btnCancelarGenerarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarGenerarReserva.Location = new Point(851, 267);
            btnCancelarGenerarReserva.Name = "btnCancelarGenerarReserva";
            btnCancelarGenerarReserva.Size = new Size(128, 34);
            btnCancelarGenerarReserva.TabIndex = 14;
            btnCancelarGenerarReserva.Text = "Cancelar";
            btnCancelarGenerarReserva.UseVisualStyleBackColor = true;
            btnCancelarGenerarReserva.Click += btnCancelarGenerarReserva_Click;
            // 
            // lsvGenerarReserva
            // 
            lsvGenerarReserva.ContextMenuStrip = contextMenuStrip2;
            lsvGenerarReserva.Cursor = Cursors.Hand;
            lsvGenerarReserva.Location = new Point(12, 58);
            lsvGenerarReserva.Name = "lsvGenerarReserva";
            lsvGenerarReserva.Size = new Size(967, 203);
            lsvGenerarReserva.TabIndex = 13;
            lsvGenerarReserva.UseCompatibleStateImageBehavior = false;
            lsvGenerarReserva.View = View.Details;
            lsvGenerarReserva.SelectedIndexChanged += lsvGenerarReserva_SelectedIndexChanged;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, eliminarToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(118, 48);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(117, 22);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnAgregarPasajero
            // 
            btnAgregarPasajero.Location = new Point(110, 16);
            btnAgregarPasajero.Name = "btnAgregarPasajero";
            btnAgregarPasajero.Size = new Size(128, 23);
            btnAgregarPasajero.TabIndex = 12;
            btnAgregarPasajero.Text = "Agregar pasajero";
            btnAgregarPasajero.UseVisualStyleBackColor = true;
            btnAgregarPasajero.Click += btnAgregarPasajero_Click;
            // 
            // lblDatapasajeros
            // 
            lblDatapasajeros.AutoSize = true;
            lblDatapasajeros.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblDatapasajeros.Location = new Point(12, 9);
            lblDatapasajeros.Name = "lblDatapasajeros";
            lblDatapasajeros.Size = new Size(102, 28);
            lblDatapasajeros.TabIndex = 11;
            lblDatapasajeros.Text = " Pasajeros ";
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(244, 16);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(128, 23);
            btnRefrescar.TabIndex = 16;
            btnRefrescar.Text = "Refrescar Lista";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // CrearReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 316);
            Controls.Add(btnRefrescar);
            Controls.Add(btnConfirmarGuardarReserva);
            Controls.Add(btnCancelarGenerarReserva);
            Controls.Add(lsvGenerarReserva);
            Controls.Add(btnAgregarPasajero);
            Controls.Add(lblDatapasajeros);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CrearReserva";
            Text = "CrearReserva";
            Load += CrearReserva_Load;
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmarGuardarReserva;
        private Button btnCancelarGenerarReserva;
        private ListView lsvGenerarReserva;
        private Button btnAgregarPasajero;
        private Label lblDatapasajeros;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private Button btnRefrescar;
    }
}