//using Cine_proyecto.Servicios;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms;
//using static System.Net.WebRequestMethods;

//namespace Cine_proyecto.Presentacion
//{
//    public partial class Consulta6 : Form
//    {
//        private readonly cineServicio servicio = new cineServicio();
//        public Consulta6()
//        {
//            InitializeComponent();
//            dgvResultados.AutoGenerateColumns = false;
//            RestablecerFechas();

//        }

//        private void RestablecerFechas()
//        {
//            dtpDesde.Value = DateTime.Today;
//            dtpHasta.Value = DateTime.Today;
//        }

//        private void Consulta6_Load(object sender, EventArgs e)
//        {
//            try
//            {
//                DataTable generos = servicio.ObtenerGenerosService();

//                // Fila extra al principio que representa "sin filtro"
//                DataRow filaTodos = generos.NewRow();
//                filaTodos["idGenero"] = 0;
//                filaTodos["nombre"] = "(Todos los géneros)";
//                generos.Rows.InsertAt(filaTodos, 0);

//                cboGenero.DataSource = generos;
//                cboGenero.DisplayMember = "nombre";
//                cboGenero.ValueMember = "idGenero";
//                cboGenero.SelectedIndex = 0;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("No se pudieron cargar los géneros:\n" + ex.Message,
//                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        private void consultaBtn_Click(object sender, EventArgs e)
//        {
//            // 1) Leer lo que el usuario cargó en pantalla
//            DateTime desde = dtpDesde.Value.Date;
//            DateTime hasta = dtpHasta.Value.Date;

//            int? idGenero = null;
//            if (cboGenero.SelectedValue != null && Convert.ToInt32(cboGenero.SelectedValue) > 0)
//                idGenero = Convert.ToInt32(cboGenero.SelectedValue);

//            // Convertir el texto a número es tarea de la pantalla; si el valor es válido o no, lo decide el servicio
//            decimal? monto = null;
//            if (!string.IsNullOrWhiteSpace(montoTxt.Text))
//            {
//                if (!decimal.TryParse(montoTxt.Text.Trim(), out decimal m))
//                {
//                    MessageBox.Show("Ingrese un monto mínimo válido (número mayor o igual a 0).",
//                        "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    montoTxt.Focus();
//                    montoTxt.SelectAll();
//                    return;
//                }
//                monto = m;
//            }


//            DataTable tabla = servicio.RecaudacionSobrePromedio(desde, hasta, idGenero, monto);
//            dgvResultados.DataSource = tabla;

//            if (tabla.Rows.Count == 0)
//            {
//                MessageBox.Show("No se encontraron resultados.", "Sin resultados",
//                    MessageBoxButtons.OK, MessageBoxIcon.Information);
//            }


//        }

//        private void limpiarBtn_Click(object sender, EventArgs e)
//        {
//            RestablecerFechas();
//            cboGenero.SelectedIndex = 0;
//            montoTxt.Clear();
//            dgvResultados.DataSource = null;

//        }

//        private void salirBtn_Click(object sender, EventArgs e)
//        {
//            if (MessageBox.Show("¿Desea salir de la consulta?", "SALIR",
//               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
//               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
//            {
//                this.Close();
//            }
//        }

//        private void label2_Click(object sender, EventArgs e)
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
            // Orden de acople: primero lo de arriba/abajo, el Fill al final
            panelPie.BringToFront();
            panelTitulo.BringToFront();
            panelFiltros.BringToFront();
            panelGrilla.BringToFront();

            // Estilo (igual en todos los forms)
            Estilos.AplicarForm(this);
            Estilos.AplicarTitulo(lblTitulo);
            Estilos.AplicarBotonPrimario(consultaBtn);
            Estilos.AplicarBotonSecundario(limpiarBtn);
            Estilos.AplicarBotonSecundario(salirBtn);
            Estilos.AplicarGrilla(dgvResultados);

            // Fechas en formato corto (en largo se cortaba el texto)
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpHasta.Format = DateTimePickerFormat.Short;

            // Reconectar eventos (se pierden al cortar/pegar en el diseñador)
            consultaBtn.Click -= consultaBtn_Click; consultaBtn.Click += consultaBtn_Click;
            limpiarBtn.Click -= limpiarBtn_Click; limpiarBtn.Click += limpiarBtn_Click;
            salirBtn.Click -= salirBtn_Click; salirBtn.Click += salirBtn_Click;

            // Carga de géneros
            try
            {
                DataTable generos = servicio.ObtenerGenerosService();

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
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los géneros:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void consultaBtn_Click(object sender, EventArgs e)
        {
            // 1) Leer lo que el usuario cargó en pantalla
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;

            int? idGenero = null;
            if (cboGenero.SelectedValue != null && Convert.ToInt32(cboGenero.SelectedValue) > 0)
                idGenero = Convert.ToInt32(cboGenero.SelectedValue);

            // Convertir el texto a número es tarea de la pantalla; si el valor es válido o no, lo decide el servicio
            decimal? monto = null;
            if (!string.IsNullOrWhiteSpace(montoTxt.Text))
            {
                if (!decimal.TryParse(montoTxt.Text.Trim(), out decimal m))
                {
                    MessageBox.Show("Ingrese un monto promedio válido.",
                        "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    montoTxt.Focus();
                    montoTxt.SelectAll();
                    return;
                }
                monto = m;
            }

            DataTable tabla = servicio.RecaudacionSobrePromedio(desde, hasta, idGenero, monto);
            dgvResultados.DataSource = tabla;
            dgvResultados.ClearSelection();

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
    }
}
