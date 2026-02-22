
/*
 * UNED I Cuatrimestre 2026
 * Proyecto I, Gestion De AutoMarket. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : semana del 16 al 22 de Febrero del 2026
 */

namespace CapaEntidades
{
    public class Vendedor : Persona
    {
        public int IdVendedor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Telefono { get; set; }
        //constructor que recibe los datos del vendedor y los envía al constructor de Persona
        public Vendedor(int id, string identificacion, string nombre, DateTime nacimiento, DateTime ingreso, string telefono)
            : base(identificacion, nombre, nacimiento) // Envía los datos al constructor de Persona
        {
            this.IdVendedor = id;
            this.FechaIngreso = ingreso;
            this.Telefono = telefono;

        }

    }
}