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
    public partial class FrmContInfoCat : Form
    {
        public FrmContInfoCat()
        {
            InitializeComponent();
        }

        //carga datos al cargar el formulario
        private void FrmContInfoCat_Load(object sender, EventArgs e)
        {
            try
            {
                // limpiar datos anteriores
                dataInfo.DataSource = null;

                // pedir datos a la capa lógica
                CategoriaVehiculo[] array = LogicaMostrarInfo.ObtenerCategorias();

                // asignar datos al DataGridView
                dataInfo.DataSource = array;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        private void dataInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
