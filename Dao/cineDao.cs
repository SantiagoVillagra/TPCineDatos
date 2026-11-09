using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Cine_proyecto.Dao
{
    internal class cineDao
    {
        private readonly AccesoDatos acceso = new AccesoDatos();

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

        // Consulta 2 (Jose): análisis de clientes con compras recurrentes
        public DataTable AnalizarComprasClientes(int cantidadPeliculas, int cantidadEntradas)
        {
            string sql = @"EXEC dbo.pa_AnalizarComprasClientes
                    @cantidadPeliculas,
                    @cantidadEntradas";

            List<Parametro> parametros = new List<Parametro>();

            parametros.Add(new Parametro("@cantidadPeliculas", cantidadPeliculas));
            parametros.Add(new Parametro("@cantidadEntradas", cantidadEntradas));

            return acceso.ConsultarBD(sql, parametros);
        }

        // Para llenar el ComboBox de géneros
        public DataTable ObtenerGeneros()
        {
            return acceso.ConsultarBD("SELECT idGenero, nombre FROM Generos ORDER BY nombre");
        }

        // Consultas 3 a 6: se agregan acá
    }
}
