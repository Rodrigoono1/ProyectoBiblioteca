using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
//test comit
    public enum Genero
    {
        Novela,
        Historia,
        Comedia,
        Terror,
        Romance
    }
    public class Libros
    {
        public int Id { get; set; }
        public string titulo { get; set; }
        public int ISBN { get; set; }
        public int año { get; set; }
        public Idioma idioma { get; set; }
        public Editorial editorial { get; set; }
        public Genero genero { get; set; }
        public Autor autor { get; set; }

        public Libros() { }
        public Libros(string titulo, int isbn, int año )
        {
            this.titulo = titulo;
            this.ISBN = isbn;
            this.año = año;
        }

        public static List<Libros> listalibros = new List<Libros>();

        public static void AgregarLibros(Libros l)
        {
            listalibros.Add(l);
        }

        public static List<Libros> ObtenerLibros()
        {
            //return listaProveedores;
            Libros libro;
            listalibros.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select l.*, a.Id from Libro l inner join AutorLibro al on l.Id = al.IdLibro inner join Autor a on a.Id= al.IdAutor";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    libro = new Libros();
                    libro.Id = elLectorDeDatos.GetInt32(0);
                    libro.titulo = elLectorDeDatos.GetString(1);
                    libro.ISBN = elLectorDeDatos.GetInt32(2);
                    libro.año = elLectorDeDatos.GetInt32(3);
                    libro.idioma = (Idioma)elLectorDeDatos.GetInt32(4);
                    libro.genero = (Genero)elLectorDeDatos.GetInt32(5);
                    libro.editorial = Editorial.ObtenerEditorial(elLectorDeDatos.GetInt32(6));
                    libro.autor = Autor.ObtenerAutores(elLectorDeDatos.GetInt32(7));

                    listalibros.Add(libro);
                }
            }
            return listalibros;
        }
        public static Libros ObtenerLibro(int id)
        {
            Libros libro = null;

            if (listalibros.Count == 0) Libros.ObtenerLibros();

            foreach (Libros l in listalibros)
            {
                if (l.Id == id)
                {
                    libro = l;
                    break;
                }

            }
            return libro;
        }

        public override string ToString()
        {
            return this.titulo;
        }
    }
}
