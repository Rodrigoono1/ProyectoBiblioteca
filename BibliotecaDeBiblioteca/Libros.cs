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
                string textoCmd = "Select * from Libros";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    libro = new Libros();
                    libro.Id = elLectorDeDatos.GetInt32(0);
                    libro.titulo = elLectorDeDatos.GetString(1);
                    libro.ISBN = elLectorDeDatos.GetString(2);
                    libro.año = elLectorDeDatos.GetInt32(3);
                    libro.idioma = (Idioma)elLectorDeDatos.GetInt32(4);
  //                  libro.editorial = Editorial.ObtenerEditoriales(elLectorDeDatos.GetInt32(5));
                    libro.genero = (Genero)elLectorDeDatos.GetInt32(6);

                    listalibros.Add(libro);
                }
            }
            return listalibros;
        }

        public override string ToString()
        {
            return String.Format("Titulo: {0} Año: {1} ISBN: {2}", this.titulo, this.año, this.ISBN);
        }
    }
}
