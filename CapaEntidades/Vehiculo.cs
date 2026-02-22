
/*
 * UNED I Cuatrimestre 2026
 * Proyecto I, Gestion De AutoMarket. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : semana del 16 al 22 de Febrero del 2026
 */

namespace CapaEntidades
{
    public class Vehiculo
    {
        // atributos
        public int IdVehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public decimal Precio { get; set; }
        public char Estado { get; set; }
        public CategoriaVehiculo Categoria { get; set; } 

        //constructor
        public Vehiculo(int id, string marca, string modelo, int anio, decimal precio, char estado, CategoriaVehiculo categoria)
        {
            this.IdVehiculo = id;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Anio = anio;
            this.Precio = precio;
            this.Estado = estado;
            this.Categoria = categoria;
        }
        public Vehiculo() { }   
    }
}
