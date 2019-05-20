using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeBiblioteca
{
    public enum Cargo { Administrador, Usuario }
    public class Usuarios : Persona
    {
        public string Contrasenha { get; set; }
        public string Usuario { get; set; }

        public Cargo CargoUsuario {get; set;}

            public Usuarios() { }
            public Usuarios(string nro_documento, string nombre, string apellido, string telefono, string direccion,string usuario, string contrasenha, Cargo cargo)
            {
                this.Nro_documento = nro_documento;
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.Telefono = telefono;
                this.Direccion = direccion;
                this.Usuario = usuario;
                this.Contrasenha = contrasenha;
                this.CargoUsuario = cargo;
            }
        public static List<Usuarios> listausuarios = new List<Usuarios>();

        public static void AgregarUsuario(Usuarios u)
        {
            listausuarios.Add(u);
        }
        public override string ToString()
        {
            return this.Usuario;
        }
    }
}
