using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    class Editorial
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int idEditorial { get; set; }


        public Editorial() { }
        public Editorial(string nro_documento, string nombre, string apellido, string telefono, string direccion)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.idEditorial = idEditorial;
            this.Telefono = telefono;
        }
    }
}