using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
        public class Usuarios : Persona
    {
        public string contrasenha { get; set; }
        public string Cargo { get; set; }


        public Usuarios() { }
        public Usuarios(string nro_documento, string nombre, string apellido)
        {
            this.nro_documento = nro_documento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;

        }

    }
}
