using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Omnireports2.Persistencia
{
    /// <summary>
    /// Se utiliza una clase contract que tendrá la definicioón de los strings necesarios
    /// para hacer query's a la base de datos.
    /// 
    /// Los miembros son definidos de tipo public static para ser alcanzado por toda la solución. 
    /// </summary>
    public class Contract
    {
        /// <summary>
        /// Clase específica para tratar los datos de Kilometros recorridos
        /// </summary>
        public class KilometrosRecorridos
        {
            /// <summary>
            /// 
            /// </summary>
            public static readonly string spKilometrosRecorridos = "sp_recorridos";
        }
        /// <summary>
        /// Clase específica para tratar los datos del Rendimiento de Combustible
        /// </summary>
        public class RendimientoCombustible
        {
            /// <summary>
            /// 
            /// </summary>
            public static readonly string spRendimiento = "sp_rendimiento";
        }
        /// <summary>
        /// Clase específica para tratar los datos de Circulo De Servicio
        /// </summary>
        public class CirculoDeServicio
        {
            /// <summary>
            /// 
            /// </summary>
            public static readonly string spCirculoDeServicio = "sp_circulo_de_servicio";
        }

        /// <summary>
        /// Clase específica para tratar los datos de Exceso de velocidad
        /// </summary>
        public class ExcesoDeVelocidad
        {
            /// <summary>
            /// 
            /// </summary>
            public static readonly string spExcesoDeVelocidad = "sp_velocidad";
        }
        /// <summary>
        /// Clase específica para tratar los datos de Frenadas Bruscas
        /// </summary>
        public class FrenadasBruscas
        {
            /// <summary>
            /// 
            /// </summary>
            public static readonly string spFrenadasBruscas = "sp_frenadas";
        }
        /// <summary>
        /// Clase específica para tratar las Entradas y Salidas de sucursales
        /// </summary>
        public class EntradasYSalidasDeSucursal
        {
            /// <summary>
            /// 
            /// </summary>
            public static readonly string spEntradasYSalidas = "sp_io_sucursales";
            /// <summary>
            /// Query con el que se obtendrá la información para llenar el cbSucursales
            /// </summary>
            public static readonly string qGetSucursales = "SELECT 'NULL' AS sucursales UNION("
                                        + " SELECT DISTINCT campo2 AS sucursales FROM TMensaje WHERE macro = 44" 
                                        + " AND campo2 LIKE '%sucursal%'"
                                        + " ) ORDER BY sucursales";
        }
        /// <summary>
        /// Clase especifica para obtener los datos de estadísticas
        /// </summary>
        public class Estadisticas
        {
            /// <summary>
            /// Query con el que se obtendrá la información para llenar el dgv Estadicticas
            /// </summary>
            public static readonly string spEstadisticas = "sp_estadisticas";
        }
        /// <summary>
        /// Clase especifica para obtener datos necesarios para generar una gráfica
        /// </summary>
        public class GraficaCombustible
        {
            /// <summary>
            /// Query con el que se obtendrá la información para generar la grafica (chart)
            /// </summary>
            public static readonly string spDatosCombustible = "sp_datos_combustible";
            public static readonly string spSanpshotCombustible = "sp_combustible_actual";

        }
    }
}
