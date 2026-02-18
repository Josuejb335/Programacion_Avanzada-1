using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Vehiculo
    {
        private string IdVehiculo { get; set; }
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private int Anio { get; set; }
        private int Precio { get; set; }
        private char Estado { get; set; }
        private CategoriaVehiculo Categoria
        {
            get { return Categoria; }
            set { Categoria = value; }
        }

    }
}
