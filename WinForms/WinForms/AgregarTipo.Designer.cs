namespace WinForms
{
    partial class AgregarTipo
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
            importeLabel = new Label();
            nombreLabel = new Label();
            importeTextBox = new TextBox();
            nombreTextBox = new TextBox();
            cancelarBtn = new Button();
            agregarBtn = new Button();
            SuspendLayout();
            // 
            // agregarLabel
            // 
            agregarLabel.AutoSize = true;
            agregarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            agregarLabel.Location = new Point(306, 29);
            agregarLabel.Name = "agregarLabel";
            agregarLabel.Size = new Size(160, 32);
            agregarLabel.TabIndex = 26;
            agregarLabel.Text = "Agregar tipo";
            agregarLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importeLabel.Location = new Point(244, 227);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new Size(54, 17);
            importeLabel.TabIndex = 33;
            importeLabel.Text = "Importe";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreLabel.Location = new Point(244, 141);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(57, 17);
            nombreLabel.TabIndex = 32;
            nombreLabel.Text = "Nombre";
            // 
            // importeTextBox
            // 
            importeTextBox.BorderStyle = BorderStyle.FixedSingle;
            importeTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importeTextBox.Location = new Point(246, 247);
            importeTextBox.Name = "importeTextBox";
            importeTextBox.Size = new Size(281, 33);
            importeTextBox.TabIndex = 31;
            importeTextBox.KeyPress += importeTextBox_KeyPress;
            // 
            // nombreTextBox
            // 
            nombreTextBox.BorderStyle = BorderStyle.FixedSingle;
            nombreTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreTextBox.Location = new Point(246, 161);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(281, 33);
            nombreTextBox.TabIndex = 30;
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
            cancelarBtn.Location = new Point(413, 387);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(171, 33);
            cancelarBtn.TabIndex = 35;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = false;
            cancelarBtn.Click += cancelarBtn_Click;
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
            agregarBtn.Location = new Point(199, 387);
            agregarBtn.Name = "agregarBtn";
            agregarBtn.Size = new Size(173, 33);
            agregarBtn.TabIndex = 34;
            agregarBtn.Text = "Agregar";
            agregarBtn.UseVisualStyleBackColor = false;
            agregarBtn.Click += agregarBtn_Click;
            // 
            // AgregarTipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(801, 478);
            Controls.Add(cancelarBtn);
            Controls.Add(agregarBtn);
            Controls.Add(importeLabel);
            Controls.Add(nombreLabel);
            Controls.Add(importeTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(agregarLabel);
            Name = "AgregarTipo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Tipo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label agregarLabel;
        private Label importeLabel;
        private Label nombreLabel;
        private TextBox importeTextBox;
        private TextBox nombreTextBox;
        private Button cancelarBtn;
        private Button agregarBtn;
    }
}