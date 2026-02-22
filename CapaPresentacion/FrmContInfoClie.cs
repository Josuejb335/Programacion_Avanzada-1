using CapaEntidades;
using CapaLogicaNegocio;

/*
 * UNED I Cuatrimestre 2026
 * Proyecto I, Gestion De AutoMarket. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : semana del 16 al 22 de Febrero del 2026
 */

namespace CapaPresentacion
{
    public partial class FrmContInfoClie : Form
    {
        public FrmContInfoClie()
        {
            InitializeComponent();
        }

        private void dataInfo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
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

        private void FrmContInfoClie_Load(object sender, EventArgs e)
        {
            try
            {
                // limpiar datos anteriores
                dataInfo.DataSource = null;

                // pedir datos a la capa lógica
                Cliente[] array = LogicaMostrarInfo.ObtenerClientes();

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
