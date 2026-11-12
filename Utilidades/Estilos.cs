using System;
using System.Collections.Generic;
using System.Text;

namespace Cine_proyecto.Utilidades
{
    namespace Cine_proyecto.Utilidades
    {
        public static class Estilos
        {
            // Paleta: se cambia acá y afecta a todos los forms
            public static readonly Color ColorPrimario = Color.FromArgb(20, 20, 30);
            public static readonly Color ColorAcento = Color.FromArgb(200, 40, 50);
            public static readonly Color ColorFondo = Color.White;
            public static readonly Color ColorFilaAlterna = Color.FromArgb(245, 245, 250);
            public static readonly Color ColorSeleccion = Color.FromArgb(60, 60, 80);

            public static readonly Font FuenteBase = new Font("Segoe UI", 10F);

            // Form: fondo y fuente comunes
            public static void AplicarForm(Form f)
            {
                f.BackColor = ColorFondo;
                f.Font = FuenteBase;
            }

            // Título de cada consulta
            public static void AplicarTitulo(Label lbl)
            {
                lbl.AutoSize = false;
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Padding = new Padding(15, 0, 0, 0);
                lbl.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
                lbl.ForeColor = ColorPrimario;
            }

            // Botón principal (Consultar, Buscar, etc.)
            public static void AplicarBotonPrimario(Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.UseVisualStyleBackColor = false;
                btn.BackColor = ColorPrimario;
                btn.ForeColor = Color.White;
                btn.Font = FuenteBase;
                btn.Size = new Size(110, 32);
                btn.Cursor = Cursors.Hand;
            }

            // Botón secundario (Salir, Cancelar)
            public static void AplicarBotonSecundario(Button btn)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = ColorPrimario;
                btn.FlatAppearance.BorderSize = 1;
                btn.UseVisualStyleBackColor = false;
                btn.BackColor = Color.White;
                btn.ForeColor = ColorPrimario;
                btn.Font = FuenteBase;
                btn.Size = new Size(110, 32);
                btn.Cursor = Cursors.Hand;
            }

            // Grilla: misma apariencia y comportamiento en todos los forms
            public static void AplicarGrilla(DataGridView dgv)
            {
                dgv.Dock = DockStyle.Fill;

                // Proporciones: las columnas se reparten el ancho disponible
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.AllowUserToResizeColumns = false;
                dgv.AllowUserToResizeRows = false;

                // Comportamiento
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.ReadOnly = true;
                dgv.RowHeadersVisible = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.MultiSelect = false;

                // Apariencia general
                dgv.BackgroundColor = ColorFondo;
                dgv.BorderStyle = BorderStyle.None;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgv.GridColor = Color.FromArgb(220, 220, 225);
                dgv.RowTemplate.Height = 30;

                // Encabezado
                dgv.EnableHeadersVisualStyles = false;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dgv.ColumnHeadersHeight = 40;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = ColorPrimario;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorPrimario;

                // Filas
                dgv.DefaultCellStyle.Font = FuenteBase;
                dgv.DefaultCellStyle.SelectionBackColor = ColorSeleccion;
                dgv.DefaultCellStyle.SelectionForeColor = Color.White;
                dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = ColorFilaAlterna;

                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;          // sin flechita
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // pisa la alineación derecha
                }
            }

        }
    }
}
