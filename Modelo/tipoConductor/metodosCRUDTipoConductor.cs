using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.tipoConductor
{
    public class metodosCRUDTipoConductor
    {
        //Crear tipo de comando para insertar(INSERT)
        //SP(Storaged procedure)
        public static SqlCommand crearComandoSPInsertarTipoConductor()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("addtipconductor", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar tipo de comando insertar(INSERT)
        public static int ejecutarcomandoSPTipoConductor(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }


        //Instrucciones para Listar

        //Crear tipo de comando para seleccionar(SELECT)
        public static SqlCommand crearComandoSELECTTipoConductor()
        {
            //Usar la conexión
            string _cadenaConexion = Configuracion.CadenaConexion;

            //Constructor sin parámetros
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;

            //Crear la instrucción SELECT
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();

            _comando.CommandType = CommandType.Text;

            return _comando;
        }

        //Ejecutar tipo de comando para seleccionar(SELECT)
        public static DataTable ejecutarcomandoSELECTTipoConductor(SqlCommand comando)
        {
            DataTable _table = new DataTable();

            try
            {
                comando.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = comando;
                adapter.Fill(_table);
            }
            catch (Exception Ex) { throw Ex; }
            finally { comando.Connection.Close(); }

            return _table;
        }


        //Crear tipo de comando para modificar/actualizar(UPDATE)
        //SP(Storaged procedure)
        public static SqlCommand crearComandoSPUPDATEConductor()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("dbo.updateaddtipconductor", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar tipo de comando modificar/actualizar(UPDATE)
        public static int ejecutarcomandoSPUPDATETipoConductor(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }


        //Crear tipo de comando para eliminar(DELETE)
        //SP(Storaged procedure)
        public static SqlCommand crearComandoSPDELETETipoConductor()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("deleteaddtip_conductor", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar tipo de comando eliminar(DELETE)
        public static int ejecutarcomandoSPDELETETipoConductor(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
    }
}
    

