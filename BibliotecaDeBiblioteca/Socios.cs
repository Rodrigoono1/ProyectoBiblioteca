using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    public class Socios : Persona
    {

      
        public string categoria { get; set; }


        public Socios() { }
        public Socios(string nro_documento, string nombre, string apellido, string email, string telefono, string direccion)
        {
            this.Nro_documento = nro_documento;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Telefono = telefono;
            this.Direccion = direccion;

        }
        
        public List<Socios> listarsocios = new List<Socios>();

    }
}
