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
    public partial class FrmRegistrarCategoria : Form
    {
        //variable para impedir guardar datos sin previsualizar
        bool datosPrevisualizados = false;
        //objeto de logica de negocio para acceder al metodo de agregar categoria
        LogicaGeneral gestorLogica = new LogicaGeneral();
        //variable por si hubo error en el metodo de guardar
        bool huboError = false;

        public FrmRegistrarCategoria()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //limpiar los campos de texto
            txtIdCategoria.Clear();
            txtNombreCat.Clear();
            txtDescripcion.Clear();
            //limpiar tabla de vista previa
            dataPreviewRegistro.Rows.Clear();
            //volver a habilitar boton de preview y deshabilitar boton de guardar
            btnPrevisual.Enabled = true;
            btnGuardarCat.Enabled = false;
        }

        // ----------- Validacion y Registro de Datos al ArrayL de objetos -----------

        //boton de preview para mostrar los datos ingresados en la tabla de vista previa
        private void btnPrevisual_Click(object sender, EventArgs e)
        {
            try
            {
                //-validaciones-
                if (string.IsNullOrWhiteSpace(txtIdCategoria.Text) || string.IsNullOrWhiteSpace(txtNombreCat.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de previsualizar.",
                    "Informacion Incompleta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                else if(!txtIdCategoria.MaskFull) ///verificar que el campo de ID este completo con los 6 digitos requeridos
                {
                    error1.SetError(txtIdCategoria, "El ID Debe contener 6 digitos.");
                    txtIdCategoria.Focus();
                    txtIdCategoria.SelectAll();
                    return;
                }
                else
                {
                    error1.SetError(txtIdCategoria, "");
                }

                //obtener datos para tabla de preview y posteriormente guardar en el ArrayL de objetos
                string idCategoria = txtIdCategoria.Text;
                string nombreCategoria = txtNombreCat.Text;
                string descripcion = txtDescripcion.Text;
                
                //se agrega una nueva fila a la tabla de vista previa con los datos obtenidos
                int n = dataPreviewRegistro.Rows.Add();
                dataPreviewRegistro.Rows[n].Cells[0].Value = idCategoria;
                dataPreviewRegistro.Rows[n].Cells[1].Value = nombreCategoria;
                dataPreviewRegistro.Rows[n].Cells[2].Value = descripcion;
                //se habilita el boton de guardar y se bloquea el boton de preview para evitar duplicados
                btnGuardarCat.Enabled = true;
                btnPrevisual.Enabled = false;
                //se marca que los datos han sido previsualizados para permitir su registro
                datosPrevisualizados = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al previsualizar los datos: " + ex.Message);
            }

        }

        private void btnGuardarCat_Click(object sender, EventArgs e)
        {
            //Recorrer tabla para guardar los datos en el ArrayL de objetos
            foreach (DataGridViewRow fila in dataPreviewRegistro.Rows)
            {
                if (fila.Cells[0].Value != null) //evitar linea en blanco al final de la tabla
                {
                    // crear objeto de tipo CategoriaVehiculo con los datos de cada fila y agregarlo al ArrayL de objetos
                    CategoriaVehiculo cat = new CategoriaVehiculo();
                    cat.IdCategoria = fila.Cells[0].Value.ToString().Trim();
                    cat.NombreCategoria = fila.Cells[1].Value.ToString();
                    cat.Descripcion = fila.Cells[2].Value.ToString();
                   
                    //llamar metodo para agregar categoria al ArrayL de objetos y mostrar mensaje de resultado
                    string resultado = gestorLogica.AgregarElemento(cat: cat);
                    if (resultado.Contains("ERROR"))
                    {
                        MessageBox.Show(resultado, "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        huboError = true;
                        break; //salir del bucle si hay un error
                    }
                }
            }
            if (!huboError)
            {
                MessageBox.Show("Todos los registros se guardaron con éxito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Solo se limpia si todo salió bien
                dataPreviewRegistro.Rows.Clear();
            }
            //limpiar los campos de texto
            txtIdCategoria.Clear();
            txtNombreCat.Clear();
            txtDescripcion.Clear();
            //limpiar tabla de vista previa
            dataPreviewRegistro.Rows.Clear();
            //volver a habilitar boton de preview y deshabilitar boton de guardar
            btnPrevisual.Enabled = true;
            btnGuardarCat.Enabled = false;
        }
    }
}
