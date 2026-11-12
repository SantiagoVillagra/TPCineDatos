//using Cine_proyecto.Servicios;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms;

//namespace Cine_proyecto.Presentacion
//{
//    public partial class Consulta3 : Form
//    {
//        private readonly cineServicio servicio = new cineServicio();
//        public Consulta3()
//        {
//            InitializeComponent();
//            dgvPeliculas.AutoGenerateColumns = false;
//        }

//        private void btnConsultar_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (cboAnio.SelectedItem == null)
//                {
//                    MessageBox.Show("Por favor, seleccione un año.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    return;
//                }

//                int anio = Convert.ToInt32(cboAnio.SelectedItem);
//                string rendimiento = cboRendimiento.SelectedItem != null ? cboRendimiento.SelectedItem.ToString() : "Todos";

//                DataTable tabla = servicio.ObtenerRendimientoPeliculas(anio, rendimiento);

//                dgvPeliculas.DataSource = tabla;

//                if (tabla.Rows.Count == 0)
//                {
//                    MessageBox.Show("No se encontraron registros para los filtros seleccionados.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Ocurrió un error al realizar la consulta:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void btnSalir_Click(object sender, EventArgs e)
//        {
//            if (MessageBox.Show("¿Desea salir de la consulta?", "SALIR",
//                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
//                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
//            {
//                this.Close();
//            }
//        }

//        private void lblTitulo_Click(object sender, EventArgs e)
//        {

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
    public partial class Consulta3 : Form
    {
        private readonly cineServicio servicio = new cineServicio();

        public Consulta3()
        {
            InitializeComponent();
            dgvPeliculas.AutoGenerateColumns = false;
        }

        private void Consulta3_Load(object sender, EventArgs e)
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
            Estilos.AplicarBotonSecundario(btnSalir);
            Estilos.AplicarGrilla(dgvPeliculas);

            // Reconectar eventos (se pierden al cortar/pegar en el diseñador)
            btnConsultar.Click -= btnConsultar_Click; btnConsultar.Click += btnConsultar_Click;
            btnSalir.Click -= btnSalir_Click; btnSalir.Click += btnSalir_Click;
        }

        private void btnConsultar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (cboAnio.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un año.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int anio = Convert.ToInt32(cboAnio.SelectedItem);
                string rendimiento = cboRendimiento.SelectedItem != null ? cboRendimiento.SelectedItem.ToString() : "Todos";

                DataTable tabla = servicio.ObtenerRendimientoPeliculas(anio, rendimiento);

                dgvPeliculas.DataSource = tabla;
                dgvPeliculas.ClearSelection();

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros para los filtros seleccionados.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al realizar la consulta:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvPeliculas.DataSource = null;
            cboAnio.SelectedIndex = -1;
            cboRendimiento.SelectedIndex = -1;
        }
    }
}