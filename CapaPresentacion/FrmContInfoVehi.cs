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
    public partial class FrmContInfoVehi : Form
    {
        public FrmContInfoVehi()
        {
            InitializeComponent();
        }

        // metodo para mostrar los datos dentro del objeto categoria dentro de Vehiculo
        private void dataInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {   
            //-- nombre cat --
            //verificar que la columna que se está formateando es la de "NombreCat"
            if (this.dataInfo.Columns[e.ColumnIndex].Name == "NombreCat")
            {
                // obtener el objeto Vehiculo de la fila actual
                var vehiculoActual = dataInfo.Rows[e.RowIndex].DataBoundItem as Vehiculo;

                if (vehiculoActual != null && vehiculoActual.Categoria != null)
                {
                    // asignarle el valor de la propiedad NombreCategoria 
                    e.Value = vehiculoActual.Categoria.NombreCategoria;
                }
            }

            // -- descripcion cat --
            //verificar que la columna que se está formateando es la de "Descripcion"
            if (this.dataInfo.Columns[e.ColumnIndex].Name == "Descripcion")
            {
                // obtener el objeto Vehiculo de la fila actual
                var vehiculoActual = dataInfo.Rows[e.RowIndex].DataBoundItem as Vehiculo;

                if (vehiculoActual != null && vehiculoActual.Categoria != null)
                {
                    // asignarle el valor de la propiedad NombreCategoria 
                    e.Value = vehiculoActual.Categoria.Descripcion;
                }
            }

            // cambiar el valor de la columna "Estado" para mostrar "Nuevo" o "Usado" en lugar de "N" o "U"
            if (this.dataInfo.Columns[e.ColumnIndex].HeaderText == "Estado")
            {
                if (e.Value != null)
                {
                    if (e.Value.ToString() == "N") e.Value = "Nuevo";
                    else if (e.Value.ToString() == "U") e.Value = "Usado";
                }
            }
        }

        private void FrmContInfoVehi_Load(object sender, EventArgs e)
        {
            try
            {
                // limpiar datos anteriores
                dataInfo.DataSource = null;

                // pedir datos a la logica
                Vehiculo[] array = LogicaMostrarInfo.ObtenerVehiculos();

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
