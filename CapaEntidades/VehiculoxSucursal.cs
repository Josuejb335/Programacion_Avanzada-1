using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class VehiculoxSucursal
    {
        public Vehiculo vehiculoAsociado { get; set; }
        public Sucursal sucursalAsociada { get; set; }
        public int cantidad { get; set; }
    }
}
