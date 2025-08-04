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
            button1 = new Button();
            button2 = new Button();
            titulo = new Label();
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
            dataGridViewCA.Location = new Point(36, 90);
            dataGridViewCA.Name = "dataGridViewCA";
            dataGridViewCA.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCA.Size = new Size(925, 272);
            dataGridViewCA.TabIndex = 0;
            dataGridViewCA.CellContentClick += dataGridViewCA_CellContentClick;
            // 
            // comboId
            // 
            comboId.DisplayMember = "id";
            comboId.FormattingEnabled = true;
            comboId.Location = new Point(25, 401);
            comboId.Name = "comboId";
            comboId.Size = new Size(198, 28);
            comboId.TabIndex = 36;
            comboId.Tag = "id";
            comboId.Text = "Seleccionar Id";
            comboId.ValueMember = "id";
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
            button1.Location = new Point(240, 395);
            button1.Name = "button1";
            button1.Size = new Size(139, 40);
            button1.TabIndex = 37;
            button1.Text = "Mostrar uno";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            button2.Location = new Point(385, 395);
            button2.Name = "button2";
            button2.Size = new Size(139, 40);
            button2.TabIndex = 38;
            button2.Text = "Mostrar Todos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titulo.Location = new Point(282, 24);
            titulo.Name = "titulo";
            titulo.Size = new Size(422, 41);
            titulo.TabIndex = 39;
            titulo.Text = "Mostrar Centros de Atencion";
            titulo.TextAlign = ContentAlignment.TopCenter;
            titulo.Click += titulo_Click;
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
            borrarBtn.Location = new Point(839, 395);
            borrarBtn.Name = "borrarBtn";
            borrarBtn.Size = new Size(139, 40);
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
            agregarCaBtn.Location = new Point(553, 395);
            agregarCaBtn.Name = "agregarCaBtn";
            agregarCaBtn.Size = new Size(136, 40);
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
            modificarCaBtn.Location = new Point(695, 395);
            modificarCaBtn.Name = "modificarCaBtn";
            modificarCaBtn.Size = new Size(136, 40);
            modificarCaBtn.TabIndex = 42;
            modificarCaBtn.Text = "Modificar";
            modificarCaBtn.UseVisualStyleBackColor = false;
            modificarCaBtn.Click += modificarCaBtn_Click;
            // 
            // MostrarCA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(990, 451);
            Controls.Add(modificarCaBtn);
            Controls.Add(agregarCaBtn);
            Controls.Add(borrarBtn);
            Controls.Add(titulo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboId);
            Controls.Add(dataGridViewCA);
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
        private Button button1;
        private Button button2;
        private Label titulo;
        private Button borrarBtn;
        private Button agregarCaBtn;
        private Button modificarCaBtn;
    }
}