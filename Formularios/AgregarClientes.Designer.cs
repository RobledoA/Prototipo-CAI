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
            SuspendLayout();
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(41, 47);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(247, 23);
            txtNombreCliente.TabIndex = 0;
            // 
            // txtCuilCuit
            // 
            txtCuilCuit.Location = new Point(41, 104);
            txtCuilCuit.Name = "txtCuilCuit";
            txtCuilCuit.Size = new Size(247, 23);
            txtCuilCuit.TabIndex = 1;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(41, 29);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(122, 15);
            lblNombreCliente.TabIndex = 2;
            lblNombreCliente.Text = "Nombre/Razón Social";
            // 
            // lblCuilCuit
            // 
            lblCuilCuit.AutoSize = true;
            lblCuilCuit.Location = new Point(41, 86);
            lblCuilCuit.Name = "lblCuilCuit";
            lblCuilCuit.Size = new Size(62, 15);
            lblCuilCuit.TabIndex = 3;
            lblCuilCuit.Text = "CUIL/CUIT";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(239, 154);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(158, 154);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // AgregarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 189);
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
    }
}