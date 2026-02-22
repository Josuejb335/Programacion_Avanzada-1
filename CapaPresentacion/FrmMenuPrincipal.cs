using CapaAccesoDatos;
using CapaLogicaNegocio;

/*
 * UNED I Cuatrimestre 2026
 * Proyecto I, Gestion De AutoMarket. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : semana del 16 al 22 de Febrero del 2026
 */

namespace CapaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        //variables usadas para arrastrar la ventana personalizada
        private bool arrastrando = false;
        private Point puntoCursorArrastre;
        private Point puntoFormularioArrastre;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        //boton de minimizar ventana personalizado
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al minimizar la ventana");
            }
        }
        //boton de cerrar ventana personalizado
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la aplicación: " + ex.Message);
            }
        }
        //mover ventana con panel personalizado
        // Se ejecuta al presionar el clic sobre el panel
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrando = true;
            puntoCursorArrastre = Cursor.Position;
            puntoFormularioArrastre = this.Location;
        }

        // Se ejecuta mientras se mueve el mouse con el clic presionado
        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastrando)
            {
                // se calcula la diferencia entre la posición actual del cursor y la posición inicial del cursor al comenzar a arrastrar
                Point diferencia = Point.Subtract(Cursor.Position, new Size(puntoCursorArrastre));
                // se aplica esa diferencia a la posición inicial del formulario para moverlo
                this.Location = Point.Add(puntoFormularioArrastre, new Size(diferencia));
            }
        }

        // Se ejecuta al soltar el clic
        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrando = false;
        }

        //cambiar colores de botones al pasar el mouse por encima
        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.DarkRed;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.DarkGreen;
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.LimeGreen;
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

        //boton para registrarCategoria, llama al metodo que abre el formulario dentro del panel contenedor
        private void btnRegistrarCat_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmRegistrarCategoria());
        }
        //boton para registrarVehiculo, llama al metodo que abre el formulario dentro del panel contenedor, y verifica que haya al menos un vendedor para asignar como encargado de la sucursal
        private void btnRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            //revisa si hay al menos una categoría
            if (LogicaGeneral.contadorArrayCat == 0)
            {
                MessageBox.Show("Debe registrar al menos una categoría antes de registrar un vehículo.",
                    "Categoría Requerida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                AbrirFormularioEnPanel(new FrmRegistrarVehiculo());
            }
        }
        //boton para registrarVendedor, llama al metodo que abre el formulario dentro del panel contenedor
        private void btnRegistrarVendedor_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmRegistrarVendedor());

        }
        //boton para registrar, llama al metodo que abre el formulario dentro del panel contenedor, y verifica que haya al menos un vendedor para asignar como encargado de la sucursal
        private void btnRegistrarSucursal_Click(object sender, EventArgs e)
        {
            //revisa si hay al menos un vendedor para asignar como encargado
            if (LogicaGeneral.contadorArrayVend == 0)
            {
                MessageBox.Show("Debe registrar al menos un Vendedor antes de registrar una sucursal.",
                    "Vendedor Encargado Requerido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                AbrirFormularioEnPanel(new FrmRegistrarSuc());
            }
        }

        //boton para registrarCliente, llama al metodo que abre el formulario dentro del panel contenedor
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmRegistrarCliente());
        }
        //boton para asociar, llama al metodo que abre el formulario dentro del panel contenedor
        private void btnAsociar_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmAsociar());
        }
        //boton para consultar, llama al metodo que abre el formulario dentro del panel contenedor
        private void btnConsultarInfo_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmMostrarInfo());
        }
    }
}