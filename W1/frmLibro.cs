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
            cmbEditorial.DataSource = Editorial.ObtenerEditoriales();
            cmbAutor.DataSource = Autor.ObtenerAutor();
            cmbEditorial.SelectedItem = null;
            cmbIdioma.SelectedItem = null;
            cmbGenero.SelectedItem = null;
            dgvLibro.AutoGenerateColumns = true;
            ActualizarListaLibros();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Libros book = CargaLibro();
            Libros.listalibros.Add(book);
            ActualizarListaLibros();
        }
        private Libros CargaLibro()
        {
            Libros libro = new Libros();
            libro.titulo = txtTitulo.Text;
            libro.ISBN = Convert.ToInt32(txtISBN.Text);
            libro.año = Convert.ToInt32(txtAñoPublicacion.Text);
            libro.idioma = (Idioma)cmbIdioma.SelectedItem;
            libro.genero = (Genero)cmbGenero.SelectedItem;
            libro.editorial = (Editorial)cmbEditorial.SelectedItem;
            libro.autor = (Autor)cmbAutor.SelectedItem;

            return libro;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ActualizarListaLibros()
        {
            dgvLibro.DataSource = null;
            dgvLibro.DataSource = Libros.ObtenerLibros();
            dgvLibro.Columns["ID"].Visible = false;
        }
    }
}
