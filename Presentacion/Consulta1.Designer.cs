namespace Cine_proyecto.Presentacion
{
    partial class Consulta1
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
            panelFiltros = new Panel();
            cBoxAnio = new ComboBox();
            cBoxMes = new ComboBox();
            btnConsultar = new Button();
            label3 = new Label();
            label2 = new Label();
            panelTitulo = new Panel();
            lblTitulo = new Label();
            panelGrilla = new Panel();
            dgvResultados = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panelPie = new Panel();
            btnSalir = new Button();
            panelFiltros.SuspendLayout();
            panelTitulo.SuspendLayout();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            panelPie.SuspendLayout();
            SuspendLayout();
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(cBoxAnio);
            panelFiltros.Controls.Add(cBoxMes);
            panelFiltros.Controls.Add(btnConsultar);
            panelFiltros.Controls.Add(label3);
            panelFiltros.Controls.Add(label2);
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Location = new Point(0, 70);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(833, 60);
            panelFiltros.TabIndex = 7;
            // 
            // cBoxAnio
            // 
            cBoxAnio.FormattingEnabled = true;
            cBoxAnio.Location = new Point(295, 20);
            cBoxAnio.Name = "cBoxAnio";
            cBoxAnio.Size = new Size(120, 23);
            cBoxAnio.TabIndex = 9;
            // 
            // cBoxMes
            // 
            cBoxMes.FormattingEnabled = true;
            cBoxMes.Location = new Point(65, 20);
            cBoxMes.Name = "cBoxMes";
            cBoxMes.Size = new Size(160, 23);
            cBoxMes.TabIndex = 7;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(440, 18);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 10;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 24);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 8;
            label3.Text = "Año: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 24);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 6;
            label2.Text = "Mes:";
            // 
            // panelTitulo
            // 
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(833, 70);
            panelTitulo.TabIndex = 8;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(18, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(124, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Rendimiento por salas";
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgvResultados);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 0);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Padding = new Padding(15, 10, 15, 10);
            panelGrilla.Size = new Size(833, 318);
            panelGrilla.TabIndex = 9;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvResultados.Location = new Point(41, 159);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(559, 119);
            dgvResultados.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.FillWeight = 15F;
            Column1.HeaderText = "Nro. Sala";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 25F;
            Column2.HeaderText = "Tipo Sala";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 20F;
            Column3.HeaderText = "Cant. Funciones";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FillWeight = 20F;
            Column4.HeaderText = "Entradas Vendidas";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.FillWeight = 20F;
            Column5.HeaderText = "Promedio Entradas";
            Column5.Name = "Column5";
            // 
            // panelPie
            // 
            panelPie.Controls.Add(btnSalir);
            panelPie.Dock = DockStyle.Bottom;
            panelPie.Location = new Point(0, 318);
            panelPie.Name = "panelPie";
            panelPie.Padding = new Padding(10, 10, 20, 10);
            panelPie.Size = new Size(833, 55);
            panelPie.TabIndex = 10;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Right;
            btnSalir.Location = new Point(738, 10);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 35);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Consulta1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 373);
            Controls.Add(panelFiltros);
            Controls.Add(panelTitulo);
            Controls.Add(panelGrilla);
            Controls.Add(panelPie);
            Name = "Consulta1";
            Text = "Consulta1";
            Load += Consulta1_Load;
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            panelPie.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelFiltros;
        private Panel panelTitulo;
        private Panel panelGrilla;
        private Panel panelPie;
        private ComboBox cBoxAnio;
        private ComboBox cBoxMes;
        private Button btnConsultar;
        private Label label3;
        private Label label2;
        private Label lblTitulo;
        private Button btnSalir;
        private DataGridView dgvResultados;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}