namespace Cine_proyecto.Presentacion
{
    partial class Consulta4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            btnConsultar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            dgvResultados = new DataGridView();
            colSala = new DataGridViewTextBoxColumn();
            colTipoSala = new DataGridViewTextBoxColumn();
            colFila = new DataGridViewTextBoxColumn();
            colButaca = new DataGridViewTextBoxColumn();
            colReservas = new DataGridViewTextBoxColumn();
            colVentas = new DataGridViewTextBoxColumn();
            panelPie = new Panel();
            panelTitulo = new Panel();
            panelGrilla = new Panel();
            panelFiltros = new Panel();
            cboTipoSala = new ComboBox();
            lblTipoSala = new Label();
            nudSala = new NumericUpDown();
            lblSala = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            panelPie.SuspendLayout();
            panelTitulo.SuspendLayout();
            panelGrilla.SuspendLayout();
            panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSala).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(21, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(295, 25);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Butacas sin uso en salas 2D y 3D";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(385, 32);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(90, 27);
            btnConsultar.TabIndex = 3;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(510, 32);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 27);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.Location = new Point(705, 10);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 35);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colSala, colTipoSala, colFila, colButaca, colReservas, colVentas });
            dgvResultados.Location = new Point(31, 175);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.Size = new Size(741, 64);
            dgvResultados.TabIndex = 0;
            // 
            // colSala
            // 
            colSala.DataPropertyName = "NumeroSala";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colSala.DefaultCellStyle = dataGridViewCellStyle1;
            colSala.FillWeight = 12F;
            colSala.HeaderText = "N° Sala";
            colSala.Name = "colSala";
            colSala.ReadOnly = true;
            // 
            // colTipoSala
            // 
            colTipoSala.DataPropertyName = "TipoSala";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colTipoSala.DefaultCellStyle = dataGridViewCellStyle2;
            colTipoSala.FillWeight = 18F;
            colTipoSala.HeaderText = "Tipo de sala";
            colTipoSala.Name = "colTipoSala";
            colTipoSala.ReadOnly = true;
            // 
            // colFila
            // 
            colFila.DataPropertyName = "FilaButaca";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colFila.DefaultCellStyle = dataGridViewCellStyle3;
            colFila.FillWeight = 12F;
            colFila.HeaderText = "Fila";
            colFila.Name = "colFila";
            colFila.ReadOnly = true;
            // 
            // colButaca
            // 
            colButaca.DataPropertyName = "NumeroButaca";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colButaca.DefaultCellStyle = dataGridViewCellStyle4;
            colButaca.FillWeight = 15F;
            colButaca.HeaderText = "N° Butaca";
            colButaca.Name = "colButaca";
            colButaca.ReadOnly = true;
            // 
            // colReservas
            // 
            colReservas.DataPropertyName = "TotalReservas";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colReservas.DefaultCellStyle = dataGridViewCellStyle5;
            colReservas.FillWeight = 21F;
            colReservas.HeaderText = "Veces reservada";
            colReservas.Name = "colReservas";
            colReservas.ReadOnly = true;
            // 
            // colVentas
            // 
            colVentas.DataPropertyName = "TotalVentas";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colVentas.DefaultCellStyle = dataGridViewCellStyle6;
            colVentas.FillWeight = 22F;
            colVentas.HeaderText = "Veces facturada";
            colVentas.Name = "colVentas";
            colVentas.ReadOnly = true;
            // 
            // panelPie
            // 
            panelPie.Controls.Add(btnSalir);
            panelPie.Dock = DockStyle.Bottom;
            panelPie.Location = new Point(0, 395);
            panelPie.Name = "panelPie";
            panelPie.Padding = new Padding(20, 10, 20, 10);
            panelPie.Size = new Size(800, 55);
            panelPie.TabIndex = 5;
            // 
            // panelTitulo
            // 
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(800, 60);
            panelTitulo.TabIndex = 6;
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgvResultados);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 60);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Padding = new Padding(15, 10, 15, 10);
            panelGrilla.Size = new Size(800, 335);
            panelGrilla.TabIndex = 7;
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(cboTipoSala);
            panelFiltros.Controls.Add(lblTipoSala);
            panelFiltros.Controls.Add(nudSala);
            panelFiltros.Controls.Add(lblSala);
            panelFiltros.Controls.Add(btnLimpiar);
            panelFiltros.Controls.Add(btnConsultar);
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Location = new Point(0, 60);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(800, 80);
            panelFiltros.TabIndex = 8;
            // 
            // cboTipoSala
            // 
            cboTipoSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoSala.FormattingEnabled = true;
            cboTipoSala.Location = new Point(210, 35);
            cboTipoSala.Name = "cboTipoSala";
            cboTipoSala.Size = new Size(150, 23);
            cboTipoSala.TabIndex = 7;
            // 
            // lblTipoSala
            // 
            lblTipoSala.Location = new Point(210, 35);
            lblTipoSala.Name = "lblTipoSala";
            lblTipoSala.Size = new Size(150, 15);
            lblTipoSala.TabIndex = 6;
            lblTipoSala.Text = "Tipo de sala";
            // 
            // nudSala
            // 
            nudSala.Location = new Point(15, 35);
            nudSala.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudSala.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSala.Name = "nudSala";
            nudSala.Size = new Size(170, 23);
            nudSala.TabIndex = 5;
            nudSala.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSala
            // 
            lblSala.AutoSize = true;
            lblSala.Location = new Point(15, 10);
            lblSala.Name = "lblSala";
            lblSala.Size = new Size(60, 15);
            lblSala.TabIndex = 4;
            lblSala.Text = "N° de sala";
            // 
            // Consulta4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFiltros);
            Controls.Add(panelGrilla);
            Controls.Add(panelTitulo);
            Controls.Add(panelPie);
            Name = "Consulta4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Butacas sin uso";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            panelPie.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelGrilla.ResumeLayout(false);
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSala).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Button btnConsultar;
        private Button btnLimpiar;
        private Button btnSalir;
        private DataGridView dgvResultados;
        private Panel panelPie;
        private Panel panelTitulo;
        private Panel panelGrilla;
        private Panel panelFiltros;
        private DataGridViewTextBoxColumn colSala;
        private DataGridViewTextBoxColumn colTipoSala;
        private DataGridViewTextBoxColumn colFila;
        private DataGridViewTextBoxColumn colButaca;
        private DataGridViewTextBoxColumn colReservas;
        private DataGridViewTextBoxColumn colVentas;
        private Label lblSala;
        private ComboBox cboTipoSala;
        private Label lblTipoSala;
        private NumericUpDown nudSala;
    }
}