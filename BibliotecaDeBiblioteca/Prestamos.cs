using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaDeBiblioteca
{
    public class Prestamos
    {
        public int Id { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public Usuarios usuario{get; set;}
        public Socios socio { get; set; }
        public Libros libro { get; set; }
        public Prestamos() { }
        public Prestamos(DateTime fechaInicio, DateTime fechaFin)
        {
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }
        public Prestamos(DateTime inicio) {
            this.fechaInicio = inicio;
        }
        public string MostrarPrestamo(Socios cliente, Usuarios encargado, Libros objeto)
        {
            this.socio = cliente;
            this.usuario= encargado;
            this.libro = objeto;



            return String.Format("{0} prestado a {1} {2} en fecha {3}", this.libro.titulo, this.socio.Nombre, this.socio.Apellido, this.fechaInicio);
        }
        public static List<Prestamos> listaPrestamos = new List<Prestamos>();

        public static void AgregarPrestamos(Prestamos pr)
        {
            listaPrestamos.Add(pr);
        }

        public static List<Prestamos> ObtenerPrestamos()
        {
            //return listaProveedores;
            Prestamos prestamo;
            listaPrestamos.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Prestamos";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    prestamo = new Prestamos();
                    prestamo.Id = elLectorDeDatos.GetInt32(0);
                    prestamo.fechaInicio = elLectorDeDatos.GetDateTime(1);
                    prestamo.fechaFin = elLectorDeDatos.GetDateTime(2);
                    prestamo.socio = Socios.ObtenerSocio(elLectorDeDatos.GetInt32(3));
                    prestamo.usuario = Usuarios.ObtenerUsuario(elLectorDeDatos.GetInt32(4));
                    prestamo.libro = Libros.ObtenerLibro(elLectorDeDatos.GetInt32(5));

                    listaPrestamos.Add(prestamo);
                }
            }
            return listaPrestamos;
        }


    }
}
