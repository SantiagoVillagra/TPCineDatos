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
            nudCantidadPeliculas = new NumericUpDown();
            nudCantidadEntradas = new NumericUpDown();
            lblTituloC2 = new Label();
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
            lblResultados = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidadPeliculas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadEntradas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // nudCantidadPeliculas
            // 
            nudCantidadPeliculas.Location = new Point(12, 106);
            nudCantidadPeliculas.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCantidadPeliculas.Name = "nudCantidadPeliculas";
            nudCantidadPeliculas.Size = new Size(83, 23);
            nudCantidadPeliculas.TabIndex = 0;
            nudCantidadPeliculas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudCantidadEntradas
            // 
            nudCantidadEntradas.Location = new Point(198, 106);
            nudCantidadEntradas.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCantidadEntradas.Name = "nudCantidadEntradas";
            nudCantidadEntradas.Size = new Size(83, 23);
            nudCantidadEntradas.TabIndex = 1;
            nudCantidadEntradas.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTituloC2
            // 
            lblTituloC2.AutoSize = true;
            lblTituloC2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloC2.Location = new Point(12, 9);
            lblTituloC2.Name = "lblTituloC2";
            lblTituloC2.Size = new Size(434, 30);
            lblTituloC2.TabIndex = 2;
            lblTituloC2.Text = "Análisis de clientes con compras recurrentes";
            // 
            // lblCantidadPeliculas
            // 
            lblCantidadPeliculas.AutoSize = true;
            lblCantidadPeliculas.Location = new Point(12, 76);
            lblCantidadPeliculas.Name = "lblCantidadPeliculas";
            lblCantidadPeliculas.Size = new Size(164, 15);
            lblCantidadPeliculas.TabIndex = 3;
            lblCantidadPeliculas.Text = "Cantidad mínima de películas";
            // 
            // lblCantidadEntradas
            // 
            lblCantidadEntradas.AutoSize = true;
            lblCantidadEntradas.Location = new Point(198, 76);
            lblCantidadEntradas.Name = "lblCantidadEntradas";
            lblCantidadEntradas.Size = new Size(163, 15);
            lblCantidadEntradas.TabIndex = 4;
            lblCantidadEntradas.Text = "Cantidad mínima de entradas";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(383, 106);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(12, 415);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(713, 415);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
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
            dgvResultados.Location = new Point(12, 207);
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
            colCliente.HeaderText = "Cliente";
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            // 
            // colFacturas
            // 
            colFacturas.DataPropertyName = "cantidadFacturas";
            colFacturas.HeaderText = "Facturas";
            colFacturas.Name = "colFacturas";
            colFacturas.ReadOnly = true;
            // 
            // colEntradas
            // 
            colEntradas.DataPropertyName = "cantidadEntradas";
            colEntradas.HeaderText = "Entradas";
            colEntradas.Name = "colEntradas";
            colEntradas.ReadOnly = true;
            // 
            // colPeliculas
            // 
            colPeliculas.DataPropertyName = "cantidadPeliculas";
            colPeliculas.HeaderText = "Peliculas";
            colPeliculas.Name = "colPeliculas";
            colPeliculas.ReadOnly = true;
            // 
            // colImporteTotal
            // 
            colImporteTotal.DataPropertyName = "importeTotal";
            colImporteTotal.HeaderText = "Importe total";
            colImporteTotal.Name = "colImporteTotal";
            colImporteTotal.ReadOnly = true;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(12, 167);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(64, 15);
            lblResultados.TabIndex = 9;
            lblResultados.Text = "Resultados";
            // 
            // Consulta2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultados);
            Controls.Add(dgvResultados);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnConsultar);
            Controls.Add(lblCantidadEntradas);
            Controls.Add(lblCantidadPeliculas);
            Controls.Add(lblTituloC2);
            Controls.Add(nudCantidadEntradas);
            Controls.Add(nudCantidadPeliculas);
            Name = "Consulta2";
            Text = "Consulta2";
            Load += Consulta2_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidadPeliculas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidadEntradas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudCantidadPeliculas;
        private NumericUpDown nudCantidadEntradas;
        private Label lblTituloC2;
        private Label lblCantidadPeliculas;
        private Label lblCantidadEntradas;
        private Button btnConsultar;
        private Button btnLimpiar;
        private Button btnSalir;
        private DataGridView dgvResultados;
        private Label lblResultados;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colFacturas;
        private DataGridViewTextBoxColumn colEntradas;
        private DataGridViewTextBoxColumn colPeliculas;
        private DataGridViewTextBoxColumn colImporteTotal;
    }
}