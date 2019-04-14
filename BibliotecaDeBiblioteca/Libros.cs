using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    class Libros
    {
        public string titulo { get; set; }
        public string ISBN { get; set; }
        public int Año { get; set; }

        public Libros(string ISBN, string titulo)
        {
            this.titulo = titulo;
            this.ISBN = ISBN;
            this.Año = Año;
        }
    }
}
