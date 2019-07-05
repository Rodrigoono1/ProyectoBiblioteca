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

             
        public Categoria Categoria { get; set; }
        public Socios() { }
        public Socios(int nro_documento, string nombre, string apellido, string email, int telefono, string direccion,Categoria categoria)
        {
            this.Nro_documento = nro_documento;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Categoria = categoria;
        }

        public override string ToString()
        {
            return "Nombre: " + this.Nombre + "; " + "Apellido: " + this.Apellido + ";" + "Contacto: " + this.Telefono;
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
                string textoCmd = "Select p.Nro_Documento, p.Nombre, p.Apellido, p.Email, p.Telefono, p.Direccion, p.Nacionalidad, s.Categoria from Socio s INNER JOIN Persona p on s.Nro_documento = p.Nro_documento";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    socio = new Socios();
                    socio.Nro_documento = elLectorDeDatos.GetInt32(0);
                    socio.Nombre = elLectorDeDatos.GetString(1);
                    socio.Apellido = elLectorDeDatos.GetString(2);
                    socio.Email = elLectorDeDatos.GetString(3);
                    socio.Telefono = elLectorDeDatos.GetInt32(4);
                    socio.Direccion = elLectorDeDatos.GetString(5);
                    socio.Nacionalidad = elLectorDeDatos.GetString(6);
                    socio.Categoria = (Categoria)elLectorDeDatos.GetInt32(7);

                    listaSocios.Add(socio);
                }
            }
            return listaSocios;
        }

        public static void CrearSocio(Socios socio)
        {
            Persona p = new Persona();
            p.Nro_documento = socio.Nro_documento;
            p.Nombre = socio.Nombre;
            p.Apellido = socio.Apellido;
            p.Email = socio.Email;
            p.Telefono = socio.Telefono;
            p.Direccion = socio.Direccion;
            p.Nacionalidad = socio.Nacionalidad;

            Persona.CrearPersona(p);
            //string password_protegido = EncodePassword(socio.Contrasenha);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();

                string textoCmd = "insert into Socio (Nro_documento, Categoria) VALUES (@Nro_documento, @Categoria)";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlParameter p0 = new SqlParameter("@Nro_documento", socio.Nro_documento);
                SqlParameter p1 = new SqlParameter("@Categoria", socio.Categoria);
                p0.SqlDbType = SqlDbType.Int;
                p1.SqlDbType = SqlDbType.Int;


                cmd.Parameters.Add(p0);
                cmd.Parameters.Add(p1);
                cmd.ExecuteNonQuery();
            }
        }


    }
}
