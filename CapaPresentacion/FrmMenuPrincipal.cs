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

        // --- Eventos para el botón Cerrar ---
        private void btnCerrar_MouseEnter(object sender, EventArgs e)
        {
            // Cambia a un rojo más oscuro cuando el mouse entra
            btnCerrar.BackColor = Color.DarkRed;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            // Vuelve al rojo original cuando el mouse sale
            btnCerrar.BackColor = Color.Red;
        }

        // --- Eventos para el botón Minimizar ---
        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.DarkGreen;
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.LimeGreen;
        }

        private void btnRegistrarCat_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}