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
//    public partial class Consulta2 : Form
//    {
//        private readonly cineServicio servicio = new cineServicio();

//        public Consulta2()
//        {
//            InitializeComponent();

//            dgvResultados.AutoGenerateColumns = false;
//        }

//        private void btnConsultar_Click(object sender, EventArgs e)
//        {
//            int cantidadPeliculas = (int)nudCantidadPeliculas.Value;
//            int cantidadEntradas = (int)nudCantidadEntradas.Value;

//            DataTable tabla = servicio.AnalizarComprasClientes(
//                cantidadPeliculas,
//                cantidadEntradas
//            );

//            dgvResultados.DataSource = tabla;

//            if (tabla.Rows.Count == 0)
//            {
//                MessageBox.Show(
//                    "No se encontraron clientes que cumplan con los criterios.",
//                    "Sin resultados",
//                    MessageBoxButtons.OK,
//                    MessageBoxIcon.Information
//                );
//            }
//        }

//        private void btnLimpiar_Click(object sender, EventArgs e)
//        {
//            nudCantidadPeliculas.Value = 1;
//            nudCantidadEntradas.Value = 1;

//            dgvResultados.DataSource = null;
//        }

//        private void btnSalir_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void Consulta2_Load(object sender, EventArgs e)
//        {

//        }

//        private void lblTituloC2_Click(object sender, EventArgs e)
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
    public partial class Consulta2 : Form
    {
        private readonly cineServicio servicio = new cineServicio();

        public Consulta2()
        {
            InitializeComponent();
            dgvResultados.AutoGenerateColumns = false;
        }

        private void Consulta2_Load(object sender, EventArgs e)
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

            // Reconectar eventos (se pierden al cortar/pegar en el diseñador)
            btnConsultar.Click -= btnConsultar_Click; btnConsultar.Click += btnConsultar_Click;
            btnLimpiar.Click -= btnLimpiar_Click; btnLimpiar.Click += btnLimpiar_Click;
            btnSalir.Click -= btnSalir_Click; btnSalir.Click += btnSalir_Click;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cantidadPeliculas = (int)nudCantidadPeliculas.Value;
            int cantidadEntradas = (int)nudCantidadEntradas.Value;

            DataTable tabla = servicio.AnalizarComprasClientes(
                cantidadPeliculas,
                cantidadEntradas
            );

            dgvResultados.DataSource = tabla;
            dgvResultados.ClearSelection();

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron clientes que cumplan con los criterios.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            nudCantidadPeliculas.Value = 1;
            nudCantidadEntradas.Value = 1;

            dgvResultados.DataSource = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la consulta?",
        "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
        MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}