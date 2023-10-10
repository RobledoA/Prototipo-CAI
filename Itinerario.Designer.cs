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
            listView1 = new ListView();
            CUILCUIT = new ColumnHeader();
            Nombre = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { CUILCUIT, Nombre });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(286, 111);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // CUILCUIT
            // 
            CUILCUIT.Text = "CUIL/CUIT";
            CUILCUIT.Width = 120;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre/Razón Social";
            Nombre.Width = 160;
            // 
            // button1
            // 
            button1.Location = new Point(223, 129);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Itinerario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "Itinerario";
            Text = "Itinerario";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader CUILCUIT;
        private ColumnHeader Nombre;
        private Button button1;
    }
}