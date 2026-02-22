using CapaAccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class LogicaMostrarInfo
    {   
        //--- Categorias ---
        //metodo para obtener la informacion del array y enviarla a la capa de presentacion
        public static CategoriaVehiculo[] ObtenerCategorias()
        {
            // 1. Contar cuántos no son nulos
            int contador = 0;
            for (int i = 0; i < Almacenamiento.ArrayCategorias.Length; i++)
            {
                if (Almacenamiento.ArrayCategorias[i] != null) contador++;
            }

            // 2. Crear arreglo del tamaño exacto
            CategoriaVehiculo[] temporal = new CategoriaVehiculo[contador];
            int index = 0;
            for (int i = 0; i < Almacenamiento.ArrayCategorias.Length; i++)
            {
                if (Almacenamiento.ArrayCategorias[i] != null)
                {
                    temporal[index] = Almacenamiento.ArrayCategorias[i];
                    index++;
                }
            }
            return temporal;
        }

        //--- Vehiculos  ---
        //metodo para obtener la informacion del array y enviarla a la capa de presentacion
        public static Vehiculo[] ObtenerVehiculos()
        {
            int contador = 0;
            for (int i = 0; i < Almacenamiento.ArrayVehiculos.Length; i++)
            {
                if (Almacenamiento.ArrayVehiculos[i] != null) contador++;
            }

            Vehiculo[] temporal = new Vehiculo[contador];
            int index = 0;
            for (int i = 0; i < Almacenamiento.ArrayVehiculos.Length; i++)
            {
                if (Almacenamiento.ArrayVehiculos[i] != null)
                {
                    temporal[index] = Almacenamiento.ArrayVehiculos[i];
                    index++;
                }
            }
            return temporal;
        }

        //--- Vendedores  ---
        //metodo para obtener la informacion del array y enviarla a la capa de presentacion
        public static Vendedor[] ObtenerVendedores()
        {
            // 1. Contar cuántos no son nulos
            int contador = 0;
            for (int i = 0; i < Almacenamiento.ArrayVendedores.Length; i++)
            {
                if (Almacenamiento.ArrayVendedores[i] != null) contador++;
            }

            // 2. Crear arreglo del tamaño exacto
            Vendedor[] temporal = new Vendedor[contador];
            int index = 0;
            for (int i = 0; i < Almacenamiento.ArrayVendedores.Length; i++)
            {
                if (Almacenamiento.ArrayVendedores[i] != null)
                {
                    temporal[index] = Almacenamiento.ArrayVendedores[i];
                    index++;
                }
            }
            return temporal;
        }

        //--- Clientes  ---
        //metodo para obtener la informacion del array y enviarla a la capa de presentacion
        public static Cliente[] ObtenerClientes()
        {
            // 1. Contar cuántos no son nulos
            int contador = 0;
            for (int i = 0; i < Almacenamiento.ArrayClientes.Length; i++)
            {
                if (Almacenamiento.ArrayClientes[i] != null) contador++;
            }

            // 2. Crear arreglo del tamaño exacto
            Cliente[] temporal = new Cliente[contador];
            int index = 0;
            for (int i = 0; i < Almacenamiento.ArrayClientes.Length; i++)
            {
                if (Almacenamiento.ArrayClientes[i] != null)
                {
                    temporal[index] = Almacenamiento.ArrayClientes[i];
                    index++;
                }
            }
            return temporal;
        }

        //--- Sucursales  ---
        //metodo para obtener la informacion del array y enviarla a la capa de presentacion
        public static Sucursal[] ObtenerSucursales()
        {
            int contador = 0;
            for (int i = 0; i < Almacenamiento.ArraySucursales.Length; i++)
            {
                if (Almacenamiento.ArraySucursales[i] != null) contador++;
            }

            Sucursal[] temporal = new Sucursal[contador];
            int index = 0;
            for (int i = 0; i < Almacenamiento.ArraySucursales.Length; i++)
            {
                if (Almacenamiento.ArraySucursales[i] != null)
                {
                    temporal[index] = Almacenamiento.ArraySucursales[i];
                    index++;
                }
            }
            return temporal;
        }

        //--- Asocies  ---
        //metodo para obtener la informacion del array y enviarla a la capa de presentacion
        public static VehiculoxSucursal[] ObtenerAsocies()
        {
            int contador = 0;
            for (int i = 0; i < Almacenamiento.ArrayVehiculosxSucursal.Length; i++)
            {
                if (Almacenamiento.ArrayVehiculosxSucursal[i] != null) contador++;
            }

            VehiculoxSucursal[] temporal = new VehiculoxSucursal[contador];
            int index = 0;
            for (int i = 0; i < Almacenamiento.ArrayVehiculosxSucursal.Length; i++)
            {
                if (Almacenamiento.ArrayVehiculosxSucursal[i] != null)
                {
                    temporal[index] = Almacenamiento.ArrayVehiculosxSucursal[i];
                    index++;
                }
            }
            return temporal;
        }
    }
}
