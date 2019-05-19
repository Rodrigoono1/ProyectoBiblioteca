using BibliotecaDeBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W1
{
    public partial class frmLibro : Form
    {
        public frmLibro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios() { Nro_documento = "1234567", Nombre = "Jose", Apellido = "Gonzalez", Email = "jgonzalez@intro.com.py", Direccion = "su casa", Contrasenha="prueba123", Cargo="recepcionista" };
            Socios socio = new Socios() { Nro_documento = "1234568", Nombre = "Alfredo", Apellido = "Rodriguez", Email = "alfredor@micorreo.com", Direccion = "al lado de Jose" };
            Prestamos prestamo = new Prestamos(Convert.ToDateTime("15/04/2019"));
            Libros libro = new Libros() { titulo="El Padrino"};
            lblTitulo.Text=prestamo.MostrarPrestamo(socio,usuario,libro);
        }
    }
}
