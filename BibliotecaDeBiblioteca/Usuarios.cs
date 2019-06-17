using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    public enum Cargo { Administrador, Usuario }
    public class Usuarios : Persona
    {
        public string Contrasenha { get; set; }
        public string Usuario { get; set; }

        public Cargo CargoUsuario {get; set;}

            public Usuarios() { }
            public Usuarios(string nro_documento, string nombre, string apellido, string telefono, string direccion,string usuario, string contrasenha, Cargo cargo)
            {
                this.Nro_documento = nro_documento;
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.Telefono = telefono;
                this.Direccion = direccion;
                this.Usuario = usuario;
                this.Contrasenha = contrasenha;
                this.CargoUsuario = cargo;
            }
        public static List<Usuarios> listausuarios = new List<Usuarios>();

        public static List<Usuarios> ObtenerUsuarios() {
            Usuarios usuario;
            listausuarios.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Usuario";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    usuario = new Usuarios();
                    usuario.Nro_documento = elLectorDeDatos.GetString(0);
                    usuario.Usuario = elLectorDeDatos.GetString(1);
                    usuario.Contrasenha = elLectorDeDatos.GetString(2);
                    usuario.Nombre = elLectorDeDatos.GetString(3);
                    usuario.Apellido = elLectorDeDatos.GetString(4);
                    usuario.Email = elLectorDeDatos.GetString(5);
                    usuario.Direccion = elLectorDeDatos.GetString(6);
                    usuario.Telefono = elLectorDeDatos.GetString(7);
                    usuario.CargoUsuario = (Cargo)elLectorDeDatos.GetInt32(8);

                    listausuarios.Add(usuario);
                }
            }

            return listausuarios;
        }
        public static void AgregarUsuario(Usuarios u)
        {
            listausuarios.Add(u);
        }
        public override string ToString()
        {
            return this.Usuario;
        }


        public static void CrearUsuario(Usuarios user)
        {
            //string password_protegido = EncodePassword(user.Contrasenha);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION)) 
            {
                con.Open();

                string textoCmd = "INSERT INTO USUARIO (usuario, password, nombre, apellido, email, telefono, direccion, nacionalidad, cargo) values(@Usuario, @password, @nombre, @apellido, @email, @telefono, @direccion, @nacionalidad, @cargo)";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlParameter p1 = new SqlParameter("@Usuario", user.Usuario.Trim());
                SqlParameter p2 = new SqlParameter("@password", user.Contrasenha);
                SqlParameter p3 = new SqlParameter("@nombre", user.Nombre);
                SqlParameter p4 = new SqlParameter("@apellido", user.Apellido);
                SqlParameter p5 = new SqlParameter("@email", user.Email);
                SqlParameter p6 = new SqlParameter("@telefono", user.Telefono);
                SqlParameter p7 = new SqlParameter("@direccion", user.Direccion);
                SqlParameter p8 = new SqlParameter("@nacionalidad", user.Nacionalidad);
                SqlParameter p9 = new SqlParameter("@cargo", user.CargoUsuario);
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.VarChar;
                p5.SqlDbType = SqlDbType.VarChar;
                p6.SqlDbType = SqlDbType.VarChar;
                p7.SqlDbType = SqlDbType.VarChar;
                p8.SqlDbType = SqlDbType.VarChar;
                p9.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1); 
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);
                cmd.Parameters.Add(p9);

                cmd.ExecuteNonQuery(); 

            }
        }

        public static bool Autenticar(string usuario, string password)
        {
            //string password_protegido = EncodePassword(password);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION)) 
            {
                con.Open();

                string textoCmd = "SELECT Usuario, password from Usuario where Usuario = @Usuario and password = @password";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlParameter p1 = new SqlParameter("@Usuario", usuario.Trim());
                p1.SqlDbType = SqlDbType.VarChar; 

                SqlParameter p2 = new SqlParameter("@password", password);
                p2.SqlDbType = SqlDbType.VarChar;

                cmd.Parameters.Add(p1); 
                cmd.Parameters.Add(p2);

                SqlDataReader reader = cmd.ExecuteReader(); 

                if (reader.HasRows) 
                {
                    reader.Close();                                                                                    
                    return true; 
                }
                else
                {
                    reader.Close();                                                     
                    return false; 
                }

            }
        }


        /*public static string EncodePassword(string originalPassword)
        {

            SHA1 sha1 = new SHA1CryptoServiceProvider();
            string salt = "0d71ee4472658cd5874c5578410a9d8611fc9aef";
            string passwordSalt = salt + originalPassword;
            byte[] inputBytes = (new UnicodeEncoding()).GetBytes(passwordSalt);
            byte[] hash = sha1.ComputeHash(inputBytes);

            return Convert.ToBase64String(hash);
        }*/

    }
}
