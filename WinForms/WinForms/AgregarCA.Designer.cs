namespace WinForms
{
    partial class AgregarCA
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
            monthCalendar1 = new MonthCalendar();
            nombreText = new TextBox();
            titulo = new Label();
            calendarioLabel = new Label();
            guardarBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            emailText = new TextBox();
            celularText = new TextBox();
            domicilioText = new TextBox();
            apellidoText = new TextBox();
            sexoCombo = new ComboBox();
            crearCentroLabel = new Label();
            textBoxDomicilio = new TextBox();
            domicilioLabel = new Label();
            nombreLabel = new Label();
            textBoxNombre = new TextBox();
            agregarBtn = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(48, 186);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // nombreText
            // 
            nombreText.BorderStyle = BorderStyle.FixedSingle;
            nombreText.Location = new Point(399, 185);
            nombreText.Name = "nombreText";
            nombreText.Size = new Size(300, 23);
            nombreText.TabIndex = 1;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titulo.Location = new Point(356, 64);
            titulo.Name = "titulo";
            titulo.Size = new Size(282, 41);
            titulo.TabIndex = 2;
            titulo.Text = "Modificar Paciente";
            titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // calendarioLabel
            // 
            calendarioLabel.AutoSize = true;
            calendarioLabel.Font = new Font("Segoe UI", 9F);
            calendarioLabel.Location = new Point(111, 156);
            calendarioLabel.Name = "calendarioLabel";
            calendarioLabel.Size = new Size(149, 20);
            calendarioLabel.TabIndex = 3;
            calendarioLabel.Text = "Fecha de Nacimiento";
            calendarioLabel.TextAlign = ContentAlignment.TopCenter;
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
            guardarBtn.Location = new Point(475, 459);
            guardarBtn.Name = "guardarBtn";
            guardarBtn.Size = new Size(140, 40);
            guardarBtn.TabIndex = 9;
            guardarBtn.Text = "Guardar";
            guardarBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(737, 335);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 10;
            label1.Text = "Sexo";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(399, 335);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 11;
            label2.Text = "Celular";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(399, 162);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 12;
            label3.Text = "Nombre";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(399, 248);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 13;
            label4.Text = "Email";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(737, 248);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 14;
            label5.Text = "Domicilio";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(737, 162);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 15;
            label6.Text = "Apellido";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // emailText
            // 
            emailText.BorderStyle = BorderStyle.FixedSingle;
            emailText.Location = new Point(399, 271);
            emailText.Name = "emailText";
            emailText.Size = new Size(300, 23);
            emailText.TabIndex = 16;
            // 
            // celularText
            // 
            celularText.BorderStyle = BorderStyle.FixedSingle;
            celularText.Location = new Point(399, 358);
            celularText.Name = "celularText";
            celularText.Size = new Size(300, 23);
            celularText.TabIndex = 17;
            // 
            // domicilioText
            // 
            domicilioText.BorderStyle = BorderStyle.FixedSingle;
            domicilioText.Location = new Point(737, 271);
            domicilioText.Name = "domicilioText";
            domicilioText.Size = new Size(300, 23);
            domicilioText.TabIndex = 19;
            // 
            // apellidoText
            // 
            apellidoText.BorderStyle = BorderStyle.FixedSingle;
            apellidoText.Location = new Point(737, 185);
            apellidoText.Name = "apellidoText";
            apellidoText.Size = new Size(300, 23);
            apellidoText.TabIndex = 20;
            // 
            // sexoCombo
            // 
            sexoCombo.DisplayMember = "-";
            sexoCombo.FormattingEnabled = true;
            sexoCombo.Items.AddRange(new object[] { "Sin Especificar", "Masculino", "Femenino" });
            sexoCombo.Location = new Point(737, 357);
            sexoCombo.Name = "sexoCombo";
            sexoCombo.Size = new Size(300, 23);
            sexoCombo.TabIndex = 21;
            sexoCombo.Text = "-";
            // 
            // crearCentroLabel
            // 
            crearCentroLabel.AutoSize = true;
            crearCentroLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            crearCentroLabel.Location = new Point(197, 41);
            crearCentroLabel.Name = "crearCentroLabel";
            crearCentroLabel.Size = new Size(304, 32);
            crearCentroLabel.TabIndex = 3;
            crearCentroLabel.Text = "Crear Centro de Atencion";
            crearCentroLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxDomicilio
            // 
            textBoxDomicilio.BorderStyle = BorderStyle.FixedSingle;
            textBoxDomicilio.Location = new Point(201, 229);
            textBoxDomicilio.Name = "textBoxDomicilio";
            textBoxDomicilio.Size = new Size(300, 23);
            textBoxDomicilio.TabIndex = 22;
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Font = new Font("Segoe UI", 9F);
            domicilioLabel.Location = new Point(199, 211);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new Size(58, 15);
            domicilioLabel.TabIndex = 21;
            domicilioLabel.Text = "Domicilio";
            domicilioLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 9F);
            nombreLabel.Location = new Point(199, 125);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(51, 15);
            nombreLabel.TabIndex = 20;
            nombreLabel.Text = "Nombre";
            nombreLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Location = new Point(201, 143);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(300, 23);
            textBoxNombre.TabIndex = 18;
            // 
            // agregarBtn
            // 
            agregarBtn.BackColor = Color.SteelBlue;
            agregarBtn.Cursor = Cursors.Hand;
            agregarBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            agregarBtn.FlatAppearance.BorderSize = 0;
            agregarBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            agregarBtn.FlatStyle = FlatStyle.Flat;
            agregarBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarBtn.ForeColor = SystemColors.ControlLightLight;
            agregarBtn.Location = new Point(283, 308);
            agregarBtn.Name = "agregarBtn";
            agregarBtn.Size = new Size(140, 40);
            agregarBtn.TabIndex = 24;
            agregarBtn.Text = "Agregar";
            agregarBtn.UseVisualStyleBackColor = false;
            agregarBtn.Click += agregarBtn_Click;
            // 
            // AgregarCA
            // 
            BackColor = Color.Gainsboro;
            ClientSize = new Size(715, 384);
            Controls.Add(agregarBtn);
            Controls.Add(textBoxDomicilio);
            Controls.Add(domicilioLabel);
            Controls.Add(nombreLabel);
            Controls.Add(textBoxNombre);
            Controls.Add(crearCentroLabel);
            Name = "AgregarCA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio";
            Load += AgregarCA_Load;
            ResumeLayout(false);
            PerformLayout();
            // 
            // AgregarCA
            // 
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private TextBox nombreText;
        private Label titulo;
        private Label calendarioLabel;
        private Button guardarBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox emailText;
        private TextBox celularText;
        private TextBox domicilioText;
        private TextBox apellidoText;
        private ComboBox sexoCombo;
        private Label crearCentroLabel;
        private TextBox textBoxDomicilio;
        private Label domicilioLabel;
        private Label nombreLabel;
        private TextBox textBoxNombre;
        private Button agregarBtn;
    }
}