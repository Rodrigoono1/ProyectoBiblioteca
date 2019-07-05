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
    public partial class frmEditorial : Form
    {
        
        public frmEditorial()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Editorial editor = new Editorial();
            editor.Nombre = txtNombre.Text;
            editor.Direccion = txtDireccion.Text;
            editor.Telefono = Convert.ToInt32(txtTelefono.Text);
            editor.Email = txtEmail.Text;

            
            Editorial.AgregarEditorial(editor);
            ActualizarLista();
            Limpiar();
        }
        private void ActualizarLista()
        {
            lstEditorial.DataSource = null;
            lstEditorial.DataSource = Editorial.ObtenerEditoriales();
        }

        private void FrmEditorial_Load(object sender, EventArgs e)
        {
            lstEditorial.DataSource = Editorial.ObtenerEditoriales();
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
           
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            if (this.lstEditorial.SelectedItems.Count ==0)
            {
                MessageBox.Show("Seleccione un Item");

            }
            else
            {
                Editorial ed = (Editorial)lstEditorial.SelectedItem;
                Editorial.BorrarEditorial(ed);
                ActualizarLista();
                Limpiar();
            }
        }
            
        

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            int index = lstEditorial.SelectedIndex;
            Editorial ed = ObtenerEdi();
            Editorial.EditarEditorial(index, ed);

            Limpiar();
            ActualizarLista();

        }

        private Editorial ObtenerEdi()
        {
            Editorial editor = new Editorial();
            editor.Id = Convert.ToInt16(txtId.Text);
            editor.Nombre = txtNombre.Text;
            editor.Direccion = txtDireccion.Text;
            editor.Telefono = Convert.ToInt32(txtTelefono.Text);
            editor.Email = txtEmail.Text;
            return editor;

        }

        private void LstEditorial_Click(object sender, EventArgs e)
        {
            Editorial ed = (Editorial)lstEditorial.SelectedItem;
            
            if (ed != null)
            {
                txtId.Text = Convert.ToString(ed.Id);
                txtNombre.Text = ed.Nombre;
                txtDireccion.Text = ed.Direccion;
                txtTelefono.Text = Convert.ToString(ed.Telefono);
                txtEmail.Text = ed.Email;

            }
        }
    }
}
