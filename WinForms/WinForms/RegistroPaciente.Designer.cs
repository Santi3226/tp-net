namespace WinForms
{
    partial class RegistroPaciente
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
            tituloLabel = new Label();
            emailTextBox = new TextBox();
            nombreUsuarioTextBox = new TextBox();
            contraseñaTextBox = new TextBox();
            confirmarContraseñaTextBox = new TextBox();
            emailLabel = new Label();
            nombreUsuarioLabel = new Label();
            contraseñaLabel = new Label();
            confirmarContraseñaLabel = new Label();
            registrarBtn = new Button();
            cancelarBtn = new Button();
            yaCuentaLabel = new Label();
            iniciarSesionLabel = new LinkLabel();
            SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloLabel.Location = new Point(395, 63);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(239, 29);
            tituloLabel.TabIndex = 1;
            tituloLabel.Text = "Registro de usuario";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(318, 152);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(380, 33);
            emailTextBox.TabIndex = 2;
            // 
            // nombreUsuarioTextBox
            // 
            nombreUsuarioTextBox.BorderStyle = BorderStyle.FixedSingle;
            nombreUsuarioTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreUsuarioTextBox.Location = new Point(318, 255);
            nombreUsuarioTextBox.Name = "nombreUsuarioTextBox";
            nombreUsuarioTextBox.Size = new Size(380, 33);
            nombreUsuarioTextBox.TabIndex = 3;
            // 
            // contraseñaTextBox
            // 
            contraseñaTextBox.BorderStyle = BorderStyle.FixedSingle;
            contraseñaTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contraseñaTextBox.Location = new Point(318, 358);
            contraseñaTextBox.Name = "contraseñaTextBox";
            contraseñaTextBox.PasswordChar = '*';
            contraseñaTextBox.Size = new Size(380, 33);
            contraseñaTextBox.TabIndex = 4;
            // 
            // confirmarContraseñaTextBox
            // 
            confirmarContraseñaTextBox.BorderStyle = BorderStyle.FixedSingle;
            confirmarContraseñaTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmarContraseñaTextBox.Location = new Point(318, 461);
            confirmarContraseñaTextBox.Name = "confirmarContraseñaTextBox";
            confirmarContraseñaTextBox.PasswordChar = '*';
            confirmarContraseñaTextBox.Size = new Size(380, 33);
            confirmarContraseñaTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(315, 132);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 17);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email";
            // 
            // nombreUsuarioLabel
            // 
            nombreUsuarioLabel.AutoSize = true;
            nombreUsuarioLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreUsuarioLabel.Location = new Point(315, 235);
            nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            nombreUsuarioLabel.Size = new Size(123, 17);
            nombreUsuarioLabel.TabIndex = 7;
            nombreUsuarioLabel.Text = "Nombre de usuario";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contraseñaLabel.Location = new Point(315, 338);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new Size(74, 17);
            contraseñaLabel.TabIndex = 8;
            contraseñaLabel.Text = "Contraseña";
            // 
            // confirmarContraseñaLabel
            // 
            confirmarContraseñaLabel.AutoSize = true;
            confirmarContraseñaLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmarContraseñaLabel.Location = new Point(315, 441);
            confirmarContraseñaLabel.Name = "confirmarContraseñaLabel";
            confirmarContraseñaLabel.Size = new Size(134, 17);
            confirmarContraseñaLabel.TabIndex = 9;
            confirmarContraseñaLabel.Text = "Confirmar contraseña";
            // 
            // registrarBtn
            // 
            registrarBtn.BackColor = Color.SteelBlue;
            registrarBtn.Cursor = Cursors.Hand;
            registrarBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            registrarBtn.FlatAppearance.BorderSize = 0;
            registrarBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            registrarBtn.FlatStyle = FlatStyle.Flat;
            registrarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registrarBtn.ForeColor = Color.White;
            registrarBtn.Location = new Point(318, 538);
            registrarBtn.Name = "registrarBtn";
            registrarBtn.Size = new Size(173, 33);
            registrarBtn.TabIndex = 10;
            registrarBtn.Text = "Iniciar Sesion";
            registrarBtn.UseVisualStyleBackColor = false;
            // 
            // cancelarBtn
            // 
            cancelarBtn.BackColor = Color.Snow;
            cancelarBtn.Cursor = Cursors.Hand;
            cancelarBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            cancelarBtn.FlatAppearance.BorderSize = 0;
            cancelarBtn.FlatAppearance.MouseOverBackColor = Color.Silver;
            cancelarBtn.FlatStyle = FlatStyle.Flat;
            cancelarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelarBtn.ForeColor = Color.Black;
            cancelarBtn.Location = new Point(527, 538);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(171, 33);
            cancelarBtn.TabIndex = 11;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = false;
            // 
            // yaCuentaLabel
            // 
            yaCuentaLabel.AutoSize = true;
            yaCuentaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yaCuentaLabel.ForeColor = Color.Black;
            yaCuentaLabel.Location = new Point(381, 609);
            yaCuentaLabel.Name = "yaCuentaLabel";
            yaCuentaLabel.Size = new Size(120, 15);
            yaCuentaLabel.TabIndex = 12;
            yaCuentaLabel.Text = "Ya tienes una cuenta?";
            // 
            // iniciarSesionLabel
            // 
            iniciarSesionLabel.ActiveLinkColor = Color.DodgerBlue;
            iniciarSesionLabel.AutoSize = true;
            iniciarSesionLabel.Cursor = Cursors.Hand;
            iniciarSesionLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            iniciarSesionLabel.LinkColor = Color.DodgerBlue;
            iniciarSesionLabel.Location = new Point(527, 609);
            iniciarSesionLabel.Name = "iniciarSesionLabel";
            iniciarSesionLabel.Size = new Size(76, 15);
            iniciarSesionLabel.TabIndex = 13;
            iniciarSesionLabel.TabStop = true;
            iniciarSesionLabel.Text = "Iniciar Sesion";
            // 
            // RegistroPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1064, 681);
            Controls.Add(iniciarSesionLabel);
            Controls.Add(yaCuentaLabel);
            Controls.Add(cancelarBtn);
            Controls.Add(registrarBtn);
            Controls.Add(confirmarContraseñaLabel);
            Controls.Add(contraseñaLabel);
            Controls.Add(nombreUsuarioLabel);
            Controls.Add(emailLabel);
            Controls.Add(confirmarContraseñaTextBox);
            Controls.Add(contraseñaTextBox);
            Controls.Add(nombreUsuarioTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(tituloLabel);
            Name = "RegistroPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLabel;
        private TextBox emailTextBox;
        private TextBox nombreUsuarioTextBox;
        private TextBox contraseñaTextBox;
        private TextBox confirmarContraseñaTextBox;
        private Label emailLabel;
        private Label nombreUsuarioLabel;
        private Label contraseñaLabel;
        private Label confirmarContraseñaLabel;
        private Button registrarBtn;
        private Button cancelarBtn;
        private Label yaCuentaLabel;
        private LinkLabel iniciarSesionLabel;
    }
}