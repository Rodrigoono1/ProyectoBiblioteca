using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeBiblioteca;

namespace W1
{
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Autor autor = ObtenerAutorFormulario();

            Autor.AgregarAutor(autor);

            ActualizarListaAutor();
        }

        private void ActualizarListaAutor()
        {
            dgvAutor.DataSource = null;
            dgvAutor.DataSource = Autor.ObtenerAutor();
        }

        private Autor ObtenerAutorFormulario()
        {
            Autor autor = new Autor();
            autor.Nombre = txtNombre.Text;
            autor.Nacionalidad = txtNacionalidad.Text;
            return autor;
        }
    }
}
