using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    public class Persona
    {
        public string nro_documento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }

        public override string ToString()
        {
            return String.Format("Nombre: {0} Apellido: {1} Nro Doc: {2}", this.nombre, this.apellido, this.nro_documento);
        }

    }
}
