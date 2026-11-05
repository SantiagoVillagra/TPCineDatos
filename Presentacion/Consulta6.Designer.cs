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
            dgvResultados = new DataGridView();
            colPelicula = new DataGridViewTextBoxColumn();
            colAnio = new DataGridViewTextBoxColumn();
            colMes = new DataGridViewTextBoxColumn();
            colEntradas = new DataGridViewTextBoxColumn();
            colMonto = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // salirBtn
            // 
            salirBtn.Location = new Point(693, 415);
            salirBtn.Name = "salirBtn";
            salirBtn.Size = new Size(75, 23);
            salirBtn.TabIndex = 0;
            salirBtn.Text = "Salir";
            salirBtn.UseVisualStyleBackColor = true;
            salirBtn.Click += salirBtn_Click;
            // 
            // consultaBtn
            // 
            consultaBtn.Location = new Point(636, 176);
            consultaBtn.Name = "consultaBtn";
            consultaBtn.Size = new Size(75, 23);
            consultaBtn.TabIndex = 1;
            consultaBtn.Text = "Consultar";
            consultaBtn.UseVisualStyleBackColor = true;
            consultaBtn.Click += consultaBtn_Click;
            // 
            // limpiarBtn
            // 
            limpiarBtn.Location = new Point(31, 415);
            limpiarBtn.Name = "limpiarBtn";
            limpiarBtn.Size = new Size(75, 23);
            limpiarBtn.TabIndex = 2;
            limpiarBtn.Text = "Limpiar";
            limpiarBtn.UseVisualStyleBackColor = true;
            limpiarBtn.Click += limpiarBtn_Click;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(56, 176);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(121, 23);
            cboGenero.TabIndex = 3;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(31, 76);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(200, 23);
            dtpDesde.TabIndex = 4;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(403, 76);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(200, 23);
            dtpHasta.TabIndex = 5;
            // 
            // montoTxt
            // 
            montoTxt.Location = new Point(363, 177);
            montoTxt.Name = "montoTxt";
            montoTxt.Size = new Size(157, 23);
            montoTxt.TabIndex = 6;
            // 
            // dgvResultados
            // 
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colPelicula, colAnio, colMes, colEntradas, colMonto });
            dgvResultados.Location = new Point(31, 250);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(737, 150);
            dgvResultados.TabIndex = 7;
            dgvResultados.CellContentClick += dgvResultados_CellContentClick;
            // 
            // colPelicula
            // 
            colPelicula.DataPropertyName = "pelicula";
            colPelicula.FillWeight = 40F;
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
            colMes.FillWeight = 8F;
            colMes.HeaderText = "Mes";
            colMes.Name = "colMes";
            // 
            // colEntradas
            // 
            colEntradas.DataPropertyName = "TotalEntradasVendidas";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N0";
            colEntradas.DefaultCellStyle = dataGridViewCellStyle3;
            colEntradas.FillWeight = 18F;
            colEntradas.HeaderText = "Entradas vendidas";
            colEntradas.Name = "colEntradas";
            // 
            // colMonto
            // 
            colMonto.DataPropertyName = "MontoTotalRecaudado";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "c2";
            colMonto.DefaultCellStyle = dataGridViewCellStyle4;
            colMonto.FillWeight = 24F;
            colMonto.HeaderText = "Monto recaudado";
            colMonto.Name = "colMonto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 58);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 8;
            label1.Text = "Fecha desde";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 58);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 9;
            label2.Text = "Fecha hasta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 153);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 10;
            label3.Text = "Generos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(363, 153);
            label4.Name = "label4";
            label4.Size = new Size(157, 15);
            label4.TabIndex = 11;
            label4.Text = "Monto promedio recaudado";
            // 
            // Consulta6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvResultados);
            Controls.Add(montoTxt);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(cboGenero);
            Controls.Add(limpiarBtn);
            Controls.Add(consultaBtn);
            Controls.Add(salirBtn);
            Name = "Consulta6";
            Text = "Consulta6";
            Load += Consulta6_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button salirBtn;
        private Button consultaBtn;
        private Button limpiarBtn;
        private ComboBox cboGenero;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private TextBox montoTxt;
        private DataGridView dgvResultados;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn colPelicula;
        private DataGridViewTextBoxColumn colAnio;
        private DataGridViewTextBoxColumn colMes;
        private DataGridViewTextBoxColumn colEntradas;
        private DataGridViewTextBoxColumn colMonto;
    }
}