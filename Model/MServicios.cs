using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Model
{
    class MServicios
    {

        public static DataTable MostrarServicios()
        {
            DataTable dtResultado = new DataTable("MostrarServicios");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;

                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = SqlCon;
                sqlCom.CommandText = "MostrarServicios";
                sqlCom.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCom);
                sqlData.Fill(dtResultado);
            }
            catch(Exception ex)
            {
                dtResultado = null;

            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return dtResultado;
        }

        public static DataTable BuscarServicios(string dato)
        {
            DataTable dtResultado = new DataTable("MostrarServicios");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexión.Cn;

                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = SqlCon;
                sqlCom.CommandText = "BuscarServicio";
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
            catch (Exception ex)
            {
                dtResultado = null;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return dtResultado;
        }
        
        public static string EstadoServicio(int idServicio)
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
                SqlCmd.CommandText = "EstadoServicio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdSalon = new SqlParameter();
                ParIdSalon.ParameterName = "@idServicio";
                ParIdSalon.SqlDbType = SqlDbType.Int;
                ParIdSalon.Value = idServicio;
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

        public static string AgregarServicio(string nombre, float tarifa, string descripcion)
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
                SqlCmd.CommandText = "AgregarServicio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@nombre";
                Parnombre.SqlDbType = SqlDbType.NVarChar;
                Parnombre.Size = 80;
                Parnombre.Value = nombre;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter ParTarifa = new SqlParameter();
                ParTarifa.ParameterName = "@tarifa";
                ParTarifa.SqlDbType = SqlDbType.Float;
                ParTarifa.Value = tarifa;
                SqlCmd.Parameters.Add(ParTarifa);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.NVarChar;
                Parnombre.Size = 100;
                ParDescripcion.Value = descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

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

        public static string ActualizarServicio(int idServicio, string nombre, float tarifa, string descripcion)
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
                SqlCmd.CommandText = "ActualizarServicio";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdServicio = new SqlParameter();
                ParIdServicio.ParameterName = "@idServicio";
                ParIdServicio.SqlDbType = SqlDbType.Int;
                ParIdServicio.Value = idServicio;
                SqlCmd.Parameters.Add(ParIdServicio);

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@nombre";
                Parnombre.SqlDbType = SqlDbType.NVarChar;
                Parnombre.Size = 80;
                Parnombre.Value = nombre;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter ParTarifa = new SqlParameter();
                ParTarifa.ParameterName = "@tarifa";
                ParTarifa.SqlDbType = SqlDbType.Float;
                ParTarifa.Value = tarifa;
                SqlCmd.Parameters.Add(ParTarifa);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.NVarChar;
                Parnombre.Size = 100;
                ParDescripcion.Value = descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

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

    }
}
