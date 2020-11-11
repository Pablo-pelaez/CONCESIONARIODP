using Modelo.tipoVehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador.tipoVehiculo
{
    public class logicaControladortipoVehiculo
    {
        //Negociar INSERT
        public int negociarInsertTipoVehiculo(int idTipoVehiculo, string nombre)
        {
            accesoMetodosCRUDTipoVehiculo negociarAcceso = new accesoMetodosCRUDTipoVehiculo();

            return negociarAcceso.insertTipoVehiculo(idTipoVehiculo, nombre);
        }

        //Negociar SELECT
        public static DataTable negociarSelectTipoVehiculo()
        {
            return accesoMetodosCRUDTipoVehiculo.listTipoVehiculo();
        }

        //Negociar UPDATE
        public int negociarUpdateTipoVehiculo(int idTipoVehiculo, string nombre)
        {
            accesoMetodosCRUDTipoVehiculo negociarAcceso = new accesoMetodosCRUDTipoVehiculo();

            return negociarAcceso.updateTipoVehiculo(idTipoVehiculo, nombre);
        }

        //Negociar DELETE
        public int negociarDeleteTipoVehiculo(int idTipoVehiculo)
        {
            accesoMetodosCRUDTipoVehiculo negociarAcceso = new accesoMetodosCRUDTipoVehiculo();

            return negociarAcceso.deleteTipoVehiculo(idTipoVehiculo);
        }
    }
}
