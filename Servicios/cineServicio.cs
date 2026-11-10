using Cine_proyecto.Dao;
using Cine_proyecto.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace Cine_proyecto.Servicios
{
    internal class cineServicio
    {
        private readonly AccesoDatos acceso = new AccesoDatos();
        private readonly cineDao dao = new cineDao();

        // Consulta 1 (Daniel): 
        public List<DgvConsulta1> TraerConsulta1(int mes, int anio)
        {
            DataTable respuesta = acceso.ConsultarBD($"EXEC sp_RendimientoSalas @mes = {mes}, @anio = {anio}");
            List<DgvConsulta1> lConsulta1 = new List<DgvConsulta1>();

            foreach (DataRow r in respuesta.Rows)
            {
                DgvConsulta1 filaConsulta = new DgvConsulta1();
                filaConsulta.NumeroSala = (int)r[0];
                filaConsulta.TipoSala = (string)r[1];
                filaConsulta.CantFunciones = (int)r[2];
                filaConsulta.EntradasVendidas = (int)r[3];
                filaConsulta.Promedioentradas = (decimal)r[4];

                lConsulta1.Add(filaConsulta);
            }

            return lConsulta1;
        }



        // Consulta 2 (Jose): análisis de clientes
        public DataTable AnalizarComprasClientes(
            int cantidadPeliculas,
            int cantidadEntradas)
        {
            return dao.AnalizarComprasClientes(
                cantidadPeliculas, cantidadEntradas);
        }



        // Consulta 5 (Matias): porcentaje de ocupación de una función
        public DataTable OcupacionFuncion(int idFuncion)
        {
            return dao.OcupacionFuncion(idFuncion);
        }


        // Consulta 6 (Santiago): películas/mes con recaudación sobre el promedio

        public DataTable ObtenerGenerosService()
        {
            return dao.ObtenerGeneros();
        }
        public DataTable RecaudacionSobrePromedio(DateTime inicio, DateTime fin, int? idGenero, decimal? montoMinimo)
        {

            if (inicio.Date > fin.Date)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser mayor que la fecha 'Hasta'.",
                            "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            return dao.RecaudacionSobrePromedio(inicio.Date, fin.Date.AddDays(1), idGenero, montoMinimo);
        }
    }
}
