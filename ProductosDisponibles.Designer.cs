namespace Prototipo_CAI
{
    partial class ProductosDisponibles
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
            btnAereos = new Button();
            btnHoteles = new Button();
            SuspendLayout();
            // 
            // btnAereos
            // 
            btnAereos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAereos.Location = new Point(58, 32);
            btnAereos.Name = "btnAereos";
            btnAereos.Size = new Size(239, 52);
            btnAereos.TabIndex = 2;
            btnAereos.Text = "Aéreos";
            btnAereos.UseVisualStyleBackColor = true;
            btnAereos.Click += btnAereos_Click;
            // 
            // btnHoteles
            // 
            btnHoteles.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnHoteles.Location = new Point(58, 104);
            btnHoteles.Name = "btnHoteles";
            btnHoteles.Size = new Size(239, 52);
            btnHoteles.TabIndex = 3;
            btnHoteles.Text = "Hoteles";
            btnHoteles.UseVisualStyleBackColor = true;
            btnHoteles.Click += btnHoteles_Click;
            // 
            // ProductosDisponibles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 186);
            Controls.Add(btnHoteles);
            Controls.Add(btnAereos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "ProductosDisponibles";
            Text = "Productos Disponibles";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAereos;
        private Button btnHoteles;
    }
}