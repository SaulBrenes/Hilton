using Hilton.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Controller
{
    class CEmpresaMantenimiento
    {
        public static DataTable MostrarEmpresas()
        {
            return MEmpresaMantenimiento.MostrarEmpresasMantenimiento();
        }

        public static DataTable BuscarEmpresa(string dato)
        {
            return MEmpresaMantenimiento.BuscarEmpresas(dato);
        }

        public static string EstadoEmpresa(int idEmpresa)
        {
            return MEmpresaMantenimiento.EstadoEmpresa(idEmpresa);
        }

        public static string AgregarEmpresa(string nombre, string direccion, string telefono)
        {
            return MEmpresaMantenimiento.AgregarEmpresa(nombre, direccion, telefono);
        }

        public static string ActualizarEmpresa(int idEmpresa,string nombre, string direccion, string telefono)
        {
            return MEmpresaMantenimiento.ActualizarEmpresa(idEmpresa, nombre, direccion, telefono);
        }
    }
}
