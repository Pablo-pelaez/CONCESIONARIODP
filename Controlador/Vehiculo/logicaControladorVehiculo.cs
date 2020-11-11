using System;
using System.Collections.Generic;
using System.Linq;
using Modelo.Vehiculo;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Controlador.Vehiculo
{
    public class logicaControladorVehiculo
    {
        //Negociar INSERT
        public int negociarInsertTipoVehiculo(int idVehiculo, string marca, string modelo, string placa, int anio, int id_tv)
        {
            accesoMetodosCRUDVehiculos negociarAcceso = new accesoMetodosCRUDVehiculos();

            return negociarAcceso.insertVehiculo(idVehiculo, marca, modelo, placa, anio, id_tv);
        }

        //Negociar SELECT
        public static DataTable negociarSelectTipoVehiculo()
        {
            return accesoMetodosCRUDVehiculos.listVehiculo();
        }

        //Negociar UPDATE
        public int negociarUpdateVehiculo(int idVehiculo, string marca, string modelo, string placa, int anio, int id_tv)
        {
            accesoMetodosCRUDVehiculos negociarAcceso = new accesoMetodosCRUDVehiculos();

            return negociarAcceso.updateVehiculo(idVehiculo, marca, modelo, placa, anio, id_tv);
        }

        //Negociar DELETE
        public int negociarDeleteVehiculo(int idTipoVehiculo)
        {
            accesoMetodosCRUDVehiculos negociarAcceso = new accesoMetodosCRUDVehiculos();

            return negociarAcceso.deleteVehiculo(idTipoVehiculo);
        }
    }
}
