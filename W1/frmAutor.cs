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
            Autor autor = new Autor();
            autor.Escritor = txtNombre.Text;
            autor.Nacionalidad = txtNacionalidad.Text;
            autor.Fecha_Nacimiento = dtpFecha.Value.Date;
            Autor.AgregarAutor(autor);

            LimpiarFormulario();
            ActualizarListaAutor();
        }
       
        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtNacionalidad.Text = "";
            dtpFecha.Value = DateTime.Now;
            
        }

        private void ActualizarListaAutor()
        {
            lstAutor.DataSource = null;
            lstAutor.DataSource = Autor.ObtenerAutor();
        }

        private Autor ObtenerAutorFormulario()
        {
            Autor autor = new Autor();
            autor.Escritor = txtNombre.Text;
            autor.Nacionalidad = txtNacionalidad.Text;
            autor.Fecha_Nacimiento = dtpFecha.Value.Date;
            return autor;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int index = lstAutor.SelectedIndex;
            Autor a = ObtenerAutorFormulario();
            Autor.EditarAutor(index, a);

            LimpiarFormulario();
            ActualizarListaAutor();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (this.lstAutor.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un Item");
            }
            else
            {
                Autor a = (Autor)lstAutor.SelectedItem;
                Autor.BorrarAutor(a);
                ActualizarListaAutor();
                LimpiarFormulario();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAutor_Load(object sender, EventArgs e)
        {
            lstAutor.DataSource = Autor.ObtenerAutor();
        }
    }
}
