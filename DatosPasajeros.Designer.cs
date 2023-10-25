namespace Prototipo_CAI
{
    partial class DatosPasajeros
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
            label1 = new Label();
            txtNombrep = new TextBox();
            txtCuitP = new TextBox();
            label2 = new Label();
            txtPasaporteP = new TextBox();
            label3 = new Label();
            dtpNacimientoP = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbNacionalidad = new ComboBox();
            cmbGénero = new ComboBox();
            label7 = new Label();
            btnConfirmarGuardarReserva = new Button();
            btnCancelarGenerarReserva = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre y Apellido";
            label1.Click += label1_Click;
            // 
            // txtNombrep
            // 
            txtNombrep.Location = new Point(12, 80);
            txtNombrep.Name = "txtNombrep";
            txtNombrep.Size = new Size(216, 23);
            txtNombrep.TabIndex = 1;
            txtNombrep.TextChanged += textBox1_TextChanged;
            // 
            // txtCuitP
            // 
            txtCuitP.Location = new Point(245, 80);
            txtCuitP.Name = "txtCuitP";
            txtCuitP.Size = new Size(216, 23);
            txtCuitP.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(245, 62);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "CUIT/CUIL";
            // 
            // txtPasaporteP
            // 
            txtPasaporteP.Location = new Point(12, 134);
            txtPasaporteP.Name = "txtPasaporteP";
            txtPasaporteP.Size = new Size(216, 23);
            txtPasaporteP.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(174, 15);
            label3.TabIndex = 4;
            label3.Text = "N° Pasaporte (De corresponder)";
            // 
            // dtpNacimientoP
            // 
            dtpNacimientoP.Location = new Point(245, 134);
            dtpNacimientoP.Name = "dtpNacimientoP";
            dtpNacimientoP.Size = new Size(216, 23);
            dtpNacimientoP.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(244, 116);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 7;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 164);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 8;
            label5.Text = "Nacionalidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(244, 164);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 10;
            label6.Text = "Género";
            // 
            // cmbNacionalidad
            // 
            cmbNacionalidad.FormattingEnabled = true;
            cmbNacionalidad.Items.AddRange(new object[] { "Argentino", "Peruano", "Brasileño", "Paraguayo", "Uruguayo" });
            cmbNacionalidad.Location = new Point(12, 182);
            cmbNacionalidad.Name = "cmbNacionalidad";
            cmbNacionalidad.Size = new Size(216, 23);
            cmbNacionalidad.TabIndex = 11;
            // 
            // cmbGénero
            // 
            cmbGénero.FormattingEnabled = true;
            cmbGénero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbGénero.Location = new Point(245, 182);
            cmbGénero.Name = "cmbGénero";
            cmbGénero.Size = new Size(216, 23);
            cmbGénero.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(9, 9);
            label7.Name = "label7";
            label7.Size = new Size(244, 28);
            label7.TabIndex = 13;
            label7.Text = "Ingresar Datos De Pasajero";
            // 
            // btnConfirmarGuardarReserva
            // 
            btnConfirmarGuardarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmarGuardarReserva.Location = new Point(176, 237);
            btnConfirmarGuardarReserva.Name = "btnConfirmarGuardarReserva";
            btnConfirmarGuardarReserva.Size = new Size(155, 34);
            btnConfirmarGuardarReserva.TabIndex = 18;
            btnConfirmarGuardarReserva.Text = "Confirmar y Agregar";
            btnConfirmarGuardarReserva.UseVisualStyleBackColor = true;
            btnConfirmarGuardarReserva.Click += btnConfirmarGuardarReserva_Click;
            // 
            // btnCancelarGenerarReserva
            // 
            btnCancelarGenerarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarGenerarReserva.Location = new Point(336, 237);
            btnCancelarGenerarReserva.Name = "btnCancelarGenerarReserva";
            btnCancelarGenerarReserva.Size = new Size(128, 34);
            btnCancelarGenerarReserva.TabIndex = 19;
            btnCancelarGenerarReserva.Text = "Cancelar";
            btnCancelarGenerarReserva.UseVisualStyleBackColor = true;
            btnCancelarGenerarReserva.Click += btnCancelarGenerarReserva_Click;
            // 
            // DatosPasajeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 294);
            Controls.Add(btnCancelarGenerarReserva);
            Controls.Add(btnConfirmarGuardarReserva);
            Controls.Add(label7);
            Controls.Add(cmbGénero);
            Controls.Add(cmbNacionalidad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpNacimientoP);
            Controls.Add(txtPasaporteP);
            Controls.Add(label3);
            Controls.Add(txtCuitP);
            Controls.Add(label2);
            Controls.Add(txtNombrep);
            Controls.Add(label1);
            Name = "DatosPasajeros";
            Text = "DatosPasajeros";
            Load += DatosPasajeros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombrep;
        private TextBox txtCuitP;
        private Label label2;
        private TextBox txtPasaporteP;
        private Label label3;
        private DateTimePicker dtpNacimientoP;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbNacionalidad;
        private ComboBox cmbGénero;
        private Label label7;
        private Button btnConfirmarGuardarReserva;
        private Button btnCancelarGenerarReserva;
    }
}