namespace WinForms
{
    partial class MostrarCA
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
            dataGridViewCA = new DataGridView();
            comboId = new ComboBox();
            mostrarUnoBtn = new Button();
            mostrarTodosBtn = new Button();
            mostrarCentrosLabel = new Label();
            borrarBtn = new Button();
            agregarCaBtn = new Button();
            modificarCaBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCA).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCA
            // 
            dataGridViewCA.AllowUserToAddRows = false;
            dataGridViewCA.AllowUserToDeleteRows = false;
            dataGridViewCA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCA.BackgroundColor = Color.Gainsboro;
            dataGridViewCA.BorderStyle = BorderStyle.None;
            dataGridViewCA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCA.Location = new Point(32, 68);
            dataGridViewCA.Margin = new Padding(3, 2, 3, 2);
            dataGridViewCA.Name = "dataGridViewCA";
            dataGridViewCA.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCA.Size = new Size(809, 204);
            dataGridViewCA.TabIndex = 0;
            dataGridViewCA.CellContentClick += dataGridViewCA_CellContentClick;
            // 
            // comboId
            // 
            comboId.DisplayMember = "id";
            comboId.FormattingEnabled = true;
            comboId.Location = new Point(22, 301);
            comboId.Margin = new Padding(3, 2, 3, 2);
            comboId.Name = "comboId";
            comboId.Size = new Size(174, 23);
            comboId.TabIndex = 36;
            comboId.Tag = "id";
            comboId.Text = "Seleccionar Id";
            comboId.ValueMember = "id";
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
            mostrarUnoBtn.Location = new Point(210, 296);
            mostrarUnoBtn.Margin = new Padding(3, 2, 3, 2);
            mostrarUnoBtn.Name = "mostrarUnoBtn";
            mostrarUnoBtn.Size = new Size(122, 30);
            mostrarUnoBtn.TabIndex = 37;
            mostrarUnoBtn.Text = "Mostrar uno";
            mostrarUnoBtn.UseVisualStyleBackColor = false;
            mostrarUnoBtn.Click += mostrarUnoBtn_Click;
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
            mostrarTodosBtn.Location = new Point(337, 296);
            mostrarTodosBtn.Margin = new Padding(3, 2, 3, 2);
            mostrarTodosBtn.Name = "mostrarTodosBtn";
            mostrarTodosBtn.Size = new Size(122, 30);
            mostrarTodosBtn.TabIndex = 38;
            mostrarTodosBtn.Text = "Mostrar Todos";
            mostrarTodosBtn.UseVisualStyleBackColor = false;
            mostrarTodosBtn.Click += mostrarTodosBtn_Click;
            // 
            // mostrarCentrosLabel
            // 
            mostrarCentrosLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mostrarCentrosLabel.AutoSize = true;
            mostrarCentrosLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            mostrarCentrosLabel.Location = new Point(247, 18);
            mostrarCentrosLabel.Name = "mostrarCentrosLabel";
            mostrarCentrosLabel.Size = new Size(345, 32);
            mostrarCentrosLabel.TabIndex = 39;
            mostrarCentrosLabel.Text = "Mostrar Centros de Atencion";
            mostrarCentrosLabel.TextAlign = ContentAlignment.TopCenter;
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
            borrarBtn.Location = new Point(734, 296);
            borrarBtn.Margin = new Padding(3, 2, 3, 2);
            borrarBtn.Name = "borrarBtn";
            borrarBtn.Size = new Size(122, 30);
            borrarBtn.TabIndex = 40;
            borrarBtn.Text = "Borrar";
            borrarBtn.UseVisualStyleBackColor = false;
            borrarBtn.Click += borrarBtn_Click;
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
            agregarCaBtn.Location = new Point(484, 296);
            agregarCaBtn.Margin = new Padding(3, 2, 3, 2);
            agregarCaBtn.Name = "agregarCaBtn";
            agregarCaBtn.Size = new Size(119, 30);
            agregarCaBtn.TabIndex = 41;
            agregarCaBtn.Text = "Agregar";
            agregarCaBtn.UseVisualStyleBackColor = false;
            agregarCaBtn.Click += agregarCaBtn_Click;
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
            modificarCaBtn.Location = new Point(608, 296);
            modificarCaBtn.Margin = new Padding(3, 2, 3, 2);
            modificarCaBtn.Name = "modificarCaBtn";
            modificarCaBtn.Size = new Size(119, 30);
            modificarCaBtn.TabIndex = 42;
            modificarCaBtn.Text = "Modificar";
            modificarCaBtn.UseVisualStyleBackColor = false;
            modificarCaBtn.Click += modificarCaBtn_Click;
            // 
            // MostrarCA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(866, 338);
            Controls.Add(modificarCaBtn);
            Controls.Add(agregarCaBtn);
            Controls.Add(borrarBtn);
            Controls.Add(mostrarCentrosLabel);
            Controls.Add(mostrarTodosBtn);
            Controls.Add(mostrarUnoBtn);
            Controls.Add(comboId);
            Controls.Add(dataGridViewCA);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MostrarCA";
            Text = "Laboratorio";
            Load += MostrarCA_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCA;
        private ComboBox comboId;
        private Button mostrarUnoBtn;
        private Button mostrarTodosBtn;
        private Label mostrarCentrosLabel;
        private Button borrarBtn;
        private Button agregarCaBtn;
        private Button modificarCaBtn;
    }
}