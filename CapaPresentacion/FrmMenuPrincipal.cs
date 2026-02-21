using CapaAccesoDatos;
using CapaLogicaNegocio;

namespace CapaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
        //variable para arrastrar la ventana personalizada

        private bool arrastrando = false;
        private Point puntoCursorArrastre;
        private Point puntoFormularioArrastre;

        public FrmMenuPrincipal()
        {
            InitializeComponent();


        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

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

        //abrir submenus con la funcion AbrirFormularioEnPanel
        private void btnRegistrarCat_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmRegistrarCategoria());
        }

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

        private void btnRegistrarVendedor_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FrmRegistrarVendedor());

        }

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
    }
}