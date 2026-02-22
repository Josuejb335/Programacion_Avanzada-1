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
    public partial class FrmRegistrarCliente : Form
    {
        //objeto de logica para acceder al metodo de agregar cliente
        LogicaGeneral gestorLogica = new LogicaGeneral();
        public FrmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIden.Text) || string.IsNullOrEmpty(txtNombre.Text) || !txtId.MaskFull)
                {
                    MessageBox.Show("Por favor, complete todos los campos.",
                        "Informacion Incompleta",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                //crear objeto de tipo Cliente con los datos ingresados
                int id = int.Parse(txtId.Text);
                string identificacion = txtIden.Text;
                string nombre = txtNombre.Text;
                DateTime nacimiento = dateNacimiento.Value;
                DateTime registro = dateRegistro.Value;
                bool activo;

                if (btnActivo.Checked)
                {
                    activo = true;
                }
                else if (btnInactivo.Checked)
                {
                    activo = false;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una estado.");
                    return;
                }

                //crear objeto de cliente con los datos ingresados
                Cliente clie = new Cliente(id, identificacion, nombre, nacimiento, registro, activo);

                //guardar el cliente usando la logica de negocio
                string resultado = gestorLogica.AgregarElemento(clie: clie);
                if (resultado.Contains("ERROR"))
                {
                    MessageBox.Show(resultado, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(resultado, "Cliente guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //limpiar campos despues de guardar
                    txtId.Clear();
                    txtIden.Clear();
                    txtNombre.Clear();
                    btnInactivo.Checked = false;
                    btnActivo.Checked = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el vendedor: " + ex.Message);
            }
        }
    }
}
