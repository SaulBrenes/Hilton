
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Hilton.Model;

//SistemaEjemploUNI
namespace Hilton.Controller
{
    class CUsuario
    {
        public static DataTable Validar_acceso(string usuario, string contraseña)
        {
            return MUsuario.Validar_Acceso(usuario, contraseña);
        }

        public static string ActualizarContraseñaUsuario(int idUsuario, string nuevaContraseña, string rol)
        {
            return MUsuario.ActualizarContrasenaUsuario(idUsuario,nuevaContraseña, rol);
        }

        public static string ActualizarDatosUsuario(int idUsuario, string usuario, string rol, int idEmpleado)
        {
            return MUsuario.ActualizarDatosUsuarios(idUsuario, usuario, idEmpleado, rol);
        }

        public static  DataTable BuscarUsuario(string dato)
        {
            return MUsuario.BuscarUsuario(dato);
        }

        public static string EstadoUsuario(int idUsuario)
        {
            return MUsuario.EstadoUsuario(idUsuario);
        }

        public static string InsertarUsuario(string usuario, string contraseña, string rol, int idEmpleado) 
            {
            return MUsuario.InsertarUsuario(usuario, contraseña, rol, idEmpleado);
            } 

        public static DataTable MostrarUsuario()
        {
            return MUsuario.MostrarUsuarios();
        }

    }
}
