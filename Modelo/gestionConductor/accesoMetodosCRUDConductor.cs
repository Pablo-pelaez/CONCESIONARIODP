using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.gestionConductor
{
    public class accesoMetodosCRUDConductor
    {
        //operacion INSERT
        public int insertConductor(int idConductor, string nombre, string licencia, int Id_Vehiculo,int id_tipo_conductor)
        {
            SqlCommand _comando = metodosCRUDConductor.crearComandoSInsertarConductor();

            _comando.Parameters.AddWithValue(@"id", idConductor);
            _comando.Parameters.AddWithValue(@"nombre", nombre);
            _comando.Parameters.AddWithValue(@"tipo_licencia", licencia);
            _comando.Parameters.AddWithValue(@"id_vehiculo", Id_Vehiculo);
            _comando.Parameters.AddWithValue(@"id_tipo_conductor", id_tipo_conductor);

            return metodosCRUDConductor.ejecutarcomandoSConductor(_comando);
        }

        //Operación SELECT
        public static DataTable listConductor()
        {
            SqlCommand _comando = metodosCRUDConductor.crearComandoSELECTConductor();

            _comando.CommandText = "select * from conductor";

            return metodosCRUDConductor.ejecutarcomandoSELECTConductor(_comando);
        }

        //Operación UPDATE
        public int updateConductor(int idConductor, string nombre, string licencia, int Id_Vehiculo, int id_tipo_conductor)
        {
            SqlCommand _comando = metodosCRUDConductor.crearComandoSPUPDATEConductor();

            _comando.Parameters.AddWithValue(@"id", idConductor);
            _comando.Parameters.AddWithValue(@"nombre", nombre);
            _comando.Parameters.AddWithValue(@"tipo_licencia", licencia);
            _comando.Parameters.AddWithValue(@"id_vehiculo", Id_Vehiculo);
            _comando.Parameters.AddWithValue(@"id_tipo_conductor", id_tipo_conductor);

            return metodosCRUDConductor.ejecutarcomandoSPUPDATETipoConductor(_comando);
        }

        //Operación DELETE
        public int deleteConductor(int idTipoConductor)
        {
            SqlCommand _comando = metodosCRUDConductor.crearComandoSPDELETEConductor();

            _comando.Parameters.AddWithValue(@"id", idTipoConductor);

            return metodosCRUDConductor.ejecutarcomandoSPDELETEConductor(_comando);
        }
    }
}
