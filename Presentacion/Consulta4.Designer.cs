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
            DataGridViewCellStyle centrado = new DataGridViewCellStyle();
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
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(25, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Text = "Butacas sin uso en salas 2D y 3D";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(27, 70);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(90, 27);
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(127, 70);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 27);
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(693, 415);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
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
            dgvResultados.Location = new Point(27, 110);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.Size = new Size(741, 290);
            // 
            // columnas
            // 
            centrado.Alignment = DataGridViewContentAlignment.MiddleCenter;

            colSala.DataPropertyName = "NumeroSala";
            colSala.DefaultCellStyle = centrado;
            colSala.HeaderText = "N° Sala";
            colSala.Name = "colSala";

            colTipoSala.DataPropertyName = "TipoSala";
            colTipoSala.DefaultCellStyle = centrado;
            colTipoSala.HeaderText = "Tipo de sala";
            colTipoSala.Name = "colTipoSala";

            colFila.DataPropertyName = "FilaButaca";
            colFila.DefaultCellStyle = centrado;
            colFila.HeaderText = "Fila";
            colFila.Name = "colFila";

            colButaca.DataPropertyName = "NumeroButaca";
            colButaca.DefaultCellStyle = centrado;
            colButaca.HeaderText = "N° Butaca";
            colButaca.Name = "colButaca";

            colReservas.DataPropertyName = "TotalReservas";
            colReservas.DefaultCellStyle = centrado;
            colReservas.HeaderText = "Veces reservada";
            colReservas.Name = "colReservas";

            colVentas.DataPropertyName = "TotalVentas";
            colVentas.DefaultCellStyle = centrado;
            colVentas.HeaderText = "Veces facturada";
            colVentas.Name = "colVentas";
            // 
            // Consulta3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResultados);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnConsultar);
            Controls.Add(lblTitulo);
            Name = "Consulta3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta 3 - Butacas sin uso";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnConsultar;
        private Button btnLimpiar;
        private Button btnSalir;
        private DataGridView dgvResultados;
        private DataGridViewTextBoxColumn colSala;
        private DataGridViewTextBoxColumn colTipoSala;
        private DataGridViewTextBoxColumn colFila;
        private DataGridViewTextBoxColumn colButaca;
        private DataGridViewTextBoxColumn colReservas;
        private DataGridViewTextBoxColumn colVentas;
    }
}