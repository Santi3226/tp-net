namespace WinForms
{
    partial class AceptarTurno
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
            aceptarLabel = new Label();
            recetaTextBox = new TextBox();
            observacionesTextBox = new TextBox();
            recetaLabel = new Label();
            observacionesLabel = new Label();
            aceptarBtn = new Button();
            cancelarBtn = new Button();
            SuspendLayout();
            // 
            // aceptarLabel
            // 
            aceptarLabel.AutoSize = true;
            aceptarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            aceptarLabel.Location = new Point(288, 29);
            aceptarLabel.Name = "aceptarLabel";
            aceptarLabel.Size = new Size(174, 32);
            aceptarLabel.TabIndex = 25;
            aceptarLabel.Text = "Aceptar turno";
            // 
            // recetaTextBox
            // 
            recetaTextBox.BorderStyle = BorderStyle.FixedSingle;
            recetaTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recetaTextBox.Location = new Point(227, 126);
            recetaTextBox.Name = "recetaTextBox";
            recetaTextBox.Size = new Size(281, 33);
            recetaTextBox.TabIndex = 26;
            // 
            // observacionesTextBox
            // 
            observacionesTextBox.BorderStyle = BorderStyle.FixedSingle;
            observacionesTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            observacionesTextBox.Location = new Point(226, 250);
            observacionesTextBox.Name = "observacionesTextBox";
            observacionesTextBox.Size = new Size(281, 33);
            observacionesTextBox.TabIndex = 27;
            // 
            // recetaLabel
            // 
            recetaLabel.AutoSize = true;
            recetaLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            recetaLabel.Location = new Point(225, 106);
            recetaLabel.Name = "recetaLabel";
            recetaLabel.Size = new Size(50, 17);
            recetaLabel.TabIndex = 28;
            recetaLabel.Text = "Receta:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            observacionesLabel.Location = new Point(224, 230);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new Size(97, 17);
            observacionesLabel.TabIndex = 29;
            observacionesLabel.Text = "Observaciones:";
            // 
            // aceptarBtn
            // 
            aceptarBtn.BackColor = Color.SteelBlue;
            aceptarBtn.Cursor = Cursors.Hand;
            aceptarBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            aceptarBtn.FlatAppearance.BorderSize = 0;
            aceptarBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            aceptarBtn.FlatStyle = FlatStyle.Flat;
            aceptarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aceptarBtn.ForeColor = Color.White;
            aceptarBtn.Location = new Point(188, 404);
            aceptarBtn.Name = "aceptarBtn";
            aceptarBtn.Size = new Size(173, 33);
            aceptarBtn.TabIndex = 30;
            aceptarBtn.Text = "Aceptar";
            aceptarBtn.UseVisualStyleBackColor = false;
            aceptarBtn.Click += aceptarBtn_Click;
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
            cancelarBtn.Location = new Point(397, 404);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(171, 33);
            cancelarBtn.TabIndex = 31;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = false;
            cancelarBtn.Click += cancelarBtn_Click;
            // 
            // AceptarTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(801, 478);
            Controls.Add(cancelarBtn);
            Controls.Add(aceptarBtn);
            Controls.Add(observacionesLabel);
            Controls.Add(recetaLabel);
            Controls.Add(observacionesTextBox);
            Controls.Add(recetaTextBox);
            Controls.Add(aceptarLabel);
            Name = "AceptarTurno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Aceptar Turno";
            Load += AceptarTurno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label aceptarLabel;
        private TextBox recetaTextBox;
        private TextBox observacionesTextBox;
        private Label recetaLabel;
        private Label observacionesLabel;
        private Button aceptarBtn;
        private Button cancelarBtn;
    }
}