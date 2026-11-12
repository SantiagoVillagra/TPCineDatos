namespace Cine_proyecto.Presentacion
{
    partial class Consulta6
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            salirBtn = new Button();
            consultaBtn = new Button();
            limpiarBtn = new Button();
            cboGenero = new ComboBox();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            montoTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panelGrilla = new Panel();
            panelTitulo = new Panel();
            panelFiltros = new Panel();
            panelPie = new Panel();
            lblTitulo = new Label();
            dgvResultados = new DataGridView();
            colPelicula = new DataGridViewTextBoxColumn();
            colAnio = new DataGridViewTextBoxColumn();
            colMes = new DataGridViewTextBoxColumn();
            colEntradas = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            panelGrilla.SuspendLayout();
            panelTitulo.SuspendLayout();
            panelFiltros.SuspendLayout();
            panelPie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // salirBtn
            // 
            salirBtn.Dock = DockStyle.Right;
            salirBtn.Location = new Point(826, 10);
            salirBtn.Name = "salirBtn";
            salirBtn.Size = new Size(75, 35);
            salirBtn.TabIndex = 0;
            salirBtn.Text = "Salir";
            salirBtn.UseVisualStyleBackColor = true;
            salirBtn.Click += salirBtn_Click;
            // 
            // consultaBtn
            // 
            consultaBtn.Location = new Point(695, 32);
            consultaBtn.Name = "consultaBtn";
            consultaBtn.Size = new Size(75, 23);
            consultaBtn.TabIndex = 1;
            consultaBtn.Text = "Consultar";
            consultaBtn.UseVisualStyleBackColor = true;
            consultaBtn.Click += consultaBtn_Click;
            // 
            // limpiarBtn
            // 
            limpiarBtn.Dock = DockStyle.Left;
            limpiarBtn.Location = new Point(20, 10);
            limpiarBtn.Name = "limpiarBtn";
            limpiarBtn.Size = new Size(75, 35);
            limpiarBtn.TabIndex = 2;
            limpiarBtn.Text = "Limpiar";
            limpiarBtn.UseVisualStyleBackColor = true;
            limpiarBtn.Click += limpiarBtn_Click;
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(385, 35);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(160, 23);
            cboGenero.TabIndex = 3;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(15, 35);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(170, 23);
            dtpDesde.TabIndex = 4;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(200, 35);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(170, 23);
            dtpHasta.TabIndex = 5;
            // 
            // montoTxt
            // 
            montoTxt.Location = new Point(560, 35);
            montoTxt.Name = "montoTxt";
            montoTxt.Size = new Size(120, 23);
            montoTxt.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 8;
            label1.Text = "Fecha desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 10);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 9;
            label2.Text = "Fecha hasta";
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 10);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 10;
            label3.Text = "Generos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(560, 10);
            label4.Name = "label4";
            label4.Size = new Size(157, 15);
            label4.TabIndex = 11;
            label4.Text = "Monto promedio recaudado";
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgvResultados);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 0);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Padding = new Padding(15, 10, 15, 10);
            panelGrilla.Size = new Size(921, 450);
            panelGrilla.TabIndex = 12;
            // 
            // panelTitulo
            // 
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(921, 60);
            panelTitulo.TabIndex = 13;
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(dtpDesde);
            panelFiltros.Controls.Add(consultaBtn);
            panelFiltros.Controls.Add(label4);
            panelFiltros.Controls.Add(dtpHasta);
            panelFiltros.Controls.Add(label1);
            panelFiltros.Controls.Add(cboGenero);
            panelFiltros.Controls.Add(montoTxt);
            panelFiltros.Controls.Add(label2);
            panelFiltros.Controls.Add(label3);
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Location = new Point(0, 60);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(921, 95);
            panelFiltros.TabIndex = 14;
            // 
            // panelPie
            // 
            panelPie.Controls.Add(limpiarBtn);
            panelPie.Controls.Add(salirBtn);
            panelPie.Dock = DockStyle.Bottom;
            panelPie.Location = new Point(0, 395);
            panelPie.Name = "panelPie";
            panelPie.Padding = new Padding(20, 10, 20, 10);
            panelPie.Size = new Size(921, 55);
            panelPie.TabIndex = 15;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(23, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(162, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Recaudacion sobre promedio";
            // 
            // dgvResultados
            // 
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.BorderStyle = BorderStyle.None;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colPelicula, colAnio, colMes, colEntradas, colMonto });
            dgvResultados.Location = new Point(23, 204);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(737, 150);
            dgvResultados.TabIndex = 8;
            // 
            // colPelicula
            // 
            colPelicula.DataPropertyName = "pelicula";
            colPelicula.FillWeight = 35F;
            colPelicula.HeaderText = "Película";
            colPelicula.Name = "colPelicula";
            // 
            // colAnio
            // 
            colAnio.DataPropertyName = "anio";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colAnio.DefaultCellStyle = dataGridViewCellStyle1;
            colAnio.FillWeight = 10F;
            colAnio.HeaderText = "Año";
            colAnio.Name = "colAnio";
            // 
            // colMes
            // 
            colMes.DataPropertyName = "mes";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colMes.DefaultCellStyle = dataGridViewCellStyle2;
            colMes.FillWeight = 10F;
            colMes.HeaderText = "Mes";
            colMes.Name = "colMes";
            // 
            // colEntradas
            // 
            colEntradas.DataPropertyName = "TotalEntradasVendidas";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            colEntradas.DefaultCellStyle = dataGridViewCellStyle3;
            colEntradas.FillWeight = 20F;
            colEntradas.HeaderText = "Entradas vendidas";
            colEntradas.Name = "colEntradas";
            // 
            // colMonto
            // 
            colMonto.DataPropertyName = "MontoTotalRecaudado";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "c2";
            colMonto.DefaultCellStyle = dataGridViewCellStyle4;
            colMonto.FillWeight = 25F;
            colMonto.HeaderText = "Monto recaudado";
            colMonto.Name = "colMonto";
            // 
            // Consulta6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 450);
            Controls.Add(panelPie);
            Controls.Add(panelFiltros);
            Controls.Add(panelTitulo);
            Controls.Add(panelGrilla);
            Name = "Consulta6";
            Text = "Consulta6";
            Load += Consulta6_Load;
            panelGrilla.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            panelPie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button salirBtn;
        private Button consultaBtn;
        private Button limpiarBtn;
        private ComboBox cboGenero;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private TextBox montoTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panelGrilla;
        private Panel panelTitulo;
        private Panel panelFiltros;
        private Panel panelPie;
        private Label lblTitulo;
        private DataGridView dgvResultados;
        private DataGridViewTextBoxColumn colPelicula;
        private DataGridViewTextBoxColumn colAnio;
        private DataGridViewTextBoxColumn colMes;
        private DataGridViewTextBoxColumn colEntradas;
        private DataGridViewTextBoxColumn colMonto;
    }
}