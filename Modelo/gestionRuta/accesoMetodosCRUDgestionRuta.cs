using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.gestionRuta
{
    public class accesoMetodosCRUDgestionRuta
    {
        //operacion INSERT
        public int insertgestinRuta(int id, string estacion, int id_vehiculo)
        {
            SqlCommand _comando = metodosCRUDgestionRuta.crearComandoSPInsertargestionRuta();

            _comando.Parameters.AddWithValue(@"id", id);
            _comando.Parameters.AddWithValue(@"estacion", estacion);
            _comando.Parameters.AddWithValue(@"id_vehiculo", id_vehiculo);

            return metodosCRUDgestionRuta.ejecutarcomandoSPgestionRuta(_comando);
        }

        //Operación SELECT
        public static DataTable listgestionRuta()
        {
            SqlCommand _comando = metodosCRUDgestionRuta.crearComandoSELECTgestionRuta();

            _comando.CommandText = "select * from ruta";

            return metodosCRUDgestionRuta.ejecutarcomandoSELECTgestionRuta(_comando); 
        }

        //Operación UPDATE
        public int updategestionRuta(int id, string estacion, int id_vehiculo)
        {
            SqlCommand _comando = metodosCRUDgestionRuta.crearComandoSPUPDATEgestionRuta();

            _comando.Parameters.AddWithValue(@"id", id);
            _comando.Parameters.AddWithValue(@"estacion", estacion);
            _comando.Parameters.AddWithValue(@"id_vehiculo", id_vehiculo);
            return metodosCRUDgestionRuta.ejecutarcomandoSPUPDATEgestionRuta(_comando);
        }

        //Operación DELETE
        public int deletegestionRuta(int id)
        {
            SqlCommand _comando = metodosCRUDgestionRuta.crearComandoSPDELETEgestionRuta();

            _comando.Parameters.AddWithValue(@"id", id);

            return metodosCRUDgestionRuta.ejecutarcomandoSPUPDATEgestionRuta(_comando);
        }
    }
}

