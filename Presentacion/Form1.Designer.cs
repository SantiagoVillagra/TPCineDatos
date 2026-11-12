namespace Cine_proyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitulo = new Label();
            panelMenu = new Panel();
            panelSubmenuConsultas = new Panel();
            btnConsulta1 = new Button();
            consulta6btn = new Button();
            consulta2btn = new Button();
            button1 = new Button();
            btnConsulta3 = new Button();
            consulta4btn = new Button();
            btnSalir = new Button();
            btnDatosGrupo = new Button();
            btnConsultas = new Button();
            btnInicio = new Button();
            panelContenedor = new Panel();
            panelHeader.SuspendLayout();
            panelMenu.SuspendLayout();
            panelSubmenuConsultas.SuspendLayout();
            panelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(239, 60);
            panelHeader.TabIndex = 6;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(21, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(31, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cine";
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(panelHeader);
            panelMenu.Controls.Add(panelSubmenuConsultas);
            panelMenu.Controls.Add(btnSalir);
            panelMenu.Controls.Add(btnDatosGrupo);
            panelMenu.Controls.Add(btnConsultas);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(239, 681);
            panelMenu.TabIndex = 7;
            // 
            // panelSubmenuConsultas
            // 
            panelSubmenuConsultas.Controls.Add(btnConsulta1);
            panelSubmenuConsultas.Controls.Add(consulta6btn);
            panelSubmenuConsultas.Controls.Add(consulta2btn);
            panelSubmenuConsultas.Controls.Add(button1);
            panelSubmenuConsultas.Controls.Add(btnConsulta3);
            panelSubmenuConsultas.Controls.Add(consulta4btn);
            panelSubmenuConsultas.Location = new Point(12, 354);
            panelSubmenuConsultas.Name = "panelSubmenuConsultas";
            panelSubmenuConsultas.Size = new Size(224, 306);
            panelSubmenuConsultas.TabIndex = 11;
            // 
            // btnConsulta1
            // 
            btnConsulta1.BackgroundImageLayout = ImageLayout.Center;
            btnConsulta1.Location = new Point(42, 48);
            btnConsulta1.Name = "btnConsulta1";
            btnConsulta1.Size = new Size(141, 30);
            btnConsulta1.TabIndex = 9;
            btnConsulta1.Text = "Rendimiento de Salas";
            btnConsulta1.UseVisualStyleBackColor = true;
            btnConsulta1.Click += btnConsulta1_Click;
            // 
            // consulta6btn
            // 
            consulta6btn.Location = new Point(42, 228);
            consulta6btn.Name = "consulta6btn";
            consulta6btn.Size = new Size(141, 30);
            consulta6btn.TabIndex = 6;
            consulta6btn.Text = "Ingreso por Película";
            consulta6btn.UseVisualStyleBackColor = true;
            consulta6btn.Click += consulta6btn_Click;
            // 
            // consulta2btn
            // 
            consulta2btn.Location = new Point(42, 84);
            consulta2btn.Name = "consulta2btn";
            consulta2btn.Size = new Size(141, 30);
            consulta2btn.TabIndex = 7;
            consulta2btn.Text = "Compras Recurrentes";
            consulta2btn.UseVisualStyleBackColor = true;
            consulta2btn.Click += consulta2btn_Click;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(42, 192);
            button1.Name = "button1";
            button1.Size = new Size(141, 30);
            button1.TabIndex = 8;
            button1.Text = "Ocupación  Funciones";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnConsulta3
            // 
            btnConsulta3.BackgroundImageLayout = ImageLayout.Center;
            btnConsulta3.Location = new Point(42, 120);
            btnConsulta3.Name = "btnConsulta3";
            btnConsulta3.Size = new Size(141, 30);
            btnConsulta3.TabIndex = 11;
            btnConsulta3.Text = "Rendimiento Ventas";
            btnConsulta3.UseVisualStyleBackColor = true;
            btnConsulta3.Click += btnConsulta3_Click;
            // 
            // consulta4btn
            // 
            consulta4btn.BackgroundImageLayout = ImageLayout.Center;
            consulta4btn.Location = new Point(42, 156);
            consulta4btn.Name = "consulta4btn";
            consulta4btn.Size = new Size(141, 30);
            consulta4btn.TabIndex = 10;
            consulta4btn.Text = "Uso de Butacas";
            consulta4btn.UseVisualStyleBackColor = true;
            consulta4btn.Click += consulta4btn_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(124, 325);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnDatosGrupo
            // 
            btnDatosGrupo.Location = new Point(110, 269);
            btnDatosGrupo.Name = "btnDatosGrupo";
            btnDatosGrupo.Size = new Size(75, 23);
            btnDatosGrupo.TabIndex = 9;
            btnDatosGrupo.Text = "Datos del grupo";
            btnDatosGrupo.UseVisualStyleBackColor = true;
            btnDatosGrupo.Click += btnDatosGrupo_Click;
            // 
            // btnConsultas
            // 
            btnConsultas.Location = new Point(78, 240);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Size = new Size(75, 23);
            btnConsultas.TabIndex = 8;
            btnConsultas.Text = "Consultas";
            btnConsultas.UseVisualStyleBackColor = true;
            btnConsultas.Click += btnConsultas_Click;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(87, 189);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(75, 23);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(30, 30, 40);
            panelContenedor.BackgroundImage = Properties.Resources.cineImg;
            panelContenedor.BackgroundImageLayout = ImageLayout.Zoom;
            panelContenedor.Controls.Add(panelMenu);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1264, 681);
            panelContenedor.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelContenedor);
            MinimumSize = new Size(1024, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CINE";
            Load += Form1_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelSubmenuConsultas.ResumeLayout(false);
            panelContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Panel panelMenu;
        private Panel panelContenedor;
        private Label lblTitulo;
        private Button btnSalir;
        private Button btnDatosGrupo;
        private Button btnConsultas;
        private Button btnInicio;
        private Panel panelSubmenuConsultas;
        private Button btnConsulta1;
        private Button consulta6btn;
        private Button consulta2btn;
        private Button button1;
        private Button btnConsulta3;
        private Button consulta4btn;
        private Panel panel1;
       
    }
}
