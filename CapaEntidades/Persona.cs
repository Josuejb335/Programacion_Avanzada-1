using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
