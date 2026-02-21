using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
