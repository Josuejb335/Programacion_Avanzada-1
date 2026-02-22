using CapaEntidades;

/*
 * UNED I Cuatrimestre 2026
 * Proyecto I, Gestion De AutoMarket. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : semana del 16 al 22 de Febrero del 2026
 */

namespace CapaAccesoDatos
{
    public class Almacenamiento
    {
        // Arreglos para almacenar los objetos de cada clase
        public static CategoriaVehiculo[] ArrayCategorias = new CategoriaVehiculo[20];
        public static Vehiculo[] ArrayVehiculos = new Vehiculo[50];
        public static Vendedor[] ArrayVendedores = new Vendedor[20];
        public static Sucursal[] ArraySucursales = new Sucursal[5];
        public static Cliente[] ArrayClientes = new Cliente[5];
        public static VehiculoxSucursal[] ArrayVehiculosxSucursal = new VehiculoxSucursal[100];
        //array para sucursales activas
        public static Sucursal[] ArraySucursalesActivas = new Sucursal[5];
    }
}
