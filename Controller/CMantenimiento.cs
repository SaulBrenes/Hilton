using Hilton.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Controller
{
    class CMantenimiento
    {
        public static DataTable MostrarMatenimientos()
        {
            return MMantenimiento.MostrarTodos();
        }

        public static DataTable BuscarMantenimiento(string dato)
        {
            return MMantenimiento.BuscarPor(dato);
        }

        public static string CrearMantenimiento(int idSalon, int idEmpleado, int idEmpresa, float costo, string descripcion, DateTime date)
        {
            return MMantenimiento.Crear(idSalon, idEmpleado, idEmpresa, costo, descripcion, date);
        }

        public static string EditarMantenimiento(int idMantenimiento ,int idSalon, int idEmpleado, int idEmpresa, float costo, string descripcion, DateTime date)
        {
            return MMantenimiento.Editar(idMantenimiento, idSalon, idEmpleado, idEmpresa, costo, descripcion, date);
        }

        public static string EstadoMantenimiento(int idMantenimiento)
        {
            return MMantenimiento.Estado(idMantenimiento);
        }

    }
}
