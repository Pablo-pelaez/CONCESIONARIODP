using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Vehiculo
{
    public class accesoMetodosCRUDVehiculos
    {
        //operacion INSERT
        public int insertVehiculo(int idVehiculo, string marca, string modelo, string placa, int anio, int id_tv)
        {
            SqlCommand _comando = metodosCRUDVehiculo.crearComandoSPInsertarVehiculo();

            _comando.Parameters.AddWithValue(@"id", idVehiculo);
            _comando.Parameters.AddWithValue(@"marca", marca);
            _comando.Parameters.AddWithValue(@"modelo", modelo);
            _comando.Parameters.AddWithValue(@"placa", placa);
            _comando.Parameters.AddWithValue(@"anio", anio);
            _comando.Parameters.AddWithValue(@"id_tv", id_tv);

            return metodosCRUDVehiculo.ejecutarcomandoSPVehiculo(_comando);
        }

        //Operación SELECT
        public static DataTable listVehiculo()
        {
            SqlCommand _comando = metodosCRUDVehiculo.crearComandoSELECVehiculo();

            _comando.CommandText = "select * from Vehiculo";

            return metodosCRUDVehiculo.ejecutarcomandoSELECTVehiculo(_comando);
        }

        //Operación UPDATE
        public int updateVehiculo(int idVehiculo, string marca, string modelo, string placa, int anio, int id_tv)
        {
            SqlCommand _comando = metodosCRUDVehiculo.crearComandoSPUPDATEVehiculo();

            _comando.Parameters.AddWithValue(@"id", idVehiculo);
            _comando.Parameters.AddWithValue(@"marca", marca);
            _comando.Parameters.AddWithValue(@"modelo", modelo);
            _comando.Parameters.AddWithValue(@"placa", placa);
            _comando.Parameters.AddWithValue(@"anio", anio);
            _comando.Parameters.AddWithValue(@"id_tv", id_tv);

            return metodosCRUDVehiculo.ejecutarcomandoSPUPDATEVehiculo(_comando);
        }

        //Operación DELETE
        public int deleteVehiculo(int idVehiculo)
        {
            SqlCommand _comando = metodosCRUDVehiculo.crearComandoSPDELETEVehiculo();

            _comando.Parameters.AddWithValue(@"id", idVehiculo);

            return metodosCRUDVehiculo.ejecutarcomandoSPDELETEVehiculo(_comando);
        }
    }
}
