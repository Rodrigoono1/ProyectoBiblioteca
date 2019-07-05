using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    public class Autor 
    {
        public int Id { get; set; }
        public string Escritor { get; set; }

        public string Nacionalidad { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }

        public List<Autor> lista_autores = new List<Autor>();

        public static List<Autor> ListaAutor = new List<Autor>();

        public static void AgregarAutor (Autor a)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textCmd = @"insert into Autor (Escritor, Nacionalidad, Fecha_Nacimiento) VALUES (@Escritor, @Nacionalidad, @Fecha_Nacimiento)";
                SqlCommand cmd = new SqlCommand(textCmd, con);
                SqlParameter p1 = new SqlParameter("@Escritor", a.Escritor);
                SqlParameter p2 = new SqlParameter("@Nacionalidad", a.Nacionalidad);
                SqlParameter p3 = new SqlParameter("@Fecha_Nacimiento", a.Fecha_Nacimiento);
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);

                cmd.ExecuteNonQuery();

            }
        }

        public static void BorrarAutor(Autor a)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Autor where Id = @Id";

                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p4 = new SqlParameter("@Id", a.Id);
                p4.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p4);

                cmd.ExecuteNonQuery();

            }
            
        }


        public static void EditarAutor(int index, Autor a)
        {
            
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Autor SET Escritor= @Escritor, Nacionalidad= @Nacionalidad, Fecha_Nacimiento = @Fecha_Nacimiento where Id = @Id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p1 = new SqlParameter("@Escritor", a.Escritor);
                SqlParameter p2 = new SqlParameter("@Nacionalidad", a.Nacionalidad);
                SqlParameter p3 = new SqlParameter("@Fecha_Nacimiento", a.Fecha_Nacimiento);
                SqlParameter p4 = new SqlParameter("@Id", a.Id);
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.DateTime;
                p4.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Autor> ObtenerAutor()
        {
            //return lista autores;
            Autor autor;
            ListaAutor.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Autor";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    autor = new Autor();
                    autor.Id = elLectorDeDatos.GetInt32(0);
                    autor.Escritor= elLectorDeDatos.GetString(1);
                    autor.Nacionalidad = elLectorDeDatos.GetString(2);
                    autor.Fecha_Nacimiento = elLectorDeDatos.GetDateTime(3);
                   

                    ListaAutor.Add(autor);
                }
            }
            return ListaAutor;
        }



        public static Autor ObtenerAutores(int id)
        {
            Autor autor = null;

            if (ListaAutor.Count == 0) Autor.ObtenerAutor();

            foreach (Autor a in ListaAutor)
            {
                if (a.Id == id)
                {
                    autor = a;
                    break;
                }

            }
            return autor;




        }

        public override string ToString()
        {
            return Escritor; 
        }




        

    }
}
