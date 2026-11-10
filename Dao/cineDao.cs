using Cine_proyecto.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Cine_proyecto.Dao
{
    internal class cineDao
    {
        private readonly AccesoDatos acceso = new AccesoDatos();

        //// Consulta 1 (Daniel): 
     
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

        // Consulta 4 (Martina): butacas de salas 2D/3D sin reservas ni facturas
        public DataTable ButacasSinUso()
        {
        string sql = @"
            SELECT NumeroSala, TipoSala, FilaButaca, NumeroButaca, TotalReservas, TotalVentas
            FROM vw_UsoButacasSalas
            WHERE TotalReservas = 0
              AND TotalVentas = 0
              AND idSala IN (
                  SELECT s.idSala
                  FROM Salas s
                  INNER JOIN TiposSala ts ON s.idTipoSala = ts.idTipoSala
                  WHERE ts.descripcion IN ('2D', '3D')
              )
        ORDER BY NumeroSala, FilaButaca, NumeroButaca";

    return acceso.ConsultarBD(sql);
}

        // Consulta 5 (Matias): Filtro ID porcentaje de ocupación de una función
        public DataTable OcupacionFuncion(int idFuncion)
        {
            string sql = @"
        EXEC pa_OcupacionFuncion @idFuncion";

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@idFuncion", idFuncion));

            return acceso.ConsultarBD(sql, parametros);
        }

        // Consulta 6 (Santiago): películas/mes con recaudación sobre el promedio
        public DataTable ObtenerGeneros()
        {
            
            return acceso.ConsultarBD("SELECT idGenero, nombre FROM Generos ORDER BY nombre;");
        }

        public DataTable RecaudacionSobrePromedio(
            DateTime desde, DateTime hastaExclusivo, int? idGenero, decimal? montoMinimo)
        {
            string sql = @"
                SELECT idPelicula, Pelicula, Anio, Mes, TotalEntradasVendidas, MontoTotalRecaudado        
                FROM dbo.fn_RecaudacionMensualPeliculasFiltrada(@FechaInicio1, @FechaFin1, @IdGenero1, @MontoMinimo)        
                WHERE MontoTotalRecaudado > (            
                    SELECT AVG(MontoTotalRecaudado)            
                    FROM dbo.fn_RecaudacionMensualPeliculasFiltrada(@FechaInicio2, @FechaFin2, @IdGenero2, NULL)        
                )        
                ORDER BY MontoTotalRecaudado DESC;";

            List<Parametro> parametros = new List<Parametro>
            {
                new Parametro("@FechaInicio1", desde),
                new Parametro("@FechaFin1",    hastaExclusivo),
                new Parametro("@IdGenero1",    (object?)idGenero    ?? DBNull.Value),
                new Parametro("@MontoMinimo",  (object?)montoMinimo ?? DBNull.Value),
                new Parametro("@FechaInicio2", desde),
                new Parametro("@FechaFin2",    hastaExclusivo),
                new Parametro("@IdGenero2",    (object?)idGenero    ?? DBNull.Value)
            };

           
            return acceso.ConsultarBD(sql, parametros);
        }
    }
    
}
