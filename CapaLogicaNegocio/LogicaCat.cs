using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class LogicaCat
    {
        //contador para llevar el control de la cantidad de categorias agregadas al arreglo de categorias en la clase Almacenamiento
        public static int contadorArrayCat = 0;
       

        //metodo para agregar una nueva categoria al arreglo de categorias en la clase Almacenamiento
        public string AgregarCategoria1(CategoriaVehiculo nuevaCat)
        {
            try
            {
                if (ExisteCategoria(nuevaCat.IdCategoria))
                {
                    return "ERROR  La categoria con el ID " + nuevaCat.IdCategoria + " ya existe. No se puede agregar.";
                }

                //se busca el primer espacio vacio del arreglo para agregar la nueva categoria
                for (int i = 0; i < Almacenamiento.ArrayCategorias.Length; i++)
                {   
                    if (Almacenamiento.ArrayCategorias[i] == null)
                    {
                        Almacenamiento.ArrayCategorias[i] = nuevaCat;
                        contadorArrayCat ++;
                        return "Categoria agregada con exito";
                    }
                }
                return "No se pudo agregar la categoria, el almacenamiento esta lleno";
            }
            catch (Exception ex)
            {
                throw new Exception("Error en Logica" + ex.Message);
            }
        }

        //metodo para verificar si una categoria existe en el arreglo de categorias
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
    }  
}
