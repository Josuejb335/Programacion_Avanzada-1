using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CategarioVehiculo
    {   
        //atributos
        private int IdCategoria { get; set; }
        private string NombreCategoria { get; set; }
        private string Descripcion { get; set; }
        //constructor
        public CategarioVehiculo(int id, string nombre, string descripcion)
        {
            this.IdCategoria = id;
            this.NombreCategoria = nombre;
            this.Descripcion = descripcion;
        }
    }
}
