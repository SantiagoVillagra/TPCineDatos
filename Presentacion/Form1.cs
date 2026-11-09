using Cine_proyecto.Presentacion;

namespace Cine_proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void consulta6btn_Click(object sender, EventArgs e)
        {
            Consulta6 frmC6 = new Consulta6();
            frmC6.ShowDialog();
        }

        private void consulta2btn_Click(object sender, EventArgs e)
        {
            Consulta2 frmC2 = new Consulta2();
            frmC2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consulta5 frmC5 = new Consulta5();
            frmC5.ShowDialog();
        }
    }
}
