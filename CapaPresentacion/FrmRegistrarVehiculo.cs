using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAccesoDatos;

namespace CapaPresentacion
{
    public partial class FrmRegistrarVehiculo : Form
    {
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

        private void btnUsado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
