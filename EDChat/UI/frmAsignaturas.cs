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
    public partial class frmAsignaturas : Form
    {
        public frmAsignaturas()
        {
            InitializeComponent();
            ArrayList listasignatura = Asignatura.listaAsignaturas();
            foreach (Asignatura asi in listasignatura)
                ListaAsignaturas.Items.Add(asi);
            
        }

        private void pboLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            cboCantHoras.SelectedItem = null;
        }

        private void ListaAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Asignatura asig = (Asignatura)ListaAsignaturas.SelectedItem;
                txtNombre.Clear();
                txtNombre.Text = asig.Nombre;
                cboCantHoras.SelectedItem = asig.Canthoras.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pboGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {
                if (cboCantHoras.Text.Length > 0)
                {
                    if (ListaAsignaturas.SelectedItem == null)
                    {
                        String mensaje;
                        int codigo;
                  
                        int canthorasid = int.Parse(cboCantHoras.SelectedItem.ToString());

                        Asignatura.registrar(txtNombre.Text, canthorasid, out codigo, out mensaje);

                        if (codigo == 1)
                        {
                            txtNombre.Clear();
                            cboCantHoras.SelectedItem = null;
                        }
                        else
                        {
                            MessageBox.Show("Se ha producido el siguiente error: " + codigo.ToString() + "  " + mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar el alumno al que le desea enviar un mensaje", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pboModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {
                if (cboCantHoras.Text.Length > 0)
                {
                    if (ListaAsignaturas.SelectedItem != null)
                    {
                        String mensaje;
                        int codigo;

                        Asignatura asi = (Asignatura)ListaAsignaturas.SelectedItem;

                        int canthorasid = int.Parse(cboCantHoras.SelectedItem.ToString());

                        Asignatura.actualizarDatos(txtNombre.Text, canthorasid, asi.Idasignatura, out codigo, out mensaje);
                        if (codigo == 1)
                        {
                            txtNombre.Clear();
                            cboCantHoras.SelectedItem = null;
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
            int codigo;
            string mensaje;
            if(txtNombre.TextLength >0)
            {
                Asignatura asi = (Asignatura)ListaAsignaturas.SelectedItem;
                Asignatura.eliminarAsignatura(asi.Idasignatura,out codigo,out mensaje);
                MessageBox.Show("Eliminado con exito! ! !");
            }
        }

        private void pboRefrescar_Click(object sender, EventArgs e)
        {
            ListaAsignaturas.Items.Clear();
            ArrayList listasignatura = Asignatura.listaAsignaturas();
            foreach (Asignatura asi in listasignatura)
                ListaAsignaturas.Items.Add(asi);
        }
    }
}
