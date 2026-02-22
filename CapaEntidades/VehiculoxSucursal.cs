
/*
 * UNED I Cuatrimestre 2026
 * Proyecto I, Gestion De AutoMarket. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : semana del 16 al 22 de Febrero del 2026
 */

namespace CapaEntidades
{
    public class VehiculoxSucursal
    {
        public Vehiculo vehiculoAsociado { get; set; }
        public Sucursal sucursalAsociada { get; set; }
        public int cantidad { get; set; }
        public VehiculoxSucursal(Vehiculo vehiculo, Sucursal sucursal, int cantidad)
        {
            this.vehiculoAsociado = vehiculo;
            this.sucursalAsociada = sucursal;
            this.cantidad = cantidad;
        }
         public VehiculoxSucursal() { }

    }
}
