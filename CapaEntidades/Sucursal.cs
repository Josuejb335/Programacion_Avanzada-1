
/*
 * UNED I Cuatrimestre 2026
 * Proyecto I, Gestion De AutoMarket. 
 * Estudiante: Josue Jimenez Barrantes
 * Fecha desarrollo : semana del 16 al 22 de Febrero del 2026
 */

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
