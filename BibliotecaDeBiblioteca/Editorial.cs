using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDeBiblioteca;

namespace BibliotecaDeBiblioteca
{
    public class Editorial
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        //public int idEditorial { get; set; }
        public string Email { get; set; }

        public List<Editorial> listareditoriales = new List<Editorial>();

        public static List<Editorial> listaEditorial = new List<Editorial>();

      public static void AgregarEditorial (Editorial e)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textCmd = @"insert into Editorial(Nombre,Direccion,Telefono, Email) VALUES (@Nombre, @Direccion, @Telefono,@Email)";
                SqlCommand cmd = new SqlCommand(textCmd, con);
                SqlParameter p1 = new SqlParameter("@Nombre", e.Nombre);
                SqlParameter p2 = new SqlParameter("@Direccion", e.Direccion);
                SqlParameter p3 = new SqlParameter("@Telefono", e.Telefono);
                SqlParameter p4 = new SqlParameter("@Email", e.Email);
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);

                cmd.ExecuteNonQuery();


            }
        }

        public static void BorrarEditorial (Editorial e)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"delete from Editorial where Id = @Id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p5 = new SqlParameter("@Id", e.Id);
                p5.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p5);

                cmd.ExecuteNonQuery();
                
            }
        }

        public static void EditarEditorial(int index, Editorial e)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Editorial SET Nombre= @Nombre, Direccion= @Direccion, Telefono= @Telefono, Email = @Email where Id = @Id";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p1 = new SqlParameter("@Nombre", e.Nombre);
                SqlParameter p2 = new SqlParameter("@Direccion", e.Direccion);
                SqlParameter p3 = new SqlParameter("@Telefono", e.Telefono);
                SqlParameter p4 = new SqlParameter("@Email", e.Email);
                SqlParameter p5 = new SqlParameter("@Id", e.Id);
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.VarChar;
                p5.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);

                cmd.ExecuteNonQuery();
            }
        }



        public static List<Editorial> ObtenerEditoriales()
        {
            Editorial editorial;
            listaEditorial.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Editorial";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    editorial = new Editorial();
                    editorial.Id = elLectorDeDatos.GetInt32(0);
                    editorial.Nombre = elLectorDeDatos.GetString(1);
                    editorial.Direccion = elLectorDeDatos.GetString(2);
                    editorial.Telefono = elLectorDeDatos.GetString(3);
                    editorial.Email = elLectorDeDatos.GetString(4);

                    listaEditorial.Add(editorial);
                }
            }
            return listaEditorial;
        }


        public static Editorial ObtenerEditorial(int id)
        {
            Editorial editorial = null;

            if (listaEditorial.Count == 0) Editorial.ObtenerEditoriales();

            foreach (Editorial e in listaEditorial)
            {
                if (e.Id == id)
                {
                    editorial = e;
                    break;
                }

            }
            return editorial;



        }

       

        public override string ToString()
        {
            return Nombre;
        }


    }
}