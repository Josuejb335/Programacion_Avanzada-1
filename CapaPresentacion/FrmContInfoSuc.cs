using CapaEntidades;
using CapaLogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * UNED I Cuatrimestre 2026
 * Proyecto I, Gestion De AutoMarket. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : semana del 16 al 22 de Febrero del 2026
 */

namespace CapaPresentacion
{
    public partial class FrmContInfoSuc : Form
    {
        public FrmContInfoSuc()
        {
            InitializeComponent();
        }

        private void dataInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //-- id vendedor --
            //verificar que la columna que se está formateando es la de "IdVendedor"
            if (this.dataInfo.Columns[e.ColumnIndex].Name == "IdVendedor")
            {
                // obtener el objeto Sucursal de la fila actual
                var sucActual = dataInfo.Rows[e.RowIndex].DataBoundItem as Sucursal;

                if (sucActual != null && sucActual.vendedorEncargado != null)
                {
                    // asignarle el valor de la propiedad  
                    e.Value = sucActual.vendedorEncargado.Identificacion;
                }
            }

            //-- nombre vendedor --
            //verificar que la columna que se está formateando es la de "NombreVendedor"
            if (this.dataInfo.Columns[e.ColumnIndex].Name == "NombreVendedor")
            {
                // obtener el objeto Sucursal de la fila actual
                var sucActual = dataInfo.Rows[e.RowIndex].DataBoundItem as Sucursal;

                if (sucActual != null && sucActual.vendedorEncargado != null)
                {
                    // asignarle el valor de la propiedad  
                    e.Value = sucActual.vendedorEncargado.Nombre;
                }
            }

            // Cambiar el valor de la columna "Activo" para mostrar "Sí" o "No" en vez de "True" o "False"
            if (this.dataInfo.Columns[e.ColumnIndex].HeaderText == "Activo")
            {
                if (e.Value is bool valorBool)
                {
                    e.Value = valorBool ? "Sí" : "No";
                    e.FormattingApplied = true;
                }
            }
        }

        private void FrmContInfoSuc_Load(object sender, EventArgs e)
        {
            try
            {
                // limpiar datos anteriores
                dataInfo.DataSource = null;

                // pedir datos a la capa lógica
                Sucursal[] array = LogicaMostrarInfo.ObtenerSucursales();

                // asignar datos al DataGridView
                dataInfo.DataSource = array;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
    }
}
