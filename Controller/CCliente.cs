using Hilton.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Controller
{
    class CCliente
    {

        public static int IdultimoClienteRegistrado()
        {
            return MClientes.IdultimoClienteRegistrado();
        }

        public static DataTable MostrarClientes()
        {
            return MClientes.MostrarClientes();
        }

        public static DataTable BuscarClientes(string dato)
        {
            return MClientes.BuscarCliente(dato);
        }

        public static string EstadoCliente(int idCliente)
        {
            return MClientes.EstadoCliente(idCliente);
        }

        public static string AgregarCliente(string pNombre, string sNombre, string pApellido, string sApellido, string telefono, string cedula)
        {
            return MClientes.InsertarCliente(pNombre, sNombre, pApellido, sApellido, telefono, cedula);
        }

        public static string ActualizarCliente(int idCliente, string pNombre, string sNombre, string pApellido, string sApellido, string telefono, string cedula)
        {
            return MClientes.ActualizarCliente(idCliente, pNombre, sNombre, pApellido, sApellido, telefono, cedula);
        }
    }
}
