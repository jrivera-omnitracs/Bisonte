using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using Omnireports2.Persistencia;

namespace Omnireports2.Vistas
{
    /// <summary>
    /// Parte 2 de 3 de la clase que gobierna el comportanmiento del formReporteDeCirculoDeServicio
    /// </summary>
    public partial class formReporteDeCirculoDeServicio
    {
        /// <summary>
        /// fechas de inicio y fin de la consulta
        /// </summary>
        private DateTime dtInicio, dtFin;
        /// <summary>
        /// grupo de unidades en la consulta
        /// </summary>
        private string grupoDeUnidades;
        /// <summary>
        /// string que será llenado con el procedure que se quiere realizar
        /// </summary>
        private string strAux_Procedure;
        /// <summary>
        /// economico del cual se generarán los reportes
        /// </summary>
        private string economico;
        /// <summary>
        /// sucursal de la cual se registran las entradas y salidas
        /// </summary>
        private string sucursal;

        /// <summary>
        /// Get & Set sucursal
        /// </summary>
        public string Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }
        /// <summary>
        /// Get&Set fecha de fin
        /// </summary>
        public DateTime DtFin
        {
            get { return dtFin; }
            set { dtFin = value; }
        }
        /// <summary>
        /// Get&Set fecha de inicio
        /// </summary>
        public DateTime DtInicio
        {
            get { return dtInicio; }
            set { dtInicio = value; }
        }
        /// <summary>
        /// Get&Set fecha del grupo de unidades
        /// </summary>
        public string GrupoDeUnidades
        {
            get { return grupoDeUnidades; }
            set { grupoDeUnidades = value; }
        }
        /// <summary>
        /// Get&Set del economico de interés
        /// </summary>
        public string Economico
        {
            get { return economico; }
            set { economico = value; }
        }

        /// <summary>
        /// Al contruir el objeto, los objetos dateTimePicker tienen la fecha del día en curso,
        /// para evitar que el usuario vea una pantalla vacia, al momento de abrir la herramienta se
        /// llenará el primer Data Grid View que el usuario observa.
        /// </summary>
        public formReporteDeCirculoDeServicio()
        {
            // Se genera la pantalla
            InitializeComponent();

            Sucursal = "NULL";

            /// Se inicializan las variables a null para ejecutar los procedimientos
            DtInicio = dtpInicio.Value.Date + dthInicial.Value.TimeOfDay;
            DtFin = dtpFin.Value.Date + dthFinal.Value.TimeOfDay;
            GrupoDeUnidades = Economico = "NULL";

            //Se llena el primer dta grid View que vera el usuario
            ActualizarGirdView(datagvExcesosVelocidad, "sp_recorridos"
                    + " '" + DtInicio.ToString("yyyyMMdd HH:mm") + "' , "
                    + "'" + DtFin.ToString("yyyyMMdd HH:mm") + "' , "
                    + "null" + ","
                    + "null");
        }

