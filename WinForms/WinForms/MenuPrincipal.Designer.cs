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
            borrarPacienteBtn = new Button();
            modificarPacienteBtn = new Button();
            agregarCaBtn = new Button();
            borrarCaBtn = new Button();
            modificarCaBtn = new Button();
            agregarPacienteBtn = new Button();
            mostrarCaBtn = new Button();
            mostrarPacienteBtn = new Button();
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
            // borrarPacienteBtn
            // 
            borrarPacienteBtn.BackColor = Color.SteelBlue;
            borrarPacienteBtn.Cursor = Cursors.Hand;
            borrarPacienteBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            borrarPacienteBtn.FlatAppearance.BorderSize = 0;
            borrarPacienteBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            borrarPacienteBtn.FlatStyle = FlatStyle.Flat;
            borrarPacienteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrarPacienteBtn.ForeColor = SystemColors.ControlLightLight;
            borrarPacienteBtn.Location = new Point(455, 170);
            borrarPacienteBtn.Margin = new Padding(3, 2, 3, 2);
            borrarPacienteBtn.Name = "borrarPacienteBtn";
            borrarPacienteBtn.Size = new Size(133, 32);
            borrarPacienteBtn.TabIndex = 10;
            borrarPacienteBtn.Text = "Borrar Paciente";
            borrarPacienteBtn.UseVisualStyleBackColor = false;
            borrarPacienteBtn.Click += borrarPacienteBtn_Click;
            // 
            // modificarPacienteBtn
            // 
            modificarPacienteBtn.BackColor = Color.SteelBlue;
            modificarPacienteBtn.Cursor = Cursors.Hand;
            modificarPacienteBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            modificarPacienteBtn.FlatAppearance.BorderSize = 0;
            modificarPacienteBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            modificarPacienteBtn.FlatStyle = FlatStyle.Flat;
            modificarPacienteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modificarPacienteBtn.ForeColor = SystemColors.ControlLightLight;
            modificarPacienteBtn.Location = new Point(455, 228);
            modificarPacienteBtn.Margin = new Padding(3, 2, 3, 2);
            modificarPacienteBtn.Name = "modificarPacienteBtn";
            modificarPacienteBtn.Size = new Size(133, 32);
            modificarPacienteBtn.TabIndex = 11;
            modificarPacienteBtn.Text = "Modificar Paciente";
            modificarPacienteBtn.UseVisualStyleBackColor = false;
            modificarPacienteBtn.Click += modificarPacienteBtn_Click;
            // 
            // agregarCaBtn
            // 
            agregarCaBtn.BackColor = Color.SteelBlue;
            agregarCaBtn.Cursor = Cursors.Hand;
            agregarCaBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            agregarCaBtn.FlatAppearance.BorderSize = 0;
            agregarCaBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            agregarCaBtn.FlatStyle = FlatStyle.Flat;
            agregarCaBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarCaBtn.ForeColor = SystemColors.ControlLightLight;
            agregarCaBtn.Location = new Point(100, 114);
            agregarCaBtn.Margin = new Padding(3, 2, 3, 2);
            agregarCaBtn.Name = "agregarCaBtn";
            agregarCaBtn.Size = new Size(133, 32);
            agregarCaBtn.TabIndex = 12;
            agregarCaBtn.Text = "Agregar CA";
            agregarCaBtn.UseVisualStyleBackColor = false;
            agregarCaBtn.Click += agregarCaBtn_Click;
            // 
            // borrarCaBtn
            // 
            borrarCaBtn.BackColor = Color.SteelBlue;
            borrarCaBtn.Cursor = Cursors.Hand;
            borrarCaBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            borrarCaBtn.FlatAppearance.BorderSize = 0;
            borrarCaBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            borrarCaBtn.FlatStyle = FlatStyle.Flat;
            borrarCaBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrarCaBtn.ForeColor = SystemColors.ControlLightLight;
            borrarCaBtn.Location = new Point(100, 170);
            borrarCaBtn.Margin = new Padding(3, 2, 3, 2);
            borrarCaBtn.Name = "borrarCaBtn";
            borrarCaBtn.Size = new Size(133, 32);
            borrarCaBtn.TabIndex = 13;
            borrarCaBtn.Text = "Borrar CA";
            borrarCaBtn.UseVisualStyleBackColor = false;
            borrarCaBtn.Click += borrarCaBtn_Click;
            // 
            // modificarCaBtn
            // 
            modificarCaBtn.BackColor = Color.SteelBlue;
            modificarCaBtn.Cursor = Cursors.Hand;
            modificarCaBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            modificarCaBtn.FlatAppearance.BorderSize = 0;
            modificarCaBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            modificarCaBtn.FlatStyle = FlatStyle.Flat;
            modificarCaBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            modificarCaBtn.ForeColor = SystemColors.ControlLightLight;
            modificarCaBtn.Location = new Point(100, 228);
            modificarCaBtn.Margin = new Padding(3, 2, 3, 2);
            modificarCaBtn.Name = "modificarCaBtn";
            modificarCaBtn.Size = new Size(133, 32);
            modificarCaBtn.TabIndex = 14;
            modificarCaBtn.Text = "Modificar CA";
            modificarCaBtn.UseVisualStyleBackColor = false;
            modificarCaBtn.Click += modificarCaBtn_Click;
            // 
            // agregarPacienteBtn
            // 
            agregarPacienteBtn.BackColor = Color.SteelBlue;
            agregarPacienteBtn.Cursor = Cursors.Hand;
            agregarPacienteBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            agregarPacienteBtn.FlatAppearance.BorderSize = 0;
            agregarPacienteBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            agregarPacienteBtn.FlatStyle = FlatStyle.Flat;
            agregarPacienteBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarPacienteBtn.ForeColor = SystemColors.ControlLightLight;
            agregarPacienteBtn.Location = new Point(455, 114);
            agregarPacienteBtn.Margin = new Padding(3, 2, 3, 2);
            agregarPacienteBtn.Name = "agregarPacienteBtn";
            agregarPacienteBtn.Size = new Size(133, 32);
            agregarPacienteBtn.TabIndex = 15;
            agregarPacienteBtn.Text = "Agregar Paciente";
            agregarPacienteBtn.UseVisualStyleBackColor = false;
            agregarPacienteBtn.Click += agregarPacienteBtn_Click;
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
            mostrarCaBtn.Location = new Point(100, 281);
            mostrarCaBtn.Margin = new Padding(3, 2, 3, 2);
            mostrarCaBtn.Name = "mostrarCaBtn";
            mostrarCaBtn.Size = new Size(133, 32);
            mostrarCaBtn.TabIndex = 16;
            mostrarCaBtn.Text = "Mostrar CA";
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
            mostrarPacienteBtn.Location = new Point(455, 281);
            mostrarPacienteBtn.Margin = new Padding(3, 2, 3, 2);
            mostrarPacienteBtn.Name = "mostrarPacienteBtn";
            mostrarPacienteBtn.Size = new Size(133, 32);
            mostrarPacienteBtn.TabIndex = 17;
            mostrarPacienteBtn.Text = "Mostrar Paciente";
            mostrarPacienteBtn.UseVisualStyleBackColor = false;
            mostrarPacienteBtn.Click += mostrarPacienteBtn_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(700, 338);
            Controls.Add(mostrarPacienteBtn);
            Controls.Add(mostrarCaBtn);
            Controls.Add(agregarPacienteBtn);
            Controls.Add(modificarCaBtn);
            Controls.Add(borrarCaBtn);
            Controls.Add(agregarCaBtn);
            Controls.Add(modificarPacienteBtn);
            Controls.Add(borrarPacienteBtn);
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
        private Button borrarPacienteBtn;
        private Button modificarPacienteBtn;
        private Button agregarCaBtn;
        private Button borrarCaBtn;
        private Button modificarCaBtn;
        private Button agregarPacienteBtn;
        private Button mostrarCaBtn;
        private Button mostrarPacienteBtn;
    }
}