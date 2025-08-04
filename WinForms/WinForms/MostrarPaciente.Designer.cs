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
            button2 = new Button();
            button1 = new Button();
            comboId = new ComboBox();
            dataGridViewPac = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPac).BeginInit();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titulo.Location = new Point(247, 28);
            titulo.Name = "titulo";
            titulo.Size = new Size(269, 41);
            titulo.TabIndex = 44;
            titulo.Text = "Mostrar Pacientes";
            titulo.TextAlign = ContentAlignment.TopCenter;
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
            button2.Location = new Point(629, 389);
            button2.Name = "button2";
            button2.Size = new Size(140, 40);
            button2.TabIndex = 43;
            button2.Text = "Mostrar Todos";
            button2.UseVisualStyleBackColor = false;
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
            button1.Location = new Point(247, 389);
            button1.Name = "button1";
            button1.Size = new Size(140, 40);
            button1.TabIndex = 42;
            button1.Text = "Mostrar uno";
            button1.UseVisualStyleBackColor = false;
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
            dataGridViewPac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPac.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPac.BackgroundColor = Color.Gainsboro;
            dataGridViewPac.BorderStyle = BorderStyle.None;
            dataGridViewPac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPac.Location = new Point(12, 82);
            dataGridViewPac.Name = "dataGridViewPac";
            dataGridViewPac.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewPac.Size = new Size(776, 279);
            dataGridViewPac.TabIndex = 40;
            // 
            // MostrarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(titulo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboId);
            Controls.Add(dataGridViewPac);
            Name = "MostrarPaciente";
            Text = "Laboratorio";
            Load += MostrarPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPac).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Button button2;
        private Button button1;
        private ComboBox comboId;
        private DataGridView dataGridViewPac;
    }
}