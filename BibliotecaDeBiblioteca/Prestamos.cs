using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    public class Prestamos
    {
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public Usuarios usuario{get; set;}
        public Socios socio { get; set; }
        public Libros libro { get; set; }
        public Prestamos(DateTime fechaInicio, DateTime fechaFin)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }
        public Prestamos(DateTime inicio) {
            this.fechaInicio = inicio;
        }
        public string MostrarPrestamo(Socios cliente, Usuarios encargado, Libros objeto)
        {
            this.socio = cliente;
            this.usuario= encargado;
            this.libro = objeto;

            return String.Format("{0} prestado a {1} {2} por {3} {4} en fecha {5}", this.libro.titulo, this.socio.Nombre, this.usuario.Nombre, this.fechaInicio);
        }
    }
}
