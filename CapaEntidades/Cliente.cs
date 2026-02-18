using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente : Persona
    {
        // atributos
        private int IdCliente { get; set; }
        private DateTime FechaRegistro { get; set; }
        private bool Activo { get; set; }
        // constructor
        public Cliente(int id, DateTime registro, bool activo, string identificacion, string nombre, DateTime nacimiento)
            : base(identificacion, nombre, nacimiento) // envía los datos al constructor de Persona
        {
            this.IdCliente = id;
            this.FechaRegistro = registro;
            this.Activo = activo;
        }


    }
}
