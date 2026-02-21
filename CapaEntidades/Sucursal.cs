using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Sucursal
    {
        //atributos
        private int IdSucursal { get; set; }
        private string NombreSucursal { get; set; }
        private string Direccion { get; set; }
        private string Telefono { get; set; }
        private bool Activo { get; set; }
        private Vendedor vendedorEncargado { get; set; }
    }
}
