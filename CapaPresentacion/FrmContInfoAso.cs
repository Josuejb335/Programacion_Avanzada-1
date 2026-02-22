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

namespace CapaPresentacion
{
    public partial class FrmContInfoAso : Form
    {
        public FrmContInfoAso()
        {
            InitializeComponent();
        }

        private void dataInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //-- nombre Vehiculo --
            //verificar que la columna que se está formateando es la de "NombreCat"
            if (this.dataInfo.Columns[e.ColumnIndex].Name == "Vehiculo")
            {
                // obtener el objeto Vehiculo de la fila actual
                var asoc = dataInfo.Rows[e.RowIndex].DataBoundItem as VehiculoxSucursal;

                if (asoc != null && asoc.vehiculoAsociado != null)
                {
                    // asignarle el valor de la propiedad NombreCategoria 
                    e.Value = $"{asoc.vehiculoAsociado.Marca} {asoc.vehiculoAsociado.Modelo}";
                }
            }

            //-- nombre sucursal --
            //verificar que la columna que se está formateando es la de "NombreCat"
            if (this.dataInfo.Columns[e.ColumnIndex].Name == "Sucursal")
            {
                // obtener el objeto Vehiculo de la fila actual
                var asoc = dataInfo.Rows[e.RowIndex].DataBoundItem as VehiculoxSucursal;

                if (asoc != null && asoc.sucursalAsociada != null)
                {
                    // asignarle el valor de la propiedad NombreCategoria 
                    e.Value = asoc.sucursalAsociada.NombreSucursal;
                }
            }
        }

        private void FrmContInfoAso_Load(object sender, EventArgs e)
        {
            try
            {
                // limpiar datos anteriores
                dataInfo.DataSource = null;

                // pedir datos a la capa lógica
                VehiculoxSucursal[] array = LogicaMostrarInfo.ObtenerAsocies();

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
