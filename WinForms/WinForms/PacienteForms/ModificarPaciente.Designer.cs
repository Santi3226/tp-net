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
            label1 = new Label();
            dniText = new TextBox();
            textId = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // fechaNacimientoCalendario
            // 
            fechaNacimientoCalendario.Location = new Point(48, 187);
            fechaNacimientoCalendario.Name = "fechaNacimientoCalendario";
            fechaNacimientoCalendario.TabIndex = 0;
            // 
            // nombreText
            // 
            nombreText.BorderStyle = BorderStyle.FixedSingle;
            nombreText.Location = new Point(737, 103);
            nombreText.Name = "nombreText";
            nombreText.Size = new Size(300, 27);
            nombreText.TabIndex = 1;
            // 
            // modificarLabel
            // 
            modificarLabel.AutoSize = true;
            modificarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            modificarLabel.Location = new Point(71, 53);
            modificarLabel.Name = "modificarLabel";
            modificarLabel.Size = new Size(282, 41);
            modificarLabel.TabIndex = 2;
            modificarLabel.Text = "Modificar Paciente";
            modificarLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Font = new Font("Segoe UI", 9F);
            fechaNacimientoLabel.Location = new Point(111, 156);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new Size(149, 20);
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
            guardarBtn.Location = new Point(470, 439);
            guardarBtn.Name = "guardarBtn";
            guardarBtn.Size = new Size(139, 40);
            guardarBtn.TabIndex = 9;
            guardarBtn.Text = "Guardar";
            guardarBtn.UseVisualStyleBackColor = false;
            guardarBtn.Click += guardarBtn_Click;
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Font = new Font("Segoe UI", 9F);
            celularLabel.Location = new Point(397, 335);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new Size(55, 20);
            celularLabel.TabIndex = 11;
            celularLabel.Text = "Celular";
            celularLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 9F);
            nombreLabel.Location = new Point(735, 81);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(64, 20);
            nombreLabel.TabIndex = 12;
            nombreLabel.Text = "Nombre";
            nombreLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 9F);
            emailLabel.Location = new Point(397, 248);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            emailLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Font = new Font("Segoe UI", 9F);
            domicilioLabel.Location = new Point(735, 334);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new Size(74, 20);
            domicilioLabel.TabIndex = 14;
            domicilioLabel.Text = "Domicilio";
            domicilioLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new Font("Segoe UI", 9F);
            apellidoLabel.Location = new Point(397, 165);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(66, 20);
            apellidoLabel.TabIndex = 15;
            apellidoLabel.Text = "Apellido";
            apellidoLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // emailText
            // 
            emailText.BorderStyle = BorderStyle.FixedSingle;
            emailText.Location = new Point(399, 271);
            emailText.Name = "emailText";
            emailText.Size = new Size(300, 27);
            emailText.TabIndex = 16;
            // 
            // celularText
            // 
            celularText.BorderStyle = BorderStyle.FixedSingle;
            celularText.Location = new Point(399, 357);
            celularText.Name = "celularText";
            celularText.Size = new Size(300, 27);
            celularText.TabIndex = 17;
            // 
            // domicilioText
            // 
            domicilioText.BorderStyle = BorderStyle.FixedSingle;
            domicilioText.Location = new Point(737, 357);
            domicilioText.Name = "domicilioText";
            domicilioText.Size = new Size(300, 27);
            domicilioText.TabIndex = 19;
            // 
            // apellidoText
            // 
            apellidoText.BorderStyle = BorderStyle.FixedSingle;
            apellidoText.Location = new Point(399, 187);
            apellidoText.Name = "apellidoText";
            apellidoText.Size = new Size(300, 27);
            apellidoText.TabIndex = 20;
            // 
            // contraseñaText
            // 
            contraseñaText.BorderStyle = BorderStyle.FixedSingle;
            contraseñaText.Location = new Point(737, 271);
            contraseñaText.Name = "contraseñaText";
            contraseñaText.PasswordChar = '*';
            contraseñaText.Size = new Size(300, 27);
            contraseñaText.TabIndex = 40;
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new Font("Segoe UI", 9F);
            contraseñaLabel.Location = new Point(735, 248);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new Size(83, 20);
            contraseñaLabel.TabIndex = 39;
            contraseñaLabel.Text = "Contraseña";
            contraseñaLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(735, 165);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 42;
            label1.Text = "DNI";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // dniText
            // 
            dniText.BorderStyle = BorderStyle.FixedSingle;
            dniText.Location = new Point(737, 187);
            dniText.Name = "dniText";
            dniText.Size = new Size(300, 27);
            dniText.TabIndex = 41;
            // 
            // textId
            // 
            textId.BorderStyle = BorderStyle.FixedSingle;
            textId.Location = new Point(399, 103);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new Size(300, 27);
            textId.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(397, 80);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 43;
            label2.Text = "Id";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // ModificarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1062, 528);
            Controls.Add(textId);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private TextBox dniText;
        private TextBox textId;
        private Label label2;
    }
}