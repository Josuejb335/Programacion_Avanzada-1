using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

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
    }
}
