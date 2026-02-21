using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Sucursal
    {
        //atributos
        public int IdSucursal { get; set; }
        public string NombreSucursal { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Vendedor vendedorEncargado { get; set; }
        public bool Activo { get; set; }

        public Sucursal(int id, string nombre, string direccion, string telefono, Vendedor encargado, bool activo)
        {
            this.IdSucursal = id;
            this.NombreSucursal = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.vendedorEncargado = encargado;
            this.Activo = activo;
        }
    }
}
