using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Model
{
    class MClientes
    {

        public static int IdultimoClienteRegistrado()
        {
            DataTable DtResultado = new DataTable("MostrarClientes");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexión.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ObtenerUltimoIdCliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception)
            {
                return -1;
            }

            return Convert.ToInt32(DtResultado.Rows[0][0]);
        }
    

        public static DataTable MostrarClientes()
        {
            DataTable DtResultado = new DataTable("MostrarClientes");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexión.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "MostrarClientes";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public static DataTable BuscarCliente(string dato)
        {
            DataTable DtResultado = new DataTable("BuscarCliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexión.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "BuscarCliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@dato";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 100;
                ParDato.Value = dato;
                SqlCmd.Parameters.Add(ParDato);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public static string EstadoCliente(int IdCliente)
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
                SqlCmd.CommandText = "EstadoCliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@IdCliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

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

        public static string InsertarCliente(string primernombre, string segundonombre, string primerapellido,
                                         string segundoapellido, string telefono, string cedula)
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
                SqlCmd.CommandText = "AgregarCliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParPrimerNombre = new SqlParameter();
                ParPrimerNombre.ParameterName = "@pNom";
                ParPrimerNombre.SqlDbType = SqlDbType.VarChar;
                ParPrimerNombre.Size = 60;
                ParPrimerNombre.Value = primernombre;
                SqlCmd.Parameters.Add(ParPrimerNombre);

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@sNom";
                ParSegundoNombre.SqlDbType = SqlDbType.VarChar;
                ParSegundoNombre.Size = 50;
                ParSegundoNombre.Value = segundonombre;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@pApe";
                ParPrimerApellido.SqlDbType = SqlDbType.VarChar;
                ParPrimerApellido.Size = 50;
                ParPrimerApellido.Value = primerapellido;
                SqlCmd.Parameters.Add(ParPrimerApellido);

                SqlParameter ParSegundoApellido = new SqlParameter();
                ParSegundoApellido.ParameterName = "@sApe";
                ParSegundoApellido.SqlDbType = SqlDbType.VarChar;
                ParSegundoApellido.Size = 50;
                ParSegundoApellido.Value = segundoapellido;
                SqlCmd.Parameters.Add(ParSegundoApellido);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.NVarChar;
                ParSegundoApellido.Size = 8;
                ParTelefono.Value = telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCedula = new SqlParameter("@cedula", SqlDbType.NVarChar, 16);
                ParCedula.Value = cedula;
                SqlCmd.Parameters.Add(ParCedula);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

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

        public static string ActualizarCliente(int idCliente, string primernombre, string segundonombre, string primerapellido,
                                        string segundoapellido, string telefono, string cedula)
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
                SqlCmd.CommandText = "ActualizarCliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idCliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = idCliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParPrimerNombre = new SqlParameter();
                ParPrimerNombre.ParameterName = "@pNom";
                ParPrimerNombre.SqlDbType = SqlDbType.VarChar;
                ParPrimerNombre.Size = 60;
                ParPrimerNombre.Value = primernombre;
                SqlCmd.Parameters.Add(ParPrimerNombre);

                SqlParameter ParSegundoNombre = new SqlParameter();
                ParSegundoNombre.ParameterName = "@sNom";
                ParSegundoNombre.SqlDbType = SqlDbType.VarChar;
                ParSegundoNombre.Size = 50;
                ParSegundoNombre.Value = segundonombre;
                SqlCmd.Parameters.Add(ParSegundoNombre);

                SqlParameter ParPrimerApellido = new SqlParameter();
                ParPrimerApellido.ParameterName = "@pApe";
                ParPrimerApellido.SqlDbType = SqlDbType.VarChar;
                ParPrimerApellido.Size = 50;
                ParPrimerApellido.Value = primerapellido;
                SqlCmd.Parameters.Add(ParPrimerApellido);

                SqlParameter ParSegundoApellido = new SqlParameter();
                ParSegundoApellido.ParameterName = "@sApe";
                ParSegundoApellido.SqlDbType = SqlDbType.VarChar;
                ParSegundoApellido.Size = 50;
                ParSegundoApellido.Value = segundoapellido;
                SqlCmd.Parameters.Add(ParSegundoApellido);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.NVarChar;
                ParSegundoApellido.Size = 8;
                ParTelefono.Value = telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParCedula = new SqlParameter("@cedula", SqlDbType.NVarChar, 16);
                ParCedula.Value = cedula;
                SqlCmd.Parameters.Add(ParCedula);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

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
    }
}
