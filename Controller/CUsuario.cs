
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
            return new MUsuario().Validar_Acceso(usuario, contraseña);
        }

    }
}
