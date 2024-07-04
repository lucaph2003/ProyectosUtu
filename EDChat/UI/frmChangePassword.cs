using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDChat.Logica;

namespace EDChat.UI
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            String mensaje;
            int codigo;

            Administrador.actualizarPassword(txtOldPassword.Text, txtConNewPassword.Text, txtNewPassword.Text, Session.id, out codigo, out mensaje);

            if (codigo == 1)
            {
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se ha producido el siguiente error: " + codigo.ToString() + "  " + mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pboCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pboMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
