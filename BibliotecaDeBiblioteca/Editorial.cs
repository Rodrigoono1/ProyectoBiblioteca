using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    public class Editorial
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public int idEditorial { get; set; }
        public string email { get; set; }

        public Editorial() { }
        public Editorial(string nro_documento, string nombre, string apellido, string telefono, string direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.idEditorial = idEditorial;
            this.telefono = telefono;
        }
    }
}