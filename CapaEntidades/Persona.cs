using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Persona
    {
        //atributos
        protected string Identificacion { get; set; }
        protected string NombreCompleto { get; set; }
        protected DateTime FechaNacimiento { get; set; }

        //constructor
        protected Persona(string identificacion, string nombreCompleto, DateTime fechaNacimiento)
        {
            Identificacion = identificacion;
            NombreCompleto = nombreCompleto;
            FechaNacimiento = fechaNacimiento;
        }

    }
}
