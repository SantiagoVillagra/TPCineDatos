namespace Cine_proyecto.Presentacion
{
    partial class Grupo
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
            salirBtn = new Button();
            panelFiltros = new Panel();
            panelTitulo = new Panel();
            lblTitulo = new Label();
            panelGrilla = new Panel();
            dgvResultados = new DataGridView();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Legajo = new DataGridViewTextBoxColumn();
            panelPie.SuspendLayout();
            panelTitulo.SuspendLayout();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // panelPie
            // 
            panelPie.Controls.Add(salirBtn);
            panelPie.Dock = DockStyle.Bottom;
            panelPie.Location = new Point(0, 395);
            panelPie.Name = "panelPie";
            panelPie.Padding = new Padding(20, 10, 20, 10);
            panelPie.Size = new Size(800, 55);
            panelPie.TabIndex = 19;
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
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Location = new Point(0, 60);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(800, 95);
            panelFiltros.TabIndex = 18;
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
            lblTitulo.Size = new Size(63, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Grupo N°3";
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
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { Apellido, Nombre, Legajo });
            dgvResultados.Location = new Point(95, 177);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(240, 150);
            dgvResultados.TabIndex = 0;
            dgvResultados.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Apellido
            // 
            Apellido.FillWeight = 40F;
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Nombre
            // 
            Nombre.FillWeight = 40F;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Legajo
            // 
            Legajo.FillWeight = 20F;
            Legajo.HeaderText = "Legajo";
            Legajo.Name = "Legajo";
            // 
            // Grupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPie);
            Controls.Add(panelFiltros);
            Controls.Add(panelTitulo);
            Controls.Add(panelGrilla);
            Name = "Grupo";
            Text = "Grupo";
            Load += Grupo_Load;
            panelPie.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPie;
        private Button salirBtn;
        private Panel panelFiltros;
        private Panel panelTitulo;
        private Label lblTitulo;
        private Panel panelGrilla;
        private DataGridView dgvResultados;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Legajo;
    }
}