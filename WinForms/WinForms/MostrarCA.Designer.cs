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
            ((System.ComponentModel.ISupportInitialize)dataGridViewCA).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCA
            // 
            dataGridViewCA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCA.BackgroundColor = Color.Gainsboro;
            dataGridViewCA.BorderStyle = BorderStyle.None;
            dataGridViewCA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCA.Location = new Point(92, 65);
            dataGridViewCA.Margin = new Padding(3, 2, 3, 2);
            dataGridViewCA.Name = "dataGridViewCA";
            dataGridViewCA.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCA.Size = new Size(538, 209);
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
            button1.Location = new Point(210, 296);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(122, 30);
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
            button2.Location = new Point(544, 296);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(122, 30);
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
            titulo.Location = new Point(172, 20);
            titulo.Name = "titulo";
            titulo.Size = new Size(345, 32);
            titulo.TabIndex = 39;
            titulo.Text = "Mostrar Centros de Atencion";
            titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // MostrarCA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(700, 338);
            Controls.Add(titulo);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Label titulo;
    }
}