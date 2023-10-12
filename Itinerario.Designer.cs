namespace Prototipo_CAI
{
    partial class Itinerario
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
            listView2 = new ListView();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // lsvItinerario
            // 
            lsvItinerario.Columns.AddRange(new ColumnHeader[] { CodItinerario, CUILCUIT, Nombre });
            lsvItinerario.FullRowSelect = true;
            lsvItinerario.Location = new Point(12, 12);
            lsvItinerario.Name = "lsvItinerario";
            lsvItinerario.Size = new Size(286, 426);
            lsvItinerario.TabIndex = 1;
            lsvItinerario.UseCompatibleStateImageBehavior = false;
            lsvItinerario.View = View.Details;
            // 
            // CodItinerario
            // 
            CodItinerario.Text = "Cod.";
            CodItinerario.Width = 40;
            // 
            // CUILCUIT
            // 
            CUILCUIT.Text = "CUIL/CUIT";
            CUILCUIT.Width = 90;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre/Razón Social";
            Nombre.Width = 151;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(329, 156);
            button1.Name = "button1";
            button1.Size = new Size(145, 49);
            button1.TabIndex = 2;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Location = new Point(502, 12);
            listView2.Name = "listView2";
            listView2.Size = new Size(286, 426);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(329, 242);
            button2.Name = "button2";
            button2.Size = new Size(145, 49);
            button2.TabIndex = 4;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(329, 327);
            button3.Name = "button3";
            button3.Size = new Size(145, 49);
            button3.TabIndex = 5;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(329, 74);
            button4.Name = "button4";
            button4.Size = new Size(145, 49);
            button4.TabIndex = 6;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Itinerario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listView2);
            Controls.Add(button1);
            Controls.Add(lsvItinerario);
            Name = "Itinerario";
            Text = "Itinerario";
            Load += Itinerario_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView lsvItinerario;
        private ColumnHeader CUILCUIT;
        private ColumnHeader CodItinerario;
        private Button button1;
        private ListView listView2;
        private Button button2;
        private Button button3;
        private Button button4;
        private ColumnHeader Nombre;
        private FileSystemWatcher fileSystemWatcher1;
    }
}