using Hilton.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Controller
{
    class CPago
    {
        public static DataTable ObtenerEncabezadoPago(int idEvento)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlconnection = new SqlConnection();
            try
            {
                sqlconnection.ConnectionString = Conexión.Cn;
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlconnection;
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "EncabezadoPago";

                SqlParameter ParIDEvento = new SqlParameter("@idEvento", SqlDbType.Int);
                ParIDEvento.Value = idEvento;
                sqlCom.Parameters.Add(ParIDEvento);

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

        public static DataTable ObtenerTotalSalones(int idEvento)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlconnection = new SqlConnection();
            try
            {
                sqlconnection.ConnectionString = Conexión.Cn;
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlconnection;
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "MostrarSalonesReservadoEvento";

                SqlParameter ParIDEvento = new SqlParameter("@IdEvento", SqlDbType.Int);
                ParIDEvento.Value = idEvento;
                sqlCom.Parameters.Add(ParIDEvento);

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

        public static DataTable  MostrarServiciosEvento(int idEvento)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlconnection = new SqlConnection();
            try
            {
                sqlconnection.ConnectionString = Conexión.Cn;
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlconnection;
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "MostrarServiciosEvento";

                SqlParameter ParIDEvento = new SqlParameter("@IdEvento", SqlDbType.Int);
                ParIDEvento.Value = idEvento;
                sqlCom.Parameters.Add(ParIDEvento);

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

        public static DataTable ObtenerTotales(int idEvento)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlconnection = new SqlConnection();
            try
            {
                sqlconnection.ConnectionString = Conexión.Cn;
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlconnection;
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "ObtenerTotalesPagoEvento";

                SqlParameter ParIDEvento = new SqlParameter("@idEvento", SqlDbType.Int);
                ParIDEvento.Value = idEvento;
                sqlCom.Parameters.Add(ParIDEvento);

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

        public static string GuardarPago(int idEvento, DateTime fecha, float descuento,
            int idEmpleado, string tipoPago)
        {
            string respuesta = "";
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection.ConnectionString = Conexión.Cn;
                sqlConnection.Open();
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlConnection;
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "GuardarPago";

                SqlParameter ParIdEvento = new SqlParameter("@idEvento", SqlDbType.Int);
                ParIdEvento.Value = idEvento;

                SqlParameter ParFecha = new SqlParameter("@fecha", SqlDbType.DateTime);
                ParFecha.Value = fecha;

                SqlParameter ParDescuento = new SqlParameter("@descuento", SqlDbType.Float);
                ParDescuento.Value = descuento;

                SqlParameter ParIdEmpleado = new SqlParameter("@idEmpleado", SqlDbType.Int);
                ParIdEmpleado.Value = idEmpleado;

                SqlParameter partipoPago = new SqlParameter("@tipoPago", SqlDbType.NVarChar, 50);
                partipoPago.Value = tipoPago;

                sqlCom.Parameters.Add(ParIdEvento);
                sqlCom.Parameters.Add(ParFecha);
                sqlCom.Parameters.Add(ParDescuento);
                sqlCom.Parameters.Add(ParIdEmpleado);
                sqlCom.Parameters.Add(partipoPago);


                respuesta = sqlCom.ExecuteNonQuery() == 0 ? "No se puede guardar el pago" : "OK";

            }
            catch (Exception ex)
            {
                respuesta = "Error al guardar el pago: " + ex.Message;
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
