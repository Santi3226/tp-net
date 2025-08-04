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
            textId = new TextBox();
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
            guardarBtn.Location = new Point(223, 352);
            guardarBtn.Name = "guardarBtn";
            guardarBtn.Size = new Size(139, 40);
            guardarBtn.TabIndex = 32;
            guardarBtn.Text = "Guardar";
            guardarBtn.UseVisualStyleBackColor = false;
            guardarBtn.Click += guardarBtn_Click;
            // 
            // textBoxDomicilio
            // 
            textBoxDomicilio.BorderStyle = BorderStyle.FixedSingle;
            textBoxDomicilio.Location = new Point(144, 287);
            textBoxDomicilio.Name = "textBoxDomicilio";
            textBoxDomicilio.Size = new Size(300, 27);
            textBoxDomicilio.TabIndex = 30;
            // 
            // domicilioLabel
            // 
            domicilioLabel.AutoSize = true;
            domicilioLabel.Font = new Font("Segoe UI", 9F);
            domicilioLabel.Location = new Point(142, 264);
            domicilioLabel.Name = "domicilioLabel";
            domicilioLabel.Size = new Size(74, 20);
            domicilioLabel.TabIndex = 29;
            domicilioLabel.Text = "Domicilio";
            domicilioLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 9F);
            nombreLabel.Location = new Point(142, 179);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(64, 20);
            nombreLabel.TabIndex = 28;
            nombreLabel.Text = "Nombre";
            nombreLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Location = new Point(144, 201);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(300, 27);
            textBoxNombre.TabIndex = 26;
            // 
            // modificarLabel
            // 
            modificarLabel.AutoSize = true;
            modificarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            modificarLabel.Location = new Point(83, 35);
            modificarLabel.Name = "modificarLabel";
            modificarLabel.Size = new Size(435, 41);
            modificarLabel.TabIndex = 25;
            modificarLabel.Text = "Modificar Centro de Atencion";
            modificarLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 9F);
            idLabel.Location = new Point(142, 109);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(22, 20);
            idLabel.TabIndex = 34;
            idLabel.Text = "Id";
            idLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // textId
            // 
            textId.BorderStyle = BorderStyle.FixedSingle;
            textId.Location = new Point(144, 132);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new Size(300, 27);
            textId.TabIndex = 35;
            // 
            // ModificarCA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(613, 425);
            Controls.Add(textId);
            Controls.Add(idLabel);
            Controls.Add(guardarBtn);
            Controls.Add(textBoxDomicilio);
            Controls.Add(domicilioLabel);
            Controls.Add(nombreLabel);
            Controls.Add(textBoxNombre);
            Controls.Add(modificarLabel);
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
        private TextBox textId;
    }
}