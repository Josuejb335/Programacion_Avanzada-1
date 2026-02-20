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
        public string AgregarCategoria(CategoriaVehiculo nuevaCat)
        {
            try
            {
                for (int i = 0; i < Almacenamiento.ArrayCategorias.Length; i++)
                {
                    //se busca el primer espacio vacio del arreglo para agregar la nueva categoria
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
    }  
}
