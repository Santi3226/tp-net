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
            comboId = new ComboBox();
            idLabel = new Label();
            contraseñaText = new TextBox();
            contraseñaLabel = new Label();
            label1 = new Label();
            dniText = new TextBox();
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
            nombreText.Location = new Point(349, 139);
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
            nombreLabel.Location = new Point(347, 122);
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
            domicilioLabel.Location = new Point(643, 186);
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
            apellidoLabel.Location = new Point(643, 122);
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
            domicilioText.Location = new Point(645, 203);
            domicilioText.Margin = new Padding(3, 2, 3, 2);
            domicilioText.Name = "domicilioText";
            domicilioText.Size = new Size(263, 23);
            domicilioText.TabIndex = 19;
            // 
            // apellidoText
            // 
            apellidoText.BorderStyle = BorderStyle.FixedSingle;
            apellidoText.Location = new Point(645, 139);
            apellidoText.Margin = new Padding(3, 2, 3, 2);
            apellidoText.Name = "apellidoText";
            apellidoText.Size = new Size(263, 23);
            apellidoText.TabIndex = 20;
            // 
            // comboId
            // 
            comboId.DisplayMember = "id";
            comboId.FormattingEnabled = true;
            comboId.Location = new Point(645, 74);
            comboId.Margin = new Padding(3, 2, 3, 2);
            comboId.Name = "comboId";
            comboId.Size = new Size(263, 23);
            comboId.TabIndex = 38;
            comboId.Tag = "id";
            comboId.ValueMember = "id";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 9F);
            idLabel.Location = new Point(643, 57);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 37;
            idLabel.Text = "Id";
            idLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // contraseñaText
            // 
            contraseñaText.BorderStyle = BorderStyle.FixedSingle;
            contraseñaText.Location = new Point(349, 80);
            contraseñaText.Margin = new Padding(3, 2, 3, 2);
            contraseñaText.Name = "contraseñaText";
            contraseñaText.Size = new Size(263, 23);
            contraseñaText.TabIndex = 40;
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new Font("Segoe UI", 9F);
            contraseñaLabel.Location = new Point(347, 63);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new Size(67, 15);
            contraseñaLabel.TabIndex = 39;
            contraseñaLabel.Text = "Contraseña";
            contraseñaLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(641, 251);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 42;
            label1.Text = "DNI";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dniText
            // 
            dniText.BorderStyle = BorderStyle.FixedSingle;
            dniText.Location = new Point(643, 268);
            dniText.Margin = new Padding(3, 2, 3, 2);
            dniText.Name = "dniText";
            dniText.Size = new Size(263, 23);
            dniText.TabIndex = 41;
            // 
            // ModificarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(929, 396);
            Controls.Add(label1);
            Controls.Add(dniText);
            Controls.Add(contraseñaText);
            Controls.Add(contraseñaLabel);
            Controls.Add(comboId);
            Controls.Add(idLabel);
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
        private ComboBox comboId;
        private Label idLabel;
        private TextBox contraseñaText;
        private Label contraseñaLabel;
        private Label label1;
        private TextBox dniText;
    }
}