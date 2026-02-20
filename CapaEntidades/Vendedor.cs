using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Vendedor : Persona
    {
        private int IdVendedor { get; set; }
        private DateTime FechaIngreso { get; set; }
        //constructor que recibe los datos del vendedor y los envía al constructor de Persona
        public Vendedor(int id, string identificacion, string nombre, DateTime nacimiento, DateTime ingreso)
            : base(identificacion, nombre, nacimiento) // Envía los datos al constructor de Persona
        {
            this.IdVendedor = id;
            this.FechaIngreso = ingreso;
        }
    }
}
