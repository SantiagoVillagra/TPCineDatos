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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            SuspendLayout();
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Columns.AddRange(new DataGridViewColumn[] { ColumnPelicula, columnTipoSala, ColumnEntradasVendidas, ColumnRecaudacionTotal, ColumnRendimiento });
            dgvPeliculas.Location = new Point(12, 150);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.RowHeadersWidth = 62;
            dgvPeliculas.Size = new Size(776, 225);
            dgvPeliculas.TabIndex = 0;
            // 
            // ColumnPelicula
            // 
            ColumnPelicula.DataPropertyName = "Pelicula";
            ColumnPelicula.HeaderText = "Pelicula";
            ColumnPelicula.MinimumWidth = 8;
            ColumnPelicula.Name = "ColumnPelicula";
            ColumnPelicula.Width = 150;
            // 
            // columnTipoSala
            // 
            columnTipoSala.DataPropertyName = "TipoSala";
            columnTipoSala.HeaderText = "Tipo de Sala";
            columnTipoSala.MinimumWidth = 8;
            columnTipoSala.Name = "columnTipoSala";
            columnTipoSala.Width = 150;
            // 
            // ColumnEntradasVendidas
            // 
            ColumnEntradasVendidas.DataPropertyName = "EntradasVendidas";
            ColumnEntradasVendidas.HeaderText = "Entradas Vendidas";
            ColumnEntradasVendidas.MinimumWidth = 8;
            ColumnEntradasVendidas.Name = "ColumnEntradasVendidas";
            ColumnEntradasVendidas.Width = 150;
            // 
            // ColumnRecaudacionTotal
            // 
            ColumnRecaudacionTotal.DataPropertyName = "RecaudacionTotal";
            dataGridViewCellStyle1.Format = "'$' #,0.00";
            ColumnRecaudacionTotal.DefaultCellStyle = dataGridViewCellStyle1;
            ColumnRecaudacionTotal.HeaderText = "Recaudación total";
            ColumnRecaudacionTotal.MinimumWidth = 8;
            ColumnRecaudacionTotal.Name = "ColumnRecaudacionTotal";
            ColumnRecaudacionTotal.Width = 150;
            // 
            // ColumnRendimiento
            // 
            ColumnRendimiento.DataPropertyName = "Rendimiento";
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
            cboRendimiento.Location = new Point(418, 83);
            cboRendimiento.Name = "cboRendimiento";
            cboRendimiento.Size = new Size(182, 33);
            cboRendimiento.TabIndex = 5;
            // 
            // cboAnio
            // 
            cboAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAnio.FormattingEnabled = true;
            cboAnio.Items.AddRange(new object[] { "2026", "2025", "2024" });
            cboAnio.Location = new Point(63, 83);
            cboAnio.Name = "cboAnio";
            cboAnio.Size = new Size(182, 33);
            cboAnio.TabIndex = 6;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(300, 83);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(112, 25);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Rendimiento";
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConsultar.Location = new Point(676, 83);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(112, 34);
            btnConsultar.TabIndex = 9;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Location = new Point(676, 404);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(12, 83);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(45, 25);
            lblAnio.TabIndex = 11;
            lblAnio.Text = "Año";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(24, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(341, 25);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Analisis anual de rendimiento de peliculas";
            // 
            // Consulta3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(lblAnio);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(lblTipo);
            Controls.Add(cboAnio);
            Controls.Add(cboRendimiento);
            Controls.Add(dgvPeliculas);
            Name = "Consulta3";
            Text = "Consulta3";
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridViewTextBoxColumn ColumnPelicula;
        private DataGridViewTextBoxColumn columnTipoSala;
        private DataGridViewTextBoxColumn ColumnEntradasVendidas;
        private DataGridViewTextBoxColumn ColumnRecaudacionTotal;
        private DataGridViewTextBoxColumn ColumnRendimiento;
        private Label lblTitulo;
    }
}