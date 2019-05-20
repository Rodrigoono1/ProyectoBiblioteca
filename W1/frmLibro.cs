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

        private void frmLibro_Load(object sender, EventArgs e)
        {
            cmbGenero.DataSource = Enum.GetValues(typeof(Genero));
            cmbIdioma.DataSource = Enum.GetValues(typeof(Idioma));
            cmbIdioma.SelectedItem = null;
            cmbGenero.SelectedItem = null;
            dgvLibro.AutoGenerateColumns = true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Libros book = CargaLibro();
            Libros.listalibros.Add(book);
        }
        private Libros CargaLibro()
        {
            Libros libro = new Libros();
            libro.titulo = txtTitulo.Text;
            libro.ISBN = txtISBN.Text;
            libro.año = Convert.ToInt16(txtAñoPublicacion.Text);
            libro.idioma = (Idioma)cmbIdioma.SelectedItem;
            libro.genero = (Genero)cmbGenero.SelectedItem;
            return libro;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
