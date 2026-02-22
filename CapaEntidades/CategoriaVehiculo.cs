
/*
 * UNED I Cuatrimestre 2026
 * Proyecto I, Gestion De AutoMarket. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : semana del 16 al 22 de Febrero del 2026
 */

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
