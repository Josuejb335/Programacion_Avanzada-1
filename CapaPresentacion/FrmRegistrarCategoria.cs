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
    public partial class FrmRegistrarCategoria : Form
    {
        public FrmRegistrarCategoria()
        {
            InitializeComponent();
        }

        private void dataPreviewRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmRegistrarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //limpiar los campos de texto
            txtIdCategoria.Clear();
            txtNombreCat.Clear();
            txtDescripcion.Clear();
            //limpiar tabla de vista previa
            dataPreviewRegistro.Rows.Clear();

        }

        // ----------- Validacion y Registro de Datos a la lista de objetos -----------

        //boton de preview para mostrar los datos ingresados en la tabla de vista previa
        private void btnPrevisual_Click(object sender, EventArgs e)
        {
            //se obtienen los datos
            string idCategoria = txtIdCategoria.Text;
            string nombreCategoria = txtNombreCat.Text;
            string descripcion = txtDescripcion.Text;

            //se agrega una nueva fila a la tabla de vista previa con los datos obtenidos
            int n = dataPreviewRegistro.Rows.Add();
            dataPreviewRegistro.Rows[n].Cells[0].Value = idCategoria;
            dataPreviewRegistro.Rows[n].Cells[1].Value = nombreCategoria;
            dataPreviewRegistro.Rows[n].Cells[2].Value = descripcion;
        }



    }
}
