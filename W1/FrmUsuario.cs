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
        }

        private void ActualizarListaUsuario()
        {
            lstUsuarios.DataSource = null;
            lstUsuarios.DataSource = Usuarios.listausuarios;
        }

        private void LimpiarForm()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtUsuario.Clear();
            txtcontrasena.Clear();
            cboCargo.SelectedItem = null;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Usuarios user = DefUsuarios();

            Usuarios.AgregarUsuario(user);

            ActualizarListaUsuario();
            LimpiarForm();
        }

        private Usuarios DefUsuarios() {
            Usuarios usuario = new Usuarios();
            usuario.Nombre = txtNombre.Text;
            usuario.Apellido = txtApellido.Text;
            usuario.Direccion = txtDireccion.Text;
            usuario.Telefono = txtTelefono.Text;
            usuario.Usuario = txtUsuario.Text;
            usuario.Contrasenha = txtcontrasena.Text;
            usuario.CargoUsuario = (Cargo)cboCargo.SelectedItem;
            return usuario;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //Funcion a ser implementada al agregar permisos a los usuarios
        }
    }
}
