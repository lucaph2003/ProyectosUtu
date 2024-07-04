using System;
using System.Collections;
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
    public partial class frmDocentes : Form
    {
        public frmDocentes()
        {
            InitializeComponent();
            ArrayList listaDocentes = Docente.listaDocentes();
            foreach (Docente doc in listaDocentes)
                lstDocentes.Items.Add(doc);

            ArrayList listasignatura = Asignatura.listaAsignaturas();
            foreach (Asignatura asi in listasignatura)
                cboAsignaturas.Items.Add(asi);

        }

        private void pboBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
            {
                ArrayList lista = Docente.listaDocentes();
                lstDocentes.Items.Clear();
                foreach (Docente doc2 in lista)
                    if (doc2.Nombre.ToUpper().StartsWith(txtBuscar.Text.ToUpper()))
                    {
                        lstDocentes.Items.Add(doc2);
                    }
            }
        }

        private void lstDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Docente doc = (Docente)lstDocentes.SelectedItem;
                Asignatura asig = doc.Asignatura;
                txtNombre.Clear();
                txtApellido.Clear();
                txtDni.Clear();
                txtPassword.Clear();
                txtNombre.Text= doc.Nombre;
                txtApellido.Text = doc.Apellido;
                txtDni.Text = doc.Ci;
                txtPassword.Text = doc.Password;
                cboAsignaturas.SelectedIndex = cboAsignaturas.FindString(asig.Nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pboLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtPassword.Clear();
            cboAsignaturas.SelectedItem = null;
        }

        private void pboGuardar_Click(object sender, EventArgs e)
        {
            String mensaje;
            int codigo;

            if(cboAsignaturas.SelectedItem != null)
            {
                Asignatura asi = (Asignatura)cboAsignaturas.SelectedItem;
                Docente.registrar(txtNombre.Text, txtApellido.Text, txtPassword.Text,  txtDni.Text, asi, out codigo, out mensaje);

                if (codigo == 1)
                {
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtDni.Clear();
                    txtPassword.Clear();
                    cboAsignaturas.SelectedItem = null;
                    MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se ha producido el siguiente error: " + codigo.ToString() + "  " + mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void pboModificar_Click(object sender, EventArgs e)
        {

            string mensaje;
            int codigo;

            if (txtNombre.Text.Length > 0)
            {
                if (txtApellido.Text.Length > 0)
                {
                    if (lstDocentes.SelectedItem != null)
                    {

                        Docente doc = (Docente)lstDocentes.SelectedItem;
                        Asignatura asig = (Asignatura)cboAsignaturas.SelectedItem;

                        Docente.actualizarDatosDocente(txtNombre.Text, txtApellido.Text, txtDni.Text, txtPassword.Text, doc.Id, asig, out codigo, out mensaje);
                        if (codigo == 1)
                        {
                            txtNombre.Clear();
                            txtApellido.Clear();
                            txtDni.Clear();
                            txtPassword.Clear();
                            cboAsignaturas.SelectedItem = null;
                            MessageBox.Show("Datos del docente actualizados con exito! ! !");
                        }
                        else
                        {
                            MessageBox.Show("Se ha producido el siguiente error: " + codigo.ToString() + "  " + mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void pboActualizar_Click(object sender, EventArgs e)
        {
            lstDocentes.Items.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtPassword.Clear();
            txtBuscar.Clear();
            cboAsignaturas.SelectedItem = null;
            ArrayList listaDocentes = Docente.listaDocentes();
            foreach (Docente doc in listaDocentes)
                lstDocentes.Items.Add(doc);
        }

        private void pboEliminar_Click(object sender, EventArgs e)
        {
            string mensaje;
            int codigo;

            if (txtNombre.TextLength > 0)
            {
                Docente doc = (Docente)lstDocentes.SelectedItem;
                Docente.eliminarDocente(doc.Id, out codigo, out mensaje);
                lstDocentes.Items.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtDni.Clear();
                txtPassword.Clear();
                txtBuscar.Clear();
                cboAsignaturas.SelectedItem = null;
                MessageBox.Show("Eliminado con exito! ! !");
            }
        }
    }
}
