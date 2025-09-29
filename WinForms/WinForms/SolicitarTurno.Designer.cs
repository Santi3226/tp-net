namespace WinForms
{
    partial class SolicitarTurno
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
            solicitarLabel = new Label();
            fechaTurnoCalendario = new DateTimePicker();
            fechaTurnoLabel = new Label();
            label1 = new Label();
            mailCheckBox = new CheckBox();
            solicitarBtn = new Button();
            cancelarBtn = new Button();
            tipoAnalisisCombo = new ComboBox();
            SuspendLayout();
            // 
            // solicitarLabel
            // 
            solicitarLabel.AutoSize = true;
            solicitarLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            solicitarLabel.Location = new Point(293, 29);
            solicitarLabel.Name = "solicitarLabel";
            solicitarLabel.Size = new Size(178, 32);
            solicitarLabel.TabIndex = 25;
            solicitarLabel.Text = "Solicitar turno";
            solicitarLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // fechaTurnoCalendario
            // 
            fechaTurnoCalendario.Location = new Point(237, 117);
            fechaTurnoCalendario.Name = "fechaTurnoCalendario";
            fechaTurnoCalendario.Size = new Size(281, 23);
            fechaTurnoCalendario.TabIndex = 27;
            // 
            // fechaTurnoLabel
            // 
            fechaTurnoLabel.AutoSize = true;
            fechaTurnoLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fechaTurnoLabel.Location = new Point(235, 97);
            fechaTurnoLabel.Name = "fechaTurnoLabel";
            fechaTurnoLabel.Size = new Size(101, 17);
            fechaTurnoLabel.TabIndex = 28;
            fechaTurnoLabel.Text = "Fecha del turno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(233, 200);
            label1.Name = "label1";
            label1.Size = new Size(102, 17);
            label1.TabIndex = 30;
            label1.Text = "Tipo de análisis:";
            // 
            // mailCheckBox
            // 
            mailCheckBox.AutoSize = true;
            mailCheckBox.Location = new Point(309, 308);
            mailCheckBox.Name = "mailCheckBox";
            mailCheckBox.Size = new Size(124, 19);
            mailCheckBox.TabIndex = 31;
            mailCheckBox.Text = "Deséa recibir mail?";
            mailCheckBox.UseVisualStyleBackColor = true;
            // 
            // solicitarBtn
            // 
            solicitarBtn.BackColor = Color.SteelBlue;
            solicitarBtn.Cursor = Cursors.Hand;
            solicitarBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            solicitarBtn.FlatAppearance.BorderSize = 0;
            solicitarBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            solicitarBtn.FlatStyle = FlatStyle.Flat;
            solicitarBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            solicitarBtn.ForeColor = Color.White;
            solicitarBtn.Location = new Point(189, 387);
            solicitarBtn.Name = "solicitarBtn";
            solicitarBtn.Size = new Size(173, 33);
            solicitarBtn.TabIndex = 32;
            solicitarBtn.Text = "Solicitar";
            solicitarBtn.UseVisualStyleBackColor = false;
            solicitarBtn.Click += solicitarBtn_Click;
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
            cancelarBtn.Location = new Point(386, 387);
            cancelarBtn.Name = "cancelarBtn";
            cancelarBtn.Size = new Size(171, 33);
            cancelarBtn.TabIndex = 33;
            cancelarBtn.Text = "Cancelar";
            cancelarBtn.UseVisualStyleBackColor = false;
            cancelarBtn.Click += cancelarBtn_Click;
            // 
            // tipoAnalisisCombo
            // 
            tipoAnalisisCombo.FormattingEnabled = true;
            tipoAnalisisCombo.Location = new Point(237, 220);
            tipoAnalisisCombo.Name = "tipoAnalisisCombo";
            tipoAnalisisCombo.Size = new Size(281, 23);
            tipoAnalisisCombo.TabIndex = 34;
            // 
            // SolicitarTurno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(801, 478);
            Controls.Add(tipoAnalisisCombo);
            Controls.Add(cancelarBtn);
            Controls.Add(solicitarBtn);
            Controls.Add(mailCheckBox);
            Controls.Add(label1);
            Controls.Add(fechaTurnoLabel);
            Controls.Add(fechaTurnoCalendario);
            Controls.Add(solicitarLabel);
            Name = "SolicitarTurno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Solicitar turno";
            Load += SolicitarTurno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label solicitarLabel;
        private DateTimePicker fechaTurnoCalendario;
        private Label fechaTurnoLabel;
        private Label label1;
        private CheckBox mailCheckBox;
        private Button solicitarBtn;
        private Button cancelarBtn;
        private ComboBox tipoAnalisisCombo;
    }
}