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
            public Usuarios(int nro_documento, string nombre, string apellido, int telefono, string direccion,string usuario, string contrasenha, Cargo cargo)
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
                string textoCmd = "Select u.Nro_documento, p.Nombre, p.Apellido, p.Telefono, p.Direccion, u.usuario, u.password, u.cargo from Usuario u Inner Join Persona p on p.Nro_documento = u.Nro_documento";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    usuario = new Usuarios();
                    usuario.Nro_documento = elLectorDeDatos.GetInt32(0);
                    usuario.Nombre = elLectorDeDatos.GetString(1);
                    usuario.Apellido = elLectorDeDatos.GetString(2);
                    usuario.Telefono = elLectorDeDatos.GetInt32(3);
                    usuario.Direccion = elLectorDeDatos.GetString(4);
                    usuario.Usuario = elLectorDeDatos.GetString(5);
                    usuario.Contrasenha = elLectorDeDatos.GetString(6);
                    usuario.CargoUsuario = (Cargo)elLectorDeDatos.GetInt32(7);

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
                Persona p = new Persona(user.Nro_documento, user.Nombre, user.Apellido, user.Telefono, user.Direccion);

                Persona.CrearPersonapUsuario(p);

                con.Open();

                string textoCmd = "insert into Usuario (Nro_documento, usuario, password, cargo) VALUES (@Nro_documento, @Usuario, @password, @cargo)";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlParameter p0 = new SqlParameter("@Nro_documento", user.Nro_documento);
                SqlParameter p1 = new SqlParameter("@Usuario", user.Usuario.Trim());
                SqlParameter p2 = new SqlParameter("@password", user.Contrasenha);
                SqlParameter p3 = new SqlParameter("@cargo", user.CargoUsuario);
                p0.SqlDbType = SqlDbType.Int;
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.Int;
                

                cmd.Parameters.Add(p0);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
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

        

    private SqlCommand ObtenerParametroId(SqlCommand cmd)
        {
            SqlParameter p90 = new SqlParameter("@Nro_Documento", this.Nro_documento);
            p90.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p90);

            return cmd;
        }

        public static void EditarUsuario(int index, Usuarios u)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                Persona person = new Persona(u.Nro_documento,u.Nombre,u.Apellido, u.Telefono, u.Direccion);
                Persona.EditarPersonapUsuario(index, person);
                con.Open();
                string textoCmd = @"UPDATE Usuario SET Nro_Documento = @Nro_Documento, Usuario = @Usuario, Password = @Password , Cargo = @Cargo where Nro_Documento= @Nro_Documento";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlParameter p1 = new SqlParameter("@Usuario", u.Usuario.Trim());
                SqlParameter p2 = new SqlParameter("@password", u.Contrasenha);
                SqlParameter p3 = new SqlParameter("@cargo", u.CargoUsuario);

                cmd = u.ObtenerParametroId(cmd);
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.Int;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);

                cmd.ExecuteNonQuery();
            }
        }
        public static Usuarios ObtenerUsuario(int id)
        {
            Usuarios usuario = null;

            if (listausuarios.Count == 0) Usuarios.ObtenerUsuarios();

            foreach (Usuarios u in listausuarios)
            {
                if (u.Nro_documento == id)
                {
                    usuario = u;
                    break;
                }

            }
            return usuario;
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
