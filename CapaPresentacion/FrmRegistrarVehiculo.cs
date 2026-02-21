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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaPresentacion
{
    public partial class FrmRegistrarVehiculo : Form
    {
        //objeto de logica de negocio para acceder al metodo de agregar categoria
        LogicaGeneral gestorLogica = new LogicaGeneral();
        //variable por si hubo error en el metodo de guardare;

        public FrmRegistrarVehiculo()
        {
            InitializeComponent();
        }

        private void FrmRegistrarVehiculo_Load(object sender, EventArgs e)
        {
            //cargar datos del combo box (categorias de vehiculos) desde el array de categorias en la clase Almacenamiento
            foreach (var cat in Almacenamiento.ArrayCategorias)
            {
                if (cat != null)
                {
                    cmbCategorias.Items.Add(cat);
                }
            }
            cmbCategorias.DisplayMember = "NombreCategoria"; //mostrar el nombre de la categoria en el combo box

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //-validaciones-
                if (string.IsNullOrWhiteSpace(txtMarca.Text) || string.IsNullOrWhiteSpace(txtModelo.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || !txtId.MaskFull || !txtAnio.MaskFull)
                {
                    MessageBox.Show("Por favor, complete todos los campos.",
                    "Informacion Incompleta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }
                if (cmbCategorias.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione una categoría.");
                    return;
                }


                //asignar valores para crear el objeto Vehiculo
                int id = int.Parse(txtId.Text);
                string marca = txtMarca.Text;
                string modelo = txtModelo.Text;
                int anio = int.Parse(txtAnio.Text);
                decimal precio = decimal.Parse(txtPrecio.Text);
                CategoriaVehiculo catSeleccionada = (CategoriaVehiculo)cmbCategorias.SelectedItem;
                //determinar el estado del vehiculo segun el radio button seleccionado
                char estado;
                if (btnNuevo.Checked)
                {
                    estado = 'N';
                }
                else if (btnUsado.Checked)
                {
                    estado = 'U';
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una estado.");
                    return;
                }

                //crear objeto vehiculo con los datos ingresados
                Vehiculo veh = new Vehiculo();
                veh.IdVehiculo = id;
                veh.Marca = marca;
                veh.Modelo = modelo;
                veh.Anio = anio;
                veh.Precio = precio;
                veh.Estado = estado;
                veh.Categoria = catSeleccionada;

                string resultado = gestorLogica.AgregarElemento(veh: veh);
                if (resultado.Contains("ERROR"))
                {
                    MessageBox.Show(resultado, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(resultado, "Vehículo guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //limpiar campos despues de guardar
                    txtId.Clear();
                    txtMarca.Clear();
                    txtModelo.Clear();
                    txtAnio.Clear();
                    txtPrecio.Clear();
                    cmbCategorias.SelectedIndex = -1;
                    btnNuevo.Checked = false;
                    btnUsado.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }
    }
}
