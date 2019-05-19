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
            socio = new Socios();
            dgvSocio.AutoGenerateColumns = true;


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

        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            Socios soc = new Socios();
            soc.Nro_documento = txtNroDoc.Text;
            soc.Nombre = txtNombre.Text;
            soc.Apellido = txtApellido.Text;
            soc.Email = txtEmail.Text;
            soc.Telefono = txtTelefono.Text;
            soc.Direccion = txtDireccion.Text;
            socio.listarsocios.Add(soc);

            ActualizarGrid();
            Limpiar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
