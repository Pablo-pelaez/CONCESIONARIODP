using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.tipoConductor
{
    public class accesoMetodosCRUDTipoConductor
    {
        //operacion INSERT
        public int insertTipoConductor(int idTipoConductor, string nombre)
        {
            SqlCommand _comando = metodosCRUDTipoConductor.crearComandoSPInsertarTipoConductor(); 

            _comando.Parameters.AddWithValue(@"id", idTipoConductor);
            _comando.Parameters.AddWithValue(@"tipo_conductor", nombre);

            return metodosCRUDTipoConductor.ejecutarcomandoSPTipoConductor(_comando);
        }

        //Operación SELECT
        public static DataTable listTipoConductor()
        {
            SqlCommand _comando = metodosCRUDTipoConductor.crearComandoSELECTTipoConductor(); 

            _comando.CommandText = "select * from tip_conductor";

            return metodosCRUDTipoConductor.ejecutarcomandoSELECTTipoConductor(_comando);
        }

        //Operación UPDATE
        public int updateTipoConductor(int idTipoConductor, string nombre)
        {
            SqlCommand _comando = metodosCRUDTipoConductor.crearComandoSPUPDATEConductor();

            _comando.Parameters.AddWithValue(@"id", idTipoConductor);
            _comando.Parameters.AddWithValue(@"tipo_conductor", nombre);

            return metodosCRUDTipoConductor.ejecutarcomandoSPUPDATETipoConductor(_comando);
        }

        //Operación DELETE
        public int deleteTipoConductor(int idTipoConductor)
        {
            SqlCommand _comando = metodosCRUDTipoConductor.crearComandoSPDELETETipoConductor();

            _comando.Parameters.AddWithValue(@"id", idTipoConductor);

            return metodosCRUDTipoConductor.ejecutarcomandoSPDELETETipoConductor(_comando); 
        }
    }
}

