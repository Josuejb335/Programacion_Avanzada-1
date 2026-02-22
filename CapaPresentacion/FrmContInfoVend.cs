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

/*
 * UNED I Cuatrimestre 2026
 * Proyecto I, Gestion De AutoMarket. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : semana del 16 al 22 de Febrero del 2026
 */

namespace CapaPresentacion
{
    public partial class FrmContInfoVend : Form
    {
        public FrmContInfoVend()
        {
            InitializeComponent();
        }

        private void FrmContInfoVend_Load(object sender, EventArgs e)
        {
            try
            {
                // limpiar datos anteriores
                dataInfo.DataSource = null;

                // pedir datos a la capa lógica
                Vendedor[] array = LogicaMostrarInfo.ObtenerVendedores();

                // asignar datos al DataGridView
                dataInfo.DataSource = array;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
    }
}
