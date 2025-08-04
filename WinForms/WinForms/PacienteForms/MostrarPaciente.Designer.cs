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
            titulo = new Label();
            comboId = new ComboBox();
            dataGridViewPac = new DataGridView();
            modificarCaBtn = new Button();
            borrarBtn = new Button();
            button2 = new Button();
            button1 = new Button();
            agregarCaBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPac).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titulo.Location = new Point(367, 29);
            titulo.Name = "titulo";
            titulo.Size = new Size(269, 41);
            titulo.TabIndex = 44;
            titulo.Text = "Mostrar Pacientes";
            titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboId
            // 
            comboId.DisplayMember = "id";
            comboId.FormattingEnabled = true;
            comboId.Location = new Point(32, 396);
            comboId.Name = "comboId";
            comboId.Size = new Size(198, 28);
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
            dataGridViewPac.Location = new Point(60, 86);
            dataGridViewPac.Name = "dataGridViewPac";
            dataGridViewPac.ReadOnly = true;
            dataGridViewPac.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewPac.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPac.Size = new Size(893, 282);
            dataGridViewPac.TabIndex = 40;
            dataGridViewPac.CellContentClick += dataGridViewPac_CellContentClick;
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
            modificarCaBtn.Location = new Point(700, 389);
            modificarCaBtn.Name = "modificarCaBtn";
            modificarCaBtn.Size = new Size(136, 40);
            modificarCaBtn.TabIndex = 49;
            modificarCaBtn.Text = "Modificar";
            modificarCaBtn.UseVisualStyleBackColor = false;
            modificarCaBtn.Click += modificarCaBtn_Click;
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
            borrarBtn.Location = new Point(844, 389);
            borrarBtn.Name = "borrarBtn";
            borrarBtn.Size = new Size(139, 40);
            borrarBtn.TabIndex = 47;
            borrarBtn.Text = "Borrar";
            borrarBtn.UseVisualStyleBackColor = false;
            borrarBtn.Click += borrarBtn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(390, 389);
            button2.Name = "button2";
            button2.Size = new Size(139, 40);
            button2.TabIndex = 46;
            button2.Text = "Mostrar Todos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(245, 389);
            button1.Name = "button1";
            button1.Size = new Size(139, 40);
            button1.TabIndex = 45;
            button1.Text = "Mostrar uno";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            agregarCaBtn.Location = new Point(558, 389);
            agregarCaBtn.Name = "agregarCaBtn";
            agregarCaBtn.Size = new Size(136, 40);
            agregarCaBtn.TabIndex = 48;
            agregarCaBtn.Text = "Agregar";
            agregarCaBtn.UseVisualStyleBackColor = false;
            agregarCaBtn.Click += agregarCaBtn_Click;
            // 
            // MostrarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1010, 446);
            Controls.Add(modificarCaBtn);
            Controls.Add(agregarCaBtn);
            Controls.Add(borrarBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(titulo);
            Controls.Add(comboId);
            Controls.Add(dataGridViewPac);
            Name = "MostrarPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio";
            Load += MostrarPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPac).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private ComboBox comboId;
        private DataGridView dataGridViewPac;
        private Button modificarCaBtn;
        private Button borrarBtn;
        private Button button2;
        private Button button1;
        private Button agregarCaBtn;
    }
}