namespace WinForms
{
    partial class MenuPrincipal
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
            bienvenidoLabel = new Label();
            mostrarCaBtn = new Button();
            mostrarPacienteBtn = new Button();
            SuspendLayout();
            // 
            // bienvenidoLabel
            // 
            bienvenidoLabel.AutoSize = true;
            bienvenidoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bienvenidoLabel.Location = new Point(70, 40);
            bienvenidoLabel.Name = "bienvenidoLabel";
            bienvenidoLabel.Size = new Size(685, 41);
            bienvenidoLabel.TabIndex = 3;
            bienvenidoLabel.Text = "Bienvenido al Sistema de Laboratorio Generico!";
            bienvenidoLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // mostrarCaBtn
            // 
            mostrarCaBtn.BackColor = Color.SteelBlue;
            mostrarCaBtn.Cursor = Cursors.Hand;
            mostrarCaBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            mostrarCaBtn.FlatAppearance.BorderSize = 0;
            mostrarCaBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            mostrarCaBtn.FlatStyle = FlatStyle.Flat;
            mostrarCaBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mostrarCaBtn.ForeColor = SystemColors.ControlLightLight;
            mostrarCaBtn.Location = new Point(158, 149);
            mostrarCaBtn.Name = "mostrarCaBtn";
            mostrarCaBtn.Size = new Size(152, 43);
            mostrarCaBtn.TabIndex = 16;
            mostrarCaBtn.Text = "Menu Centros";
            mostrarCaBtn.UseVisualStyleBackColor = false;
            mostrarCaBtn.Click += mostrarCaBtn_Click;
            // 
            // mostrarPacienteBtn
            // 
            mostrarPacienteBtn.BackColor = Color.SteelBlue;
            mostrarPacienteBtn.Cursor = Cursors.Hand;
            mostrarPacienteBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            mostrarPacienteBtn.FlatAppearance.BorderSize = 0;
            mostrarPacienteBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            mostrarPacienteBtn.FlatStyle = FlatStyle.Flat;
            mostrarPacienteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mostrarPacienteBtn.ForeColor = SystemColors.ControlLightLight;
            mostrarPacienteBtn.Location = new Point(497, 149);
            mostrarPacienteBtn.Name = "mostrarPacienteBtn";
            mostrarPacienteBtn.Size = new Size(152, 43);
            mostrarPacienteBtn.TabIndex = 17;
            mostrarPacienteBtn.Text = "Menu Paciente";
            mostrarPacienteBtn.UseVisualStyleBackColor = false;
            mostrarPacienteBtn.Click += mostrarPacienteBtn_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(827, 233);
            Controls.Add(mostrarPacienteBtn);
            Controls.Add(mostrarCaBtn);
            Controls.Add(bienvenidoLabel);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bienvenidoLabel;
        private Button mostrarCaBtn;
        private Button mostrarPacienteBtn;
    }
}