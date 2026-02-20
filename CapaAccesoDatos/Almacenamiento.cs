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
        // listas para almacenar los objetos de cada clase
        private Vehiculo[] listaVehiculos = new Vehiculo[20];
        private Vendedor[] listaVendedores = new Vendedor[20];
        private Sucursal[] listaSucursales = new Sucursal[5];
        private Cliente[] listaClientes = new Cliente[5];
    }
}
