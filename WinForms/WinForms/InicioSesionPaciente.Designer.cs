namespace WinForms
{
    partial class InicioSesionPaciente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tituloLabel = new Label();
            emailTextBox = new TextBox();
            contraseñaTextBox = new TextBox();
            emailLabel = new Label();
            contraseñaLabel = new Label();
            recordarmeCheckBox = new CheckBox();
            iniciarSesionBtn = new Button();
            noCuentaLabel = new Label();
            olvidasteLabel = new LinkLabel();
            registrarmeLabel = new LinkLabel();
            SuspendLayout();
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tituloLabel.Location = new Point(423, 52);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new Size(198, 29);
            tituloLabel.TabIndex = 0;
            tituloLabel.Text = "Inicio de Sesion";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(328, 215);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(380, 33);
            emailTextBox.TabIndex = 1;
            // 
            // contraseñaTextBox
            // 
            contraseñaTextBox.BorderStyle = BorderStyle.FixedSingle;
            contraseñaTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contraseñaTextBox.Location = new Point(328, 372);
            contraseñaTextBox.Name = "contraseñaTextBox";
            contraseñaTextBox.PasswordChar = '*';
            contraseñaTextBox.Size = new Size(380, 33);
            contraseñaTextBox.TabIndex = 2;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(325, 195);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 17);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contraseñaLabel.Location = new Point(325, 352);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new Size(74, 17);
            contraseñaLabel.TabIndex = 4;
            contraseñaLabel.Text = "Contraseña";
            // 
            // recordarmeCheckBox
            // 
            recordarmeCheckBox.AutoSize = true;
            recordarmeCheckBox.FlatStyle = FlatStyle.Flat;
            recordarmeCheckBox.Location = new Point(328, 432);
            recordarmeCheckBox.Name = "recordarmeCheckBox";
            recordarmeCheckBox.Size = new Size(87, 19);
            recordarmeCheckBox.TabIndex = 5;
            recordarmeCheckBox.Text = "Recordarme";
            recordarmeCheckBox.UseVisualStyleBackColor = true;
            // 
            // iniciarSesionBtn
            // 
            iniciarSesionBtn.BackColor = Color.SteelBlue;
            iniciarSesionBtn.Cursor = Cursors.Hand;
            iniciarSesionBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            iniciarSesionBtn.FlatAppearance.BorderSize = 0;
            iniciarSesionBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            iniciarSesionBtn.FlatStyle = FlatStyle.Flat;
            iniciarSesionBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iniciarSesionBtn.ForeColor = Color.White;
            iniciarSesionBtn.Location = new Point(459, 517);
            iniciarSesionBtn.Name = "iniciarSesionBtn";
            iniciarSesionBtn.Size = new Size(137, 33);
            iniciarSesionBtn.TabIndex = 7;
            iniciarSesionBtn.Text = "Iniciar Sesion";
            iniciarSesionBtn.UseVisualStyleBackColor = false;
            iniciarSesionBtn.Click += iniciarSesionBtn_Click;
            // 
            // noCuentaLabel
            // 
            noCuentaLabel.AutoSize = true;
            noCuentaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            noCuentaLabel.ForeColor = Color.Black;
            noCuentaLabel.Location = new Point(423, 577);
            noCuentaLabel.Name = "noCuentaLabel";
            noCuentaLabel.Size = new Size(101, 15);
            noCuentaLabel.TabIndex = 8;
            noCuentaLabel.Text = "No tienes cuenta?";
            // 
            // olvidasteLabel
            // 
            olvidasteLabel.ActiveLinkColor = Color.DodgerBlue;
            olvidasteLabel.AutoSize = true;
            olvidasteLabel.Cursor = Cursors.Hand;
            olvidasteLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            olvidasteLabel.LinkColor = Color.DodgerBlue;
            olvidasteLabel.Location = new Point(596, 436);
            olvidasteLabel.Name = "olvidasteLabel";
            olvidasteLabel.Size = new Size(112, 15);
            olvidasteLabel.TabIndex = 10;
            olvidasteLabel.TabStop = true;
            olvidasteLabel.Text = "Olvidaste tus datos?";
            // 
            // registrarmeLabel
            // 
            registrarmeLabel.ActiveLinkColor = Color.DodgerBlue;
            registrarmeLabel.AutoSize = true;
            registrarmeLabel.Cursor = Cursors.Hand;
            registrarmeLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            registrarmeLabel.LinkColor = Color.DodgerBlue;
            registrarmeLabel.Location = new Point(547, 577);
            registrarmeLabel.Name = "registrarmeLabel";
            registrarmeLabel.Size = new Size(70, 15);
            registrarmeLabel.TabIndex = 11;
            registrarmeLabel.TabStop = true;
            registrarmeLabel.Text = "Registrarme";
            // 
            // InicioSesionPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1064, 681);
            Controls.Add(registrarmeLabel);
            Controls.Add(olvidasteLabel);
            Controls.Add(noCuentaLabel);
            Controls.Add(iniciarSesionBtn);
            Controls.Add(recordarmeCheckBox);
            Controls.Add(contraseñaLabel);
            Controls.Add(emailLabel);
            Controls.Add(contraseñaTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(tituloLabel);
            Name = "InicioSesionPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio";
            Load += InicioSesionPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tituloLabel;
        private TextBox emailTextBox;
        private TextBox contraseñaTextBox;
        private Label emailLabel;
        private Label contraseñaLabel;
        private CheckBox recordarmeCheckBox;
        private Button iniciarSesionBtn;
        private Label noCuentaLabel;
        private LinkLabel olvidasteLabel;
        private LinkLabel registrarmeLabel;
    }
}
