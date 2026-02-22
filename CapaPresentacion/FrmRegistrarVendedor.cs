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
    public partial class FrmRegistrarVendedor : Form
    {
        LogicaGeneral gestorLogica = new LogicaGeneral();
        public FrmRegistrarVendedor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //validar que los campos obligatorios no estén vacíos
                if (string.IsNullOrEmpty(txtIden.Text) || string.IsNullOrEmpty(txtNombre.Text) || !txtTelefono.MaskFull || !txtId.MaskFull)
                {
                    MessageBox.Show("Por favor, complete todos los campos.",
                        "Informacion Incompleta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                //crear objeto de tipo Vendedor con los datos ingresados
                int id = int.Parse(txtId.Text);
                string identificacion = txtIden.Text;
                string nombre = txtNombre.Text;
                DateTime nacimiento = dateNacimiento.Value;
                DateTime ingreso = dateIngreso.Value;
                string telefono = txtTelefono.Text;

                //crear el objeto Vendedor
                Vendedor vend = new Vendedor(id, identificacion, nombre, nacimiento, ingreso, telefono);

                //guardar el vendedor usando la logica de negocio
                string resultado = gestorLogica.AgregarElemento(vend: vend);
                if (resultado.Contains("ERROR"))
                {
                    MessageBox.Show(resultado, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(resultado, "Vendedor guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //limpiar campos despues de guardar
                    txtId.Clear();
                    txtIden.Clear();
                    txtNombre.Clear();
                    txtTelefono.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el vendedor: " + ex.Message);
            }
        }
    }
}
