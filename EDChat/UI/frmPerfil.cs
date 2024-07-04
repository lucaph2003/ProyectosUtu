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
    public partial class frmPerfil : Form
    {
        public frmPerfil()
        {
            InitializeComponent();
            txtNombre.Text = Session.nombre;
            txtApellido.Text = Session.apellido;
            pboImagen.Image = Session.fotoperfil;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes|*.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {

                pboImagen.Image = Image.FromFile(ofdSeleccionar.FileName);

            }
        }

        private void lnkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.Visible = true;
            this.Visible = true;
        }

      
        private void pboGuardar_Click(object sender, EventArgs e)
        {
            String mensaje;
            int codigo;

            Administrador.actualizarDatos(pboImagen.Image, txtNombre.Text, txtApellido.Text, Session.id, out codigo, out mensaje);

            if (codigo == 1)
            {
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se ha producido el siguiente error: " + codigo.ToString() + "  " + mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
