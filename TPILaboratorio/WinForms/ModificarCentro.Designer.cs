namespace WinForms
{
    partial class ModificarCentro
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
            modificarLabel = new Label();
            direccionLabel = new Label();
            nombreLabel = new Label();
            direccionTextBox = new TextBox();
            nombreTextBox = new TextBox();
            cancelarBtn = new Button();
            modificarBtn = new Button();
            SuspendLayout();
            // 
            // modificarLabel
            // 
            modificarLabel.AutoSize = true;
            modificarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            modificarLabel.Location = new Point(299, 29);
            modificarLabel.Name = "modificarLabel";
            modificarLabel.Size = new Size(206, 32);
            modificarLabel.TabIndex = 26;
            modificarLabel.Text = "Modificar centro";
            modificarLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            direccionLabel.Location = new Point(259, 254);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new Size(62, 17);
            direccionLabel.TabIndex = 33;
            direccionLabel.Text = "Dirección";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreLabel.Location = new Point(259, 131);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(57, 17);
            nombreLabel.TabIndex = 32;
            nombreLabel.Text = "Nombre";
            // 
            // direccionTextBox
            // 
            direccionTextBox.BorderStyle = BorderStyle.FixedSingle;
            direccionTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            direccionTextBox.Location = new Point(261, 274);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(281, 33);
            direccionTextBox.TabIndex = 31;
            // 
            // nombreTextBox
            // 
            nombreTextBox.BorderStyle = BorderStyle.FixedSingle;
            nombreTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreTextBox.Location = new Point(261, 151);
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
            cancelarBtn.Location = new Point(418, 396);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(171, 33);
            cancelarBtn.TabIndex = 35;
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
            modificarBtn.Location = new Point(204, 396);
            modificarBtn.Name = "modificarBtn";
            modificarBtn.Size = new Size(173, 33);
            modificarBtn.TabIndex = 34;
            modificarBtn.Text = "Modificar";
            modificarBtn.UseVisualStyleBackColor = false;
            // 
            // ModificarCentro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(801, 478);
            Controls.Add(cancelarBtn);
            Controls.Add(modificarBtn);
            Controls.Add(direccionLabel);
            Controls.Add(nombreLabel);
            Controls.Add(direccionTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(modificarLabel);
            Name = "ModificarCentro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ModificarCentro";
            Load += ModificarCentro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label modificarLabel;
        private Label direccionLabel;
        private Label nombreLabel;
        private TextBox direccionTextBox;
        private TextBox nombreTextBox;
        private Button cancelarBtn;
        private Button modificarBtn;
    }
}