using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    public enum Idioma
    {
        Español,
        Inglés
    }

    public enum Genero
    {

    }
    public class Libros
    {
        public string titulo { get; set; }
        public string ISBN { get; set; }
        public int año { get; set; }
        public Idioma idioma { get; set; }
        public Editorial editorial { get; set; }
        public Genero genero { get; set; }

        public Libros() { }
        public Libros(string titulo, string isbn, int año )
        {
            this.titulo = titulo;
            this.ISBN = isbn;
            this.año = año;
        }
        public override string ToString()
        {
            return String.Format("Titulo: {0} Año: {1} ISBN: {2}", this.titulo, this.año, this.ISBN);
        }
    }
}
