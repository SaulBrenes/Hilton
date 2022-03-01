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



        public static DataTable ObtenerEventoEditar(int idEvento)
        {
            return MEventos.ObtenerEventoEditar(idEvento);
        }

        public static DataTable IdServiciosEvento(int idEvento)
        {
            return MEventos.IdServiciosEvento(idEvento);
        }

        public static string EditarAsistenciaEvento(int idEvento,  string descripcion, int Asistencia)
        {
            return MEventos.EditarAsistentesEvento(idEvento,  descripcion, Asistencia);
        }


        public static string AgregarEvento(DateTime fecha, DateTime HoraInicio, DateTime HoraFinal,
                                            int numeropersonas, string descripcion, int IdCliente)
        {
            return MEventos.GuardarEvento(fecha, HoraInicio, HoraFinal, numeropersonas, descripcion, IdCliente);
        }

        public static int ObtenerIDUltimoEvento()
        {
            return MEventos.IdultimoEventoRegistrado();
        }

        public static string AgregarReservacion(int idEvento, int idSalon)
        {
            return MEventos.GuardarReservacion(idEvento, idSalon);
        }

        public static string AgregarServicios(int idEvento, int idServicio)
        {
            return MEventos.GuardarServicio(idEvento, idServicio);
        }

        public static string AgregarContratacionExterna(int idEvento, string nombre, string descripcion, float precio)
        {
            return MEventos.AgregarContratacionExterna(idEvento,nombre,descripcion, precio);
        }
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
