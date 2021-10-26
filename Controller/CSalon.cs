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
    }
}
