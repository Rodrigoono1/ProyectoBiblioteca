using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    public enum Categoria
    {
        Free,
        Basico,
        Premium
    }

    public class Socios : Persona
    {

             
        //public Categoria Categoria { get; set; }
        public string Categoria { get; set; }
        public int Id { get; set; }
        public Socios() { }
        public Socios(string nro_documento, string nombre, string apellido, string email, string telefono, string direccion,string categoria)
        {
            this.Nro_documento = nro_documento;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Categoria = categoria;
        }
        

        public List<Socios> listarsocios = new List<Socios>();

        public static List<Socios> listaSocios = new List<Socios>();


        public static List<Socios> ObtenerSocios()
        {
            //return listaProveedores;
            Socios socio;
            listaSocios.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Socios";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    socio = new Socios();
                    socio.Id = elLectorDeDatos.GetInt32(0);
                    socio.Nro_documento = elLectorDeDatos.GetString(1);
                    socio.Nombre = elLectorDeDatos.GetString(2);
                    socio.Apellido = elLectorDeDatos.GetString(3);
                    socio.Email = elLectorDeDatos.GetString(4);
                    socio.Telefono = elLectorDeDatos.GetString(5);
                    socio.Direccion = elLectorDeDatos.GetString(6);

                    listaSocios.Add(socio);
                }
            }
            return listaSocios;
        }

    }
}
