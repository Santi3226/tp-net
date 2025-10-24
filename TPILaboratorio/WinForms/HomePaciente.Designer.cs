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
            btnRecepcion = new Button();
            btnGanancias = new Button();
            ((System.ComponentModel.ISupportInitialize)proximosTurnosPacienteDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)proximosTurnosAdministradorDGV).BeginInit();
            SuspendLayout();
            // 
            // proximosTurnosPacienteDGV
            // 
            proximosTurnosPacienteDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            proximosTurnosPacienteDGV.Location = new Point(32, 135);
            proximosTurnosPacienteDGV.Margin = new Padding(3, 4, 3, 4);
            proximosTurnosPacienteDGV.Name = "proximosTurnosPacienteDGV";
            proximosTurnosPacienteDGV.RowHeadersWidth = 51;
            proximosTurnosPacienteDGV.Size = new Size(850, 393);
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
            cerrarSesionBtn.Location = new Point(746, 575);
            cerrarSesionBtn.Margin = new Padding(3, 4, 3, 4);
            cerrarSesionBtn.Name = "cerrarSesionBtn";
            cerrarSesionBtn.Size = new Size(134, 40);
            cerrarSesionBtn.TabIndex = 5;
            cerrarSesionBtn.Text = "Cerrar sesión";
            cerrarSesionBtn.UseVisualStyleBackColor = false;
            cerrarSesionBtn.Click += cerrarSesionBtn_Click;
            // 
            // labelMisProximosTurnos
            // 
            labelMisProximosTurnos.AutoSize = true;
            labelMisProximosTurnos.Font = new Font("Segoe UI", 12F);
            labelMisProximosTurnos.Location = new Point(27, 89);
            labelMisProximosTurnos.Name = "labelMisProximosTurnos";
            labelMisProximosTurnos.Size = new Size(195, 28);
            labelMisProximosTurnos.TabIndex = 6;
            labelMisProximosTurnos.Text = "Mis próximos turnos:";
            labelMisProximosTurnos.Visible = false;
            // 
            // pacienteMenuStrip
            // 
            pacienteMenuStrip.BackColor = Color.DarkGray;
            pacienteMenuStrip.Font = new Font("Segoe UI", 11F);
            pacienteMenuStrip.GripStyle = ToolStripGripStyle.Visible;
            pacienteMenuStrip.ImageScalingSize = new Size(20, 20);
            pacienteMenuStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            pacienteMenuStrip.Location = new Point(0, 0);
            pacienteMenuStrip.Name = "pacienteMenuStrip";
            pacienteMenuStrip.Padding = new Padding(3, 3, 0, 3);
            pacienteMenuStrip.Size = new Size(915, 24);
            pacienteMenuStrip.TabIndex = 7;
            // 
            // proximosTurnosAdministradorDGV
            // 
            proximosTurnosAdministradorDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            proximosTurnosAdministradorDGV.Location = new Point(32, 135);
            proximosTurnosAdministradorDGV.Margin = new Padding(3, 4, 3, 4);
            proximosTurnosAdministradorDGV.Name = "proximosTurnosAdministradorDGV";
            proximosTurnosAdministradorDGV.RowHeadersWidth = 51;
            proximosTurnosAdministradorDGV.Size = new Size(850, 393);
            proximosTurnosAdministradorDGV.TabIndex = 8;
            proximosTurnosAdministradorDGV.Visible = false;
            proximosTurnosAdministradorDGV.CellContentClick += proximosTurnosAdministradorDGV_CellContentClick;
            // 
            // btnRecepcion
            // 
            btnRecepcion.Location = new Point(553, 582);
            btnRecepcion.Name = "btnRecepcion";
            btnRecepcion.Size = new Size(156, 29);
            btnRecepcion.TabIndex = 9;
            btnRecepcion.Text = "Reporte Recepción";
            btnRecepcion.UseVisualStyleBackColor = true;
            btnRecepcion.Click += btnRecepcion_Click;
            // 
            // btnGanancias
            // 
            btnGanancias.Location = new Point(369, 582);
            btnGanancias.Name = "btnGanancias";
            btnGanancias.Size = new Size(158, 29);
            btnGanancias.TabIndex = 10;
            btnGanancias.Text = "Reporte Ganancias";
            btnGanancias.UseVisualStyleBackColor = true;
            btnGanancias.Click += btnGanancias_Click;
            // 
            // HomePaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(915, 637);
            Controls.Add(btnGanancias);
            Controls.Add(btnRecepcion);
            Controls.Add(proximosTurnosAdministradorDGV);
            Controls.Add(cerrarSesionBtn);
            Controls.Add(proximosTurnosPacienteDGV);
            Controls.Add(pacienteMenuStrip);
            Controls.Add(labelMisProximosTurnos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = pacienteMenuStrip;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnRecepcion;
        private Button btnGanancias;
    }
}