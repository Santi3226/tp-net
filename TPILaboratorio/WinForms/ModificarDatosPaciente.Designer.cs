namespace WinForms
{
    partial class ModificarDatosPaciente
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
            nombreTextBox = new TextBox();
            apellidoTextBox = new TextBox();
            telefonoTextBox = new TextBox();
            direccionTextBox = new TextBox();
            mailTextBox = new TextBox();
            confirmarBtn = new Button();
            cancelarBtn = new Button();
            nombreLabel = new Label();
            apellidoLabel = new Label();
            telefonoLabel = new Label();
            direccionLabel = new Label();
            mailLabel = new Label();
            SuspendLayout();
            // 
            // modificarLabel
            // 
            modificarLabel.AutoSize = true;
            modificarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            modificarLabel.Location = new Point(301, 29);
            modificarLabel.Name = "modificarLabel";
            modificarLabel.Size = new Size(195, 32);
            modificarLabel.TabIndex = 25;
            modificarLabel.Text = "Modificar datos";
            modificarLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // nombreTextBox
            // 
            nombreTextBox.BorderStyle = BorderStyle.FixedSingle;
            nombreTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreTextBox.Location = new Point(246, 98);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(281, 33);
            nombreTextBox.TabIndex = 26;
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.BorderStyle = BorderStyle.FixedSingle;
            apellidoTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            apellidoTextBox.Location = new Point(246, 158);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(281, 33);
            apellidoTextBox.TabIndex = 27;
            // 
            // telefonoTextBox
            // 
            telefonoTextBox.BorderStyle = BorderStyle.FixedSingle;
            telefonoTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telefonoTextBox.Location = new Point(246, 217);
            telefonoTextBox.Name = "telefonoTextBox";
            telefonoTextBox.Size = new Size(281, 33);
            telefonoTextBox.TabIndex = 28;
            // 
            // direccionTextBox
            // 
            direccionTextBox.BorderStyle = BorderStyle.FixedSingle;
            direccionTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            direccionTextBox.Location = new Point(246, 278);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(281, 33);
            direccionTextBox.TabIndex = 29;
            // 
            // mailTextBox
            // 
            mailTextBox.BorderStyle = BorderStyle.FixedSingle;
            mailTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mailTextBox.Location = new Point(246, 342);
            mailTextBox.Name = "mailTextBox";
            mailTextBox.Size = new Size(281, 33);
            mailTextBox.TabIndex = 30;
            // 
            // confirmarBtn
            // 
            confirmarBtn.BackColor = Color.SteelBlue;
            confirmarBtn.Cursor = Cursors.Hand;
            confirmarBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            confirmarBtn.FlatAppearance.BorderSize = 0;
            confirmarBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            confirmarBtn.FlatStyle = FlatStyle.Flat;
            confirmarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmarBtn.ForeColor = Color.White;
            confirmarBtn.Location = new Point(198, 417);
            confirmarBtn.Name = "confirmarBtn";
            confirmarBtn.Size = new Size(173, 33);
            confirmarBtn.TabIndex = 31;
            confirmarBtn.Text = "Confirmar";
            confirmarBtn.UseVisualStyleBackColor = false;
            confirmarBtn.Click += confirmarBtn_Click;
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
            cancelarBtn.Location = new Point(402, 417);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(171, 33);
            cancelarBtn.TabIndex = 32;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = false;
            cancelarBtn.Click += cancelarBtn_Click;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreLabel.Location = new Point(244, 78);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(57, 17);
            nombreLabel.TabIndex = 33;
            nombreLabel.Text = "Nombre";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            apellidoLabel.Location = new Point(243, 138);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(56, 17);
            apellidoLabel.TabIndex = 34;
            apellidoLabel.Text = "Apellido";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telefonoLabel.Location = new Point(243, 198);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new Size(58, 17);
            telefonoLabel.TabIndex = 35;
            telefonoLabel.Text = "Teléfono";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            direccionLabel.Location = new Point(243, 258);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new Size(62, 17);
            direccionLabel.TabIndex = 36;
            direccionLabel.Text = "Dirección";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mailLabel.Location = new Point(243, 322);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new Size(33, 17);
            mailLabel.TabIndex = 37;
            mailLabel.Text = "Mail";
            // 
            // ModificarDatosPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(801, 478);
            Controls.Add(mailLabel);
            Controls.Add(direccionLabel);
            Controls.Add(telefonoLabel);
            Controls.Add(apellidoLabel);
            Controls.Add(nombreLabel);
            Controls.Add(cancelarBtn);
            Controls.Add(confirmarBtn);
            Controls.Add(mailTextBox);
            Controls.Add(direccionTextBox);
            Controls.Add(telefonoTextBox);
            Controls.Add(apellidoTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(modificarLabel);
            Name = "ModificarDatosPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar datos";
            Load += ModificarDatosPaciente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label modificarLabel;
        private TextBox nombreTextBox;
        private TextBox apellidoTextBox;
        private TextBox telefonoTextBox;
        private TextBox direccionTextBox;
        private TextBox mailTextBox;
        private Button confirmarBtn;
        private Button cancelarBtn;
        private Label nombreLabel;
        private Label apellidoLabel;
        private Label telefonoLabel;
        private Label direccionLabel;
        private Label mailLabel;
    }
}