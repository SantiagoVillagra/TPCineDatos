namespace Cine_proyecto.Presentacion
{
    partial class Consulta5
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
            panelPie = new Panel();
            limpiarBtn = new Button();
            salirBtn = new Button();
            panelFiltros = new Panel();
            nudIdFuncion = new NumericUpDown();
            consultaBtn = new Button();
            lblIdFuncion = new Label();
            panelTitulo = new Panel();
            lblTitulo = new Label();
            panelGrilla = new Panel();
            dgvResultados = new DataGridView();
            colIdFuncion = new DataGridViewTextBoxColumn();
            colPelicula = new DataGridViewTextBoxColumn();
            colEntradas = new DataGridViewTextBoxColumn();
            colCapacidad = new DataGridViewTextBoxColumn();
            colOcupacion = new DataGridViewTextBoxColumn();
            panelPie.SuspendLayout();
            panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIdFuncion).BeginInit();
            panelTitulo.SuspendLayout();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // panelPie
            // 
            panelPie.Controls.Add(limpiarBtn);
            panelPie.Controls.Add(salirBtn);
            panelPie.Dock = DockStyle.Bottom;
            panelPie.Location = new Point(0, 395);
            panelPie.Name = "panelPie";
            panelPie.Padding = new Padding(20, 10, 20, 10);
            panelPie.Size = new Size(800, 55);
            panelPie.TabIndex = 19;
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
            // salirBtn
            // 
            salirBtn.Dock = DockStyle.Right;
            salirBtn.Location = new Point(705, 10);
            salirBtn.Name = "salirBtn";
            salirBtn.Size = new Size(75, 35);
            salirBtn.TabIndex = 0;
            salirBtn.Text = "Salir";
            salirBtn.UseVisualStyleBackColor = true;
            salirBtn.Click += salirBtn_Click;
            // 
            // panelFiltros
            // 
            panelFiltros.Controls.Add(nudIdFuncion);
            panelFiltros.Controls.Add(consultaBtn);
            panelFiltros.Controls.Add(lblIdFuncion);
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Location = new Point(0, 60);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(800, 95);
            panelFiltros.TabIndex = 18;
            // 
            // nudIdFuncion
            // 
            nudIdFuncion.Location = new Point(18, 36);
            nudIdFuncion.Name = "nudIdFuncion";
            nudIdFuncion.Size = new Size(120, 23);
            nudIdFuncion.TabIndex = 10;
            // 
            // consultaBtn
            // 
            consultaBtn.Location = new Point(349, 34);
            consultaBtn.Name = "consultaBtn";
            consultaBtn.Size = new Size(75, 23);
            consultaBtn.TabIndex = 1;
            consultaBtn.Text = "Consultar";
            consultaBtn.UseVisualStyleBackColor = true;
            consultaBtn.Click += consultaBtn_Click;
            // 
            // lblIdFuncion
            // 
            lblIdFuncion.AutoSize = true;
            lblIdFuncion.Location = new Point(15, 10);
            lblIdFuncion.Name = "lblIdFuncion";
            lblIdFuncion.Size = new Size(81, 15);
            lblIdFuncion.TabIndex = 8;
            lblIdFuncion.Text = "ID de función:";
            // 
            // panelTitulo
            // 
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(800, 60);
            panelTitulo.TabIndex = 17;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(23, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(136, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ocupacion de funciones";
            lblTitulo.UseMnemonic = false;
            // 
            // panelGrilla
            // 
            panelGrilla.Controls.Add(dgvResultados);
            panelGrilla.Dock = DockStyle.Fill;
            panelGrilla.Location = new Point(0, 0);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Padding = new Padding(15, 10, 15, 10);
            panelGrilla.Size = new Size(800, 450);
            panelGrilla.TabIndex = 16;
            // 
            // dgvResultados
            // 
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.BorderStyle = BorderStyle.None;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { colIdFuncion, colPelicula, colEntradas, colCapacidad, colOcupacion });
            dgvResultados.Location = new Point(15, 161);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(770, 160);
            dgvResultados.TabIndex = 8;
            // 
            // colIdFuncion
            // 
            colIdFuncion.DataPropertyName = "idFuncion";
            colIdFuncion.HeaderText = "ID Función";
            colIdFuncion.Name = "colIdFuncion";
            // 
            // colPelicula
            // 
            colPelicula.DataPropertyName = "pelicula";
            colPelicula.HeaderText = "Película";
            colPelicula.Name = "colPelicula";
            // 
            // colEntradas
            // 
            colEntradas.DataPropertyName = "entradasVendidas";
            colEntradas.HeaderText = "Entradas Vendidas";
            colEntradas.Name = "colEntradas";
            // 
            // colCapacidad
            // 
            colCapacidad.DataPropertyName = "capacidad";
            colCapacidad.HeaderText = "Capacidad";
            colCapacidad.Name = "colCapacidad";
            // 
            // colOcupacion
            // 
            colOcupacion.DataPropertyName = "porcentajeOcupacion";
            colOcupacion.HeaderText = "Ocupacion (%)";
            colOcupacion.Name = "colOcupacion";
            // 
            // Consulta5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPie);
            Controls.Add(panelFiltros);
            Controls.Add(panelTitulo);
            Controls.Add(panelGrilla);
            Name = "Consulta5";
            Text = "Consulta5";
            panelPie.ResumeLayout(false);
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIdFuncion).EndInit();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPie;
        private Button limpiarBtn;
        private Button salirBtn;
        private Panel panelFiltros;
        private Button consultaBtn;
        private Label lblIdFuncion;
        private Panel panelTitulo;
        private Label lblTitulo;
        private Panel panelGrilla;
        private DataGridView dgvResultados;
        private NumericUpDown nudIdFuncion;
        private DataGridViewTextBoxColumn colIdFuncion;
        private DataGridViewTextBoxColumn colPelicula;
        private DataGridViewTextBoxColumn colEntradas;
        private DataGridViewTextBoxColumn colCapacidad;
        private DataGridViewTextBoxColumn colOcupacion;
    }
}