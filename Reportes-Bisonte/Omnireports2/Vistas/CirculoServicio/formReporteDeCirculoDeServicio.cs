using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using Omnireports2.Persistencia;
using Omnireports2.Aplicación;
using System.Windows.Forms;

namespace Omnireports2.Vistas
{
    /// <summary>
    /// Parte 1 de 3 de la clase que gobierna el comportanmiento del formReporteDeCirculoDeServicio
    /// Hereda de la clase madre Reporte
    /// </summary>
    public partial class formReporteDeCirculoDeServicio : Reporte
    {
        /// <summary>
        /// ACTUALIZA EL CONTENIDO DE UN DATA GRIDVIEW
        /// </summary>
        /// <param name="dgvAuxiliar">Se pasa la referencia del objeto Data Grid View (DGV) que se quiere actualizar</param>
        /// <param name="procedure"> Se pasa el procedimiento con el cual se planea llenar el DGV</param>
        private void ActualizarGirdView(DataGridView dgvAuxiliar, string procedure)
        {
            dgvAuxiliar.DataSource = GetDataToGrid(procedure);
            dgvAuxiliar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        private void ActualizarChart()
        {
        }

        /// <summary>
        /// Fragmento del builder de la cadena de query para generar un 
        /// reporte por grupo de unidades
        /// </summary>
        /// <param name="grupo">grupo de unidades sobre el que se generará 
        /// la consulta</param>
        private void EnableGrupoUnidades(string grupo)
        {
            this.txtEconomico.Enabled = false;
            Economico = "NULL";
            GrupoDeUnidades = grupo;
        }

        /// <summary>
        /// Setter de el miembro de la clase economico con el formato correto para hacer la consulta
        /// </summary>
        private void SetEconomico()
        {
            if (txtEconomico.Enabled)
            {
                if (!txtEconomico.Text.Equals(null) && !txtEconomico.Text.Equals(""))
                {
                    Economico = "'" + txtEconomico.Text + "'";
                }
            }
            else
            {
                Economico = "NULL";
            }
        }
    }
}
