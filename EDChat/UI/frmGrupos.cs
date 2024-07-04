using EDChat.Logica;
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

namespace EDChat.UI
{
    public partial class frmGrupos : Form
    {
        public frmGrupos()
        {
            InitializeComponent();

            ArrayList listaalumnos = Alumno.listaAlumnos();
            foreach (Alumno al in listaalumnos)
                listAlumnos.Items.Add(al);

            ArrayList listagrupos = Grupo.listaGrupos();
            foreach (Grupo gru in listagrupos)
                listGrupos.Items.Add(gru.ToString());

            ArrayList listaorientaciones = Orientacion.listaOrientaciones();
            foreach (Orientacion ori in listaorientaciones)
                cboOrientacion.Items.Add(ori);
        }

        private void pboIngresar_Click(object sender, EventArgs e)
        {
            if(listAlumnos.SelectedItem != null)
            {
                Alumno al = (Alumno)listAlumnos.SelectedItem;
                listAlumnosIngresados.Items.Add(al);
                listAlumnos.Items.Remove(al);
            }
        }

        private void pboEliminar_Click(object sender, EventArgs e)
        {
            if(listAlumnosIngresados.SelectedItem != null)
            {
                Alumno al = (Alumno)listAlumnosIngresados.SelectedItem;
                listAlumnos.Items.Add(al);
                listAlumnosIngresados.Items.Remove(al);
            }
        }

        private void pboRegistrar_Click(object sender, EventArgs e)
        {
            string mensaje;
            int codigo;
            if(txtNombre.TextLength > 0)
            {
                int grado = int.Parse(cboGrado.SelectedItem.ToString());
                Orientacion orientacion = (Orientacion)cboOrientacion.SelectedItem;
                Grupo grupo = Grupo.registrarGrupo(orientacion, txtNombre.Text, grado, cboTurno.SelectedItem.ToString(), out codigo, out mensaje);

                //for (int i = 0; i <= listAlumnosIngresados.Items.Count -1; i++)
                //    {
                //        string mensaje2;
                //        int codigo2;
                //        Alumno al = (Alumno)listAlumnosIngresados.Items[i];
                //        Grupo.registrarAlumnos_grupo(grupo,al,out codigo2,out mensaje2);
                //    }


                   
                foreach (Object item in listAlumnosIngresados.Items)
                {
                    string mensaje2;
                    int codigo2;
                    Alumno al = (Alumno)item;
                    Grupo.registrarAlumnos_grupo(grupo, al, out codigo2, out mensaje2);
                }

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

        private void pboBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
            {
                ArrayList lista = Grupo.listaGrupos();
                listGrupos.Items.Clear();
                foreach (Grupo gru in lista)
                    if (gru.Nombre.ToUpper().StartsWith(txtBuscar.Text.ToUpper()))
                    {
                        listGrupos.Items.Add(gru);
                    }
            }
        }

        private void pboBorrar_Click(object sender, EventArgs e)
        {
            int codigo;
            string mensaje;
            if (listGrupos.SelectedItem != null)
            {
                Grupo gru = (Grupo)listGrupos.SelectedItem;
                Grupo.eliminarGrupo(gru.Id, out codigo, out mensaje);
                MessageBox.Show("Eliminado con exito! ! !");
            }
        }

        private void pboActualizar_Click(object sender, EventArgs e)
        {
            listGrupos.Items.Clear();
            ArrayList listagrupo = Grupo.listaGrupos();
            foreach (Grupo gru in listagrupo)
                listGrupos.Items.Add(gru);
        }

        private void pboActualizar2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            cboGrado.SelectedItem = null;
            cboOrientacion.SelectedItem = null;
            cboTurno.SelectedItem = null;
            listAlumnosIngresados.Items.Clear();
            listAlumnos.Items.Clear();
            ArrayList listaalumnos = Alumno.listaAlumnos();
            foreach (Alumno al in listaalumnos)
                listAlumnos.Items.Add(al);

        }
    }
}
