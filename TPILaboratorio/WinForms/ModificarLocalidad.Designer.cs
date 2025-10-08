namespace WinForms
{
    partial class ModificarLocalidad
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
            codigoPostalLabel = new Label();
            nombreLabel = new Label();
            codigoPostalTextBox = new TextBox();
            nombreTextBox = new TextBox();
            modificarLabel = new Label();
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
            cancelarBtn.Location = new Point(422, 406);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(171, 33);
            cancelarBtn.TabIndex = 49;
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
            modificarBtn.Location = new Point(208, 406);
            modificarBtn.Name = "modificarBtn";
            modificarBtn.Size = new Size(173, 33);
            modificarBtn.TabIndex = 48;
            modificarBtn.Text = "Modificar";
            modificarBtn.UseVisualStyleBackColor = false;
            modificarBtn.Click += modificarBtn_Click;
            // 
            // codigoPostalLabel
            // 
            codigoPostalLabel.AutoSize = true;
            codigoPostalLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            codigoPostalLabel.Location = new Point(259, 266);
            codigoPostalLabel.Name = "codigoPostalLabel";
            codigoPostalLabel.Size = new Size(91, 17);
            codigoPostalLabel.TabIndex = 47;
            codigoPostalLabel.Text = "Código postal";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreLabel.Location = new Point(259, 143);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(57, 17);
            nombreLabel.TabIndex = 46;
            nombreLabel.Text = "Nombre";
            // 
            // codigoPostalTextBox
            // 
            codigoPostalTextBox.BorderStyle = BorderStyle.FixedSingle;
            codigoPostalTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            codigoPostalTextBox.Location = new Point(261, 286);
            codigoPostalTextBox.Name = "codigoPostalTextBox";
            codigoPostalTextBox.Size = new Size(281, 33);
            codigoPostalTextBox.TabIndex = 45;
            // 
            // nombreTextBox
            // 
            nombreTextBox.BorderStyle = BorderStyle.FixedSingle;
            nombreTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreTextBox.Location = new Point(261, 163);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(281, 33);
            nombreTextBox.TabIndex = 44;
            // 
            // modificarLabel
            // 
            modificarLabel.AutoSize = true;
            modificarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            modificarLabel.Location = new Point(282, 44);
            modificarLabel.Name = "modificarLabel";
            modificarLabel.Size = new Size(236, 32);
            modificarLabel.TabIndex = 43;
            modificarLabel.Text = "Modificar localidad";
            modificarLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ModificarLocalidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(801, 478);
            Controls.Add(cancelarBtn);
            Controls.Add(modificarBtn);
            Controls.Add(codigoPostalLabel);
            Controls.Add(nombreLabel);
            Controls.Add(codigoPostalTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(modificarLabel);
            Name = "ModificarLocalidad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Localidad";
            Load += ModificarLocalidad_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelarBtn;
        private Button modificarBtn;
        private Label codigoPostalLabel;
        private Label nombreLabel;
        private TextBox codigoPostalTextBox;
        private TextBox nombreTextBox;
        private Label modificarLabel;
    }
}