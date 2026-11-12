namespace Cine_proyecto.Presentacion
{
    partial class Consulta2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            nudCantidadPeliculas = new NumericUpDown();
            nudCantidadEntradas = new NumericUpDown();
            lblTitulo = new Label();
            lblCantidadPeliculas = new Label();
            lblCantidadEntradas = new Label();
            btnConsultar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            dgvResultados = new DataGridView();
            colCliente = new DataGridViewTextBoxColumn();
            colFacturas = new DataGridViewTextBoxColumn();
            colEntradas = new DataGridViewTextBoxColumn();
            colPeliculas = new DataGridViewTextBoxColumn();
            colImporteTotal = new DataGridViewTextBoxColumn();
            panelFiltros = new Panel();
            panelTitulo = new Panel();
            panelPie = new Panel();
            panelGrilla = new Panel();
            ((System.ComponentModel.ISupportInitialize)nudCantidadPeliculas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadEntradas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            panelFiltros.SuspendLayout();
            panelTitulo.SuspendLayout();
            panelPie.SuspendLayout();
            panelGrilla.SuspendLayout();
            SuspendLayout();
            // 
            // nudCantidadPeliculas
            // 
            nudCantidadPeliculas.Location = new Point(15, 35);
            nudCantidadPeliculas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidadPeliculas.Name = "nudCantidadPeliculas";
            nudCantidadPeliculas.Size = new Size(170, 23);
            nudCantidadPeliculas.TabIndex = 0;
            nudCantidadPeliculas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudCantidadEntradas
            // 
            nudCantidadEntradas.Location = new Point(230, 35);
            nudCantidadEntradas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidadEntradas.Name = "nudCantidadEntradas";
            nudCantidadEntradas.Size = new Size(170, 23);
            nudCantidadEntradas.TabIndex = 1;
            nudCantidadEntradas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(434, 30);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Análisis de clientes con compras recurrentes";
            // 
            // lblCantidadPeliculas
            // 
            lblCantidadPeliculas.AutoSize = true;
            lblCantidadPeliculas.Location = new Point(15, 10);
            lblCantidadPeliculas.Name = "lblCantidadPeliculas";
            lblCantidadPeliculas.Size = new Size(164, 15);
            lblCantidadPeliculas.TabIndex = 3;
            lblCantidadPeliculas.Text = "Cantidad mínima de películas";
            // 
            // lblCantidadEntradas
            // 
            lblCantidadEntradas.AutoSize = true;
            lblCantidadEntradas.Location = new Point(230, 10);
            lblCantidadEntradas.Name = "lblCantidadEntradas";
            lblCantidadEntradas.Size = new Size(163, 15);
            lblCantidadEntradas.TabIndex = 4;
            lblCantidadEntradas.Text = "Cantidad mínima de entradas";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(430, 32);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Dock = DockStyle.Left;
            btnLimpiar.Location = new Point(20, 10);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 35);
            btnLimpiar.TabIndex = 6;
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
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colCliente, colFacturas, colEntradas, colPeliculas, colImporteTotal });
            dgvResultados.Location = new Point(18, 50);
            dgvResultados.MultiSelect = false;
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResultados.Size = new Size(776, 150);
            dgvResultados.TabIndex = 8;
            // 
            // colCliente
            // 
            colCliente.DataPropertyName = "cliente";
            colCliente.FillWeight = 30F;
            colCliente.HeaderText = "Cliente";
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            // 
            // colFacturas
            // 
            colFacturas.DataPropertyName = "cantidadFacturas";
            colFacturas.FillWeight = 15F;
            colFacturas.HeaderText = "Facturas";
            colFacturas.Name = "colFacturas";
            colFacturas.ReadOnly = true;
            // 
            // colEntradas
            // 
            colEntradas.DataPropertyName = "cantidadEntradas";
            colEntradas.FillWeight = 15F;
            colEntradas.HeaderText = "Entradas";
            colEntradas.Name = "colEntradas";
            colEntradas.ReadOnly = true;
            // 
            // colPeliculas
            // 
            colPeliculas.DataPropertyName = "cantidadPeliculas";
            colPeliculas.FillWeight = 15F;
            colPeliculas.HeaderText = "Peliculas";
            colPeliculas.Name = "colPeliculas";
            colPeliculas.ReadOnly = true;
            // 
            // colImporteTotal
            // 
            colImporteTotal.DataPropertyName = "importeTotal";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            colImporteTotal.DefaultCellStyle = dataGridViewCellStyle1;
            colImporteTotal.FillWeight = 25F;
            colImporteTotal.HeaderText = "Importe total";
            colImporteTotal.Name = "colImporteTotal";
            colImporteTotal.ReadOnly = true;
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(nudCantidadEntradas);
            panelFiltros.Controls.Add(nudCantidadPeliculas);
            panelFiltros.Controls.Add(lblCantidadPeliculas);
            panelFiltros.Controls.Add(lblCantidadEntradas);
            panelFiltros.Controls.Add(btnConsultar);
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Location = new Point(0, 0);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(800, 80);
            panelFiltros.TabIndex = 10;
            // 
            // panelTitulo
            // 
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 80);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(800, 60);
            panelTitulo.TabIndex = 11;
            // 
            // panelPie
            // 
            panelPie.Controls.Add(btnLimpiar);
            panelPie.Controls.Add(btnSalir);
            panelPie.Dock = DockStyle.Bottom;
            panelPie.Location = new Point(0, 395);
            panelPie.Name = "panelPie";
            panelPie.Padding = new Padding(20, 10, 20, 10);
            panelPie.Size = new Size(800, 55);
            panelPie.TabIndex = 12;
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgvResultados);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 140);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Padding = new Padding(15, 10, 15, 10);
            panelGrilla.Size = new Size(800, 255);
            panelGrilla.TabIndex = 13;
            // 
            // Consulta2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelGrilla);
            Controls.Add(panelPie);
            Controls.Add(panelTitulo);
            Controls.Add(panelFiltros);
            Name = "Consulta2";
            Text = "Consulta2";
            Load += Consulta2_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidadPeliculas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadEntradas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelPie.ResumeLayout(false);
            panelGrilla.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown nudCantidadPeliculas;
        private NumericUpDown nudCantidadEntradas;
        private Label lblTitulo;
        private Label lblCantidadPeliculas;
        private Label lblCantidadEntradas;
        private Button btnConsultar;
        private Button btnLimpiar;
        private Button btnSalir;
        private DataGridView dgvResultados;
        private Panel panelFiltros;
        private Panel panelTitulo;
        private Panel panelPie;
        private Panel panelGrilla;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colFacturas;
        private DataGridViewTextBoxColumn colEntradas;
        private DataGridViewTextBoxColumn colPeliculas;
        private DataGridViewTextBoxColumn colImporteTotal;
    }
}