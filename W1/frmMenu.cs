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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void TsmSocio_Click(object sender, EventArgs e)
        {
            frmSocio form = new frmSocio();
            form.Show();
        }

        private void TsmAutor_Click(object sender, EventArgs e)
        {
            frmAutor form = new frmAutor();
            form.Show();
        }

        private void TsmEditorial_Click(object sender, EventArgs e)
        {
            frmEditorial form = new frmEditorial();
            form.Show();
        }

        private void TsmLibro_Click(object sender, EventArgs e)
        {
            frmLibro form = new frmLibro();
            form.Show();
        }

        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario form = new frmUsuario();
            form.Show();
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por Team Cannon \n" +
                "-Diego Benitez \n" + "-Renato Jara \n" + "-Barbara Morales \n" + "-Rodrigo Ono \n" + "-Jose Yegros");
        }

        private void TsmPrestamo_Click(object sender, EventArgs e)
        {
            frmPrestamos form = new frmPrestamos();
            form.Show();
        }
    }
}
