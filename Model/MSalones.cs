using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Model
{
    class MSalones
    {
        public static DataTable MostrarSalones()
        {
            DataTable dtResultado = new DataTable("MostrarSalones");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;

                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = SqlCon;
                sqlCom.CommandText = "MostrarSalones";
                sqlCom.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCom);
                sqlData.Fill(dtResultado);
            }
            catch (Exception)
            {
                dtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dtResultado;
        }

        public static DataTable BuscarSalones(string dato)
        {
            DataTable dtResultado = new DataTable("MostrarSalones");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexión.Cn;

                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = SqlCon;
                sqlCom.CommandText = "BuscarSalon";
                sqlCom.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDato = new SqlParameter();
                ParDato.ParameterName = "@dato";
                ParDato.SqlDbType = SqlDbType.VarChar;
                ParDato.Size = 100;
                ParDato.Value = dato;
                sqlCom.Parameters.Add(ParDato);

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCom);
                sqlData.Fill(dtResultado);
            }
            catch(Exception)
            {
                dtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return dtResultado;
        }

        public static string AgregarSalon(string codigo, string nombre, float precioHora, int capacidadMax)
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
                SqlCmd.CommandText = "AgregarSalon";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 2;
                ParCodigo.Value = codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParPrecioHora = new SqlParameter();
                ParPrecioHora.ParameterName = "@precioHora";
                ParPrecioHora.SqlDbType = SqlDbType.Float;
                ParPrecioHora.Value = precioHora;
                SqlCmd.Parameters.Add(ParPrecioHora);

                SqlParameter ParCapacidadMax = new SqlParameter();
                ParCapacidadMax.ParameterName = "@capacidadMax";
                ParCapacidadMax.SqlDbType = SqlDbType.Int;
                ParCapacidadMax.Value = capacidadMax;
                SqlCmd.Parameters.Add(ParCapacidadMax);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingreso el Registro";

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

        public static string ActualizarSalon(int idSalon,string codigo, string nombre, float precioHora, int capacidadMax)
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
                SqlCmd.CommandText = "ActualizarSalon";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdSalon = new SqlParameter();
                ParIdSalon.ParameterName = "@idSalon";
                ParIdSalon.SqlDbType = SqlDbType.Int;
                ParIdSalon.Value = idSalon;
                SqlCmd.Parameters.Add(ParIdSalon);

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 2;
                ParCodigo.Value = codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParPrecioHora = new SqlParameter();
                ParPrecioHora.ParameterName = "@preciohora";
                ParPrecioHora.SqlDbType = SqlDbType.Float;
                ParPrecioHora.Value = precioHora;
                SqlCmd.Parameters.Add(ParPrecioHora);

                SqlParameter ParCapacidadMax = new SqlParameter();
                ParCapacidadMax.ParameterName = "@capacidadMax";
                ParCapacidadMax.SqlDbType = SqlDbType.Int;
                ParCapacidadMax.Value = capacidadMax;
                SqlCmd.Parameters.Add(ParCapacidadMax);

                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el Registro";

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

        public static string EstadoSalon(int idSalon) {
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
                SqlCmd.CommandText = "EstadoSalon";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdSalon = new SqlParameter();
                ParIdSalon.ParameterName = "@idSalon";
                ParIdSalon.SqlDbType = SqlDbType.Int;
                ParIdSalon.Value = idSalon;
                SqlCmd.Parameters.Add(ParIdSalon);


                //Ejecutamos nuestro comando

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se actualizo el estado";

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
