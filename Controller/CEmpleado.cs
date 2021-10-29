using Hilton.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Controller
{
    class CEmpleado
    {
        public static DataTable MostrarEmpleados()
        {
            return MEmpleado.MostrarEmpleado();
        }

        public static DataTable BuscarEmpleado(string dato)
        {
            return MEmpleado.BuscarEmpleado(dato);
        }

        public static string EstadoEmpleado(int idEmpleado)
        {
            return MEmpleado.EstadoEmpleado(idEmpleado);
        } 

        public static string AgregarEmpleado(string pNombre, string sNombre, string pApellido, string sApellido, string telefono)
        {
            return MEmpleado.InsertarEmpleado(pNombre, sNombre, pApellido, sApellido, telefono);
        }

        public static string ActualizarEmpleado(int idEmpleado, string pNombre, string sNombre, string pApellido, string sApellido, string telefono)
        {
            return MEmpleado.ActualizarEmpleado(idEmpleado, pNombre, sNombre, pApellido, sApellido, telefono);
        }
    }
}
