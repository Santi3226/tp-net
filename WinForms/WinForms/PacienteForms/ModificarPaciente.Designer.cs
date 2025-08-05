namespace WinForms
{
    partial class ModificarPaciente
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
            fechaNacimientoCalendario = new MonthCalendar();
            nombreText = new TextBox();
            modificarLabel = new Label();
            fechaNacimientoLabel = new Label();
            guardarBtn = new Button();
            celularLabel = new Label();
            nombreLabel = new Label();
            emailLabel = new Label();
            domicilioLabel = new Label();
            apellidoLabel = new Label();
            emailText = new TextBox();
            celularText = new TextBox();
            domicilioText = new TextBox();
            apellidoText = new TextBox();
            contraseñaText = new TextBox();
            contraseñaLabel = new Label();
            dniLabel = new Label();
            dniText = new TextBox();
            textId = new TextBox();
            idLabel = new Label();
            SuspendLayout();
            // 
            // fechaNacimientoCalendario
            // 
            fechaNacimientoCalendario.Location = new Point(42, 140);
            fechaNacimientoCalendario.Margin = new Padding(8, 7, 8, 7);
            fechaNacimientoCalendario.Name = "fechaNacimientoCalendario";
            fechaNacimientoCalendario.TabIndex = 0;
            // 
            // nombreText
            // 
            nombreText.BorderStyle = BorderStyle.FixedSingle;
            nombreText.Location = new Point(645, 77);
            nombreText.Margin = new Padding(3, 2, 3, 2);
            nombreText.Name = "nombreText";
            nombreText.Size = new Size(263, 23);
            nombreText.TabIndex = 1;
            // 
            // modificarLabel
            // 
            modificarLabel.AutoSize = true;
            modificarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            modificarLabel.Location = new Point(62, 40);
            modificarLabel.Name = "modificarLabel";
            modificarLabel.Size = new Size(228, 32);
            modificarLabel.TabIndex = 2;
            modificarLabel.Text = "Modificar Paciente";
            modificarLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Font = new Font("Segoe UI", 9F);
            fechaNacimientoLabel.Location = new Point(97, 117);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new Size(119, 15);
            fechaNacimientoLabel.TabIndex = 3;
            fechaNacimientoLabel.Text = "Fecha de Nacimiento";
            fechaNacimientoLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // guardarBtn
            // 
            guardarBtn.BackColor = Color.SteelBlue;
            guardarBtn.Cursor = Cursors.Hand;
            guardarBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            guardarBtn.FlatAppearance.BorderSize = 0;
            guardarBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            guardarBtn.FlatStyle = FlatStyle.Flat;
            guardarBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guardarBtn.ForeColor = SystemColors.ControlLightLight;
            guardarBtn.Location = new Point(411, 329);
            guardarBtn.Margin = new Padding(3, 2, 3, 2);
            guardarBtn.Name = "guardarBtn";
            guardarBtn.Size = new Size(122, 30);
            guardarBtn.TabIndex = 9;
            guardarBtn.Text = "Guardar";
            guardarBtn.UseVisualStyleBackColor = false;
            guardarBtn.Click += guardarBtn_Click;
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Font = new Font("Segoe UI", 9F);
            celularLabel.Location = new Point(347, 251);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new Size(44, 15);
            celularLabel.TabIndex = 11;
            celularLabel.Text = "Celular";
            celularLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 9F);
            nombreLabel.Location = new Point(643, 61);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(51, 15);
            nombreLabel.TabIndex = 12;
            nombreLabel.Text = "Nombre";
            nombreLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 9F);
            emailLabel.Location = new Point(347, 186);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            emailLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Font = new Font("Segoe UI", 9F);
            domicilioLabel.Location = new Point(643, 250);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new Size(58, 15);
            domicilioLabel.TabIndex = 14;
            domicilioLabel.Text = "Domicilio";
            domicilioLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new Font("Segoe UI", 9F);
            apellidoLabel.Location = new Point(347, 124);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(51, 15);
            apellidoLabel.TabIndex = 15;
            apellidoLabel.Text = "Apellido";
            apellidoLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // emailText
            // 
            emailText.BorderStyle = BorderStyle.FixedSingle;
            emailText.Location = new Point(349, 203);
            emailText.Margin = new Padding(3, 2, 3, 2);
            emailText.Name = "emailText";
            emailText.Size = new Size(263, 23);
            emailText.TabIndex = 16;
            // 
            // celularText
            // 
            celularText.BorderStyle = BorderStyle.FixedSingle;
            celularText.Location = new Point(349, 268);
            celularText.Margin = new Padding(3, 2, 3, 2);
            celularText.Name = "celularText";
            celularText.Size = new Size(263, 23);
            celularText.TabIndex = 17;
            // 
            // domicilioText
            // 
            domicilioText.BorderStyle = BorderStyle.FixedSingle;
            domicilioText.Location = new Point(645, 268);
            domicilioText.Margin = new Padding(3, 2, 3, 2);
            domicilioText.Name = "domicilioText";
            domicilioText.Size = new Size(263, 23);
            domicilioText.TabIndex = 19;
            // 
            // apellidoText
            // 
            apellidoText.BorderStyle = BorderStyle.FixedSingle;
            apellidoText.Location = new Point(349, 140);
            apellidoText.Margin = new Padding(3, 2, 3, 2);
            apellidoText.Name = "apellidoText";
            apellidoText.Size = new Size(263, 23);
            apellidoText.TabIndex = 20;
            // 
            // contraseñaText
            // 
            contraseñaText.BorderStyle = BorderStyle.FixedSingle;
            contraseñaText.Location = new Point(645, 203);
            contraseñaText.Margin = new Padding(3, 2, 3, 2);
            contraseñaText.Name = "contraseñaText";
            contraseñaText.PasswordChar = '*';
            contraseñaText.Size = new Size(263, 23);
            contraseñaText.TabIndex = 40;
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new Font("Segoe UI", 9F);
            contraseñaLabel.Location = new Point(643, 186);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new Size(67, 15);
            contraseñaLabel.TabIndex = 39;
            contraseñaLabel.Text = "Contraseña";
            contraseñaLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Font = new Font("Segoe UI", 9F);
            dniLabel.Location = new Point(643, 124);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new Size(27, 15);
            dniLabel.TabIndex = 42;
            dniLabel.Text = "DNI";
            dniLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // dniText
            // 
            dniText.BorderStyle = BorderStyle.FixedSingle;
            dniText.Location = new Point(645, 140);
            dniText.Margin = new Padding(3, 2, 3, 2);
            dniText.Name = "dniText";
            dniText.Size = new Size(263, 23);
            dniText.TabIndex = 41;
            // 
            // textId
            // 
            textId.BorderStyle = BorderStyle.FixedSingle;
            textId.Location = new Point(349, 77);
            textId.Margin = new Padding(3, 2, 3, 2);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new Size(263, 23);
            textId.TabIndex = 44;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 9F);
            idLabel.Location = new Point(347, 60);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 43;
            idLabel.Text = "Id";
            idLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ModificarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(929, 396);
            Controls.Add(textId);
            Controls.Add(idLabel);
            Controls.Add(dniLabel);
            Controls.Add(dniText);
            Controls.Add(contraseñaText);
            Controls.Add(contraseñaLabel);
            Controls.Add(apellidoText);
            Controls.Add(domicilioText);
            Controls.Add(celularText);
            Controls.Add(emailText);
            Controls.Add(apellidoLabel);
            Controls.Add(domicilioLabel);
            Controls.Add(emailLabel);
            Controls.Add(nombreLabel);
            Controls.Add(celularLabel);
            Controls.Add(guardarBtn);
            Controls.Add(fechaNacimientoLabel);
            Controls.Add(modificarLabel);
            Controls.Add(nombreText);
            Controls.Add(fechaNacimientoCalendario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ModificarPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio";
            Load += ModificarPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar fechaNacimientoCalendario;
        private TextBox nombreText;
        private Label modificarLabel;
        private Label fechaNacimientoLabel;
        private Button guardarBtn;
        private Label celularLabel;
        private Label nombreLabel;
        private Label emailLabel;
        private Label domicilioLabel;
        private Label apellidoLabel;
        private TextBox emailText;
        private TextBox celularText;
        private TextBox domicilioText;
        private TextBox apellidoText;
        private TextBox contraseñaText;
        private Label contraseñaLabel;
        private Label dniLabel;
        private TextBox dniText;
        private TextBox textId;
        private Label idLabel;
    }
}