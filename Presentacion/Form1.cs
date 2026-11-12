
using Cine_proyecto.Presentacion;

namespace Cine_proyecto
{
    public partial class Form1 : Form
    {
        private Form? formActivo;

        // Paleta de colores: se cambia acá y afecta a todo el menú
        private readonly Color colorHeader = Color.FromArgb(20, 20, 30);
        private readonly Color colorMenu = Color.FromArgb(30, 30, 40);
        private readonly Color colorSubmenu = Color.FromArgb(40, 40, 55);
        private readonly Color colorHover = Color.FromArgb(60, 60, 80);

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true; // evita parpadeos
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Orden de acople de los paneles principales
            panelHeader.SendToBack();        // se acopla primero (arriba)
            panelContenedor.BringToFront();  // se acopla último (rellena el resto)

            // Header
            panelHeader.BackColor = colorHeader;
            lblTitulo.Text = "CINE - Consultas";
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.AutoSize = false;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            lblTitulo.Padding = new Padding(15, 0, 0, 0);

            // Menú lateral
            panelMenu.BackColor = colorMenu;

            EstilizarBotonMenu(btnInicio, colorMenu, 45, 15);
            EstilizarBotonMenu(btnConsultas, colorMenu, 45, 15);
            EstilizarBotonMenu(btnDatosGrupo, colorMenu, 45, 15);
            EstilizarBotonMenu(btnSalir, colorMenu, 45, 15);
            btnSalir.Dock = DockStyle.Bottom;

            // Submenú de consultas
            Button[] botonesConsulta =
            {
                btnConsulta1, consulta2btn, btnConsulta3,
                consulta4btn, button1, consulta6btn
            };

            // Reconectar los eventos Click (se perdieron al cortar/pegar en el diseñador)
            btnConsulta1.Click -= btnConsulta1_Click; btnConsulta1.Click += btnConsulta1_Click;
            consulta2btn.Click -= consulta2btn_Click; consulta2btn.Click += consulta2btn_Click;
            btnConsulta3.Click -= btnConsulta3_Click; btnConsulta3.Click += btnConsulta3_Click;
            consulta4btn.Click -= consulta4btn_Click; consulta4btn.Click += consulta4btn_Click;
            button1.Click -= button1_Click; button1.Click += button1_Click;
            consulta6btn.Click -= consulta6btn_Click; consulta6btn.Click += consulta6btn_Click;
            foreach (Button b in botonesConsulta)
                EstilizarBotonMenu(b, colorSubmenu, 40, 35);

            OrdenarDeArribaAbajo(botonesConsulta);

            panelSubmenuConsultas.Dock = DockStyle.Top;
            panelSubmenuConsultas.BackColor = colorSubmenu;
            panelSubmenuConsultas.Height = botonesConsulta.Length * 40;
            panelSubmenuConsultas.Visible = false;

            // Orden vertical del menú
            OrdenarDeArribaAbajo(btnInicio, btnConsultas, panelSubmenuConsultas, btnDatosGrupo);
        }

        // ---------- Helpers de estilo y orden ----------

        private void EstilizarBotonMenu(Button btn, Color fondo, int alto, int sangria)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = colorHover;
            btn.UseVisualStyleBackColor = false;
            btn.BackColor = fondo;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10F);
            btn.Dock = DockStyle.Top;
            btn.Height = alto;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(sangria, 0, 0, 0);
            btn.Cursor = Cursors.Hand;
        }

        // Con Dock = Top el orden visual depende del z-order; esto lo deja de arriba hacia abajo
        private void OrdenarDeArribaAbajo(params Control[] controles)
        {
            foreach (Control c in controles)
                c.BringToFront();
        }

        // ---------- Carga de forms dentro del panel ----------

        private void AbrirFormEnPanel(Form hijo)
        {
            CerrarFormActivo(); // cierra el anterior de forma segura
            formActivo = hijo;

            // Si el hijo se cierra por su cuenta (ej. su botón Salir), limpiamos la referencia
            hijo.FormClosed += (s, e) =>
            {
                if (formActivo == hijo)
                    formActivo = null;
            };

            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(hijo);
            hijo.BringToFront();
            hijo.Show();
        }

        private void CerrarFormActivo()
        {
            // Solo cierra si existe y no fue cerrado/destruido antes
            if (formActivo != null && !formActivo.IsDisposed)
                formActivo.Close();

            formActivo = null;
        }

        // ---------- Menú ----------

        private void btnInicio_Click(object sender, EventArgs e)
        {
            CerrarFormActivo(); // vuelve a mostrarse la imagen de fondo
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            panelSubmenuConsultas.Visible = !panelSubmenuConsultas.Visible;
        }

        private void btnDatosGrupo_Click(object sender, EventArgs e)
        {
            
            AbrirFormEnPanel(new Grupo());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea salir de la aplicacion?", "SALIR",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Consulta1());
        }

        private void consulta2btn_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Consulta2());
        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Consulta3());
        }

        private void consulta4btn_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Consulta4());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Consulta5());
        }

        private void consulta6btn_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Consulta6());
        }
    }
}



//using Cine_proyecto.Presentacion;

//namespace Cine_proyecto
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void consulta6btn_Click(object sender, EventArgs e)
//        {
//            Consulta6 frmC6 = new Consulta6();
//            frmC6.ShowDialog();
//        }

//        private void consulta2btn_Click(object sender, EventArgs e)
//        {
//            Consulta2 frmC2 = new Consulta2();
//            frmC2.ShowDialog();
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {

//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            Consulta5 frmC5 = new Consulta5();
//            frmC5.ShowDialog();
//        }

//        private void btnConsulta1_Click(object sender, EventArgs e)
//        {
//            Consulta1 frmC1 = new Consulta1();
//            frmC1.ShowDialog();
//        }

//        private void consulta4btn_Click(object sender, EventArgs e)
//        {
//            Consulta4 frmC4 = new Consulta4();
//            frmC4.ShowDialog();
//        }

//        private void btnConsulta3_Click(object sender, EventArgs e)
//        {
//            Consulta3 ventana = new Consulta3();
//            ventana.ShowDialog();
//        }

//        private void panelMenu_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void btnInicio_Click(object sender, EventArgs e)
//        {

//        }

//        private void btnConsultas_Click(object sender, EventArgs e)
//        {

//        }

//        private void btnDatosGrupo_Click(object sender, EventArgs e)
//        {

//        }

//        private void btnSalir_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}