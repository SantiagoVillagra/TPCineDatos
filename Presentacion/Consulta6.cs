using Cine_proyecto.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Cine_proyecto.Presentacion
{
    public partial class Consulta6 : Form
    {
        private readonly cineServicio servicio = new cineServicio();
        public Consulta6()
        {
            InitializeComponent();
            dgvResultados.AutoGenerateColumns = false;
            RestablecerFechas();

        }

        private void RestablecerFechas()
        {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
        }

        private void Consulta6_Load(object sender, EventArgs e)
        {
            DataTable generos = servicio.ObtenerGeneros();

            // Fila extra al principio que representa "sin filtro"
            DataRow filaTodos = generos.NewRow();
            filaTodos["idGenero"] = 0;
            filaTodos["nombre"] = "(Todos los géneros)";
            generos.Rows.InsertAt(filaTodos, 0);

            cboGenero.DataSource = generos;
            cboGenero.DisplayMember = "nombre";
            cboGenero.ValueMember = "idGenero";
            cboGenero.SelectedIndex = 0;
        }

        private void consultaBtn_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;




            if (desde > hasta)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que 'Hasta'.",
                    "Rango inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDesde.Focus();
                return;
            }

            int? idGenero = null;
            if (cboGenero.SelectedValue != null && Convert.ToInt32(cboGenero.SelectedValue) > 0)
            {
                idGenero = Convert.ToInt32(cboGenero.SelectedValue);
            }

            decimal? monto = null;
            if (!string.IsNullOrWhiteSpace(montoTxt.Text))
            {
                if (!decimal.TryParse(montoTxt.Text.Trim(), out decimal m) || m < 0)
                {
                    MessageBox.Show("Ingrese un monto mínimo válido (número mayor o igual a 0).",
                        "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    montoTxt.Focus();
                    montoTxt.SelectAll();
                    return;
                }
                monto = m;
            }

            // La función usa fecha fin EXCLUSIVA: sumamos 1 día para incluir el 'hasta' elegido
            DataTable tabla = servicio.RecaudacionSobrePromedio(desde, hasta.AddDays(1), idGenero, monto);
            dgvResultados.DataSource = tabla;

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados.", "Sin resultados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiarBtn_Click(object sender, EventArgs e)
        {
            RestablecerFechas();
            cboGenero.SelectedIndex = 0;
            montoTxt.Clear();
            dgvResultados.DataSource = null;

        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la consulta?", "SALIR",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
