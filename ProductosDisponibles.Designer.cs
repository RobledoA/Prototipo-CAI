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
            lsvProductosDisponibles = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lsvProductosDisponibles
            // 
            lsvProductosDisponibles.Location = new Point(23, 12);
            lsvProductosDisponibles.Name = "lsvProductosDisponibles";
            lsvProductosDisponibles.Size = new Size(729, 271);
            lsvProductosDisponibles.TabIndex = 0;
            lsvProductosDisponibles.UseCompatibleStateImageBehavior = false;
            lsvProductosDisponibles.View = View.Details;
            // 
            // button1
            // 
            button1.Location = new Point(818, 12);
            button1.Name = "button1";
            button1.Size = new Size(115, 47);
            button1.TabIndex = 1;
            button1.Text = "Aéreos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(818, 85);
            button2.Name = "button2";
            button2.Size = new Size(115, 47);
            button2.TabIndex = 2;
            button2.Text = "Hotelería";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(818, 162);
            button3.Name = "button3";
            button3.Size = new Size(115, 47);
            button3.TabIndex = 3;
            button3.Text = "Cruceros";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(818, 236);
            button4.Name = "button4";
            button4.Size = new Size(115, 47);
            button4.TabIndex = 4;
            button4.Text = "Paquetes Turísticos";
            button4.UseVisualStyleBackColor = true;
            // 
            // ProductosDisponibles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 397);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lsvProductosDisponibles);
            Name = "ProductosDisponibles";
            Text = "ProductosDisponibles";
            ResumeLayout(false);
        }

        #endregion

        private ListView lsvProductosDisponibles;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}