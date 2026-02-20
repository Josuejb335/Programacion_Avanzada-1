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
        // atributos
        private int IdVehiculo { get; set; }
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private int Anio { get; set; }
        private decimal Precio { get; set; }
        private char Estado { get; set; }
        private CategoriaVehiculo Categoria
        {
            get { return Categoria; }
            set { Categoria = value; }
        }

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
    }
}
