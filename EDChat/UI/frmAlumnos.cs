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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();

            ArrayList listaContactos = Alumno.listaAlumnos();
            foreach (Alumno al in listaContactos)
            listAlumnos.Items.Add(al);
        }

        private void pboBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
            {
                ArrayList lista = Alumno.listaAlumnos();
                listAlumnos.Items.Clear();
                foreach (Alumno al2 in lista)
                    if (al2.Nombre.ToUpper().StartsWith(txtBuscar.Text.ToUpper()))
                    {
                        
                        listAlumnos.Items.Add(al2);
                    }
            }
        }

        private void pboLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();

        }

        private void listAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Alumno al = (Alumno)listAlumnos.SelectedItem;
                txtNombre.Clear();
                txtApellido.Clear();
                txtDni.Clear();
                txtPassword.Clear();
                txtNombre.Text = al.Nombre;
                txtApellido.Text =al.Apellido ;
                txtDni.Text = al.Ci ;
                txtPassword.Text = al.Password;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                    if (listAlumnos.SelectedItem != null)
                    {

                        Alumno al = (Alumno)listAlumnos.SelectedItem;

                        Alumno.actualizarDatosAlumno(txtNombre.Text, txtApellido.Text, txtDni.Text,txtPassword.Text,al.Id, out codigo, out mensaje);
                        if (codigo == 1)
                        {
                            txtNombre.Clear();
                            txtApellido.Clear();
                            txtDni.Clear();
                            txtPassword.Clear();
                            MessageBox.Show("Datos del alumno actualizados con exito! ! !");
                        }
                        else
                        {
                            MessageBox.Show("Se ha producido el siguiente error: " + codigo.ToString() + "  " + mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void pboEliminar_Click(object sender, EventArgs e)
        {
            string mensaje;
            int codigo;

            if (txtNombre.TextLength > 0)
            {
                Alumno al = (Alumno)listAlumnos.SelectedItem;
                Alumno.eliminarAlumno(al.Id, out codigo, out mensaje);
                MessageBox.Show("Eliminado con exito! ! !");
            }
            
        }

        private void pboGuardar_Click(object sender, EventArgs e)
        {
            String mensaje;
            int codigo;

            if (txtNombre != null)
            {
                if (txtApellido != null)
                {
                    if (txtDni != null)
                    {
                        if (txtPassword != null)
                        {
                          
                                Alumno.registrar(txtNombre.Text, txtApellido.Text, txtPassword.Text, txtDni.Text, out codigo, out mensaje);

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
            }
            else
            {
                MessageBox.Show("Completa todos los campos");
            }
        }

        private void pboActualizar_Click(object sender, EventArgs e)
        {
            listAlumnos.Items.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtPassword.Clear();
            txtBuscar.Clear();
            ArrayList listaContactos = Alumno.listaAlumnos();
            foreach (Alumno al in listaContactos)
                listAlumnos.Items.Add(al);

        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {

        }
    }
}
