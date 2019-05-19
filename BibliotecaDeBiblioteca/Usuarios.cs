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
            public string cargo { get; set; }


            public Usuarios() { }
            public Usuarios(string nro_documento, string nombre, string apellido, int telefono, string direccion)
            {
                this.Nro_documento = nro_documento;
                this.Nombre = nombre;
                this.Telefono = telefono;
                this.Direccion = direccion;
            }
        }
}
