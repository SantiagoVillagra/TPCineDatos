using Cine_proyecto.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int cantidadPeliculas = (int)nudCantidadPeliculas.Value;
            int cantidadEntradas = (int)nudCantidadEntradas.Value;

            DataTable tabla = servicio.AnalizarComprasClientes(
                cantidadPeliculas,
                cantidadEntradas
            );

            dgvResultados.DataSource = tabla;

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
            this.Close();
        }
    }
}
