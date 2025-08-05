namespace WinForms
{
    partial class MostrarPaciente
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
            mostrarPacientesLabel = new Label();
            comboId = new ComboBox();
            dataGridViewPac = new DataGridView();
            modificarPacienteBtn = new Button();
            borrarBtn = new Button();
            mostrarTodosBtn = new Button();
            mostrarUnoBtn = new Button();
            agregarPacienteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPac).BeginInit();
            SuspendLayout();
            // 
            // mostrarPacientesLabel
            // 
            mostrarPacientesLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mostrarPacientesLabel.AutoSize = true;
            mostrarPacientesLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            mostrarPacientesLabel.Location = new Point(321, 22);
            mostrarPacientesLabel.Name = "mostrarPacientesLabel";
            mostrarPacientesLabel.Size = new Size(219, 32);
            mostrarPacientesLabel.TabIndex = 44;
            mostrarPacientesLabel.Text = "Mostrar Pacientes";
            mostrarPacientesLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboId
            // 
            comboId.DisplayMember = "id";
            comboId.FormattingEnabled = true;
            comboId.Location = new Point(28, 297);
            comboId.Margin = new Padding(3, 2, 3, 2);
            comboId.Name = "comboId";
            comboId.Size = new Size(174, 23);
            comboId.TabIndex = 41;
            comboId.Tag = "id";
            comboId.Text = "Seleccionar Id";
            comboId.ValueMember = "id";
            // 
            // dataGridViewPac
            // 
            dataGridViewPac.AllowUserToAddRows = false;
            dataGridViewPac.AllowUserToDeleteRows = false;
            dataGridViewPac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPac.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPac.BackgroundColor = Color.Gainsboro;
            dataGridViewPac.BorderStyle = BorderStyle.None;
            dataGridViewPac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPac.Location = new Point(52, 64);
            dataGridViewPac.Margin = new Padding(3, 2, 3, 2);
            dataGridViewPac.Name = "dataGridViewPac";
            dataGridViewPac.ReadOnly = true;
            dataGridViewPac.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewPac.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPac.Size = new Size(781, 212);
            dataGridViewPac.TabIndex = 40;
            dataGridViewPac.CellContentClick += dataGridViewPac_CellContentClick;
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
            modificarPacienteBtn.Location = new Point(612, 292);
            modificarPacienteBtn.Margin = new Padding(3, 2, 3, 2);
            modificarPacienteBtn.Name = "modificarPacienteBtn";
            modificarPacienteBtn.Size = new Size(119, 30);
            modificarPacienteBtn.TabIndex = 49;
            modificarPacienteBtn.Text = "Modificar";
            modificarPacienteBtn.UseVisualStyleBackColor = false;
            modificarPacienteBtn.Click += modificarPacienteBtn_Click;
            // 
            // borrarBtn
            // 
            borrarBtn.BackColor = Color.Crimson;
            borrarBtn.Cursor = Cursors.Hand;
            borrarBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            borrarBtn.FlatAppearance.BorderSize = 0;
            borrarBtn.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            borrarBtn.FlatStyle = FlatStyle.Flat;
            borrarBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrarBtn.ForeColor = SystemColors.ControlLightLight;
            borrarBtn.Location = new Point(738, 292);
            borrarBtn.Margin = new Padding(3, 2, 3, 2);
            borrarBtn.Name = "borrarBtn";
            borrarBtn.Size = new Size(122, 30);
            borrarBtn.TabIndex = 47;
            borrarBtn.Text = "Borrar";
            borrarBtn.UseVisualStyleBackColor = false;
            borrarBtn.Click += borrarBtn_Click;
            // 
            // mostrarTodosBtn
            // 
            mostrarTodosBtn.BackColor = Color.SteelBlue;
            mostrarTodosBtn.Cursor = Cursors.Hand;
            mostrarTodosBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            mostrarTodosBtn.FlatAppearance.BorderSize = 0;
            mostrarTodosBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            mostrarTodosBtn.FlatStyle = FlatStyle.Flat;
            mostrarTodosBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mostrarTodosBtn.ForeColor = SystemColors.ControlLightLight;
            mostrarTodosBtn.Location = new Point(341, 292);
            mostrarTodosBtn.Margin = new Padding(3, 2, 3, 2);
            mostrarTodosBtn.Name = "mostrarTodosBtn";
            mostrarTodosBtn.Size = new Size(122, 30);
            mostrarTodosBtn.TabIndex = 46;
            mostrarTodosBtn.Text = "Mostrar Todos";
            mostrarTodosBtn.UseVisualStyleBackColor = false;
            mostrarTodosBtn.Click += mostrarTodosBtn_Click;
            // 
            // mostrarUnoBtn
            // 
            mostrarUnoBtn.BackColor = Color.SteelBlue;
            mostrarUnoBtn.Cursor = Cursors.Hand;
            mostrarUnoBtn.FlatAppearance.BorderColor = Color.SteelBlue;
            mostrarUnoBtn.FlatAppearance.BorderSize = 0;
            mostrarUnoBtn.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            mostrarUnoBtn.FlatStyle = FlatStyle.Flat;
            mostrarUnoBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mostrarUnoBtn.ForeColor = SystemColors.ControlLightLight;
            mostrarUnoBtn.Location = new Point(214, 292);
            mostrarUnoBtn.Margin = new Padding(3, 2, 3, 2);
            mostrarUnoBtn.Name = "mostrarUnoBtn";
            mostrarUnoBtn.Size = new Size(122, 30);
            mostrarUnoBtn.TabIndex = 45;
            mostrarUnoBtn.Text = "Mostrar uno";
            mostrarUnoBtn.UseVisualStyleBackColor = false;
            mostrarUnoBtn.Click += mostrarUnoBtn_Click;
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
            agregarPacienteBtn.Location = new Point(488, 292);
            agregarPacienteBtn.Margin = new Padding(3, 2, 3, 2);
            agregarPacienteBtn.Name = "agregarPacienteBtn";
            agregarPacienteBtn.Size = new Size(119, 30);
            agregarPacienteBtn.TabIndex = 48;
            agregarPacienteBtn.Text = "Agregar";
            agregarPacienteBtn.UseVisualStyleBackColor = false;
            agregarPacienteBtn.Click += agregarPacienteBtn_Click;
            // 
            // MostrarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(884, 334);
            Controls.Add(modificarPacienteBtn);
            Controls.Add(agregarPacienteBtn);
            Controls.Add(borrarBtn);
            Controls.Add(mostrarTodosBtn);
            Controls.Add(mostrarUnoBtn);
            Controls.Add(mostrarPacientesLabel);
            Controls.Add(comboId);
            Controls.Add(dataGridViewPac);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MostrarPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio";
            Load += MostrarPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPac).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mostrarPacientesLabel;
        private ComboBox comboId;
        private DataGridView dataGridViewPac;
        private Button modificarPacienteBtn;
        private Button borrarBtn;
        private Button mostrarTodosBtn;
        private Button mostrarUnoBtn;
        private Button agregarPacienteBtn;
    }
}