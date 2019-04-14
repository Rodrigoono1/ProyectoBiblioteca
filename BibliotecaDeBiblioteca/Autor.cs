using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    public class Autor : Persona
    {
        public int Codigo { get; set; }
        public Autor() { }
        public Autor(int codigo, string nombre, string apellido)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
    }
}
