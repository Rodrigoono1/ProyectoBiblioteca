using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    class Prestamos
    {
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Prestamos(DateTime FechaInicio, DateTime FechaFin)
        {
            this.FechaInicio = FechaInicio;
            this.FechaFin = FechaFin;
        }
    }
}
