namespace Prototipo_CAI
{
    partial class AgregarClientes
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
            txtNombreCliente = new TextBox();
            txtCuilCuit = new TextBox();
            lblNombreCliente = new Label();
            lblCuilCuit = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.BackColor = Color.FromArgb(214, 237, 255);
            txtNombreCliente.Location = new Point(138, 48);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(176, 23);
            txtNombreCliente.TabIndex = 0;
            // 
            // txtCuilCuit
            // 
            txtCuilCuit.BackColor = Color.FromArgb(214, 237, 255);
            txtCuilCuit.Location = new Point(138, 105);
            txtCuilCuit.Name = "txtCuilCuit";
            txtCuilCuit.Size = new Size(176, 23);
            txtCuilCuit.TabIndex = 1;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.ForeColor = Color.White;
            lblNombreCliente.Location = new Point(12, 51);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(122, 15);
            lblNombreCliente.TabIndex = 2;
            lblNombreCliente.Text = "Nombre/Razón Social";
            // 
            // lblCuilCuit
            // 
            lblCuilCuit.AutoSize = true;
            lblCuilCuit.ForeColor = Color.White;
            lblCuilCuit.Location = new Point(63, 105);
            lblCuilCuit.Name = "lblCuilCuit";
            lblCuilCuit.Size = new Size(62, 15);
            lblCuilCuit.TabIndex = 3;
            lblCuilCuit.Text = "CUIL/CUIT";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(214, 237, 255);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(13, 189);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(302, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(214, 237, 255);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Location = new Point(13, 151);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(302, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 133);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // AgregarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 32, 50);
            ClientSize = new Size(327, 255);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblCuilCuit);
            Controls.Add(lblNombreCliente);
            Controls.Add(txtCuilCuit);
            Controls.Add(txtNombreCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AgregarClientes";
            Text = "AgregarClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreCliente;
        private TextBox txtCuilCuit;
        private Label lblNombreCliente;
        private Label lblCuilCuit;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label label1;
    }
}