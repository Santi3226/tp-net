namespace WinForms
{
    partial class ModificarTipo
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
            cancelarBtn = new Button();
            modificarBtn = new Button();
            importeLabel = new Label();
            nombreLabel = new Label();
            importeTextBox = new TextBox();
            nombreTextBox = new TextBox();
            modificarLabel = new Label();
            plantillaCombo = new ComboBox();
            plantillaLabel = new Label();
            SuspendLayout();
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
            cancelarBtn.Location = new Point(409, 405);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(171, 33);
            cancelarBtn.TabIndex = 42;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = false;
            cancelarBtn.Click += cancelarBtn_Click;
            // 
            // modificarBtn
            // 
            modificarBtn.BackColor = Color.SteelBlue;
            modificarBtn.Cursor = Cursors.Hand;
            modificarBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            modificarBtn.FlatAppearance.BorderSize = 0;
            modificarBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            modificarBtn.FlatStyle = FlatStyle.Flat;
            modificarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modificarBtn.ForeColor = Color.White;
            modificarBtn.Location = new Point(195, 405);
            modificarBtn.Name = "modificarBtn";
            modificarBtn.Size = new Size(173, 33);
            modificarBtn.TabIndex = 41;
            modificarBtn.Text = "Modificar";
            modificarBtn.UseVisualStyleBackColor = false;
            modificarBtn.Click += modificarBtn_Click;
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importeLabel.Location = new Point(246, 228);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new Size(54, 17);
            importeLabel.TabIndex = 40;
            importeLabel.Text = "Importe";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreLabel.Location = new Point(246, 142);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(57, 17);
            nombreLabel.TabIndex = 39;
            nombreLabel.Text = "Nombre";
            // 
            // importeTextBox
            // 
            importeTextBox.BorderStyle = BorderStyle.FixedSingle;
            importeTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importeTextBox.Location = new Point(248, 248);
            importeTextBox.Name = "importeTextBox";
            importeTextBox.Size = new Size(281, 33);
            importeTextBox.TabIndex = 38;
            importeTextBox.KeyPress += importeTextBox_KeyPress;
            // 
            // nombreTextBox
            // 
            nombreTextBox.BorderStyle = BorderStyle.FixedSingle;
            nombreTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreTextBox.Location = new Point(248, 162);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(281, 33);
            nombreTextBox.TabIndex = 37;
            // 
            // modificarLabel
            // 
            modificarLabel.AutoSize = true;
            modificarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            modificarLabel.Location = new Point(303, 39);
            modificarLabel.Name = "modificarLabel";
            modificarLabel.Size = new Size(178, 32);
            modificarLabel.TabIndex = 36;
            modificarLabel.Text = "Modificar tipo";
            modificarLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // plantillaCombo
            // 
            plantillaCombo.FormattingEnabled = true;
            plantillaCombo.Location = new Point(248, 329);
            plantillaCombo.Name = "plantillaCombo";
            plantillaCombo.Size = new Size(281, 23);
            plantillaCombo.TabIndex = 44;
            // 
            // plantillaLabel
            // 
            plantillaLabel.AutoSize = true;
            plantillaLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plantillaLabel.Location = new Point(244, 310);
            plantillaLabel.Name = "plantillaLabel";
            plantillaLabel.Size = new Size(52, 17);
            plantillaLabel.TabIndex = 43;
            plantillaLabel.Text = "Plantilla";
            // 
            // ModificarTipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(801, 478);
            Controls.Add(plantillaCombo);
            Controls.Add(plantillaLabel);
            Controls.Add(cancelarBtn);
            Controls.Add(modificarBtn);
            Controls.Add(importeLabel);
            Controls.Add(nombreLabel);
            Controls.Add(importeTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(modificarLabel);
            Name = "ModificarTipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Tipo";
            Load += ModificarTipo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelarBtn;
        private Button modificarBtn;
        private Label importeLabel;
        private Label nombreLabel;
        private TextBox importeTextBox;
        private TextBox nombreTextBox;
        private Label modificarLabel;
        private ComboBox plantillaCombo;
        private Label plantillaLabel;
    }
}