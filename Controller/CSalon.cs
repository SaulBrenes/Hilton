using Hilton.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Controller
{
    class CSalon
    {
        public static DataTable MostrarSalones()
        {
            return MSalones.MostrarSalones();
        }

        public static DataTable BuscarSalon(string dato) {
            return MSalones.BuscarSalones(dato);
        }

        public static string AgregarSalon(string codigo, string nombre, float precioHora, int capacidadMax)
        {
            return MSalones.AgregarSalon(codigo, nombre, precioHora, capacidadMax);
        }

        public static string ActualizarSalon(int idSalon, string codigo, string nombre, float precioHora, int capacidadMax)
        {
            return MSalones.ActualizarSalon(idSalon, codigo, nombre, precioHora, capacidadMax);
        }

        public static string EstadoSalon (int idSalon)
        {
            return MSalones.EstadoSalon(idSalon);
        }
    }
}
