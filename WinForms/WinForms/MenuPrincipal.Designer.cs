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
            menuCentrosBtn = new Button();
            menuPacienteBtn = new Button();
            SuspendLayout();
            // 
            // bienvenidoLabel
            // 
            bienvenidoLabel.AutoSize = true;
            bienvenidoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bienvenidoLabel.Location = new Point(61, 30);
            bienvenidoLabel.Name = "bienvenidoLabel";
            bienvenidoLabel.Size = new Size(557, 32);
            bienvenidoLabel.TabIndex = 3;
            bienvenidoLabel.Text = "Bienvenido al Sistema de Laboratorio Generico!";
            bienvenidoLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // menuCentrosBtn
            // 
            menuCentrosBtn.BackColor = Color.SteelBlue;
            menuCentrosBtn.Cursor = Cursors.Hand;
            menuCentrosBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            menuCentrosBtn.FlatAppearance.BorderSize = 0;
            menuCentrosBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            menuCentrosBtn.FlatStyle = FlatStyle.Flat;
            menuCentrosBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuCentrosBtn.ForeColor = SystemColors.ControlLightLight;
            menuCentrosBtn.Location = new Point(138, 112);
            menuCentrosBtn.Margin = new Padding(3, 2, 3, 2);
            menuCentrosBtn.Name = "menuCentrosBtn";
            menuCentrosBtn.Size = new Size(133, 32);
            menuCentrosBtn.TabIndex = 16;
            menuCentrosBtn.Text = "Menu Centros";
            menuCentrosBtn.UseVisualStyleBackColor = false;
            menuCentrosBtn.Click += menuCentrosBtn_Click;
            // 
            // menuPacienteBtn
            // 
            menuPacienteBtn.BackColor = Color.SteelBlue;
            menuPacienteBtn.Cursor = Cursors.Hand;
            menuPacienteBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            menuPacienteBtn.FlatAppearance.BorderSize = 0;
            menuPacienteBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            menuPacienteBtn.FlatStyle = FlatStyle.Flat;
            menuPacienteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuPacienteBtn.ForeColor = SystemColors.ControlLightLight;
            menuPacienteBtn.Location = new Point(435, 112);
            menuPacienteBtn.Margin = new Padding(3, 2, 3, 2);
            menuPacienteBtn.Name = "menuPacienteBtn";
            menuPacienteBtn.Size = new Size(133, 32);
            menuPacienteBtn.TabIndex = 17;
            menuPacienteBtn.Text = "Menu Paciente";
            menuPacienteBtn.UseVisualStyleBackColor = false;
            menuPacienteBtn.Click += menuPacienteBtn_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(724, 175);
            Controls.Add(menuPacienteBtn);
            Controls.Add(menuCentrosBtn);
            Controls.Add(bienvenidoLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bienvenidoLabel;
        private Button menuCentrosBtn;
        private Button menuPacienteBtn;
    }
}