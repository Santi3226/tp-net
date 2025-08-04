namespace WinForms
{
    partial class AgregarPaciente
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
            modificarLabel = new Label();
            confirmarContraseñaLabel = new Label();
            contraseñaLabel = new Label();
            mailLabel = new Label();
            direccionLabel = new Label();
            confirmarContraseñaTextBox = new TextBox();
            contraseñaTextBox = new TextBox();
            mailTextBox = new TextBox();
            direccionTextBox = new TextBox();
            telefonoLabel = new Label();
            dniLabel = new Label();
            apellidoLabel = new Label();
            nombreLabel = new Label();
            telefonoTextBox = new TextBox();
            dniTextBox = new TextBox();
            apellidoTextBox = new TextBox();
            nombreTextBox = new TextBox();
            label1 = new Label();
            fechaNacimientoCalendario = new MonthCalendar();
            cancelarBtn = new Button();
            registrarBtn = new Button();
            SuspendLayout();
            // 
            // modificarLabel
            // 
            modificarLabel.AutoSize = true;
            modificarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            modificarLabel.Location = new Point(414, 22);
            modificarLabel.Name = "modificarLabel";
            modificarLabel.Size = new Size(272, 41);
            modificarLabel.TabIndex = 41;
            modificarLabel.Text = "Registrar Paciente";
            modificarLabel.TextAlign = ContentAlignment.TopCenter;
            modificarLabel.Click += modificarLabel_Click;
            // 
            // confirmarContraseñaLabel
            // 
            confirmarContraseñaLabel.AutoSize = true;
            confirmarContraseñaLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmarContraseñaLabel.Location = new Point(625, 480);
            confirmarContraseñaLabel.Name = "confirmarContraseñaLabel";
            confirmarContraseñaLabel.Size = new Size(175, 23);
            confirmarContraseñaLabel.TabIndex = 40;
            confirmarContraseñaLabel.Text = "Confirmar contraseña";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contraseñaLabel.Location = new Point(627, 381);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new Size(97, 23);
            contraseñaLabel.TabIndex = 39;
            contraseñaLabel.Text = "Contraseña";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mailLabel.Location = new Point(627, 297);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(42, 23);
            mailLabel.TabIndex = 38;
            mailLabel.Text = "Mail";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            direccionLabel.Location = new Point(58, 297);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new Size(81, 23);
            direccionLabel.TabIndex = 37;
            direccionLabel.Text = "Dirección";
            // 
            // confirmarContraseñaTextBox
            // 
            confirmarContraseñaTextBox.BorderStyle = BorderStyle.FixedSingle;
            confirmarContraseñaTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmarContraseñaTextBox.Location = new Point(627, 507);
            confirmarContraseñaTextBox.Margin = new Padding(3, 4, 3, 4);
            confirmarContraseñaTextBox.Name = "confirmarContraseñaTextBox";
            confirmarContraseñaTextBox.PasswordChar = '*';
            confirmarContraseñaTextBox.Size = new Size(434, 39);
            confirmarContraseñaTextBox.TabIndex = 34;
            // 
            // contraseñaTextBox
            // 
            contraseñaTextBox.BorderStyle = BorderStyle.FixedSingle;
            contraseñaTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contraseñaTextBox.Location = new Point(627, 408);
            contraseñaTextBox.Margin = new Padding(3, 4, 3, 4);
            contraseñaTextBox.Name = "contraseñaTextBox";
            contraseñaTextBox.PasswordChar = '*';
            contraseñaTextBox.Size = new Size(434, 39);
            contraseñaTextBox.TabIndex = 32;
            // 
            // mailTextBox
            // 
            mailTextBox.BorderStyle = BorderStyle.FixedSingle;
            mailTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mailTextBox.Location = new Point(627, 323);
            mailTextBox.Margin = new Padding(3, 4, 3, 4);
            mailTextBox.Name = "mailTextBox";
            mailTextBox.Size = new Size(434, 39);
            mailTextBox.TabIndex = 30;
            // 
            // direccionTextBox
            // 
            direccionTextBox.BorderStyle = BorderStyle.FixedSingle;
            direccionTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            direccionTextBox.Location = new Point(60, 323);
            direccionTextBox.Margin = new Padding(3, 4, 3, 4);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(434, 39);
            direccionTextBox.TabIndex = 29;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telefonoLabel.Location = new Point(625, 209);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(74, 23);
            telefonoLabel.TabIndex = 36;
            telefonoLabel.Text = "Teléfono";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dniLabel.Location = new Point(58, 209);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new Size(40, 23);
            dniLabel.TabIndex = 35;
            dniLabel.Text = "DNI";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            apellidoLabel.Location = new Point(625, 115);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(72, 23);
            apellidoLabel.TabIndex = 33;
            apellidoLabel.Text = "Apellido";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreLabel.Location = new Point(58, 115);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(73, 23);
            nombreLabel.TabIndex = 31;
            nombreLabel.Text = "Nombre";
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.BorderStyle = BorderStyle.FixedSingle;
            telefonoTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telefonoTextBox.Location = new Point(627, 235);
            telefonoTextBox.Margin = new Padding(3, 4, 3, 4);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(434, 39);
            telefonoTextBox.TabIndex = 28;
            // 
            // dniTextBox
            // 
            dniTextBox.BorderStyle = BorderStyle.FixedSingle;
            dniTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dniTextBox.Location = new Point(60, 235);
            dniTextBox.Margin = new Padding(3, 4, 3, 4);
            dniTextBox.Name = "dniTextBox";
            dniTextBox.Size = new Size(434, 39);
            dniTextBox.TabIndex = 27;
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.BorderStyle = BorderStyle.FixedSingle;
            apellidoTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            apellidoTextBox.Location = new Point(627, 142);
            apellidoTextBox.Margin = new Padding(3, 4, 3, 4);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(434, 39);
            apellidoTextBox.TabIndex = 26;
            // 
            // nombreTextBox
            // 
            nombreTextBox.BorderStyle = BorderStyle.FixedSingle;
            nombreTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreTextBox.Location = new Point(60, 142);
            nombreTextBox.Margin = new Padding(3, 4, 3, 4);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(434, 39);
            nombreTextBox.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 408);
            label1.Name = "label1";
            label1.Size = new Size(171, 23);
            label1.TabIndex = 47;
            label1.Text = "Fecha de Nacimiento";
            // 
            // fechaNacimientoCalendario
            // 
            fechaNacimientoCalendario.Location = new Point(143, 442);
            fechaNacimientoCalendario.Margin = new Padding(10, 12, 10, 12);
            fechaNacimientoCalendario.Name = "fechaNacimientoCalendario";
            fechaNacimientoCalendario.TabIndex = 46;
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
            cancelarBtn.Location = new Point(625, 622);
            cancelarBtn.Margin = new Padding(3, 4, 3, 4);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(195, 44);
            cancelarBtn.TabIndex = 43;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = false;
            cancelarBtn.Click += cancelarBtn_Click;
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
            registrarBtn.Location = new Point(863, 622);
            registrarBtn.Margin = new Padding(3, 4, 3, 4);
            registrarBtn.Name = "registrarBtn";
            registrarBtn.Size = new Size(198, 44);
            registrarBtn.TabIndex = 42;
            registrarBtn.Text = "Registrar";
            registrarBtn.UseVisualStyleBackColor = false;
            registrarBtn.Click += registrarBtn_Click;
            // 
            // AgregarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1117, 732);
            Controls.Add(label1);
            Controls.Add(fechaNacimientoCalendario);
            Controls.Add(cancelarBtn);
            Controls.Add(registrarBtn);
            Controls.Add(modificarLabel);
            Controls.Add(confirmarContraseñaLabel);
            Controls.Add(contraseñaLabel);
            Controls.Add(mailLabel);
            Controls.Add(direccionLabel);
            Controls.Add(confirmarContraseñaTextBox);
            Controls.Add(contraseñaTextBox);
            Controls.Add(mailTextBox);
            Controls.Add(direccionTextBox);
            Controls.Add(telefonoLabel);
            Controls.Add(dniLabel);
            Controls.Add(apellidoLabel);
            Controls.Add(nombreLabel);
            Controls.Add(telefonoTextBox);
            Controls.Add(dniTextBox);
            Controls.Add(apellidoTextBox);
            Controls.Add(nombreTextBox);
            Name = "AgregarPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio";
            Load += AgregarPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label modificarLabel;
        private Label confirmarContraseñaLabel;
        private Label contraseñaLabel;
        private Label mailLabel;
        private Label direccionLabel;
        private TextBox confirmarContraseñaTextBox;
        private TextBox contraseñaTextBox;
        private TextBox mailTextBox;
        private TextBox direccionTextBox;
        private Label telefonoLabel;
        private Label dniLabel;
        private Label apellidoLabel;
        private Label nombreLabel;
        private TextBox telefonoTextBox;
        private TextBox dniTextBox;
        private TextBox apellidoTextBox;
        private TextBox nombreTextBox;
        private Label label1;
        private MonthCalendar fechaNacimientoCalendario;
        private Button cancelarBtn;
        private Button registrarBtn;
    }
}