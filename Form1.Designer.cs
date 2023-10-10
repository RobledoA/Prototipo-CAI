namespace Prototipo_CAI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnItinerarios = new Button();
            btnProdDisponibles = new Button();
            btnReservas = new Button();
            SuspendLayout();
            // 
            // btnItinerarios
            // 
            btnItinerarios.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnItinerarios.Location = new Point(49, 82);
            btnItinerarios.Name = "btnItinerarios";
            btnItinerarios.Size = new Size(239, 52);
            btnItinerarios.TabIndex = 0;
            btnItinerarios.Text = "Itinerarios";
            btnItinerarios.UseVisualStyleBackColor = true;
            // 
            // btnProdDisponibles
            // 
            btnProdDisponibles.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnProdDisponibles.Location = new Point(49, 165);
            btnProdDisponibles.Name = "btnProdDisponibles";
            btnProdDisponibles.Size = new Size(239, 52);
            btnProdDisponibles.TabIndex = 1;
            btnProdDisponibles.Text = "Productos Disponibles";
            btnProdDisponibles.UseVisualStyleBackColor = true;
            // 
            // btnReservas
            // 
            btnReservas.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnReservas.Location = new Point(49, 248);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(239, 52);
            btnReservas.TabIndex = 2;
            btnReservas.Text = "Reservas";
            btnReservas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 401);
            Controls.Add(btnReservas);
            Controls.Add(btnProdDisponibles);
            Controls.Add(btnItinerarios);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnItinerarios;
        private Button btnProdDisponibles;
        private Button btnReservas;
    }
}