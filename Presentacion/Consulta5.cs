using Cine_proyecto.Servicios;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace Cine_proyecto.Presentacion
{
    public partial class Consulta5 : Form
    {
        private readonly cineServicio servicio = new cineServicio();

        private Label lblTitulo;
        private Label lblIdFuncion;
        private NumericUpDown nudIdFuncion;
        private Button btnConsultar;
        private Button btnLimpiar;
        private Button btnSalir;
        private DataGridView dgvResultados;

        public Consulta5()
        {

            GenerarFormulario();
        }

        private void GenerarFormulario()
        {
            this.Text = "Consulta de ocupación por función";
            this.Size = new Size(850, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            lblTitulo = new Label();
            lblTitulo.Text = "Ocupación de funciones";
            lblTitulo.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.AutoSize = true;

            lblIdFuncion = new Label();
            lblIdFuncion.Text = "ID de función:";
            lblIdFuncion.Location = new Point(25, 75);
            lblIdFuncion.AutoSize = true;

            nudIdFuncion = new NumericUpDown();
            nudIdFuncion.Location = new Point(120, 72);
            nudIdFuncion.Minimum = 1;
            nudIdFuncion.Maximum = 999999;
            nudIdFuncion.Value = 1;

            btnConsultar = new Button();
            btnConsultar.Text = "Consultar";
            btnConsultar.Location = new Point(280, 70);
            btnConsultar.Click += btnConsultar_Click;

            btnLimpiar = new Button();
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Location = new Point(380, 70);
            btnLimpiar.Click += btnLimpiar_Click;

            btnSalir = new Button();
            btnSalir.Text = "Salir";
            btnSalir.Location = new Point(480, 70);
            btnSalir.Click += btnSalir_Click;

            dgvResultados = new DataGridView();
            dgvResultados.Location = new Point(25, 120);
            dgvResultados.Size = new Size(780, 300);
            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.ReadOnly = true;
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvResultados.Columns.Add("colIdFuncion", "ID Función");
            dgvResultados.Columns["colIdFuncion"].DataPropertyName = "idFuncion";

            dgvResultados.Columns.Add("colPelicula", "Película");
            dgvResultados.Columns["colPelicula"].DataPropertyName = "pelicula";

            dgvResultados.Columns.Add("colEntradas", "Entradas vendidas");
            dgvResultados.Columns["colEntradas"].DataPropertyName = "entradasVendidas";

            dgvResultados.Columns.Add("colCapacidad", "Capacidad");
            dgvResultados.Columns["colCapacidad"].DataPropertyName = "capacidad";

            dgvResultados.Columns.Add("colOcupacion", "Ocupación (%)");
            dgvResultados.Columns["colOcupacion"].DataPropertyName = "porcentajeOcupacion";

            this.Controls.Add(lblTitulo);
            this.Controls.Add(lblIdFuncion);
            this.Controls.Add(nudIdFuncion);
            this.Controls.Add(btnConsultar);
            this.Controls.Add(btnLimpiar);
            this.Controls.Add(btnSalir);
            this.Controls.Add(dgvResultados);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int idFuncion = (int)nudIdFuncion.Value;

            DataTable tabla = servicio.OcupacionFuncion(idFuncion);

            dgvResultados.DataSource = tabla;

            if (tabla.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron resultados para esa función.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            nudIdFuncion.Value = 1;
            dgvResultados.DataSource = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}