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
            listView1 = new ListView();
            btnNuevaReserva = new Button();
            btnConfirmarReserva = new Button();
            btnEditarReserva = new Button();
            btnBuscarReserva = new Button();
            txtBuscarReserva = new TextBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 360);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnNuevaReserva
            // 
            btnNuevaReserva.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevaReserva.Location = new Point(402, 386);
            btnNuevaReserva.Name = "btnNuevaReserva";
            btnNuevaReserva.Size = new Size(118, 46);
            btnNuevaReserva.TabIndex = 1;
            btnNuevaReserva.Text = "Nuevo";
            btnNuevaReserva.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarReserva
            // 
            btnConfirmarReserva.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmarReserva.Location = new Point(670, 386);
            btnConfirmarReserva.Name = "btnConfirmarReserva";
            btnConfirmarReserva.Size = new Size(118, 46);
            btnConfirmarReserva.TabIndex = 2;
            btnConfirmarReserva.Text = "Confirmar";
            btnConfirmarReserva.UseVisualStyleBackColor = true;
            // 
            // btnEditarReserva
            // 
            btnEditarReserva.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditarReserva.Location = new Point(536, 386);
            btnEditarReserva.Name = "btnEditarReserva";
            btnEditarReserva.Size = new Size(118, 46);
            btnEditarReserva.TabIndex = 3;
            btnEditarReserva.Text = "Editar";
            btnEditarReserva.UseVisualStyleBackColor = true;
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
            // Reservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 444);
            Controls.Add(txtBuscarReserva);
            Controls.Add(btnBuscarReserva);
            Controls.Add(btnEditarReserva);
            Controls.Add(btnConfirmarReserva);
            Controls.Add(btnNuevaReserva);
            Controls.Add(listView1);
            Name = "Reservas";
            Text = "Reservas";
            Load += Reservas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button btnNuevaReserva;
        private Button btnConfirmarReserva;
        private Button btnEditarReserva;
        private Button btnBuscarReserva;
        private TextBox txtBuscarReserva;
    }
}