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
    public partial class frmPrestamos : Form
    {
        public frmPrestamos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            dtgDetallePrestamo.AutoGenerateColumns = true;
            cmbSocio.DataSource = Socios.ObtenerSocios();
            cmbLibro.DataSource = Libros.ObtenerLibros();
            cmbSocio.SelectedItem = null;
            cmbLibro.SelectedItem = null;
            ActualizarListaPrestamos();
        }
        private void ActualizarListaPrestamos()
        {
            dtgDetallePrestamo.DataSource = null;
            dtgDetallePrestamo.DataSource = Prestamos.ObtenerPrestamos();
            dtgDetallePrestamo.Columns["ID"].Visible = false;
        }

    }
}
