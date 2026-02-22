using CapaAccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class FrmAsociar : Form
    {
        LogicaAsocie logicaAsocie = new LogicaAsocie();

        public FrmAsociar()
        {
            InitializeComponent();
        }

        private void FrmAsociar_Load(object sender, EventArgs e)
        {
            //cargar sucursales activas en el combo box
            try
            {
                Sucursal[] sucActicvas = logicaAsocie.ObtenerSucActivas();

                if (sucActicvas.Length == 0)
                {
                    MessageBox.Show("No hay sucursales activas registradas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cmbSuc.DataSource = sucActicvas;
                cmbSuc.DisplayMember = "NombreSucursal";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar sucursales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //cargar vehiculos en el combo box
            try
            {
                cmbVehi.DisplayMember = "Modelo";
                bool hayVehiculos = false;

                foreach (var vehi in Almacenamiento.ArrayVehiculos)
                {
                    if (vehi != null) // Solo agregar vehículos que NO son null
                    {
                        cmbVehi.Items.Add(vehi);
                        hayVehiculos = true;
                    }
                }

                if (!hayVehiculos)
                {
                    MessageBox.Show("No hay Vehículos registrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vehículos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSuc.SelectedItem == null || cmbVehi.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione una sucursal y un vehículo para asociar.", "Información Incompleta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //recuperer objetos del combobox
                Sucursal sucursalSeleccionada = (Sucursal)cmbSuc.SelectedItem;
                Vehiculo vehiculoSeleccionado = (Vehiculo)cmbVehi.SelectedItem;
                int cantidad = int.Parse(txtNum.Text);

                //enviar el objeto a la lógica de negocio guardar en el Array
                string resultado = logicaAsocie.AgregarAsociacion(vehiculoSeleccionado, sucursalSeleccionada, cantidad);
                if (resultado.Contains("ERROR"))
                {
                    MessageBox.Show(resultado, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(resultado, "Asociacion Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //limpiar campos despues de guardar
                    cmbSuc.SelectedIndex = -1;
                    cmbVehi.SelectedIndex = -1;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asociar vehículo a sucursal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }   
}
