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
            listView1 = new ListView();
            btnDetalles = new Button();
            btnCrearItinerario = new Button();
            lblPresupuesto = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // lsvProductosDisponibles
            // 
            lsvProductosDisponibles.CheckBoxes = true;
            lsvProductosDisponibles.FullRowSelect = true;
            lsvProductosDisponibles.Location = new Point(12, 12);
            lsvProductosDisponibles.Name = "lsvProductosDisponibles";
            lsvProductosDisponibles.Size = new Size(729, 228);
            lsvProductosDisponibles.TabIndex = 0;
            lsvProductosDisponibles.UseCompatibleStateImageBehavior = false;
            lsvProductosDisponibles.View = View.Details;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(759, 66);
            button1.Name = "button1";
            button1.Size = new Size(115, 47);
            button1.TabIndex = 1;
            button1.Text = "Aéreos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(759, 129);
            button2.Name = "button2";
            button2.Size = new Size(115, 47);
            button2.TabIndex = 2;
            button2.Text = "Hotelería";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 275);
            listView1.Name = "listView1";
            listView1.Size = new Size(729, 234);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnDetalles
            // 
            btnDetalles.Location = new Point(351, 246);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(75, 23);
            btnDetalles.TabIndex = 6;
            btnDetalles.Text = "Ver Detalles";
            btnDetalles.UseVisualStyleBackColor = true;
            // 
            // btnCrearItinerario
            // 
            btnCrearItinerario.Location = new Point(759, 406);
            btnCrearItinerario.Name = "btnCrearItinerario";
            btnCrearItinerario.Size = new Size(115, 47);
            btnCrearItinerario.TabIndex = 7;
            btnCrearItinerario.Text = "Crear Itinerario";
            btnCrearItinerario.UseVisualStyleBackColor = true;
            // 
            // lblPresupuesto
            // 
            lblPresupuesto.AutoSize = true;
            lblPresupuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPresupuesto.Location = new Point(768, 275);
            lblPresupuesto.Name = "lblPresupuesto";
            lblPresupuesto.Size = new Size(96, 21);
            lblPresupuesto.TabIndex = 8;
            lblPresupuesto.Text = "Presupuesto";
            // 
            // button3
            // 
            button3.Location = new Point(759, 462);
            button3.Name = "button3";
            button3.Size = new Size(115, 47);
            button3.TabIndex = 9;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // ProductosDisponibles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 521);
            Controls.Add(button3);
            Controls.Add(lblPresupuesto);
            Controls.Add(btnCrearItinerario);
            Controls.Add(btnDetalles);
            Controls.Add(listView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lsvProductosDisponibles);
            Name = "ProductosDisponibles";
            Text = "ProductosDisponibles";
            Load += ProductosDisponibles_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvProductosDisponibles;
        private Button button1;
        private Button button2;
        private ListView listView1;
        private Button btnDetalles;
        private Button btnCrearItinerario;
        private Label lblPresupuesto;
        private Button button3;
    }
}