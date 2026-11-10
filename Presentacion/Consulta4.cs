using Cine_proyecto.Servicios;
using System;
using System.Data;
using System.Windows.Forms;

namespace Cine_proyecto.Presentacion
{
    public partial class Consulta4 : Form
    {
        private readonly cineServicio servicio = new cineServicio();

        public Consulta4()
        {
            InitializeComponent();
            dgvResultados.AutoGenerateColumns = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = servicio.ButacasSinUso();
                dgvResultados.DataSource = tabla;

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron butacas sin reservas ni facturas en salas 2D o 3D.",
                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ejecutar la consulta.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvResultados.DataSource = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}