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
    public partial class frmContrasenia : Form
    {
        public frmContrasenia()
        {
            InitializeComponent();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            Atajos.EnterDatos(txtPassword,"Ingrese Contraseña");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Atajos.LeaveDatos(txtPassword, "Ingrese Contraseña");
        }

        private void txtConPassword_Enter(object sender, EventArgs e)
        {
            Atajos.EnterDatos(txtConPassword, "Confirme Contraseña");
        }

        private void txtConPassword_Leave(object sender, EventArgs e)
        {
            Atajos.LeaveDatos(txtConPassword, "Confirme Contraseña");
        }

        private void pboCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pboMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtConPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
