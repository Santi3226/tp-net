namespace WinForms
{
    partial class BorrarCA
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
            components = new System.ComponentModel.Container();
            centroAtencionInMemoryBindingSource = new BindingSource(components);
            label1 = new Label();
            titulo = new Label();
            button1 = new Button();
            pacienteInMemoryBindingSource = new BindingSource(components);
            textBoxId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)centroAtencionInMemoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pacienteInMemoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // centroAtencionInMemoryBindingSource
            // 
            centroAtencionInMemoryBindingSource.DataSource = typeof(Data.CentroAtencionInMemory);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(158, 168);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 23;
            label1.Text = "Id Centro de Atencion";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // titulo
            // 
            titulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titulo.AutoSize = true;
            titulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titulo.Location = new Point(122, 71);
            titulo.Name = "titulo";
            titulo.Size = new Size(386, 41);
            titulo.TabIndex = 22;
            titulo.Text = "Borrar Centro de Atencion";
            titulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(249, 293);
            button1.Name = "button1";
            button1.Size = new Size(140, 40);
            button1.TabIndex = 33;
            button1.Text = "Borrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pacienteInMemoryBindingSource
            // 
            pacienteInMemoryBindingSource.DataSource = typeof(Data.PacienteInMemory);
            // 
            // textBoxId
            // 
            textBoxId.BorderStyle = BorderStyle.FixedSingle;
            textBoxId.Location = new Point(158, 191);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(300, 27);
            textBoxId.TabIndex = 34;
            // 
            // BorrarCA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(623, 388);
            Controls.Add(textBoxId);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(titulo);
            Name = "BorrarCA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio";
            Load += BorrarCA_Load;
            ((System.ComponentModel.ISupportInitialize)centroAtencionInMemoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pacienteInMemoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label titulo;
        private Button button1;
        private BindingSource centroAtencionInMemoryBindingSource;
        private BindingSource pacienteInMemoryBindingSource;
        private TextBox textBoxId;
    }
}