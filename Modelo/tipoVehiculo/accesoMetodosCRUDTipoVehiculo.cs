using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.tipoVehiculo
{
    public class accesoMetodosCRUDTipoVehiculo
    {
        //operacion INSERT
        public int insertTipoVehiculo(int idTipoVehiculo, string nombre)
        {
            SqlCommand _comando = metodosCRUDTipoVehiculo.crearComandoSPInsertarTipoVehiculo();

            _comando.Parameters.AddWithValue(@"id", idTipoVehiculo);
            _comando.Parameters.AddWithValue(@"nombre", nombre);

            return metodosCRUDTipoVehiculo.ejecutarcomandoSPTipoVehiculo(_comando);
        }

        //Operación SELECT
        public static DataTable listTipoVehiculo()
        {
            SqlCommand _comando = metodosCRUDTipoVehiculo.crearComandoSELECTTipoVehiculo();

            _comando.CommandText = "select * from Tipo_Vehiculo";

            return metodosCRUDTipoVehiculo.ejecutarcomandoSELECTTipoVehiculo(_comando);
        }

        //Operación UPDATE
        public int updateTipoVehiculo(int idTipoVehiculo, string nombre)
        {
            SqlCommand _comando = metodosCRUDTipoVehiculo.crearComandoSPUPDATETipoVehiculo();

            _comando.Parameters.AddWithValue(@"id", idTipoVehiculo);
            _comando.Parameters.AddWithValue(@"nombre", nombre);

            return metodosCRUDTipoVehiculo.ejecutarcomandoSPUPDATETipoVehiculo(_comando);
        }

        //Operación DELETE
        public int deleteTipoVehiculo(int idTipoVehiculo)
        {
            SqlCommand _comando = metodosCRUDTipoVehiculo.crearComandoSPDELETETipoVehiculo();

            _comando.Parameters.AddWithValue(@"id", idTipoVehiculo);

            return metodosCRUDTipoVehiculo.ejecutarcomandoSPDELETETipoVehiculo(_comando);
        }
    }
}
