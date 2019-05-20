using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    public enum Categoria
    {
        Free,
        Basico,
        Premium
    }

    public class Socios : Persona
    {

             
        //public Categoria Categoria { get; set; }
        public string Categoria { get; set; }
        public Socios() { }
        public Socios(string nro_documento, string nombre, string apellido, string email, string telefono, string direccion,string categoria)
        {
            this.Nro_documento = nro_documento;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Telefono = telefono;
            this.Direccion = direccion;
            this.Categoria = categoria;
        }
        

        public List<Socios> listarsocios = new List<Socios>();

    }
}
