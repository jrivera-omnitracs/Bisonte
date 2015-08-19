using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.IO;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using Omnireports2.Persistencia;


namespace Omnireports2.Aplicación
{
    /// <summary>
    /// Clase padre para los forms de reportes
    /// </summary>
    public class Reporte : Form
    {

        /// <summary>
        /// Se obtienen los datso necesarios para llenar un GataGridView
        /// </summary>
        /// <param name="consulta">Es la consulta o procedure de la que se van a rcibir datos</param>
        /// <returns></returns>
        public System.Data.DataTable GetDataToGrid(string consulta)
        {
            System.Data.DataTable myDataTable = new System.Data.DataTable();
            myDataTable = DatabaseHelper.execSPRead(consulta);
            return myDataTable;
        }
        
        /// <summary>
        /// Se genera un .xlsx a partir de un DataGridView
        /// </summary>
        /// <param name="grd">Data Grid View que será convertido a un archivo excel (.xlsx)</param>
        public void ExportarDataGridViewExcel(DataGridView grd)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = grd.Name.ToString();
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    for (int i = 0; i < grd.Columns.Count; i++)
                    {
                        if (i < grd.Columns.Count)
                        {
                            hoja_trabajo.Cells[1, i + 1] = grd.Columns[i].HeaderText.ToString();
                        }
                    }
                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < grd.Rows.Count; i++)
                    {
                        for (int j = 0; j < grd.Columns.Count; j++)
                        {
                            if ((grd.Rows[i].Cells[j].Value == null) == false)
                            {
                                hoja_trabajo.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }
                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                    MessageBox.Show("ARCHIVO GUARDADO");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());
            }

        }
    }
}
