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


        //metodo para agregar una nueva categoria al arreglo de categorias en la clase Almacenamiento
        public string AgregarElemento(CategoriaVehiculo cat = null, Vehiculo veh = null, Vendedor vend = null)
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

                    //se busca el primer espacio vacio del arreglo para agregar la nueva categoria
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

                    //se busca el primer espacio vacio del arreglo para agregar la nueva categoria
                    for (int i = 0; i < Almacenamiento.ArrayVendedores.Length; i++)
                    {
                        if (Almacenamiento.ArrayVendedores[i] == null)
                        {
                            Almacenamiento.ArrayVendedores[i] = vend;
                            contadorArrayVeh++;
                            return "Vendedor agregada con exito";
                        }
                    }
                    return "No se pudo agregar el Vendedor, el almacenamiento esta lleno";
                }
                //guardar sucursal





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

        //metodo para verificar si un ID de vehiculo existe en el arreglo de categorias
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

        //metodo para verificar si un ID de vendedor existe en el arreglo de categorias
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


    }
}
    
