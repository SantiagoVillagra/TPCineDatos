using Cine_proyecto.Negocio;
using Cine_proyecto.Servicios;
using Cine_proyecto.Utilidades;
using Cine_proyecto.Utilidades.Cine_proyecto.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cine_proyecto.Presentacion
{
    public partial class Consulta1 : Form
    {
        cineServicio servicio;
        public Consulta1()
        {
            InitializeComponent();
            servicio = new cineServicio();
        }

        private void Consulta1_Load(object sender, EventArgs e)
        {
            panelPie.BringToFront();
            panelTitulo.BringToFront();
            panelFiltros.BringToFront();
            panelGrilla.BringToFront();


            // Estilo (siempre igual en todos los forms)
            Estilos.AplicarForm(this);
            Estilos.AplicarTitulo(lblTitulo);
            Estilos.AplicarBotonPrimario(btnConsultar);
            Estilos.AplicarBotonSecundario(btnSalir);
            Estilos.AplicarGrilla(dgvResultados);

            // Lo que ya tenías
            cargarCombos();
            cBoxMes.SelectedIndex = 0;
            cBoxAnio.SelectedItem = DateTime.Now.Year.ToString();
            //cBoxAnio.SelectedItem = DateTime.Now.Year;


        }


        private void cargarCombos()
        {
            List<Mes> meses = new List<Mes>
            {
                new Mes { idMes = 1 , nombreMes = "Enero" },
                new Mes { idMes = 2 , nombreMes = "Febrero" },
                new Mes { idMes = 3 , nombreMes = "Marzo" },
                new Mes { idMes = 4 , nombreMes = "Abril" },
                new Mes { idMes = 5 , nombreMes = "Mayo" },
                new Mes { idMes = 6 , nombreMes = "Junio" },
                new Mes { idMes = 7 , nombreMes = "Julio" },
                new Mes { idMes = 8 , nombreMes = "Agosto" },
                new Mes { idMes = 9 , nombreMes = "Septiembre" },
                new Mes { idMes = 10 , nombreMes = "Octubre" },
                new Mes { idMes = 11 , nombreMes = "Noviembre" },
                new Mes { idMes = 12 , nombreMes = "Diciembre" }
            };

            cBoxMes.DataSource = meses;
            cBoxMes.DisplayMember = "nombreMes";
            cBoxMes.ValueMember = "idMes";

            int anio = DateTime.Now.Year;

            for (int i = 2024; i <= anio; i++)
            {
                cBoxAnio.Items.Add(i);
            }
        }
        private bool validar()
        {
            if (cBoxMes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un mes!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBoxMes.Focus();
                return false;
            }
            if (cBoxAnio.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un año!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBoxAnio.Focus();
                return false;
            }
            return true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                int mes = (int)cBoxMes.SelectedValue;
                int anio = (int)cBoxAnio.SelectedItem;

                List<DgvConsulta1> lConsulta1 = servicio.TraerConsulta1(mes, anio);

                dgvResultados.Rows.Clear();
                foreach (DgvConsulta1 d in lConsulta1)
                {
                    dgvResultados.Rows.Add(d.NumeroSala, d.TipoSala, d.CantFunciones, d.EntradasVendidas, d.Promedioentradas);
                }
                if (lConsulta1.Count == 0)
                    MessageBox.Show("No hay datos para el período seleccionado.", "Sin resultados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
