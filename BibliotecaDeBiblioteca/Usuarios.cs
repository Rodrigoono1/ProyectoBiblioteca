using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
        public class Usuarios : Persona
        {
            public string Contrasenha { get; set; }
            public string Cargo { get; set; }


            public Usuarios() { }
            public Usuarios(string nro_documento, string nombre, string apellido, int telefono, string direccion)
            {
                this.Nro_documento = nro_documento;
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.Telefono = telefono;
                this.Direccion = direccion;
            }
        }
}
