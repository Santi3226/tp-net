namespace WinForms
{
    partial class BorrarCA
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
            components = new System.ComponentModel.Container();
            centroAtencionInMemoryBindingSource = new BindingSource(components);
            idCentroLabel = new Label();
            borrarCentroLabel = new Label();
            borrarBtn = new Button();
            pacienteInMemoryBindingSource = new BindingSource(components);
            comboId = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)centroAtencionInMemoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pacienteInMemoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // centroAtencionInMemoryBindingSource
            // 
            centroAtencionInMemoryBindingSource.DataSource = typeof(Data.CentroAtencionInMemory);
            // 
            // idCentroLabel
            // 
            idCentroLabel.AutoSize = true;
            idCentroLabel.Font = new Font("Segoe UI", 9F);
            idCentroLabel.Location = new Point(138, 126);
            idCentroLabel.Name = "idCentroLabel";
            idCentroLabel.Size = new Size(123, 15);
            idCentroLabel.TabIndex = 23;
            idCentroLabel.Text = "Id Centro de Atencion";
            idCentroLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // borrarCentroLabel
            // 
            borrarCentroLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            borrarCentroLabel.AutoSize = true;
            borrarCentroLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            borrarCentroLabel.Location = new Point(121, 53);
            borrarCentroLabel.Name = "borrarCentroLabel";
            borrarCentroLabel.Size = new Size(316, 32);
            borrarCentroLabel.TabIndex = 22;
            borrarCentroLabel.Text = "Borrar Centro de Atencion";
            borrarCentroLabel.TextAlign = ContentAlignment.TopCenter;
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
            borrarBtn.Location = new Point(218, 220);
            borrarBtn.Margin = new Padding(3, 2, 3, 2);
            borrarBtn.Name = "borrarBtn";
            borrarBtn.Size = new Size(122, 30);
            borrarBtn.TabIndex = 33;
            borrarBtn.Text = "Borrar";
            borrarBtn.UseVisualStyleBackColor = false;
            borrarBtn.Click += borrarBtn_Click;
            // 
            // pacienteInMemoryBindingSource
            // 
            pacienteInMemoryBindingSource.DataSource = typeof(Data.PacienteInMemory);
            // 
            // comboId
            // 
            comboId.DisplayMember = "id";
            comboId.FormattingEnabled = true;
            comboId.Location = new Point(141, 143);
            comboId.Margin = new Padding(3, 2, 3, 2);
            comboId.Name = "comboId";
            comboId.Size = new Size(278, 23);
            comboId.TabIndex = 35;
            comboId.Tag = "id";
            comboId.ValueMember = "id";
            // 
            // BorrarCA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(545, 291);
            Controls.Add(comboId);
            Controls.Add(borrarBtn);
            Controls.Add(idCentroLabel);
            Controls.Add(borrarCentroLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BorrarCA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio";
            Load += BorrarCA_Load;
            ((System.ComponentModel.ISupportInitialize)centroAtencionInMemoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pacienteInMemoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label idCentroLabel;
        private Label borrarCentroLabel;
        private Button borrarBtn;
        private BindingSource centroAtencionInMemoryBindingSource;
        private BindingSource pacienteInMemoryBindingSource;
        private ComboBox comboId;
    }
}