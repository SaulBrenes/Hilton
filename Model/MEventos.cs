using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Model
{
    class MEventos
    {
        public static DataTable Mostrar()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlconnection = new SqlConnection();
            try
            {
                sqlconnection.ConnectionString = Conexión.Cn;
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlconnection;
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "MostrarEventos";

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
        
        public static DataTable Buscar(string dato)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlconnection = new SqlConnection();
            try
            {
                sqlconnection.ConnectionString = Conexión.Cn;
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlconnection;
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "BuscarEventos";

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

        public static DataTable ReservacionesEvento(int idEvento)
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

                SqlParameter ParIdEvento = new SqlParameter("@IdEvento", SqlDbType.Int);
                ParIdEvento.Value = idEvento;

                sqlCom.Parameters.Add(ParIdEvento);

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

        public static DataTable SeviciosEvento(int idEvento)
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

                SqlParameter ParIdEvento = new SqlParameter("@IdEvento", SqlDbType.Int);
                ParIdEvento.Value = idEvento;

                sqlCom.Parameters.Add(ParIdEvento);

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

        public static DataTable ContratacionesEvento(int idEvento)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlconnection = new SqlConnection();
            try
            {
                sqlconnection.ConnectionString = Conexión.Cn;
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlconnection;
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "MostrarContratacionesExternas";

                SqlParameter ParIdEvento = new SqlParameter("@idEvento", SqlDbType.Int);
                ParIdEvento.Value = idEvento;

                sqlCom.Parameters.Add(ParIdEvento);

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

        public static string CambioEstadoEvento(int idEvento)
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
                sqlCom.CommandText = "EventoCanceladoReservado";

                SqlParameter ParIdEvento = new SqlParameter("@idEvento", SqlDbType.Int);
                ParIdEvento.Value = idEvento;

                sqlCom.Parameters.Add(ParIdEvento);
                respuesta = sqlCom.ExecuteNonQuery() == 1 ? "OK" : "No se puede actualizar estado";

            }
            catch (Exception ex)
            {
                respuesta = "No se pudo actulizar estado del evento" + ex.Message;
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

        public static DataTable SalonesOcupados(DateTime fecha)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlconnection = new SqlConnection();
            try
            {
                sqlconnection.ConnectionString = Conexión.Cn;
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlconnection;
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "SalonesOcupados";

                SqlParameter ParFecha = new SqlParameter("@fecha", SqlDbType.Date);
                ParFecha.Value = $"{fecha.Year}-{fecha.Month}-{fecha.Day}";

                sqlCom.Parameters.Add(ParFecha);

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCom);
                sqlData.Fill(dt);
            }
            catch
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

        public static DataTable SalonesDisponibles(DateTime fecha, DateTime HoraInicio, DateTime HoraFinal)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlconnection = new SqlConnection();
            try
            {
                sqlconnection.ConnectionString = Conexión.Cn;
                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = sqlconnection;
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.CommandText = "SalonesDisponibles";

                SqlParameter ParFecha = new SqlParameter("@fecha", SqlDbType.Date);
                ParFecha.Value = $"{fecha.Year}-{fecha.Month}-{fecha.Day}";

                SqlParameter ParHI = new SqlParameter("@HI", SqlDbType.Time);
                ParHI.Value = $"{HoraInicio.Hour}:{HoraInicio.Minute}";

                SqlParameter ParHF = new SqlParameter("@HF", SqlDbType.Time);
                ParHF.Value = $"{HoraFinal.Hour}:{HoraFinal.Minute}";

                sqlCom.Parameters.Add(ParFecha);
                sqlCom.Parameters.Add(ParHI);
                sqlCom.Parameters.Add(ParHF);

                SqlDataAdapter sqlData = new SqlDataAdapter(sqlCom);
                sqlData.Fill(dt);
            }
            catch(Exception)
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
    }
}
