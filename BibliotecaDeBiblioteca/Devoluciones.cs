using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BibliotecaDeBiblioteca
{
    public class Devoluciones
    {
        public int Id { get; set; }
        public string Socio { get; set; }
        public string Libro { get; set; }
        public string Fecha_Prestamo { get; set; }
        public string Fecha_Devolucion { get; set; }
        //si
        public Devoluciones() { }
       
        public List<Devoluciones> listardevoluciones = new List<Devoluciones>();

        public static List<Devoluciones> listaDevolucion = new List<Devoluciones>();

        public static List<Devoluciones> ObtenerDevoluciones()
        {
            Devoluciones devolucion;
            listaDevolucion.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCmd = "Select * from Devoluciones";

                SqlCommand cmd = new SqlCommand(textoCmd, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    devolucion = new Devoluciones();
                    devolucion.Id = elLectorDeDatos.GetInt32(0);
                    devolucion.Socio = elLectorDeDatos.GetString(1);
                    devolucion.Libro = elLectorDeDatos.GetString(2);
                    devolucion.Fecha_Prestamo = elLectorDeDatos.GetString(3);
                    devolucion.Fecha_Devolucion = elLectorDeDatos.GetString(4);


                    listaDevolucion.Add(devolucion);
                }
            }
            return listaDevolucion;
        }
    }
}

