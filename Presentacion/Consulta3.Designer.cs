namespace Cine_proyecto.Presentacion
{
    partial class Consulta3
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            
            dgvPeliculas = new DataGridView();
            ColumnPelicula = new DataGridViewTextBoxColumn();
            columnTipoSala = new DataGridViewTextBoxColumn();
            ColumnEntradasVendidas = new DataGridViewTextBoxColumn();
            ColumnRecaudacionTotal = new DataGridViewTextBoxColumn();
            ColumnRendimiento = new DataGridViewTextBoxColumn();
            cboRendimiento = new ComboBox();
            cboAnio = new ComboBox();
            lblTipo = new Label();
            btnConsultar = new Button();
            btnSalir = new Button();
            lblAnio = new Label();
            panelPie = new Panel();
            panelTitulo = new Panel();
            panelFiltros = new Panel();
            panelGrilla = new Panel();
            btnLimpiar = new Button();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            panelPie.SuspendLayout();
            panelTitulo.SuspendLayout();
            panelFiltros.SuspendLayout();
            panelGrilla.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Columns.AddRange(new DataGridViewColumn[] { ColumnPelicula, columnTipoSala, ColumnEntradasVendidas, ColumnRecaudacionTotal, ColumnRendimiento });
            dgvPeliculas.Location = new Point(28, 46);
            dgvPeliculas.Margin = new Padding(2);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.RowHeadersWidth = 62;
            dgvPeliculas.Size = new Size(1003, 129);
            dgvPeliculas.TabIndex = 0;
            // 
            // ColumnPelicula
            // 
            ColumnPelicula.DataPropertyName = "Pelicula";
            ColumnPelicula.FillWeight = 35F;
            ColumnPelicula.HeaderText = "Pelicula";
            ColumnPelicula.MinimumWidth = 8;
            ColumnPelicula.Name = "ColumnPelicula";
            ColumnPelicula.Width = 150;
            // 
            // columnTipoSala
            // 
            columnTipoSala.DataPropertyName = "TipoSala";
            columnTipoSala.FillWeight = 15F;
            columnTipoSala.HeaderText = "Tipo de Sala";
            columnTipoSala.MinimumWidth = 8;
            columnTipoSala.Name = "columnTipoSala";
            columnTipoSala.Width = 150;
            // 
            // ColumnEntradasVendidas
            // 
            ColumnEntradasVendidas.DataPropertyName = "EntradasVendidas";
            ColumnEntradasVendidas.FillWeight = 15F;
            ColumnEntradasVendidas.HeaderText = "Entradas Vendidas";
            ColumnEntradasVendidas.MinimumWidth = 8;
            ColumnEntradasVendidas.Name = "ColumnEntradasVendidas";
            ColumnEntradasVendidas.Width = 150;
            // 
            // ColumnRecaudacionTotal
            // 
            ColumnRecaudacionTotal.DataPropertyName = "RecaudacionTotal";
            dataGridViewCellStyle5.Format = "'$' #,0.00";
            ColumnRecaudacionTotal.DefaultCellStyle = dataGridViewCellStyle5;
            ColumnRecaudacionTotal.FillWeight = 20F;
            ColumnRecaudacionTotal.HeaderText = "Recaudación total";
            ColumnRecaudacionTotal.MinimumWidth = 8;
            ColumnRecaudacionTotal.Name = "ColumnRecaudacionTotal";
            ColumnRecaudacionTotal.Width = 150;
            // 
            // ColumnRendimiento
            // 
            ColumnRendimiento.DataPropertyName = "Rendimiento";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            ColumnRendimiento.DefaultCellStyle = dataGridViewCellStyle6;
            ColumnRendimiento.FillWeight = 15F;
            ColumnRendimiento.HeaderText = "Rendimiento";
            ColumnRendimiento.MinimumWidth = 8;
            ColumnRendimiento.Name = "ColumnRendimiento";
            ColumnRendimiento.Width = 150;
            // 
            // cboRendimiento
            // 
            cboRendimiento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRendimiento.FormattingEnabled = true;
            cboRendimiento.Items.AddRange(new object[] { "Todos", "Alto Rendimiento", "Bajo Rendimiento" });
            cboRendimiento.Location = new Point(305, 20);
            cboRendimiento.Margin = new Padding(2);
            cboRendimiento.Name = "cboRendimiento";
            cboRendimiento.Size = new Size(160, 23);
            cboRendimiento.TabIndex = 5;
            // 
            // cboAnio
            // 
            cboAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAnio.FormattingEnabled = true;
            cboAnio.Items.AddRange(new object[] { "2026", "2025", "2024" });
            cboAnio.Location = new Point(60, 20);
            cboAnio.Margin = new Padding(2);
            cboAnio.Name = "cboAnio";
            cboAnio.Size = new Size(120, 23);
            cboAnio.TabIndex = 6;
            // 
            // lblTipo
            // 
            lblTipo.Location = new Point(210, 24);
            lblTipo.Margin = new Padding(2, 0, 2, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(160, 15);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Rendimiento";
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultar.Location = new Point(490, 18);
            btnConsultar.Margin = new Padding(2);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(78, 20);
            btnConsultar.TabIndex = 9;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.Location = new Point(820, 10);
            btnSalir.Margin = new Padding(2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(78, 35);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(15, 24);
            lblAnio.Margin = new Padding(2, 0, 2, 0);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(29, 15);
            lblAnio.TabIndex = 11;
            lblAnio.Text = "Año";
            // 
            // panelPie
            // 
            panelPie.Controls.Add(btnLimpiar);
            panelPie.Controls.Add(btnSalir);
            panelPie.Dock = DockStyle.Bottom;
            panelPie.Location = new Point(0, 399);
            panelPie.Name = "panelPie";
            panelPie.Padding = new Padding(20, 10, 20, 10);
            panelPie.Size = new Size(918, 55);
            panelPie.TabIndex = 13;
            // 
            // panelTitulo
            // 
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(918, 60);
            panelTitulo.TabIndex = 14;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(41, 19);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(228, 15);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Análisis anual de rendimiento de películas";
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(btnConsultar);
            panelFiltros.Controls.Add(cboRendimiento);
            panelFiltros.Controls.Add(cboAnio);
            panelFiltros.Controls.Add(lblTipo);
            panelFiltros.Controls.Add(lblAnio);
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Location = new Point(0, 60);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(918, 70);
            panelFiltros.TabIndex = 15;
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgvPeliculas);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 130);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Padding = new Padding(15, 10, 15, 10);
            panelGrilla.Size = new Size(918, 269);
            panelGrilla.TabIndex = 16;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Dock = DockStyle.Left;
            btnLimpiar.Location = new Point(20, 10);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 35);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Consulta3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 454);
            Controls.Add(panelGrilla);
            Controls.Add(panelFiltros);
            Controls.Add(panelTitulo);
            Controls.Add(panelPie);
            Margin = new Padding(2);
            Name = "Consulta3";
            Text = "Consulta3";
            Load += Consulta3_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            panelPie.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            panelGrilla.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPeliculas;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox cboRendimiento;
        private ComboBox cboAnio;
        private Label label1;
        private Label lblTipo;
        private Button btnConsultar;
        private Button btnSalir;
        private Label lblAnio;
        private Label lblTitulo;
        private Panel panelPie;
        private Panel panelTitulo;
        private Panel panelFiltros;
        private Panel panelGrilla;
        private DataGridViewTextBoxColumn ColumnPelicula;
        private DataGridViewTextBoxColumn columnTipoSala;
        private DataGridViewTextBoxColumn ColumnEntradasVendidas;
        private DataGridViewTextBoxColumn ColumnRecaudacionTotal;
        private DataGridViewTextBoxColumn ColumnRendimiento;
        private Button btnLimpiar;
    }
}