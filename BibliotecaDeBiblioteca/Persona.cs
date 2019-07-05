using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BibliotecaDeBiblioteca
{
    public class Persona
    {
        public int Nro_documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Nacionalidad { get; set; }

        public Persona() { }
        public Persona(int CI, string nombre, string apellido, int telefono, string direccion)
        {
            this.Nro_documento = CI;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono = telefono;
            this.Direccion = direccion;
        }

        public override string ToString()
        {
            return String.Format("Nombre: {0} Apellido: {1} Nro Doc: {2}", this.Nombre, this.Apellido, this.Nro_documento);
        }

        public static void CrearPersonapUsuario(Persona person)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                try {
                    string textoCmd = "INSERT INTO Persona (Nro_documento, Nombre, Apellido, Telefono, Direccion) values (@Nro_documento, @nombre, @apellido,  @telefono, @direccion)";

                    SqlCommand cmd = new SqlCommand(textoCmd, con);
                    SqlParameter p0 = new SqlParameter("@Nro_documento", person.Nro_documento);
                    SqlParameter p1 = new SqlParameter("@nombre", person.Nombre);
                    SqlParameter p2 = new SqlParameter("@apellido", person.Apellido);
                    SqlParameter p3 = new SqlParameter("@telefono", person.Telefono);
                    SqlParameter p4 = new SqlParameter("@direccion", person.Direccion);
                    p0.SqlDbType = SqlDbType.Int;
                    p1.SqlDbType = SqlDbType.VarChar;
                    p2.SqlDbType = SqlDbType.VarChar;
                    p3.SqlDbType = SqlDbType.Int;
                    p4.SqlDbType = SqlDbType.VarChar;

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);

                    cmd.ExecuteNonQuery();

                }
                catch (Exception){
                    MessageBox.Show("Oh oh, algo salio mal");
                }
                
            }
        }
        public static void EditarPersonapUsuario(int index, Persona p)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Persona SET Nro_Documento = @Nro_Documento, Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Direccion = @Direccion where Nro_Documento = @Nro_Documento";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p1 = new SqlParameter("@nombre", p.Nombre);
                SqlParameter p2 = new SqlParameter("@apellido", p.Apellido);
                SqlParameter p3 = new SqlParameter("@telefono", p.Telefono);
                SqlParameter p4 = new SqlParameter("@direccion", p.Direccion);
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.Int;
                p4.SqlDbType = SqlDbType.VarChar;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd = p.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }
        }

        public static void CrearPersona(Persona person)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                try
                {
                    string textoCmd = "INSERT INTO Persona (Nro_Documento, Nombre, Apellido, Email, Telefono, Direccion, Nacionalidad) values (@Nro_documento, @nombre, @apellido, @email, @telefono, @direccion, @nacionalidad)";

                    SqlCommand cmd = new SqlCommand(textoCmd, con);
                    SqlParameter p0 = new SqlParameter("@Nro_documento", person.Nro_documento);
                    SqlParameter p1 = new SqlParameter("@nombre", person.Nombre);
                    SqlParameter p2 = new SqlParameter("@apellido", person.Apellido);
                    SqlParameter p3 = new SqlParameter("@email", person.Email);
                    SqlParameter p4 = new SqlParameter("@telefono", person.Telefono);
                    SqlParameter p5 = new SqlParameter("@direccion", person.Direccion);
                    SqlParameter p6 = new SqlParameter("@nacionalidad", person.Nacionalidad);
                    p0.SqlDbType = SqlDbType.Int;
                    p1.SqlDbType = SqlDbType.VarChar;
                    p2.SqlDbType = SqlDbType.VarChar;
                    p3.SqlDbType = SqlDbType.VarChar;
                    p4.SqlDbType = SqlDbType.Int;
                    p5.SqlDbType = SqlDbType.VarChar;
                    p6.SqlDbType = SqlDbType.VarChar;

                    cmd.Parameters.Add(p0);
                    cmd.Parameters.Add(p1);
                    cmd.Parameters.Add(p2);
                    cmd.Parameters.Add(p3);
                    cmd.Parameters.Add(p4);
                    cmd.Parameters.Add(p5);
                    cmd.Parameters.Add(p6);

                    cmd.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Oh oh, algo salio mal \n" + e.ToString());
                }

            }
        }
        public static void EditarPersona(int index, Persona p)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = @"UPDATE Persona SET Nro_Documento = @Nro_Documento, Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Direccion = @Direccion where Nro_Documento = @Nro_Documento";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                SqlParameter p1 = new SqlParameter("@nombre", p.Nombre);
                SqlParameter p2 = new SqlParameter("@apellido", p.Apellido);
                SqlParameter p3 = new SqlParameter("@telefono", p.Telefono);
                SqlParameter p4 = new SqlParameter("@direccion", p.Direccion);
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.VarChar;
                p3.SqlDbType = SqlDbType.Int;
                p4.SqlDbType = SqlDbType.VarChar;

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd = p.ObtenerParametroId(cmd);

                cmd.ExecuteNonQuery();
            }
        }
        private SqlCommand ObtenerParametroId(SqlCommand cmd)
        {
            SqlParameter p90 = new SqlParameter("@Nro_Documento", this.Nro_documento);
            p90.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p90);

            return cmd;
        }

    }
}
