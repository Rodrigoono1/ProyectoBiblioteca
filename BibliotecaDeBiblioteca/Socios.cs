using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    class Socios : Persona
    {
        public string categoria { get; set; }


        public Socios() { }
        public Socios(string nro_documento, string nombre, string apellido)
        {
            this.nro_documento = nro_documento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;

        }
    }
}
