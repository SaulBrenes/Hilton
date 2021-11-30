using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Model
{
    class MMantenimiento
    {
        
        public static DataTable MostrarTodos()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlconnection = new SqlConnection();
            try
            {
                sqlconnection.ConnectionString = Conexión.Cn;
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlconnection;
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "MostrarMantenimientos";

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCom);
                sqlData.Fill(dt);

            }
            catch (Exception)
            {
                dt = null;
            }
            finally
            {
                if (sqlconnection.State == ConnectionState.Open)
                {
                    sqlconnection.Close();
                }
            }
            return dt;
        }

        public static DataTable BuscarPor(string dato)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlconnection = new SqlConnection();
            try
            {
                sqlconnection.ConnectionString = Conexión.Cn;
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlconnection;
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "BuscarMantenimientos";

                SqlParameter ParDato = new SqlParameter("@dato", SqlDbType.NVarChar, 100);
                ParDato.Value = dato;

                sqlCom.Parameters.Add(ParDato);

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCom);
                sqlData.Fill(dt);

            }
            catch (Exception)
            {
                dt = null;
            }
            finally
            {
                if (sqlconnection.State == ConnectionState.Open)
                {
                    sqlconnection.Close();
                }
            }
            return dt;
        } 

        public static string Crear(int idSalon, int idEmpleado, int idEmpresa, float costo ,string descripcion, DateTime date)
        {
            string respuesta ="";
            SqlConnection sqlconnection = new SqlConnection();
            try
            {
                sqlconnection.ConnectionString = Conexión.Cn;
                SqlCommand sqlCom = new SqlCommand();
                sqlconnection.Open();
                sqlCom.Connection = sqlconnection;
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "AgregarMantenimientoSalon";

                SqlParameter ParIdSalon = new SqlParameter("@idSalon", SqlDbType.Int);
                ParIdSalon.Value = idSalon;

                SqlParameter ParIdEmpresa = new SqlParameter("@idEmpresa", SqlDbType.Int);
                ParIdEmpresa.Value = idEmpresa;

                SqlParameter ParIdEmpleado = new SqlParameter("@idEmpleado", SqlDbType.Int);
                ParIdEmpleado.Value = idEmpleado;

                SqlParameter ParCosto = new SqlParameter("@costo", SqlDbType.Float);
                ParCosto.Value = costo;

                SqlParameter ParDescripcion = new SqlParameter("@descripcion", SqlDbType.NVarChar, 150);
                ParDescripcion.Value = descripcion;

                SqlParameter ParFecha = new SqlParameter("@fecha", SqlDbType.Date);
                ParFecha.Value = $"{date.Year}-{date.Month}-{date.Day}";

                sqlCom.Parameters.Add(ParIdSalon);
                sqlCom.Parameters.Add(ParIdEmpresa);
                sqlCom.Parameters.Add(ParIdEmpleado);
                sqlCom.Parameters.Add(ParCosto);
                sqlCom.Parameters.Add(ParDescripcion);
                sqlCom.Parameters.Add(ParFecha);

                respuesta = sqlCom.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso mantenimiento";

            }
            catch (Exception ex)
            {
                respuesta = "No se pudo ingresar mantenimiento:"+ex.Message;
            }
            finally
            {
                if (sqlconnection.State == ConnectionState.Open)
                {
                    sqlconnection.Close();
                }
            }
            return respuesta;

        }

        public static string Editar(int idMantenimiento,int idSalon, int idEmpleado, 
            int idEmpresa, float costo, string descripcion, DateTime date)
        {
            string respuesta = "";
            SqlConnection sqlconnection = new SqlConnection();
            try
            {
                sqlconnection.ConnectionString = Conexión.Cn;
                SqlCommand sqlCom = new SqlCommand();
                sqlconnection.Open();
                sqlCom.Connection = sqlconnection;
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "EditarMantenimiento";


                SqlParameter ParIdMantenimiento = new SqlParameter("@idMantenimiento", SqlDbType.Int);
                ParIdMantenimiento.Value = idMantenimiento;

                SqlParameter ParIdSalon = new SqlParameter("@idSalon", SqlDbType.Int);
                ParIdSalon.Value = idSalon;

                SqlParameter ParIdEmpresa = new SqlParameter("@idEmpresa", SqlDbType.Int);
                ParIdEmpresa.Value = idEmpresa;

                SqlParameter ParIdEmpleado = new SqlParameter("@idEmpleado", SqlDbType.Int);
                ParIdEmpleado.Value = idEmpleado;

                SqlParameter ParCosto = new SqlParameter("@costo", SqlDbType.Float);
                ParCosto.Value = costo;

                SqlParameter ParDescripcion = new SqlParameter("@decripcion", SqlDbType.NVarChar, 200);
                ParDescripcion.Value = descripcion;

                SqlParameter ParFecha = new SqlParameter("@fecha", SqlDbType.Date);
                ParFecha.Value = $"{date.Year}-{date.Month}-{date.Day}";

                sqlCom.Parameters.Add(ParIdMantenimiento);
                sqlCom.Parameters.Add(ParIdSalon);
                sqlCom.Parameters.Add(ParIdEmpresa);
                sqlCom.Parameters.Add(ParIdEmpleado);
                sqlCom.Parameters.Add(ParCosto);
                sqlCom.Parameters.Add(ParDescripcion);
                sqlCom.Parameters.Add(ParFecha);

                respuesta = sqlCom.ExecuteNonQuery() == 1 ? "OK" : "No se edito mantenimiento";

            }
            catch (Exception ex)
            {
                respuesta = "No se puede editar mantenimiento:" + ex.Message;
            }
            finally
            {
                if (sqlconnection.State == ConnectionState.Open)
                {
                    sqlconnection.Close();
                }
            }
            return respuesta;
        }

        public static string Estado(int idMantenimiento) 
        {
            string respuesta = "";
            SqlConnection  sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexión.Cn;
                sqlConnection.Open();
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlConnection;
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "EstadoMantenimiento";

                SqlParameter ParIdMantenimiento = new SqlParameter("@idMantenimiento", SqlDbType.Int);
                ParIdMantenimiento.Value = idMantenimiento;

                sqlCom.Parameters.Add(ParIdMantenimiento);
                respuesta = sqlCom.ExecuteNonQuery() == 1 ? "OK" : "No se puede actualizar estado";

            }
            catch(Exception ex)
            {
                respuesta = "No se pudo actulizar estado del mantenimiento" + ex.Message ;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return respuesta;
        }


    }
}
