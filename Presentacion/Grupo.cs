using Cine_proyecto.Utilidades.Cine_proyecto.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Windows.Forms;

namespace Cine_proyecto.Presentacion
{
    public partial class Grupo : Form
    {
        public Grupo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grupo_Load(object sender, EventArgs e)
        {

            // Orden de acople: primero lo de arriba/abajo, el Fill al final
            panelPie.BringToFront();
            panelTitulo.BringToFront();
            panelFiltros.BringToFront();
            panelGrilla.BringToFront();

            // Estilo (igual en todos los forms)
            Estilos.AplicarForm(this);
            Estilos.AplicarTitulo(lblTitulo);
            //Estilos.AplicarBotonPrimario(consultaBtn);
            //Estilos.AplicarBotonSecundario(limpiarBtn);
            Estilos.AplicarBotonSecundario(salirBtn);
            Estilos.AplicarGrilla(dgvResultados);









            dgvResultados.Rows.Add("Alvarez", "Daniel", 430111);
            dgvResultados.Rows.Add("Iriarte", "José", 430184);
            dgvResultados.Rows.Add("Machio Steffen", "Valentina", 430309);
            dgvResultados.Rows.Add("Nievas", "Martina Elin", 430274);
            dgvResultados.Rows.Add("Poete Lafragette", "Matías", 430200);
            dgvResultados.Rows.Add("Villagra", "Santiago", 430087);

        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "SALIR",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
