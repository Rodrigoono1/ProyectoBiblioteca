using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    public class Libros
    {
        public string titulo { get; set; }
        public string ISBN { get; set; }
        public int Año { get; set; }

        public Libros() { }
        public Libros(string titulo, string isbn, int año )
        {
            this.titulo = titulo;
            this.ISBN = isbn;
            this.Año = año;
        }
        public override string ToString()
        {
            return String.Format("Titulo: {0} Año: {1} ISBN: {2}", this.titulo, this.Año, this.ISBN);
        }
    }
}
