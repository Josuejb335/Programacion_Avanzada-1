using CapaAccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class LogicaGeneral
    {
        //agregar elementos a los array


        //contador para llevar el control de la cantidad de categorias agregadas al arreglo de categorias en la clase Almacenamiento
        public static int contadorArrayCat = 0;
        public static int contadorArrayVeh = 0;
        public static int contadorArrayVend = 0;
        public static int contadorArraySuc = 0;
        public static int contadorArrayClie = 0;


        //metodo para agregar una nueva categoria al arreglo de categorias en la clase Almacenamiento
        public string AgregarElemento(CategoriaVehiculo cat = null, Vehiculo veh = null, Vendedor vend = null, Sucursal suc = null, Cliente clie = null)
        {
            try
            {   
                //guardar categoria
                if (cat != null)
                {
                    //caso 1: para agregar una categoria

                    if (ExisteCategoria(cat.IdCategoria))
                    {
                        return "ERROR  La categoria con el ID " + cat.IdCategoria + " ya existe. No se puede agregar.";
                    }

                    //se busca el primer espacio vacio del arreglo para agregar la nueva categoria
                    for (int i = 0; i < Almacenamiento.ArrayCategorias.Length; i++)
                    {
                        if (Almacenamiento.ArrayCategorias[i] == null)
                        {
                            Almacenamiento.ArrayCategorias[i] = cat;
                            contadorArrayCat++;
                            return "Categoria agregada con exito";
                        }
                    }
                    return "ERROR No se pudo agregar la categoria, el almacenamiento esta lleno";
                }
                //guardar vehiculo
                if (veh != null)
                {
                    if (ExisteVehiculo(veh.IdVehiculo))
                    {
                        return "ERROR  El Vehiculo con el ID " + veh.IdVehiculo + " ya existe. No se puede agregar.";
                    }

                    //se busca el primer espacio vacio del arreglo para agregar el nuevo vehiculo
                    for (int i = 0; i < Almacenamiento.ArrayVehiculos.Length; i++)
                    {
                        if (Almacenamiento.ArrayVehiculos[i] == null)
                        {
                            Almacenamiento.ArrayVehiculos[i] = veh;
                            contadorArrayVeh++;
                            return "Vehiculo agregada con exito";
                        }
                    }
                    return "No se pudo agregar el Vehiculo, el almacenamiento esta lleno";
                }
                //guardar vendedor
                if (vend != null)
                {
                    if (ExisteVendedor(vend.IdVendedor))
                    {
                        return "ERROR  El Vendedor con el ID " + vend.IdVendedor + " ya existe. No se puede agregar.";
                    }

                    //se busca el primer espacio vacio del arreglo para agregar el nuevo vendedor
                    for (int i = 0; i < Almacenamiento.ArrayVendedores.Length; i++)
                    {
                        if (Almacenamiento.ArrayVendedores[i] == null)
                        {
                            Almacenamiento.ArrayVendedores[i] = vend;
                            contadorArrayVend++;
                            return "Vendedor agregada con exito";
                        }
                    }
                    return "No se pudo agregar el Vendedor, el almacenamiento esta lleno";
                }
                //guardar sucursal
                if (suc != null)
                {
                    if (ExisteSucursal(suc.IdSucursal))
                    {
                        return "ERROR La sucursal con el ID " + suc.IdSucursal + " ya existe. No se puede agregar.";
                    }

                    //se busca el primer espacio vacio del arreglo para agregar la nueva sucursal
                    for (int i = 0; i < Almacenamiento.ArraySucursales.Length; i++)
                    {
                        if (Almacenamiento.ArraySucursales[i] == null)
                        {
                            Almacenamiento.ArraySucursales[i] = suc;
                            contadorArrayVend++;
                            return "Sucursal agregada con exito";
                        }
                    }
                    return "No se pudo agregar la Sucursal, el almacenamiento esta lleno";
                }
                //guardar cliente
                if (clie != null)
                {
                    if (ExisteCliente(clie.IdCliente))
                    {
                        return "ERROR el Cliente con el ID " + clie.IdCliente + " ya existe. No se puede agregar.";
                    }

                    //se busca el primer espacio vacio del arreglo para agregar la nueva sucursal
                    for (int i = 0; i < Almacenamiento.ArrayClientes.Length; i++)
                    {
                        if (Almacenamiento.ArrayClientes[i] == null)
                        {
                            Almacenamiento.ArrayClientes[i] = clie;
                            contadorArrayClie++;
                            return "Cliente agregado con exito";
                        }
                    }
                    return "No se pudo agregar el Cliente, el almacenamiento esta lleno";
                }
                return "No se proporcionó un elemento válido para agregar.";
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Logica" + ex.Message);
            }
        }

        //metodo para verificar si un ID de categoria existe en el arreglo de categorias
        public bool ExisteCategoria(string idBusqueda)
        {
            // limpiar espacios en blanco 
            idBusqueda = idBusqueda.Trim();

            for (int i = 0; i < Almacenamiento.ArrayCategorias.Length; i++)
            {
                // saltar espacios vacíos para evitar errores de referencia nula
                if (Almacenamiento.ArrayCategorias[i] != null)
                {
                    // se compara 
                    if (Almacenamiento.ArrayCategorias[i].IdCategoria.Trim().Equals(idBusqueda, StringComparison.OrdinalIgnoreCase))
                    {
                        return true; // se encontró la categoría
                    }
                }
            }
            return false; //no se encontró la categoría
        }

        //metodo para verificar si un ID de vehiculo existe en el arreglo de vehiculos
        public bool ExisteVehiculo(int idBusqueda)
        {
            for (int i = 0; i < Almacenamiento.ArrayVehiculos.Length; i++)
            {
                // saltar espacios vacíos para evitar errores de referencia nula
                if (Almacenamiento.ArrayVehiculos[i] != null)
                {
                    // se compara 
                    if (Almacenamiento.ArrayVehiculos[i].IdVehiculo == idBusqueda)
                    {
                        return true; // se encontró el vehiculo
                    }
                }
            }
            return false; //no se encontró el vehiculo
        }

        //metodo para verificar si un ID de vendedor existe en el arreglo de vendeores
        public bool ExisteVendedor(int idBusqueda)
        {
            for (int i = 0; i < Almacenamiento.ArrayVendedores.Length; i++)
            {
                // saltar espacios vacíos para evitar errores de referencia nula
                if (Almacenamiento.ArrayVendedores[i] != null)
                {
                    // se compara 
                    if (Almacenamiento.ArrayVendedores[i].IdVendedor == idBusqueda)
                    {
                        return true; // se encontró el vendedor
                    }
                }
            }
            return false; //no se encontró el vendedor
        }

        //metodo para verificar si un ID de sucursal existe en el arreglo de sucursales
        public bool ExisteSucursal(int idBusqueda)
        {
            for (int i = 0; i < Almacenamiento.ArraySucursales.Length; i++)
            {
                // saltar espacios vacíos para evitar errores de referencia nula
                if (Almacenamiento.ArraySucursales[i] != null)
                {
                    // se compara 
                    if (Almacenamiento.ArraySucursales[i].IdSucursal == idBusqueda)
                    {
                        return true; // se encontró la sucursal
                    }
                }
            }
            return false; //no se encontró la sucursal
        }

        //metodo para verificar si un ID de cliente existe en el arreglo de clientes
        public bool ExisteCliente(int idBusqueda)
        {
            for (int i = 0; i < Almacenamiento.ArrayClientes.Length; i++)
            {
                // saltar espacios vacíos para evitar errores de referencia nula
                if (Almacenamiento.ArrayClientes[i] != null)
                {
                    // se compara 
                    if (Almacenamiento.ArrayClientes[i].IdCliente == idBusqueda)
                    {
                        return true; // se encontró el cliente
                    }
                }
            }
            return false; //no se encontró el cliente
        }


    }
}
    
