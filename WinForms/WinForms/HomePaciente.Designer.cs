namespace WinForms
{
    partial class HomePaciente
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
            proximosTurnosPacienteDGV = new DataGridView();
            cerrarSesionBtn = new Button();
            labelMisProximosTurnos = new Label();
            pacienteMenuStrip = new MenuStrip();
            proximosTurnosAdministradorDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)proximosTurnosPacienteDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proximosTurnosAdministradorDGV).BeginInit();
            SuspendLayout();
            // 
            // proximosTurnosPacienteDGV
            // 
            proximosTurnosPacienteDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            proximosTurnosPacienteDGV.Location = new Point(28, 101);
            proximosTurnosPacienteDGV.Name = "proximosTurnosPacienteDGV";
            proximosTurnosPacienteDGV.Size = new Size(744, 295);
            proximosTurnosPacienteDGV.TabIndex = 4;
            proximosTurnosPacienteDGV.Visible = false;
            // 
            // cerrarSesionBtn
            // 
            cerrarSesionBtn.BackColor = Color.DarkRed;
            cerrarSesionBtn.Cursor = Cursors.Hand;
            cerrarSesionBtn.FlatAppearance.BorderSize = 0;
            cerrarSesionBtn.FlatStyle = FlatStyle.Flat;
            cerrarSesionBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cerrarSesionBtn.ForeColor = Color.White;
            cerrarSesionBtn.Location = new Point(653, 431);
            cerrarSesionBtn.Name = "cerrarSesionBtn";
            cerrarSesionBtn.Size = new Size(117, 30);
            cerrarSesionBtn.TabIndex = 5;
            cerrarSesionBtn.Text = "Cerrar sesión";
            cerrarSesionBtn.UseVisualStyleBackColor = false;
            cerrarSesionBtn.Click += cerrarSesionBtn_Click;
            // 
            // labelMisProximosTurnos
            // 
            labelMisProximosTurnos.AutoSize = true;
            labelMisProximosTurnos.Font = new Font("Segoe UI", 12F);
            labelMisProximosTurnos.Location = new Point(24, 67);
            labelMisProximosTurnos.Name = "labelMisProximosTurnos";
            labelMisProximosTurnos.Size = new Size(156, 21);
            labelMisProximosTurnos.TabIndex = 6;
            labelMisProximosTurnos.Text = "Mis próximos turnos:";
            labelMisProximosTurnos.Visible = false;
            // 
            // pacienteMenuStrip
            // 
            pacienteMenuStrip.BackColor = Color.DarkGray;
            pacienteMenuStrip.Font = new Font("Segoe UI", 11F);
            pacienteMenuStrip.GripStyle = ToolStripGripStyle.Visible;
            pacienteMenuStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            pacienteMenuStrip.Location = new Point(0, 0);
            pacienteMenuStrip.Name = "pacienteMenuStrip";
            pacienteMenuStrip.Size = new Size(801, 24);
            pacienteMenuStrip.TabIndex = 7;
            // 
            // proximosTurnosAdministradorDGV
            // 
            proximosTurnosAdministradorDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            proximosTurnosAdministradorDGV.Location = new Point(28, 101);
            proximosTurnosAdministradorDGV.Name = "proximosTurnosAdministradorDGV";
            proximosTurnosAdministradorDGV.Size = new Size(744, 295);
            proximosTurnosAdministradorDGV.TabIndex = 8;
            proximosTurnosAdministradorDGV.Visible = false;
            // 
            // HomePaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(801, 478);
            Controls.Add(proximosTurnosAdministradorDGV);
            Controls.Add(cerrarSesionBtn);
            Controls.Add(proximosTurnosPacienteDGV);
            Controls.Add(pacienteMenuStrip);
            Controls.Add(labelMisProximosTurnos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = pacienteMenuStrip;
            Name = "HomePaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += HomePaciente_Load;
            ((System.ComponentModel.ISupportInitialize)proximosTurnosPacienteDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)proximosTurnosAdministradorDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView proximosTurnosPacienteDGV;
        private Button cerrarSesionBtn;
        private Label labelMisProximosTurnos;
        private MenuStrip pacienteMenuStrip;
        private DataGridView proximosTurnosAdministradorDGV;
    }
}