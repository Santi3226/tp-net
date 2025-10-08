namespace WinForms
{
    partial class AgregarPlantilla
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
            agregarBtn = new Button();
            preparacionLabel = new Label();
            horasAyunoLabel = new Label();
            preparacionTextBox = new TextBox();
            horasAyunoTextBox = new TextBox();
            agregarLabel = new Label();
            diasPrevistosLabel = new Label();
            diasPrevistosTextBox = new TextBox();
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
            cancelarBtn.Location = new Point(422, 402);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(171, 33);
            cancelarBtn.TabIndex = 42;
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
            agregarBtn.Location = new Point(208, 402);
            agregarBtn.Name = "agregarBtn";
            agregarBtn.Size = new Size(173, 33);
            agregarBtn.TabIndex = 41;
            agregarBtn.Text = "Agregar";
            agregarBtn.UseVisualStyleBackColor = false;
            agregarBtn.Click += agregarBtn_Click;
            // 
            // preparacionLabel
            // 
            preparacionLabel.AutoSize = true;
            preparacionLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            preparacionLabel.Location = new Point(251, 205);
            preparacionLabel.Name = "preparacionLabel";
            preparacionLabel.Size = new Size(78, 17);
            preparacionLabel.TabIndex = 40;
            preparacionLabel.Text = "Preparación";
            // 
            // horasAyunoLabel
            // 
            horasAyunoLabel.AutoSize = true;
            horasAyunoLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            horasAyunoLabel.Location = new Point(251, 119);
            horasAyunoLabel.Name = "horasAyunoLabel";
            horasAyunoLabel.Size = new Size(101, 17);
            horasAyunoLabel.TabIndex = 39;
            horasAyunoLabel.Text = "Horas de ayuno";
            // 
            // preparacionTextBox
            // 
            preparacionTextBox.BorderStyle = BorderStyle.FixedSingle;
            preparacionTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            preparacionTextBox.Location = new Point(253, 225);
            preparacionTextBox.Name = "preparacionTextBox";
            preparacionTextBox.Size = new Size(281, 33);
            preparacionTextBox.TabIndex = 38;
            // 
            // horasAyunoTextBox
            // 
            horasAyunoTextBox.BorderStyle = BorderStyle.FixedSingle;
            horasAyunoTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            horasAyunoTextBox.Location = new Point(253, 139);
            horasAyunoTextBox.Name = "horasAyunoTextBox";
            horasAyunoTextBox.Size = new Size(281, 33);
            horasAyunoTextBox.TabIndex = 37;
            // 
            // agregarLabel
            // 
            agregarLabel.AutoSize = true;
            agregarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            agregarLabel.Location = new Point(290, 46);
            agregarLabel.Name = "agregarLabel";
            agregarLabel.Size = new Size(207, 32);
            agregarLabel.TabIndex = 36;
            agregarLabel.Text = "Agregar plantilla";
            agregarLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // diasPrevistosLabel
            // 
            diasPrevistosLabel.AutoSize = true;
            diasPrevistosLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diasPrevistosLabel.Location = new Point(251, 293);
            diasPrevistosLabel.Name = "diasPrevistosLabel";
            diasPrevistosLabel.Size = new Size(90, 17);
            diasPrevistosLabel.TabIndex = 44;
            diasPrevistosLabel.Text = "Días previstos";
            // 
            // diasPrevistosTextBox
            // 
            diasPrevistosTextBox.BorderStyle = BorderStyle.FixedSingle;
            diasPrevistosTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            diasPrevistosTextBox.Location = new Point(253, 313);
            diasPrevistosTextBox.Name = "diasPrevistosTextBox";
            diasPrevistosTextBox.Size = new Size(281, 33);
            diasPrevistosTextBox.TabIndex = 43;
            diasPrevistosTextBox.KeyPress += diasPrevistosTextBox_KeyPress;
            // 
            // AgregarPlantilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(801, 478);
            Controls.Add(diasPrevistosLabel);
            Controls.Add(diasPrevistosTextBox);
            Controls.Add(cancelarBtn);
            Controls.Add(agregarBtn);
            Controls.Add(preparacionLabel);
            Controls.Add(horasAyunoLabel);
            Controls.Add(preparacionTextBox);
            Controls.Add(horasAyunoTextBox);
            Controls.Add(agregarLabel);
            Name = "AgregarPlantilla";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Plantilla";
            Load += AgregarPlantilla_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelarBtn;
        private Button agregarBtn;
        private Label preparacionLabel;
        private Label horasAyunoLabel;
        private TextBox preparacionTextBox;
        private TextBox horasAyunoTextBox;
        private Label agregarLabel;
        private Label diasPrevistosLabel;
        private TextBox diasPrevistosTextBox;
    }
}