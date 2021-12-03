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

        public static string GuardarEvento(DateTime fecha, DateTime HoraInicio, DateTime HoraFinal,
                                            int numeropersonas, string descripcion, int IdCliente)
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
                sqlCom.CommandText = "AgregarEvento";

                SqlParameter ParFecha = new SqlParameter("@Fecha", SqlDbType.Date);
                ParFecha.Value = $"{fecha.Year}-{fecha.Month}-{fecha.Day}";

                SqlParameter ParNPersonas = new SqlParameter("@NP", SqlDbType.Int);
                ParNPersonas.Value = numeropersonas;

                SqlParameter ParIdCliente = new SqlParameter("@Idcliente", SqlDbType.Int);
                ParIdCliente.Value = IdCliente;

                SqlParameter ParHI = new SqlParameter("@HI", SqlDbType.Time);
                ParHI.Value = $"{HoraInicio.Hour}:{HoraInicio.Minute}";

                SqlParameter ParHF = new SqlParameter("@HF", SqlDbType.Time);
                ParHF.Value = $"{HoraFinal.Hour}:{HoraFinal.Minute}";

                SqlParameter ParDescripcion = new SqlParameter("@descripcion", SqlDbType.Text);
                ParDescripcion.Value = descripcion;

                sqlCom.Parameters.Add(ParFecha);
                sqlCom.Parameters.Add(ParHI);
                sqlCom.Parameters.Add(ParNPersonas);
                sqlCom.Parameters.Add(ParHF);
                sqlCom.Parameters.Add(ParDescripcion);
                sqlCom.Parameters.Add(ParIdCliente);

                respuesta = sqlCom.ExecuteNonQuery() == 0 ? "No se puede agregar evento": "OK";

            }
            catch (Exception ex)
            {
                respuesta = "Error al agregar evento: " + ex.Message;
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

        public static string GuardarReservacion(int idEvento, int idSalon)
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
                sqlCom.CommandText = "ContratacionReservacion";

   
                SqlParameter ParIdEvento = new SqlParameter("@idEvento", SqlDbType.Int);
                ParIdEvento.Value = idEvento;

                SqlParameter ParIdSalon = new SqlParameter("@idsalon", SqlDbType.Int);
                ParIdSalon.Value = idSalon;

                sqlCom.Parameters.Add(ParIdEvento);
                sqlCom.Parameters.Add(ParIdSalon);

                respuesta = sqlCom.ExecuteNonQuery() == 1 ? "OK" : "No se puede agregar reservación";

            }
            catch (Exception ex)
            {
                respuesta = "Error al agregar reservación: " + ex.Message;
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
        
        
        public static string GuardarServicio(int idEvento, int idServicio)
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
                sqlCom.CommandText = "ContratacionServicios";


                SqlParameter ParIdEvento = new SqlParameter("@idEvento", SqlDbType.Int);
                ParIdEvento.Value = idEvento;

                SqlParameter ParIdServicio = new SqlParameter("@idServicio", SqlDbType.Int);
                ParIdServicio.Value = idServicio;

                sqlCom.Parameters.Add(ParIdEvento);
                sqlCom.Parameters.Add(ParIdServicio);

                respuesta = sqlCom.ExecuteNonQuery() == 1 ? "OK" : "No se puede agregar servicio";

            }
            catch (Exception ex)
            {
                respuesta = "Error al agregar servicio: " + ex.Message;
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


        public static string AgregarContratacionExterna(int idEvento, string nombre, string descripcion,float precio)
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
                sqlCom.CommandText = "AgregarContratacionExterna";


                SqlParameter ParIdEvento = new SqlParameter("@idEvento", SqlDbType.Int);
                ParIdEvento.Value = idEvento;

                SqlParameter ParNombre = new SqlParameter("@nombre", SqlDbType.NVarChar,100);
                ParNombre.Value = nombre;

                SqlParameter ParDescripcion = new SqlParameter("@descripcion", SqlDbType.NVarChar, 200);
                ParDescripcion.Value = descripcion;

                SqlParameter ParPrecio = new SqlParameter("@precio", SqlDbType.Float);
                ParPrecio.Value = precio;

                sqlCom.Parameters.Add(ParIdEvento);
                sqlCom.Parameters.Add(ParNombre);
                sqlCom.Parameters.Add(ParDescripcion);
                sqlCom.Parameters.Add(ParPrecio);

                respuesta = sqlCom.ExecuteNonQuery() == 1 ? "OK" : "No se puede agregar contratacion externa";

            }
            catch (Exception ex)
            {
                respuesta = "Error al agregar contratación externa: " + ex.Message;
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
    

        public static int IdultimoEventoRegistrado()
        {
            DataTable DtResultado = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexión.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "UltimoIdEvento";
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

    }
}
