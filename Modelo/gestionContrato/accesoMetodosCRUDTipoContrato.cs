using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.gestionContrato
{
    public class accesoMetodosCRUDTipoContrato
    {
        //operacion INSERT
        public int insertTipoContrato(int idTipoContrato, int idConductor,int Idvehiculo)
        {
            SqlCommand _comando = metodosCRUDContrato.crearComandoSPInsertarTipoContrato();

            _comando.Parameters.AddWithValue(@"id", idTipoContrato);
            _comando.Parameters.AddWithValue(@"id_conductor", idConductor);
            _comando.Parameters.AddWithValue(@"id_vehiculo", Idvehiculo);

            return metodosCRUDContrato.ejecutarcomandoSPTipoContrato(_comando);
        }

        //Operación SELECT
        public static DataTable listTipoContrato()
        {
            SqlCommand _comando = metodosCRUDContrato.crearComandoSELECTTipoContrato();

            _comando.CommandText = "select *from contrato";

            return metodosCRUDContrato.ejecutarcomandoSELECTTipoContrato(_comando);
        }

        //Operación UPDATE
        public int updateTipoConductor(int idTipoContrato, int idConductor, int Idvehiculo)
        {
            SqlCommand _comando = metodosCRUDContrato.crearComandoSPUPDATEContrato();

            _comando.Parameters.AddWithValue(@"id", idTipoContrato);
            _comando.Parameters.AddWithValue(@"id_conductor", idConductor);
            _comando.Parameters.AddWithValue(@"id_vehiculo", Idvehiculo);

            return metodosCRUDContrato.ejecutarcomandoSPUPDATETipoContrato(_comando);
        }

        //Operación DELETE
        public int deleteTipoConductor(int idTipoContrato)
        {
            SqlCommand _comando = metodosCRUDContrato.crearComandoSPDELETETipoContrato();

            _comando.Parameters.AddWithValue(@"id", idTipoContrato);

            return metodosCRUDContrato.ejecutarcomandoSPDELETETipoContrato(_comando);
        }
    }
}
