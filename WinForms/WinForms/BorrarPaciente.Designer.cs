namespace WinForms
{
    partial class BorrarPaciente
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
            borrarBtn = new Button();
            sexoCombo = new ComboBox();
            idCentroLabel = new Label();
            borrarPacienteLabel = new Label();
            SuspendLayout();
            // 
            // borrarBtn
            // 
            borrarBtn.BackColor = Color.Crimson;
            borrarBtn.Cursor = Cursors.Hand;
            borrarBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            borrarBtn.FlatAppearance.BorderSize = 0;
            borrarBtn.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            borrarBtn.FlatStyle = FlatStyle.Flat;
            borrarBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrarBtn.ForeColor = SystemColors.ControlLightLight;
            borrarBtn.Location = new Point(201, 214);
            borrarBtn.Margin = new Padding(3, 2, 3, 2);
            borrarBtn.Name = "borrarBtn";
            borrarBtn.Size = new Size(122, 30);
            borrarBtn.TabIndex = 37;
            borrarBtn.Text = "Borrar";
            borrarBtn.UseVisualStyleBackColor = false;
            borrarBtn.Click += borrarBtn_Click;
            // 
            // sexoCombo
            // 
            sexoCombo.DisplayMember = "id";
            sexoCombo.FormattingEnabled = true;
            sexoCombo.Items.AddRange(new object[] { "Sin Especificar", "Masculino", "Femenino" });
            sexoCombo.Location = new Point(132, 140);
            sexoCombo.Margin = new Padding(3, 2, 3, 2);
            sexoCombo.Name = "sexoCombo";
            sexoCombo.Size = new Size(263, 23);
            sexoCombo.TabIndex = 36;
            sexoCombo.Tag = "id";
            sexoCombo.Text = "-";
            sexoCombo.ValueMember = "id";
            // 
            // idCentroLabel
            // 
            idCentroLabel.AutoSize = true;
            idCentroLabel.Font = new Font("Segoe UI", 9F);
            idCentroLabel.Location = new Point(130, 123);
            idCentroLabel.Name = "idCentroLabel";
            idCentroLabel.Size = new Size(65, 15);
            idCentroLabel.TabIndex = 35;
            idCentroLabel.Text = "Id Paciente";
            idCentroLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // borrarPacienteLabel
            // 
            borrarPacienteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            borrarPacienteLabel.AutoSize = true;
            borrarPacienteLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            borrarPacienteLabel.Location = new Point(168, 49);
            borrarPacienteLabel.Name = "borrarPacienteLabel";
            borrarPacienteLabel.Size = new Size(190, 32);
            borrarPacienteLabel.TabIndex = 34;
            borrarPacienteLabel.Text = "Borrar Paciente";
            borrarPacienteLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // BorrarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(545, 291);
            Controls.Add(borrarBtn);
            Controls.Add(sexoCombo);
            Controls.Add(idCentroLabel);
            Controls.Add(borrarPacienteLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BorrarPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio";
            Load += BorrarPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button borrarBtn;
        private ComboBox sexoCombo;
        private Label idCentroLabel;
        private Label borrarPacienteLabel;
    }
}