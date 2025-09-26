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
            solicitarTurnoToolStripMenuItem = new ToolStripMenuItem();
            modificarTurnoToolStripMenuItem = new ToolStripMenuItem();
            cancelarTurnoToolStripMenuItem = new ToolStripMenuItem();
            modificarDatosToolStripMenuItem = new ToolStripMenuItem();
            modificarMisDatosToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)proximosTurnosPacienteDGV).BeginInit();
            pacienteMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // proximosTurnosPacienteDGV
            // 
            proximosTurnosPacienteDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            proximosTurnosPacienteDGV.Location = new Point(28, 101);
            proximosTurnosPacienteDGV.Name = "proximosTurnosPacienteDGV";
            proximosTurnosPacienteDGV.Size = new Size(744, 295);
            proximosTurnosPacienteDGV.TabIndex = 4;
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
            // 
            // pacienteMenuStrip
            // 
            pacienteMenuStrip.BackColor = Color.DarkGray;
            pacienteMenuStrip.Font = new Font("Segoe UI", 11F);
            pacienteMenuStrip.GripStyle = ToolStripGripStyle.Visible;
            pacienteMenuStrip.Items.AddRange(new ToolStripItem[] { solicitarTurnoToolStripMenuItem, modificarTurnoToolStripMenuItem, cancelarTurnoToolStripMenuItem, modificarDatosToolStripMenuItem, modificarMisDatosToolStripMenuItem });
            pacienteMenuStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            pacienteMenuStrip.Location = new Point(0, 0);
            pacienteMenuStrip.Name = "pacienteMenuStrip";
            pacienteMenuStrip.Size = new Size(801, 28);
            pacienteMenuStrip.TabIndex = 7;
            // 
            // solicitarTurnoToolStripMenuItem
            // 
            solicitarTurnoToolStripMenuItem.Name = "solicitarTurnoToolStripMenuItem";
            solicitarTurnoToolStripMenuItem.Size = new Size(114, 24);
            solicitarTurnoToolStripMenuItem.Text = "Solicitar turno";
            // 
            // modificarTurnoToolStripMenuItem
            // 
            modificarTurnoToolStripMenuItem.Name = "modificarTurnoToolStripMenuItem";
            modificarTurnoToolStripMenuItem.Size = new Size(124, 24);
            modificarTurnoToolStripMenuItem.Text = "Datos del turno";
            // 
            // cancelarTurnoToolStripMenuItem
            // 
            cancelarTurnoToolStripMenuItem.Name = "cancelarTurnoToolStripMenuItem";
            cancelarTurnoToolStripMenuItem.Size = new Size(117, 24);
            cancelarTurnoToolStripMenuItem.Text = "Cancelar turno";
            // 
            // modificarDatosToolStripMenuItem
            // 
            modificarDatosToolStripMenuItem.Name = "modificarDatosToolStripMenuItem";
            modificarDatosToolStripMenuItem.Size = new Size(124, 24);
            modificarDatosToolStripMenuItem.Text = "Modificar turno";
            // 
            // modificarMisDatosToolStripMenuItem
            // 
            modificarMisDatosToolStripMenuItem.Name = "modificarMisDatosToolStripMenuItem";
            modificarMisDatosToolStripMenuItem.Size = new Size(153, 24);
            modificarMisDatosToolStripMenuItem.Text = "Modificar mis datos";
            // 
            // HomePaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(801, 478);
            Controls.Add(labelMisProximosTurnos);
            Controls.Add(cerrarSesionBtn);
            Controls.Add(proximosTurnosPacienteDGV);
            Controls.Add(pacienteMenuStrip);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = pacienteMenuStrip;
            Name = "HomePaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)proximosTurnosPacienteDGV).EndInit();
            pacienteMenuStrip.ResumeLayout(false);
            pacienteMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView proximosTurnosPacienteDGV;
        private Button cerrarSesionBtn;
        private Label labelMisProximosTurnos;
        private MenuStrip pacienteMenuStrip;
        private ToolStripMenuItem solicitarTurnoToolStripMenuItem;
        private ToolStripMenuItem modificarTurnoToolStripMenuItem;
        private ToolStripMenuItem cancelarTurnoToolStripMenuItem;
        private ToolStripMenuItem modificarDatosToolStripMenuItem;
        private ToolStripMenuItem modificarMisDatosToolStripMenuItem;
    }
}