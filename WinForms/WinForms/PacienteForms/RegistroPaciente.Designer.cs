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
            nombreTextBox = new TextBox();
            apellidoTextBox = new TextBox();
            dniTextBox = new TextBox();
            telefonoTextBox = new TextBox();
            nombreLabel = new Label();
            apellidoLabel = new Label();
            dniLabel = new Label();
            telefonoLabel = new Label();
            registrarBtn = new Button();
            cancelarBtn = new Button();
            yaCuentaLabel = new Label();
            iniciarSesionLabel = new LinkLabel();
            direccionTextBox = new TextBox();
            mailTextBox = new TextBox();
            contraseñaTextBox = new TextBox();
            confirmarContraseñaTextBox = new TextBox();
            fechaNacimientoCalendario = new MonthCalendar();
            direccionLabel = new Label();
            mailLabel = new Label();
            contraseñaLabel = new Label();
            confirmarContraseñaLabel = new Label();
            modificarLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // nombreTextBox
            // 
            nombreTextBox.BorderStyle = BorderStyle.FixedSingle;
            nombreTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreTextBox.Location = new Point(121, 156);
            nombreTextBox.Margin = new Padding(3, 4, 3, 4);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(434, 39);
            nombreTextBox.TabIndex = 1;
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.BorderStyle = BorderStyle.FixedSingle;
            apellidoTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            apellidoTextBox.Location = new Point(688, 156);
            apellidoTextBox.Margin = new Padding(3, 4, 3, 4);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(434, 39);
            apellidoTextBox.TabIndex = 2;
            // 
            // dniTextBox
            // 
            dniTextBox.BorderStyle = BorderStyle.FixedSingle;
            dniTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dniTextBox.Location = new Point(121, 249);
            dniTextBox.Margin = new Padding(3, 4, 3, 4);
            dniTextBox.Name = "dniTextBox";
            dniTextBox.Size = new Size(434, 39);
            dniTextBox.TabIndex = 3;
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.BorderStyle = BorderStyle.FixedSingle;
            telefonoTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telefonoTextBox.Location = new Point(688, 249);
            telefonoTextBox.Margin = new Padding(3, 4, 3, 4);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(434, 39);
            telefonoTextBox.TabIndex = 4;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreLabel.Location = new Point(119, 129);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(73, 23);
            nombreLabel.TabIndex = 6;
            nombreLabel.Text = "Nombre";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            apellidoLabel.Location = new Point(686, 129);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(72, 23);
            apellidoLabel.TabIndex = 7;
            apellidoLabel.Text = "Apellido";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dniLabel.Location = new Point(119, 223);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new Size(40, 23);
            dniLabel.TabIndex = 8;
            dniLabel.Text = "DNI";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telefonoLabel.Location = new Point(686, 223);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(74, 23);
            telefonoLabel.TabIndex = 9;
            telefonoLabel.Text = "Teléfono";
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
            registrarBtn.Location = new Point(832, 595);
            registrarBtn.Margin = new Padding(3, 4, 3, 4);
            registrarBtn.Name = "registrarBtn";
            registrarBtn.Size = new Size(198, 44);
            registrarBtn.TabIndex = 10;
            registrarBtn.Text = "Registrar";
            registrarBtn.UseVisualStyleBackColor = false;
            registrarBtn.Click += registrarBtn_Click;
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
            cancelarBtn.Location = new Point(599, 595);
            cancelarBtn.Margin = new Padding(3, 4, 3, 4);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(195, 44);
            cancelarBtn.TabIndex = 11;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = false;
            cancelarBtn.Click += cancelarBtn_Click;
            // 
            // yaCuentaLabel
            // 
            yaCuentaLabel.AutoSize = true;
            yaCuentaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yaCuentaLabel.ForeColor = Color.Black;
            yaCuentaLabel.Location = new Point(650, 687);
            yaCuentaLabel.Name = "yaCuentaLabel";
            yaCuentaLabel.Size = new Size(156, 20);
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
            iniciarSesionLabel.Location = new Point(817, 687);
            iniciarSesionLabel.Name = "iniciarSesionLabel";
            iniciarSesionLabel.Size = new Size(96, 20);
            iniciarSesionLabel.TabIndex = 13;
            iniciarSesionLabel.TabStop = true;
            iniciarSesionLabel.Text = "Iniciar Sesion";
            iniciarSesionLabel.LinkClicked += iniciarSesionLabel_LinkClicked;
            // 
            // direccionTextBox
            // 
            direccionTextBox.BorderStyle = BorderStyle.FixedSingle;
            direccionTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            direccionTextBox.Location = new Point(121, 337);
            direccionTextBox.Margin = new Padding(3, 4, 3, 4);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(434, 39);
            direccionTextBox.TabIndex = 5;
            // 
            // mailTextBox
            // 
            mailTextBox.BorderStyle = BorderStyle.FixedSingle;
            mailTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mailTextBox.Location = new Point(686, 333);
            mailTextBox.Margin = new Padding(3, 4, 3, 4);
            mailTextBox.Name = "mailTextBox";
            mailTextBox.Size = new Size(434, 39);
            mailTextBox.TabIndex = 6;
            // 
            // contraseñaTextBox
            // 
            contraseñaTextBox.BorderStyle = BorderStyle.FixedSingle;
            contraseñaTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contraseñaTextBox.Location = new Point(121, 428);
            contraseñaTextBox.Margin = new Padding(3, 4, 3, 4);
            contraseñaTextBox.Name = "contraseñaTextBox";
            contraseñaTextBox.PasswordChar = '*';
            contraseñaTextBox.Size = new Size(434, 39);
            contraseñaTextBox.TabIndex = 7;
            // 
            // confirmarContraseñaTextBox
            // 
            confirmarContraseñaTextBox.BorderStyle = BorderStyle.FixedSingle;
            confirmarContraseñaTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmarContraseñaTextBox.Location = new Point(686, 428);
            confirmarContraseñaTextBox.Margin = new Padding(3, 4, 3, 4);
            confirmarContraseñaTextBox.Name = "confirmarContraseñaTextBox";
            confirmarContraseñaTextBox.PasswordChar = '*';
            confirmarContraseñaTextBox.Size = new Size(434, 39);
            confirmarContraseñaTextBox.TabIndex = 8;
            // 
            // fechaNacimientoCalendario
            // 
            fechaNacimientoCalendario.Location = new Point(121, 545);
            fechaNacimientoCalendario.Margin = new Padding(10, 12, 10, 12);
            fechaNacimientoCalendario.Name = "fechaNacimientoCalendario";
            fechaNacimientoCalendario.TabIndex = 19;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            direccionLabel.Location = new Point(119, 311);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new Size(81, 23);
            direccionLabel.TabIndex = 20;
            direccionLabel.Text = "Dirección";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mailLabel.Location = new Point(683, 307);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(42, 23);
            mailLabel.TabIndex = 21;
            mailLabel.Text = "Mail";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contraseñaLabel.Location = new Point(119, 401);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new Size(97, 23);
            contraseñaLabel.TabIndex = 22;
            contraseñaLabel.Text = "Contraseña";
            // 
            // confirmarContraseñaLabel
            // 
            confirmarContraseñaLabel.AutoSize = true;
            confirmarContraseñaLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmarContraseñaLabel.Location = new Point(683, 401);
            confirmarContraseñaLabel.Name = "confirmarContraseñaLabel";
            confirmarContraseñaLabel.Size = new Size(175, 23);
            confirmarContraseñaLabel.TabIndex = 23;
            confirmarContraseñaLabel.Text = "Confirmar contraseña";
            // 
            // modificarLabel
            // 
            modificarLabel.AutoSize = true;
            modificarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            modificarLabel.Location = new Point(475, 36);
            modificarLabel.Name = "modificarLabel";
            modificarLabel.Size = new Size(272, 41);
            modificarLabel.TabIndex = 24;
            modificarLabel.Text = "Registrar Paciente";
            modificarLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 511);
            label1.Name = "label1";
            label1.Size = new Size(171, 23);
            label1.TabIndex = 25;
            label1.Text = "Fecha de Nacimiento";
            // 
            // RegistroPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1219, 785);
            Controls.Add(label1);
            Controls.Add(modificarLabel);
            Controls.Add(confirmarContraseñaLabel);
            Controls.Add(contraseñaLabel);
            Controls.Add(mailLabel);
            Controls.Add(direccionLabel);
            Controls.Add(fechaNacimientoCalendario);
            Controls.Add(confirmarContraseñaTextBox);
            Controls.Add(contraseñaTextBox);
            Controls.Add(mailTextBox);
            Controls.Add(direccionTextBox);
            Controls.Add(iniciarSesionLabel);
            Controls.Add(yaCuentaLabel);
            Controls.Add(cancelarBtn);
            Controls.Add(registrarBtn);
            Controls.Add(telefonoLabel);
            Controls.Add(dniLabel);
            Controls.Add(apellidoLabel);
            Controls.Add(nombreLabel);
            Controls.Add(telefonoTextBox);
            Controls.Add(dniTextBox);
            Controls.Add(apellidoTextBox);
            Controls.Add(nombreTextBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistroPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio";
            Load += RegistroPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox nombreTextBox;
        private TextBox apellidoTextBox;
        private TextBox dniTextBox;
        private TextBox telefonoTextBox;
        private Label nombreLabel;
        private Label apellidoLabel;
        private Label dniLabel;
        private Label telefonoLabel;
        private Button registrarBtn;
        private Button cancelarBtn;
        private Label yaCuentaLabel;
        private LinkLabel iniciarSesionLabel;
        private TextBox direccionTextBox;
        private TextBox mailTextBox;
        private TextBox contraseñaTextBox;
        private TextBox confirmarContraseñaTextBox;
        private MonthCalendar fechaNacimientoCalendario;
        private Label direccionLabel;
        private Label mailLabel;
        private Label contraseñaLabel;
        private Label confirmarContraseñaLabel;
        private Label modificarLabel;
        private Label label1;
    }
}