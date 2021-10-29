using Hilton.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Controller
{
    class CServicio
    {
        public static DataTable MostrarServicios()
        {
            return MServicios.MostrarServicios();
        }

        public static DataTable BuscarServicios(string dato)
        {
            return MServicios.BuscarServicios(dato);
        }

        public static string AgregarServicio(string nombre, float tarifa, string descripcion)
        {
            return MServicios.AgregarServicio(nombre, tarifa, descripcion);
        }

        public static string ActualizarServicio(int idServicio, string nombre, float tarifa, string descripcion)
        {
            return MServicios.ActualizarServicio(idServicio,nombre, tarifa, descripcion);
        }

        public static string EstadoServicio(int idServicio)
        {
            return MServicios.EstadoServicio(idServicio);
        }
    }
}
