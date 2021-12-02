using Hilton.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilton.Controller
{
    class CEvento
    {
        public static DataTable MostrarEventos()
        {
            return MEventos.Mostrar();
        }

        public static DataTable BuscarEventos(string dato)
        {
            return MEventos.Buscar(dato);
        }

        public static DataTable ReservacionesEvento(int idEvento)
        {
            return MEventos.ReservacionesEvento(idEvento);
        }

        public static DataTable ServiciosEventos(int idEvento)
        {
            return MEventos.SeviciosEvento(idEvento);
        }

        public static DataTable ContratacionesExternaEvento(int idEvento)
        {
            return MEventos.ContratacionesEvento(idEvento);
        }

        public static string CambiarEstadoEvento(int idEvento)
        {
            return MEventos.CambioEstadoEvento(idEvento);
        }

        public static DataTable HorarioSalonesOcupados(DateTime date)
        {
            return MEventos.SalonesOcupados(date);
        }

        public static DataTable SalonesDisponibles(DateTime fecha, DateTime HoraInicio, DateTime HoraFinal)
        {
            return MEventos.SalonesDisponibles(fecha, HoraInicio, HoraFinal);
        }
    }
}
