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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            ActualizarListaUsuario();
            cboCargo.DataSource = Enum.GetValues(typeof(Cargo));
            cboCargo.SelectedItem = null;
            txtNombre.Focus();
            LimpiarForm();
        }

        private void ActualizarListaUsuario()
        {
            lstUsuarios.DataSource = null;
            lstUsuarios.DataSource = Usuarios.ObtenerUsuarios();
        }

        private void LimpiarForm()
        {
            nudCI.Value = 0;
            cboCargo.Enabled = true;
            txtcontrasena.Enabled = true;
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtUsuario.Clear();
            txtcontrasena.Clear();
            cboCargo.SelectedItem = null;
            lstUsuarios.SelectedItem = null;
            btnModificar.Enabled = false;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Usuarios user = DefUsuarios();

            Usuarios.CrearUsuario(user);

            ActualizarListaUsuario();
            LimpiarForm();
        }

        private Usuarios DefUsuarios() {
            Usuarios usuario = new Usuarios();
            usuario.Nro_documento = Convert.ToInt32(nudCI.Value);
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Direccion = txtDireccion.Text;
            usuario.Telefono = Convert.ToInt32(txtTelefono.Text);
            usuario.Usuario = txtUsuario.Text;
            usuario.Contrasenha = txtcontrasena.Text;
            usuario.CargoUsuario = (Cargo)cboCargo.SelectedItem;
            return usuario;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            Usuarios u = (Usuarios)lstUsuarios.SelectedItem;
            int index = lstUsuarios.SelectedIndex;
            
            Usuarios user = DefUsuarios();
            Usuarios.EditarUsuario(index, user);
            ActualizarListaUsuario();
            LimpiarForm();
        }

        private void LstUsuarios_Click(object sender, EventArgs e)
        {
            /*txtcontrasena.Enabled = false;
            cboCargo.Enabled = false;*/
            btnModificar.Enabled = true;
            Usuarios user = (Usuarios)lstUsuarios.SelectedItem;
            if (user != null)
            {
                nudCI.Value = user.Nro_documento;
                txtNombre.Text = user.Nombre;
                txtApellido.Text = user.Apellido;
                txtTelefono.Text = Convert.ToString(user.Telefono);
                txtDireccion.Text = user.Direccion;
                txtUsuario.Text = user.Usuario;
                txtcontrasena.Text = user.Contrasenha;
                cboCargo.SelectedItem = user.CargoUsuario;
            }
        }
    }
}
