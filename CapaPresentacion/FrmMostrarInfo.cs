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
    public partial class FrmMostrarInfo : Form
    {
        public FrmMostrarInfo()
        {
            InitializeComponent();
        }
        // metodo para abrir todos los submenus dentro del espacio vacio del panel contenedor
        private void AbrirFormularioEnPanel(object formHijo)
        {
            // Si hay algo dentro del panel se elimina para mostrar el nuevo formulario
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);

            // se crea el formulario como un control de bajo nivel
            Form fh = formHijo as Form;
            fh.TopLevel = false; // inidicar que no es una ventana independiente
            fh.FormBorderStyle = FormBorderStyle.None; // Quita los bordes de la ventana hija
            fh.Dock = DockStyle.Fill; // Hace que llene todo el panel

            // Se añade al panel y se muestra
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmContInfoCat());
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmContInfoVehi());
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmContInfoVend());
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmContInfoSuc());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmContInfoClie());
        }

        private void btnAsociaciones_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmContInfoAso());
        }
    }
}