        /// <summary>
        /// Al seleccionar el botón generar, se pregunta por el Data Grid View (DGV) activo
        /// y se genera un llama al método ExportarDataGridViewExcel para generar un
        /// archivo excel con la información del DGV
        /// </summary>
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tpExcesoVelocidad"])
            {
                ExportarDataGridViewExcel(datagvExcesosVelocidad);
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tpFrenadasBruscas"])
            {
                ExportarDataGridViewExcel(datagvFrenadasBruscas);
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tpKilometrosRecorridos"])
            {
                ExportarDataGridViewExcel(datagvKmRecorridos);
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tpRendimientoCombustible"])
            {
                ExportarDataGridViewExcel(datagvRendimientoCombustible);
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tpEstadisticas"])
            {
                ExportarDataGridViewExcel(datagvEstadisticas);
            }
        }

        /// <summary>
        /// Al detectar un cambio en las fechas y limita al usuario a introducir fechas válidas 
        /// para los rangos de fechas. Asi mismo actualiza el valor de fecha que después será
        /// utilizado para generar los Data Grid View.
        /// 
        /// Este método se aplica en específico a fecha de inicio
        /// </summary>
        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            this.dtpFin.MinDate = dtpInicio.Value;
            DtInicio = dtpInicio.Value.Date + dthInicial.Value.TimeOfDay;
        }

        /// <summary>
        /// Al detectar un cambio en las fechas y limita al usuario a introducir fechas válidas 
        /// para los rangos de fechas. Asi mismo actualiza el valor de fecha que después será
        /// utilizado para generar los Data Grid View.
        /// 
        /// Este método se aplica en específico a fecha de fin
        /// </summary>
        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            this.dtpInicio.MaxDate = dtpFin.Value;
            DtFin = dtpFin.Value.Date + dthFinal.Value.TimeOfDay;
        }

        /// <summary>
        /// Al detectar que el usuari selecciona una pestaña distinta a la que se encuentra carga 
        /// únicamente los datos en el Data Grid View de esa pestña en específico. Esto permite que 
        /// la carga del sistema sea más ágil.
        /// </summary>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///Se establece el economico antes de hacer una consulta
            SetEconomico();
            ///Se actualiza solamente el Data Grid View que el usuaio está visualizabdo en el momento
            if (tabControl1.SelectedTab == tabControl1.TabPages["tpExcesoVelocidad"])
            {
                strAux_Procedure = Contract.ExcesoDeVelocidad.spExcesoDeVelocidad
                    + " '" + DtInicio.ToString("yyyyMMdd HH:mm") + "' ,"
                    + " '" + DtFin.ToString("yyyyMMdd HH:mm") + "' ,"
                    + " " + Economico + "";
                ActualizarGirdView(datagvExcesosVelocidad, strAux_Procedure);
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tpFrenadasBruscas"])
            {
                strAux_Procedure = Contract.FrenadasBruscas.spFrenadasBruscas
                    + " '" + DtInicio.ToString("yyyyMMdd HH:mm") + "' ,"
                    + " '" + DtFin.ToString("yyyyMMdd HH:mm") + "' ,"
                    + " " + Economico + "";
                ActualizarGirdView(datagvFrenadasBruscas, strAux_Procedure);
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tpKilometrosRecorridos"])
            {
                strAux_Procedure = Contract.KilometrosRecorridos.spKilometrosRecorridos
                    + " '" + DtInicio.ToString("yyyyMMdd HH:mm") + "' ,"
                    + " '" + DtFin.ToString("yyyyMMdd HH:mm") + "' ,"
                    + " " + Economico + "";
                ActualizarGirdView(datagvKmRecorridos, strAux_Procedure);
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tpRendimientoCombustible"])
            {
                strAux_Procedure = Contract.RendimientoCombustible.spRendimiento
                    + " '" + DtInicio.ToString("yyyyMMdd HH:mm") + "' ,"
                    + " '" + DtFin.ToString("yyyyMMdd HH:mm") + "' ,"
                    + " " + Economico + "";
                ActualizarGirdView(datagvRendimientoCombustible, strAux_Procedure);
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["tpEstadisticas"])
            {
                strAux_Procedure = Contract.Estadisticas.spEstadisticas
                    + " '" + DtInicio.ToString("yyyyMMdd HH:mm") + "' ,"
                    + " '" + DtFin.ToString("yyyyMMdd HH:mm") + "' ,"
                    + " " + Economico + "";
                ActualizarGirdView(datagvEstadisticas, strAux_Procedure);
            }
        }

        /// <summary>
        /// Cuando el usuaio cambia los parámetros para la generación de reportes (fecha inicio, 
        /// fecha fin, grupo o económico) deberá dar click en el botón de actualizar para que el 
        /// Data Grid View que está visualizando se actualice.
        /// </summary>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(sender, e);
        }
    }
}
