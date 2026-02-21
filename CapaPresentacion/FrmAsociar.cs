using CapaAccesoDatos;
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
    public partial class FrmAsociar : Form
    {
        public FrmAsociar()
        {
            InitializeComponent();
        }

        private void FrmAsociar_Load(object sender, EventArgs e)
        {
            foreach (var suc in Almacenamiento.ArraySucursales)
            {

            }
        }
    }
}
