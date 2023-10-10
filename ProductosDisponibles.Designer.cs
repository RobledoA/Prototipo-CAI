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
            gbAereos = new GroupBox();
            SuspendLayout();
            // 
            // gbAereos
            // 
            gbAereos.Location = new Point(12, 12);
            gbAereos.Name = "gbAereos";
            gbAereos.Size = new Size(696, 95);
            gbAereos.TabIndex = 0;
            gbAereos.TabStop = false;
            gbAereos.Text = "Aereos";
            // 
            // ProductosDisponibles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbAereos);
            Name = "ProductosDisponibles";
            Text = "ProductosDisponibles";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAereos;
    }
}