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
    public partial class frmInterfaz : Form
    {
        public frmInterfaz()
        {
            InitializeComponent();
        }
        private void AbrirFormhija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        

        private void pboCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pboMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOrientaciones_Click(object sender, EventArgs e)
        {
            panelContenedor.Refresh();
            AbrirFormhija(new frmOrientaciones());
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            panelContenedor.Refresh();
            AbrirFormhija(new frmAlumnos());
        }

        private void btnDocentes_Click(object sender, EventArgs e)
        {
            panelContenedor.Refresh();
            AbrirFormhija(new frmDocentes());
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            panelContenedor.Refresh();
            AbrirFormhija(new frmPerfil());
        }

        private void btnAsignaturas_Click(object sender, EventArgs e)
        {
            panelContenedor.Refresh();
            AbrirFormhija(new frmAsignaturas());
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            panelContenedor.Refresh();
            AbrirFormhija(new frmGrupos());
        }
    }
}
