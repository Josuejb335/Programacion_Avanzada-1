using CapaAccesoDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class LogicaAsocie
    {
        //contador para el arreglo de sucursales activas
        int contadorArrayActivas = 0;

        //metodo para obtener las sucursales activas
        public Sucursal[] ObtenerSucActivas()
        {
            for (int i = 0; i < Almacenamiento.ArraySucursales.Length; i++)
            {
                if (Almacenamiento.ArraySucursales[i] != null && Almacenamiento.ArraySucursales[i].Activo)
                {
                    contadorArrayActivas++;
                }
            }
            Almacenamiento.ArraySucursalesActivas = new Sucursal[contadorArrayActivas];
            //contador para el arreglo de sucursales activas
            int indiceNuevo = 0;

            for (int i = 0; i < Almacenamiento.ArraySucursales.Length; i++)
            {
                if (Almacenamiento.ArraySucursales[i] != null && Almacenamiento.ArraySucursales[i].Activo)
                {
                    Almacenamiento.ArraySucursalesActivas[indiceNuevo] = Almacenamiento.ArraySucursales[i];
                    indiceNuevo++;
                }
            }
            return Almacenamiento.ArraySucursalesActivas;
        }

        //metoodo para asociar un vehiculo a una sucursal (lo agrega al array para eso)
        public string AgregarAsociacion(Vehiculo veh, Sucursal suc, int num)
        {
            try
            {
                //verificar que no exista esa asociacion antes de agregarla
                if (ExisteAsociacion(veh.IdVehiculo, suc.IdSucursal))
                {
                    return "ERROR ya existe esa asociacion.";
                }

                //verificar que no sean null antes de agregar la asociacion
                if (veh == null || suc == null)
                {
                    return "ERROR  Por favor, seleccione un vehículo y una sucursal para asociar.";
                }

                //se busca el primer espacio vacio del arreglo para agregar la nueva asociacion
                for (int i = 0; i < Almacenamiento.ArrayVehiculosxSucursal.Length; i++)
                {
                    if (Almacenamiento.ArrayVehiculosxSucursal[i] == null)
                    {
                        Almacenamiento.ArrayVehiculosxSucursal[i] = new VehiculoxSucursal { vehiculoAsociado = veh, sucursalAsociada = suc, cantidad = num};
                        return "Asociación agregada con éxito";
                    }
                }
                return "ERROR No se pudo agregar la asociación, el almacenamiento está lleno";
            }
            catch (Exception ex)
            {
                return "ERROR al agregar la asociación: " + ex.Message;
            }
        }
    
        //metodo para revisar que no se agreguen asociaciones repetidas
        public bool ExisteAsociacion(int idVehiculo, int idSucursal)
        {
            for (int i = 0; i < Almacenamiento.ArrayVehiculosxSucursal.Length; i++)
            {
                if (Almacenamiento.ArrayVehiculosxSucursal[i] != null &&
                    Almacenamiento.ArrayVehiculosxSucursal[i].vehiculoAsociado.IdVehiculo == idVehiculo &&
                    Almacenamiento.ArrayVehiculosxSucursal[i].sucursalAsociada.IdSucursal == idSucursal)
                {
                    return true;
                }
            }
            return false;
        }




    }
}
