namespace WinForms
{
    partial class ModificarCA
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
            button1 = new Button();
            textBoxDomicilio = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxNombre = new TextBox();
            label7 = new Label();
            label1 = new Label();
            textBoxId = new TextBox();
            SuspendLayout();
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
            button1.Location = new Point(223, 352);
            button1.Name = "button1";
            button1.Size = new Size(140, 40);
            button1.TabIndex = 32;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxDomicilio
            // 
            textBoxDomicilio.BorderStyle = BorderStyle.FixedSingle;
            textBoxDomicilio.Location = new Point(144, 287);
            textBoxDomicilio.Name = "textBoxDomicilio";
            textBoxDomicilio.Size = new Size(300, 27);
            textBoxDomicilio.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(144, 264);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 29;
            label8.Text = "Domicilio";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.Location = new Point(144, 178);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 28;
            label9.Text = "Nombre";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Location = new Point(144, 201);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(300, 27);
            textBoxNombre.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label7.Location = new Point(83, 34);
            label7.Name = "label7";
            label7.Size = new Size(435, 41);
            label7.TabIndex = 25;
            label7.Text = "Modificar Centro de Atencion";
            label7.TextAlign = ContentAlignment.TopCenter;
            label7.Click += label7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(144, 109);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 34;
            label1.Text = "Id";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxId
            // 
            textBoxId.BorderStyle = BorderStyle.FixedSingle;
            textBoxId.Location = new Point(144, 132);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(300, 27);
            textBoxId.TabIndex = 33;
            // 
            // ModificarCA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(612, 425);
            Controls.Add(label1);
            Controls.Add(textBoxId);
            Controls.Add(button1);
            Controls.Add(textBoxDomicilio);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textBoxNombre);
            Controls.Add(label7);
            Name = "ModificarCA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Laboratorio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxDomicilio;
        private Label label8;
        private Label label9;
        private TextBox textBoxNombre;
        private Label label7;
        private Label label1;
        private TextBox textBoxId;
    }
}