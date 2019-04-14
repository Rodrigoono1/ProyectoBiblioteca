using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    public class Autor : Persona
    {
        public Autor() { }
        public Autor(string nro_documento, string nombre, string apellido, int telefono, string direccion)
        {
            this.nro_documento = nro_documento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
        }
    }
}
