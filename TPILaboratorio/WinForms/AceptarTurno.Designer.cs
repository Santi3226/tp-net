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
            observacionesTextBox = new TextBox();
            observacionesLabel = new Label();
            aceptarBtn = new Button();
            cancelarBtn = new Button();
            SuspendLayout();
            // 
            // aceptarLabel
            // 
            aceptarLabel.AutoSize = true;
            aceptarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            aceptarLabel.Location = new Point(329, 39);
            aceptarLabel.Name = "aceptarLabel";
            aceptarLabel.Size = new Size(214, 41);
            aceptarLabel.TabIndex = 25;
            aceptarLabel.Text = "Aceptar turno";
            // 
            // observacionesTextBox
            // 
            observacionesTextBox.BorderStyle = BorderStyle.FixedSingle;
            observacionesTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            observacionesTextBox.Location = new Point(272, 187);
            observacionesTextBox.Margin = new Padding(3, 4, 3, 4);
            observacionesTextBox.Name = "observacionesTextBox";
            observacionesTextBox.Size = new Size(321, 39);
            observacionesTextBox.TabIndex = 27;
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            observacionesLabel.Location = new Point(270, 161);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new Size(124, 23);
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
            aceptarBtn.Location = new Point(220, 297);
            aceptarBtn.Margin = new Padding(3, 4, 3, 4);
            aceptarBtn.Name = "aceptarBtn";
            aceptarBtn.Size = new Size(198, 44);
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
            cancelarBtn.Location = new Point(459, 297);
            cancelarBtn.Margin = new Padding(3, 4, 3, 4);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(195, 44);
            cancelarBtn.TabIndex = 31;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = false;
            cancelarBtn.Click += cancelarBtn_Click;
            // 
            // AceptarTurno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(875, 411);
            Controls.Add(cancelarBtn);
            Controls.Add(aceptarBtn);
            Controls.Add(observacionesLabel);
            Controls.Add(observacionesTextBox);
            Controls.Add(aceptarLabel);
            Margin = new Padding(3, 4, 3, 4);
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