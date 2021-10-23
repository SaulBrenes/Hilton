
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Hilton.Data;

//SistemaEjemploUNI
namespace Hilton.Controller
{
    class CUsuario
    {
        public static DataTable Validar_acceso(string usuario, string contraseña)
        {
            return new DUsuario().Validar_Acceso(usuario, contraseña);
        }

    }
}
