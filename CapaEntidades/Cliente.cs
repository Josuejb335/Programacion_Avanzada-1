
/*
 * UNED I Cuatrimestre 2026
 * Proyecto I, Gestion De AutoMarket. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : semana del 16 al 22 de Febrero del 2026
 */

namespace CapaEntidades
{
    public class Cliente : Persona
    {
        // atributos
        public int IdCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
        // constructor
        public Cliente(int id, string identificacion, string nombre, DateTime nacimiento, DateTime registro, bool activo)
            : base(identificacion, nombre, nacimiento) // envía los datos al constructor de Persona
        {
            this.IdCliente = id;
            this.FechaRegistro = registro;
            this.Activo = activo;
        }


    }
}
