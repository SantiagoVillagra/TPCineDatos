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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnConsultar = new Button();
            btnSalir = new Button();
            dgvResultados = new DataGridView();
            cBoxMes = new ComboBox();
            cBoxAnio = new ComboBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 17);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 0;
            label1.Text = "Rendimiento por salas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 69);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 0;
            label2.Text = "Mes:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 69);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Año: ";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(506, 65);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(509, 235);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvResultados.Location = new Point(25, 107);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(559, 119);
            dgvResultados.TabIndex = 5;
            // 
            // cBoxMes
            // 
            cBoxMes.FormattingEnabled = true;
            cBoxMes.Location = new Point(97, 65);
            cBoxMes.Name = "cBoxMes";
            cBoxMes.Size = new Size(121, 23);
            cBoxMes.TabIndex = 1;
            // 
            // cBoxAnio
            // 
            cBoxAnio.FormattingEnabled = true;
            cBoxAnio.Location = new Point(341, 65);
            cBoxAnio.Name = "cBoxAnio";
            cBoxAnio.Size = new Size(121, 23);
            cBoxAnio.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nro. Sala";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tipo Sala";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Cant. Funciones";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Entradas Vendidas";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Promedio Entradas";
            Column5.Name = "Column5";
            // 
            // Consulta1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 270);
            Controls.Add(cBoxAnio);
            Controls.Add(cBoxMes);
            Controls.Add(dgvResultados);
            Controls.Add(btnSalir);
            Controls.Add(btnConsultar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Consulta1";
            Text = "Consulta1";
            Load += Consulta1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnConsultar;
        private Button btnSalir;
        private DataGridView dgvResultados;
        private ComboBox cBoxMes;
        private ComboBox cBoxAnio;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}