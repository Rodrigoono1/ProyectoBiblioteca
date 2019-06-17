using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Editorial() { }
        public Editorial(string nombre, string direccion, string telefono, string email)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            //this.idEditorial = idEditorial; ver para que se puso esto
            this.Telefono = telefono;
            this.Email = email;

            
        }
        public List<Editorial> listareditoriales = new List<Editorial>();

        public static List<Editorial> listaEditorial = new List<Editorial>();

        public static List<Editorial> ObtenerEditoriales()
        {
            //return listaProveedores;
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

    }
}