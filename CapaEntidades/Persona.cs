
/*
 * UNED I Cuatrimestre 2026
 * Proyecto I, Gestion De AutoMarket. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : semana del 16 al 22 de Febrero del 2026
 */

namespace CapaEntidades
{
    public class Persona
    {
        //atributos
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        //constructor
        public Persona(string identificacion, string nombre, DateTime fechaNacimiento)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            FechaNacimiento = fechaNacimiento;
        }

    }
}
