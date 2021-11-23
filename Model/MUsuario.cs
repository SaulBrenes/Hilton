using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hilton.Model
{
    class MUsuario
    {

        public static DataTable Validar_Acceso(string usuario, string contraseña)
        {
            DataTable DtResultado = new DataTable("Inicio_Sesión");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando la conexión del servidor
                SqlCon.ConnectionString = Conexión.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Validar_Acceso";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //   Cargando los parámetros del procedimiento almacenado
                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 50;
                ParUsuario.Value = usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@contraseña";
                ParContraseña.SqlDbType = SqlDbType.VarChar;
                ParContraseña.Size = 50;
                ParContraseña.Value = contraseña;
                SqlCmd.Parameters.Add(ParContraseña);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception)
            {
                DtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return DtResultado;

        }

        public  static DataTable BuscarUsuario(string dato)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexión.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlConnection;
                SqlCmd.CommandText = "BuscarUsuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@dato";
                ParDato.SqlDbType = SqlDbType.NVarChar;
                ParDato.Value = dato;
                ParDato.Size= 100;
                SqlCmd.Parameters.Add(ParDato);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(SqlCmd);
                sqlDataAdapter.Fill(dt);

            }
            catch (Exception)
            {
                dt = null;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }
            return dt;
        }

        public static DataTable MostrarUsuarios()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlconection = new SqlConnection();

            try
            {
                sqlconection.ConnectionString = Conexión.Cn;
                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = sqlconection;
                sqlcommand.CommandType = CommandType.StoredProcedure;
                sqlcommand.CommandText = "MostrarUsuarios";

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlcommand);
                sqlData.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            finally
            {
                if(sqlconection.State == ConnectionState.Open)
                {
                    sqlconection.Close();
                }
            }

            return dt;
        }

        public static string ActualizarContrasenaUsuario(int idUsuario, string contrasena, string rol)
        {
            string respuesta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = Conexión.Cn;
                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = "ActualizarContrasenaUsuario";
                sqlCom.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
                ParIdUsuario.Value = idUsuario;

                sqlCom.Parameters.Add(ParIdUsuario);

                SqlParameter ParNContrasena = new SqlParameter("@nuevaContraseña", SqlDbType.NVarChar,100);
                ParNContrasena.Value = contrasena;

                sqlCom.Parameters.Add(ParNContrasena);

                SqlParameter ParRol = new SqlParameter("@rol", SqlDbType.NVarChar, 60);
                ParRol.Value = rol;
                sqlCom.Parameters.Add(ParRol);

                respuesta = sqlCom.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó contraseña";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return respuesta;
        }

        public static string ActualizarDatosUsuarios(int idUsuario, string usuario, int idEmpleado ,string rol)
        {
            DataTable dt = new DataTable();
            string respuesta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = Conexión.Cn;
                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = "ActualizarDatosUsuario";
                sqlCom.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdUsuario = new SqlParameter("@idUsuario", SqlDbType.Int);
                ParIdUsuario.Value = idUsuario;

                sqlCom.Parameters.Add(ParIdUsuario);

                SqlParameter ParUsuario= new SqlParameter("@usuario", SqlDbType.NVarChar, 50);
                ParUsuario.Value = usuario;

                sqlCom.Parameters.Add(ParUsuario);

                SqlParameter ParIdEmpleado = new SqlParameter("@idEmpleado", SqlDbType.Int);
                ParIdEmpleado.Value = idEmpleado;

                sqlCom.Parameters.Add(ParIdEmpleado);

                SqlParameter ParRol = new SqlParameter("@rol", SqlDbType.NVarChar, 60);
                ParRol.Value = rol;
                sqlCom.Parameters.Add(ParRol);

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCom);
                sqlData.Fill(dt);
                respuesta = dt.Rows[0].ItemArray[0].ToString();

                //respuesta = sqlCom.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó datos del usuario";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return respuesta;
        }

        public static string EstadoUsuario(int idUsuario)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código
                SqlCon.ConnectionString = Conexión.Cn;
                SqlCon.Open();
                //Establecer el Comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "EstadoUsuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdUsuario = new SqlParameter();
                ParIdUsuario.ParameterName = "@IdUsuario";
                ParIdUsuario.SqlDbType = SqlDbType.Int;
                ParIdUsuario.Value = idUsuario;
                SqlCmd.Parameters.Add(ParIdUsuario);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el estado";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public static string InsertarUsuario(string usuario, string contraseña, string rol, int idEmpleado)
        {
            string respuesta;
            SqlConnection sqlCon = new SqlConnection();

            try
            {
                sqlCon.ConnectionString = Conexión.Cn;
                sqlCon.Open();
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = "Insertar_Usuario";
                sqlCom.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUsuario = new SqlParameter("@usuario", SqlDbType.NVarChar, 50);
                ParUsuario.Value = usuario;

                sqlCom.Parameters.Add(ParUsuario);

                SqlParameter ParIdEmpleado = new SqlParameter("@idEmpleado", SqlDbType.Int);
                ParIdEmpleado.Value = idEmpleado;

                sqlCom.Parameters.Add(ParIdEmpleado);

                SqlParameter ParRol = new SqlParameter("@rol", SqlDbType.NVarChar, 60);
                ParRol.Value = rol;

                sqlCom.Parameters.Add(ParRol);

                SqlParameter ParNContrasena = new SqlParameter("@contraseña", SqlDbType.NVarChar, 50);
                ParNContrasena.Value = contraseña;

                sqlCom.Parameters.Add(ParNContrasena);

                respuesta = sqlCom.ExecuteNonQuery() == 1 ? "OK" : "No se actualizó usuario";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            }

            return respuesta;
        }
        

    }
}
