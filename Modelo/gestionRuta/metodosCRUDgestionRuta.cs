using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.gestionRuta
{
    public class metodosCRUDgestionRuta
    {
        //Crear tipo de comando para insertar(INSERT)
        //SP(Storaged procedure)
        public static SqlCommand crearComandoSPInsertargestionRuta()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("pro_ruta", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar tipo de comando insertar(INSERT)
        public static int ejecutarcomandoSPgestionRuta(SqlCommand comando)
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
        public static SqlCommand crearComandoSELECTgestionRuta()
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
        public static DataTable ejecutarcomandoSELECTgestionRuta(SqlCommand comando)
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
        public static SqlCommand crearComandoSPUPDATEgestionRuta()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("update_ruta", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar tipo de comando modificar/actualizar(UPDATE)
        public static int ejecutarcomandoSPUPDATEgestionRuta(SqlCommand comando)
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
        public static SqlCommand crearComandoSPDELETEgestionRuta()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;

            SqlConnection _conexion = new SqlConnection(_cadenaConexion);

            SqlCommand _comando = new SqlCommand("delete_ruta", _conexion);

            _comando.CommandType = CommandType.StoredProcedure;

            return _comando;
        }

        //Ejecutar tipo de comando eliminar(DELETE)
        public static int ejecutarcomandoSPDELETEgestionRuta(SqlCommand comando)
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
