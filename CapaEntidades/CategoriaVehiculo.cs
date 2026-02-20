using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CategoriaVehiculo
    {   
        //atributos
        public string IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }
        //constructor
        public CategoriaVehiculo(string id, string nombre, string descripcion)
        {
            this.IdCategoria = id;
            this.NombreCategoria = nombre;
            this.Descripcion = descripcion;
        }
        //constructor vacio para poder crear objetos sin necesidad de proporcionar los datos al momento instanciar
        public CategoriaVehiculo()
        {
        }   
    }
}
