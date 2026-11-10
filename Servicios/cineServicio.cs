using Cine_proyecto.Dao;
using Cine_proyecto.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Cine_proyecto.Servicios
{
    internal class cineServicio
    {
        private readonly AccesoDatos acceso = new AccesoDatos();
        private readonly cineDao dao = new cineDao();

        // Consulta 1: películas/mes con recaudación sobre el promedio
        public DataTable RecaudacionSobrePromedio(DateTime inicio, DateTime fin, int? idGenero, decimal? montoMinimo)
        {
            string sql = @"
                WITH Mensual AS (
                    SELECT * FROM dbo.fn_RecaudacionMensualPeliculasFiltrada(@inicio, @fin, @idGenero, @montoMin)
                )
                SELECT Pelicula, Anio, Mes, TotalEntradasVendidas, MontoTotalRecaudado
                FROM Mensual
                WHERE MontoTotalRecaudado > (SELECT AVG(MontoTotalRecaudado) FROM Mensual)
                ORDER BY MontoTotalRecaudado DESC";

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@inicio", inicio));
            parametros.Add(new Parametro("@fin", fin));
            // null de C# no es NULL de SQL: hay que mandar DBNull.Value
            parametros.Add(new Parametro("@idGenero", (object?)idGenero ?? DBNull.Value));
            parametros.Add(new Parametro("@montoMin", (object?)montoMinimo ?? DBNull.Value));

            return acceso.ConsultarBD(sql, parametros);
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

        // Para llenar el ComboBox de géneros
        public DataTable ObtenerGeneros()
        {
            return acceso.ConsultarBD("SELECT idGenero, nombre FROM Generos ORDER BY nombre");
        }

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

    }
}
