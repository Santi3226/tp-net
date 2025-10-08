namespace WinForms
{
    partial class AgregarCentro
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
            agregarLabel = new Label();
            nombreTextBox = new TextBox();
            direccionTextBox = new TextBox();
            nombreLabel = new Label();
            direccionLabel = new Label();
            agregarBtn = new Button();
            cancelarBtn = new Button();
            localidadCombo = new ComboBox();
            localidadLabel = new Label();
            SuspendLayout();
            // 
            // agregarLabel
            // 
            agregarLabel.AutoSize = true;
            agregarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            agregarLabel.Location = new Point(297, 36);
            agregarLabel.Name = "agregarLabel";
            agregarLabel.Size = new Size(188, 32);
            agregarLabel.TabIndex = 25;
            agregarLabel.Text = "Agregar centro";
            agregarLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // nombreTextBox
            // 
            nombreTextBox.BorderStyle = BorderStyle.FixedSingle;
            nombreTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreTextBox.Location = new Point(247, 144);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(281, 33);
            nombreTextBox.TabIndex = 26;
            // 
            // direccionTextBox
            // 
            direccionTextBox.BorderStyle = BorderStyle.FixedSingle;
            direccionTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            direccionTextBox.Location = new Point(247, 232);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(281, 33);
            direccionTextBox.TabIndex = 27;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreLabel.Location = new Point(245, 124);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(57, 17);
            nombreLabel.TabIndex = 28;
            nombreLabel.Text = "Nombre";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            direccionLabel.Location = new Point(245, 212);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new Size(62, 17);
            direccionLabel.TabIndex = 29;
            direccionLabel.Text = "Dirección";
            // 
            // agregarBtn
            // 
            agregarBtn.BackColor = Color.SteelBlue;
            agregarBtn.Cursor = Cursors.Hand;
            agregarBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            agregarBtn.FlatAppearance.BorderSize = 0;
            agregarBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            agregarBtn.FlatStyle = FlatStyle.Flat;
            agregarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarBtn.ForeColor = Color.White;
            agregarBtn.Location = new Point(196, 395);
            agregarBtn.Name = "agregarBtn";
            agregarBtn.Size = new Size(173, 33);
            agregarBtn.TabIndex = 30;
            agregarBtn.Text = "Agregar";
            agregarBtn.UseVisualStyleBackColor = false;
            agregarBtn.Click += agregarBtn_Click;
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
            cancelarBtn.Location = new Point(410, 395);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(171, 33);
            cancelarBtn.TabIndex = 31;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = false;
            cancelarBtn.Click += cancelarBtn_Click;
            // 
            // localidadCombo
            // 
            localidadCombo.FormattingEnabled = true;
            localidadCombo.Location = new Point(247, 320);
            localidadCombo.Name = "localidadCombo";
            localidadCombo.Size = new Size(281, 23);
            localidadCombo.TabIndex = 38;
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            localidadLabel.Location = new Point(243, 301);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new Size(64, 17);
            localidadLabel.TabIndex = 37;
            localidadLabel.Text = "Localidad";
            // 
            // AgregarCentro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(801, 478);
            Controls.Add(localidadCombo);
            Controls.Add(localidadLabel);
            Controls.Add(cancelarBtn);
            Controls.Add(agregarBtn);
            Controls.Add(direccionLabel);
            Controls.Add(nombreLabel);
            Controls.Add(direccionTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(agregarLabel);
            Name = "AgregarCentro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Centro";
            Load += AgregarCentro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label agregarLabel;
        private TextBox nombreTextBox;
        private TextBox direccionTextBox;
        private Label nombreLabel;
        private Label direccionLabel;
        private Button agregarBtn;
        private Button cancelarBtn;
        private ComboBox localidadCombo;
        private Label localidadLabel;
    }
}