using CapaAccesoDatos;
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
using static System.Net.Mime.MediaTypeNames;

namespace CapaPresentacion
{
    public partial class FrmRegistrarSuc : Form
    {
        //objeto de logica de negocio para acceder al metodo de agregar categoria
        LogicaGeneral gestorLogica = new LogicaGeneral();   
        public FrmRegistrarSuc()
        {
            InitializeComponent();
        }

        private void btnNuevo_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void FrmRegistrarSuc_Load(object sender, EventArgs e)
        {
            //cargar datos del combo box (categorias de vehiculos) desde el array de categorias en la clase Almacenamiento
            foreach (var vend in Almacenamiento.ArrayVendedores)
            {
                if (vend != null)
                {
                    cmbEncargado.Items.Add(vend);
                }
            }
            cmbEncargado.DisplayMember = "Nombre"; //mostrar el nombre de la categoria en el combo box
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //verificar que no hayan campos vacios antes de agregar al array
                if (!txtId.MaskFull || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtUbicacion.Text) || !txtTelefono.MaskFull)
                {
                    MessageBox.Show("Por favor, complete todos los campos.",
                    "Informacion Incompleta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                if (cmbEncargado.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione una categoría.");
                    return;
                }

                //obtener datos de la interfaz para crear el objeto para agregar al array
                int id = int.Parse(txtId.Text);
                string nombre = txtNombre.Text;
                string ubicacion = txtUbicacion.Text;
                string telefono = txtTelefono.Text;
                Vendedor EncargadoSeleccionado = (Vendedor)cmbEncargado.SelectedItem;
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

                //crear objeto
                Sucursal suc = new Sucursal(id, nombre, ubicacion, telefono, EncargadoSeleccionado, activo);

                //guardar la sucursal usando la logica de negocio
                string resultado = gestorLogica.AgregarElemento(suc: suc);
                if (resultado.Contains("ERROR"))
                {
                    MessageBox.Show(resultado, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(resultado, "Vehículo guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //limpiar campos despues de guardar
                    txtId.Clear();
                    txtNombre.Clear();
                    txtUbicacion.Clear();
                    txtTelefono.Clear();
                    btnActivo.Checked = false;
                    btnInactivo.Checked = false;
                    cmbEncargado.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  
        }
    }
}
