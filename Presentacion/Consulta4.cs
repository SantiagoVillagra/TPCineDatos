//using Cine_proyecto.Servicios;
//using System;
//using System.Data;
//using System.Windows.Forms;

//namespace Cine_proyecto.Presentacion
//{
//    public partial class Consulta4 : Form
//    {
//        private readonly cineServicio servicio = new cineServicio();

//        public Consulta4()
//        {
//            InitializeComponent();
//            dgvResultados.AutoGenerateColumns = false;
//        }

//        private void btnConsultar_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                DataTable tabla = servicio.ButacasSinUso();
//                dgvResultados.DataSource = tabla;

//                if (tabla.Rows.Count == 0)
//                {
//                    MessageBox.Show("No se encontraron butacas sin reservas ni facturas en salas 2D o 3D.",
//                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("No se pudo ejecutar la consulta.\n\n" + ex.Message,
//                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void btnLimpiar_Click(object sender, EventArgs e)
//        {
//            dgvResultados.DataSource = null;
//        }

//        private void btnSalir_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }
//    }
//}

using Cine_proyecto.Servicios;
using Cine_proyecto.Utilidades;
using Cine_proyecto.Utilidades.Cine_proyecto.Utilidades;
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
            Load += Consulta4_Load; // conecta el Load por código
        }

        private void Consulta4_Load(object? sender, EventArgs e)
        {
            // Orden de acople: primero lo de arriba/abajo, el Fill al final
            panelPie.BringToFront();
            panelTitulo.BringToFront();
            panelFiltros.BringToFront();
            panelGrilla.BringToFront();

            // Estilo (igual en todos los forms)
            Estilos.AplicarForm(this);
            Estilos.AplicarTitulo(lblTitulo);
            Estilos.AplicarBotonPrimario(btnConsultar);
            Estilos.AplicarBotonSecundario(btnLimpiar);
            Estilos.AplicarBotonSecundario(btnSalir);
            Estilos.AplicarGrilla(dgvResultados);

            // Combo de tipo de sala
            cboTipoSala.Items.Clear();
            
            cboTipoSala.Items.Add("2D");
            cboTipoSala.Items.Add("3D");
            cboTipoSala.SelectedIndex = 0;

            // Reconectar eventos (se pierden al cortar/pegar en el diseñador)
            btnConsultar.Click -= btnConsultar_Click; btnConsultar.Click += btnConsultar_Click;
            btnLimpiar.Click -= btnLimpiar_Click; btnLimpiar.Click += btnLimpiar_Click;
            btnSalir.Click -= btnSalir_Click; btnSalir.Click += btnSalir_Click;


            cboTipoSala.Items.Clear();
            
            cboTipoSala.Items.Add("2D");
            cboTipoSala.Items.Add("3D");
            cboTipoSala.SelectedIndex = 0;
        }

        private void btnConsultar_Click(object? sender, EventArgs e)
        {
            try
            {
                // 0 = sin filtro de sala
                int? numeroSala = nudSala.Value > 0 ? (int)nudSala.Value : null;


                // "(Todos)" = sin filtro de tipo
                //string? tipoSala = cboTipoSala.SelectedIndex > 0
                //    ? cboTipoSala.SelectedItem?.ToString()
                //    : null;

                string? tipoSala = cboTipoSala.SelectedItem?.ToString();

                DataTable tabla = servicio.ButacasSinUso(numeroSala, tipoSala);
                dgvResultados.DataSource = tabla;
                dgvResultados.ClearSelection();

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron butacas sin uso con los filtros seleccionados.",
                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ejecutar la consulta.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            nudSala.Value = 1;
            cboTipoSala.SelectedIndex = 1;
            dgvResultados.DataSource = null;
        }

        private void btnSalir_Click(object? sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la consulta?", "SALIR",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}