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
        Editorial edi;
        public frmEditorial()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Editorial editor = new Editorial();
            editor.Nombre = txtNombre.Text;
            editor.Direccion = txtDireccion.Text;
            editor.Telefono = txtTelefono.Text;
            editor.Email = txtEmail.Text;
            edi.listareditoriales.Add(editor);

            ActualizarGrid();
            Limpiar();
        }

        private void FrmEditorial_Load(object sender, EventArgs e)
        {
            edi = new Editorial();
            dgvEditorial.AutoGenerateColumns = true;

        }
        private void ActualizarGrid()
        {
            dgvEditorial.DataSource = null;
            dgvEditorial.DataSource = edi.listareditoriales;
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
            Editorial editor = (Editorial)dgvEditorial.CurrentRow.DataBoundItem;
            if (editor != null)
            {
                edi.listareditoriales.Remove(editor);
            }
            ActualizarGrid();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
