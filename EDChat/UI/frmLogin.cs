using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDChat.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pboSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pboMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void txtDni_Enter(object sender, EventArgs e)
        {
            Atajos.EnterDatos(txtDni,"DNI");
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            Atajos.LeaveDatos(txtDni, "DNI");
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            Atajos.EnterDatos(txtPassword, "Contraseña");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Atajos.LeaveDatos(txtPassword, "Contraseña");
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string password = txtPassword.Text;

            try
            {

                Logica.Control ctrl = new Logica.Control();
                string respuesta = ctrl.ctrlLogin(dni, password);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmInterfaz frm = new frmInterfaz();
                    frm.Visible = true;
                    this.Visible = false;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
