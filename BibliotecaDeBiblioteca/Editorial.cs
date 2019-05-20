using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    public class Editorial
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        //public int idEditorial { get; set; }
        public string Email { get; set; }

        public Editorial() { }
        public Editorial(string nombre, string direccion, string telefono, string email)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            //this.idEditorial = idEditorial; ver para que se puso esto
            this.Telefono = telefono;
            this.Email = email;

            
        }
        public List<Editorial> listareditoriales = new List<Editorial>();
    }
}