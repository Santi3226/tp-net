namespace WinForms
{
    partial class ModificarCA
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
            guardarBtn = new Button();
            textBoxDomicilio = new TextBox();
            domicilioLabel = new Label();
            nombreLabel = new Label();
            textBoxNombre = new TextBox();
            modificarLabel = new Label();
            idLabel = new Label();
            comboId = new ComboBox();
            SuspendLayout();
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
            guardarBtn.Location = new Point(195, 264);
            guardarBtn.Margin = new Padding(3, 2, 3, 2);
            guardarBtn.Name = "guardarBtn";
            guardarBtn.Size = new Size(122, 30);
            guardarBtn.TabIndex = 32;
            guardarBtn.Text = "Guardar";
            guardarBtn.UseVisualStyleBackColor = false;
            guardarBtn.Click += guardarBtn_Click;
            // 
            // textBoxDomicilio
            // 
            textBoxDomicilio.BorderStyle = BorderStyle.FixedSingle;
            textBoxDomicilio.Location = new Point(126, 215);
            textBoxDomicilio.Margin = new Padding(3, 2, 3, 2);
            textBoxDomicilio.Name = "textBoxDomicilio";
            textBoxDomicilio.Size = new Size(263, 23);
            textBoxDomicilio.TabIndex = 30;
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Font = new Font("Segoe UI", 9F);
            domicilioLabel.Location = new Point(124, 198);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new Size(58, 15);
            domicilioLabel.TabIndex = 29;
            domicilioLabel.Text = "Domicilio";
            domicilioLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 9F);
            nombreLabel.Location = new Point(124, 134);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(51, 15);
            nombreLabel.TabIndex = 28;
            nombreLabel.Text = "Nombre";
            nombreLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Location = new Point(126, 151);
            textBoxNombre.Margin = new Padding(3, 2, 3, 2);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(263, 23);
            textBoxNombre.TabIndex = 26;
            // 
            // modificarLabel
            // 
            modificarLabel.AutoSize = true;
            modificarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            modificarLabel.Location = new Point(73, 26);
            modificarLabel.Name = "modificarLabel";
            modificarLabel.Size = new Size(354, 32);
            modificarLabel.TabIndex = 25;
            modificarLabel.Text = "Modificar Centro de Atencion";
            modificarLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 9F);
            idLabel.Location = new Point(124, 82);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 34;
            idLabel.Text = "Id";
            idLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboId
            // 
            comboId.DisplayMember = "id";
            comboId.FormattingEnabled = true;
            comboId.Location = new Point(126, 99);
            comboId.Margin = new Padding(3, 2, 3, 2);
            comboId.Name = "comboId";
            comboId.Size = new Size(263, 23);
            comboId.TabIndex = 36;
            comboId.Tag = "id";
            comboId.ValueMember = "id";
            // 
            // ModificarCA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(536, 319);
            Controls.Add(comboId);
            Controls.Add(idLabel);
            Controls.Add(guardarBtn);
            Controls.Add(textBoxDomicilio);
            Controls.Add(domicilioLabel);
            Controls.Add(nombreLabel);
            Controls.Add(textBoxNombre);
            Controls.Add(modificarLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ModificarCA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio";
            Load += ModificarCA_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guardarBtn;
        private TextBox textBoxDomicilio;
        private Label domicilioLabel;
        private Label nombreLabel;
        private TextBox textBoxNombre;
        private Label modificarLabel;
        private Label idLabel;
        private ComboBox comboId;
    }
}