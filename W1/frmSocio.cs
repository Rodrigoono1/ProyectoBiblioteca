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
    public partial class frmSocio : Form
    {
        Socios socio;

        public frmSocio()
        {
            InitializeComponent();
        }

        private void FrmSocio_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = Enum.GetValues(typeof(Categoria));
            socio = new Socios();
            dgvSocio.AutoGenerateColumns = true;
            cmbCategoria.SelectedItem = null;


        }

           private void ActualizarGrid()
        {
            dgvSocio.DataSource = null;
            dgvSocio.DataSource = socio.listarsocios;
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtNroDoc.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            cmbCategoria.SelectedItem = null;

        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {

            Socios soc = new Socios();
            soc.Nro_documento = Convert.ToInt32(txtNroDoc.Text);
            soc.Nombre = txtNombre.Text;
            soc.Apellido = txtApellido.Text;
            soc.Email = txtEmail.Text;
            soc.Telefono = Convert.ToInt32(txtTelefono.Text);
            soc.Direccion = txtDireccion.Text;
            soc.Categoria = (Categoria)cmbCategoria.SelectedItem;
            socio.listarsocios.Add(soc);
            
            ActualizarGrid();
            Limpiar();
        }
        
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //ver como hacer funcionar modificar con datagrid con el profe
        private void BtnModificar_Click(object sender, EventArgs e)
        {

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            Socios soc = (Socios)dgvSocio.CurrentRow.DataBoundItem;
            if (soc != null)
            {
                socio.listarsocios.Remove(soc);
            }
            ActualizarGrid();
        }

    }
}
