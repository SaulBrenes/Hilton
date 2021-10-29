using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Model
{
    class MEmpresaMantenimiento
    {
        public static DataTable MostrarEmpresasMantenimiento()
        {
            DataTable dtResultado = new DataTable("MostrarEmpresas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexión.Cn;

                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = SqlCon;
                sqlCom.CommandText = "MostrarEmpresasMantenimiento";
                sqlCom.CommandType = CommandType.StoredProcedure;

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
        
        public static DataTable BuscarEmpresas(string dato)
        {
            DataTable dtResultado = new DataTable("MostrarEmpresas");
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexión.Cn;

                SqlCommand sqlCom = new SqlCommand();
                sqlCom.Connection = SqlCon;
                sqlCom.CommandText = "BuscarEmpresaMantenimiento";
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
    
        public static string EstadoEmpresa(int idEmpresa)
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
                SqlCmd.CommandText = "EstadoEmpresaMantenimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter ParIdEmpresa = new SqlParameter();
                ParIdEmpresa.ParameterName = "@idEmpresa";
                ParIdEmpresa.SqlDbType = SqlDbType.Int;
                ParIdEmpresa.Value = idEmpresa;
                SqlCmd.Parameters.Add(ParIdEmpresa);


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
        
        public static string AgregarEmpresa(string nombre, string direccion, string telefono)
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
                SqlCmd.CommandText = "AgregarEmpresaMantenimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@nombre";
                Parnombre.SqlDbType = SqlDbType.NVarChar;
                Parnombre.Size = 80;
                Parnombre.Value = nombre;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter Pardireccion = new SqlParameter();
                Pardireccion.ParameterName = "@direccion";
                Pardireccion.SqlDbType = SqlDbType.NVarChar;
                Pardireccion.Size = 100;
                Pardireccion.Value = direccion;
                SqlCmd.Parameters.Add(Pardireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.NVarChar;
                Parnombre.Size = 8;
                ParTelefono.Value = telefono;
                SqlCmd.Parameters.Add(ParTelefono);

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

        public static string ActualizarEmpresa(int idEmpresa, string nombre, string direccion, string telefono)
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
                SqlCmd.CommandText = "ActualizarEmpresaMantenimiento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                // Parámetros del Procedimiento Almacenado
                SqlParameter ParIdEmpresa = new SqlParameter();
                ParIdEmpresa.ParameterName = "@idEmpresa";
                ParIdEmpresa.SqlDbType = SqlDbType.Int;
                ParIdEmpresa.Value = idEmpresa;
                SqlCmd.Parameters.Add(ParIdEmpresa);

                SqlParameter Parnombre = new SqlParameter();
                Parnombre.ParameterName = "@nombre";
                Parnombre.SqlDbType = SqlDbType.NVarChar;
                Parnombre.Size = 80;
                Parnombre.Value = nombre;
                SqlCmd.Parameters.Add(Parnombre);

                SqlParameter Pardireccion = new SqlParameter();
                Pardireccion.ParameterName = "@direccion";
                Pardireccion.SqlDbType = SqlDbType.NVarChar;
                Pardireccion.Size = 100;
                Pardireccion.Value = direccion;
                SqlCmd.Parameters.Add(Pardireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";
                ParTelefono.SqlDbType = SqlDbType.NVarChar;
                Parnombre.Size = 8;
                ParTelefono.Value = telefono;
                SqlCmd.Parameters.Add(ParTelefono);

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
