//using Cine_proyecto.Servicios;
//using Cine_proyecto.Utilidades.Cine_proyecto.Utilidades; // Ajusta según el namespace exacto de tu clase Estilos
//using System;
//using System.Data;
//using System.Drawing;
//using System.Windows.Forms;

//namespace Cine_proyecto.Presentacion
//{
//    public partial class Consulta5 : Form
//    {
//        private readonly cineServicio servicio = new cineServicio();

//        public Consulta5()
//        {
//            InitializeComponent();
//            ConfigurarFormulario();
//        }

//        private void ConfigurarFormulario()
//        {
//            // 1. Aplicar estilos generales definidos en tu clase Estilos
//            Estilos.AplicarForm(this);
//            Estilos.AplicarTitulo(lblTitulo);
//            Estilos.AplicarBotonPrimario(consultaBtn);
//            Estilos.AplicarBotonSecundario(limpiarBtn);
//            Estilos.AplicarBotonSecundario(salirBtn);
//            Estilos.AplicarGrilla(dgvResultados);

//            // 2. Configurar las columnas de la grilla de forma programática
//            ConfigurarColumnasGrilla();
//        }

//        private void ConfigurarColumnasGrilla()
//        {
//            dgvResultados.Columns.Clear();
//            dgvResultados.AutoGenerateColumns = false;

//            dgvResultados.Columns.Add(new DataGridViewTextBoxColumn()
//            {
//                Name = "colIdFuncion",
//                HeaderText = "ID Función",
//                DataPropertyName = "idFuncion"
//            });

//            dgvResultados.Columns.Add(new DataGridViewTextBoxColumn()
//            {
//                Name = "colPelicula",
//                HeaderText = "Película",
//                DataPropertyName = "pelicula"
//            });

//            dgvResultados.Columns.Add(new DataGridViewTextBoxColumn()
//            {
//                Name = "colEntradas",
//                HeaderText = "Entradas vendidas",
//                DataPropertyName = "entradasVendidas"
//            });

//            dgvResultados.Columns.Add(new DataGridViewTextBoxColumn()
//            {
//                Name = "colCapacidad",
//                HeaderText = "Capacidad",
//                DataPropertyName = "capacidad"
//            });

//            dgvResultados.Columns.Add(new DataGridViewTextBoxColumn()
//            {
//                Name = "colOcupacion",
//                HeaderText = "Ocupación (%)",
//                DataPropertyName = "porcentajeOcupacion"
//            });
//        }

//        private void consultaBtn_Click(object sender, EventArgs e)
//        {
//            //int idFuncion = (int)nudIdFuncion.Value;

//            //// Llamada al servicio con tu base de datos
//            //DataTable tabla = servicio.OcupacionFuncion(idFuncion);

//            //dgvResultados.DataSource = tabla;

//            //if (tabla == null || tabla.Rows.Count == 0)
//            //{
//            //    MessageBox.Show(
//            //        "No se encontraron resultados para esa función.",
//            //        "Sin resultados",
//            //        MessageBoxButtons.OK,
//            //        MessageBoxIcon.Information
//            //    );
//            //}
//            int idFuncion = (int)nudIdFuncion.Value;

//            DataTable tabla = servicio.OcupacionFuncion(idFuncion);

//            // Asignamos los datos
//            dgvResultados.DataSource = tabla;

//            // Forzamos la aplicación de estilos a las columnas generadas
//            Estilos.AplicarGrilla(dgvResultados);

//            if (tabla == null || tabla.Rows.Count == 0)
//            {
//                MessageBox.Show(
//                    "No se encontraron resultados para esa función.",
//                    "Sin resultados",
//                    MessageBoxButtons.OK,
//                    MessageBoxIcon.Information
//                );
//            }



//        }

//        private void limpiarBtn_Click(object sender, EventArgs e)
//        {
//            nudIdFuncion.Value = nudIdFuncion.Minimum;
//            dgvResultados.DataSource = null;
//        }

//        private void salirBtn_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }
//    }
//}

using Cine_proyecto.Servicios;
using Cine_proyecto.Utilidades.Cine_proyecto.Utilidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace Cine_proyecto.Presentacion
{
    public partial class Consulta5 : Form
    {
        private readonly cineServicio servicio = new cineServicio();

        public Consulta5()
        {
            InitializeComponent();
            dgvResultados.AutoGenerateColumns = false;
            Load += Consulta5_Load; // conecta el Load por código
        }

        private void Consulta5_Load(object? sender, EventArgs e)
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

            // Reconectar eventos (se pierden al cortar/pegar en el diseñador)
            consultaBtn.Click -= consultaBtn_Click; consultaBtn.Click += consultaBtn_Click;
            limpiarBtn.Click -= limpiarBtn_Click; limpiarBtn.Click += limpiarBtn_Click;
            salirBtn.Click -= salirBtn_Click; salirBtn.Click += salirBtn_Click;
        }

        private void consultaBtn_Click(object? sender, EventArgs e)
        {
            try
            {
                int idFuncion = (int)nudIdFuncion.Value;

                DataTable tabla = servicio.OcupacionFuncion(idFuncion);

                dgvResultados.DataSource = tabla;
                dgvResultados.ClearSelection();

                if (tabla == null || tabla.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron resultados para esa función.",
                        "Sin resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo ejecutar la consulta.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarBtn_Click(object? sender, EventArgs e)
        {
            nudIdFuncion.Value = nudIdFuncion.Minimum;
            dgvResultados.DataSource = null;
        }

        private void salirBtn_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}