namespace Registro_Clientes
{
    partial class frmInicioSesion
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
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            cmdSalir = new Button();
            cmdIngresar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtRegistroUsuario = new TextBox();
            txtRegistroContraseña = new TextBox();
            cmdRegistrar = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbArea = new ComboBox();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(88, 12);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(169, 23);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(88, 51);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(169, 23);
            txtContraseña.TabIndex = 1;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(88, 96);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(75, 23);
            cmdSalir.TabIndex = 2;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            // 
            // cmdIngresar
            // 
            cmdIngresar.Location = new Point(182, 96);
            cmdIngresar.Name = "cmdIngresar";
            cmdIngresar.Size = new Size(75, 23);
            cmdIngresar.TabIndex = 3;
            cmdIngresar.Text = "Ingresar";
            cmdIngresar.UseVisualStyleBackColor = true;
            cmdIngresar.Click += cmdIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 4;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 5;
            label2.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 154);
            label3.Name = "label3";
            label3.Size = new Size(147, 15);
            label3.TabIndex = 6;
            label3.Text = "¿Aun no tiene una cuenta?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 169);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 7;
            label4.Text = "Registrate aqui:";
            // 
            // txtRegistroUsuario
            // 
            txtRegistroUsuario.Location = new Point(88, 196);
            txtRegistroUsuario.Name = "txtRegistroUsuario";
            txtRegistroUsuario.Size = new Size(169, 23);
            txtRegistroUsuario.TabIndex = 8;
            // 
            // txtRegistroContraseña
            // 
            txtRegistroContraseña.Location = new Point(88, 225);
            txtRegistroContraseña.Name = "txtRegistroContraseña";
            txtRegistroContraseña.PasswordChar = '*';
            txtRegistroContraseña.Size = new Size(169, 23);
            txtRegistroContraseña.TabIndex = 9;
            // 
            // cmdRegistrar
            // 
            cmdRegistrar.Location = new Point(182, 283);
            cmdRegistrar.Name = "cmdRegistrar";
            cmdRegistrar.Size = new Size(75, 23);
            cmdRegistrar.TabIndex = 10;
            cmdRegistrar.Text = "Registrar";
            cmdRegistrar.UseVisualStyleBackColor = true;
            cmdRegistrar.Click += cmdRegistrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 196);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 11;
            label5.Text = "Usuario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 228);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 12;
            label6.Text = "Contraseña:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 257);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 13;
            label7.Text = "Area:";
            // 
            // cbArea
            // 
            cbArea.FormattingEnabled = true;
            cbArea.Items.AddRange(new object[] { "Administrador", "Ventas", "Compras" });
            cbArea.Location = new Point(88, 254);
            cbArea.Name = "cbArea";
            cbArea.Size = new Size(169, 23);
            cbArea.TabIndex = 14;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 311);
            Controls.Add(cbArea);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmdRegistrar);
            Controls.Add(txtRegistroContraseña);
            Controls.Add(txtRegistroUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmdIngresar);
            Controls.Add(cmdSalir);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Name = "frmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button cmdSalir;
        private Button cmdIngresar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtRegistroUsuario;
        private TextBox txtRegistroContraseña;
        private Button cmdRegistrar;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbArea;
    }
}