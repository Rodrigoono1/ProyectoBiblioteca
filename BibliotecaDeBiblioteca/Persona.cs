using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    public class Persona
    {
        public string Nro_documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Nacionalidad { get; set; }

        public override string ToString()
        {
            return String.Format("Nombre: {0} Apellido: {1} Nro Doc: {2}", this.Nombre, this.Apellido, this.Nro_documento);
        }

    }
}
