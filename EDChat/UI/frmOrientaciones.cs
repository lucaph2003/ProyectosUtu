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
    public partial class frmOrientaciones : Form
    {
        public frmOrientaciones()
        {
            InitializeComponent();
            ArrayList listasignatura = Asignatura.listaAsignaturas();
            foreach (Asignatura asi in listasignatura)
                listAsignaturas.Items.Add(asi);

            ArrayList listaorientaciones = Orientacion.listaOrientaciones();
            foreach (Orientacion ori in listaorientaciones)
                listOrientaciones.Items.Add(ori);
        }

        private void pboIngresar_Click(object sender, EventArgs e)
        {
            if(listAsignaturas.SelectedItem != null)
            {
                Asignatura asi = (Asignatura)listAsignaturas.SelectedItem;
                listAsignaturasIngresadas.Items.Add(asi);
                listAsignaturas.Items.Remove(asi);
            }
        }

        private void pboEliminar_Click(object sender, EventArgs e)
        {
            if(listAsignaturasIngresadas.SelectedItem != null)
            {
                Asignatura asi = (Asignatura)listAsignaturasIngresadas.SelectedItem;
                listAsignaturas.Items.Add(asi);
                listAsignaturasIngresadas.Items.Remove(asi);
            }
        }

        private void pboGuardar_Click(object sender, EventArgs e)
        {
            string mensaje;
            int codigo;
            if (txtNombre.TextLength > 0)
            {
                Orientacion ultima = Orientacion.registrarOrientacion(txtNombre.Text, out codigo, out mensaje);
                
                for (int i = 0; i <= listAsignaturasIngresadas.Items.Count - 1; i++)
                {
                    
                    Asignatura asig = (Asignatura)listAsignaturasIngresadas.Items[i];
                    Orientacion.registrarAsignaturas_Orientacion(ultima, asig, out codigo, out mensaje);
                }

                //foreach (Object item in listAsignaturasIngresadas.Items)
                //{
                //  Asignatura asig = (Asignatura)item;
                //   Orientacion.registrarAsignaturas_Orientacion(ultima, asig, out codigo, out mensaje);
                //}


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
                ArrayList lista = Orientacion.listaOrientaciones();
                listOrientaciones.Items.Clear();
                foreach (Orientacion ori in lista)
                    if (ori.Nombre.ToUpper().StartsWith(txtBuscar.Text.ToUpper()))
                    {
                        listOrientaciones.Items.Add(ori);
                    }
            }
        }

        private void pboBorrar_Click(object sender, EventArgs e)
        {
            int codigo;
            string mensaje;
            if (listOrientaciones.SelectedItem != null)
            {
                Orientacion ori = (Orientacion)listOrientaciones.SelectedItem;
                Orientacion.eliminarOrientaciones(ori.Id, out codigo, out mensaje);
                MessageBox.Show("Eliminado con exito! ! !");
            }
        }

        private void pboActualizar_Click(object sender, EventArgs e)
        {
            listOrientaciones.Items.Clear();
            ArrayList listaorientaciones = Orientacion.listaOrientaciones();
            foreach (Orientacion ori in listaorientaciones)
                listOrientaciones.Items.Add(ori);
        }

        private void pboActualizar2_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            listAsignaturasIngresadas.Items.Clear();
            listAsignaturas.Items.Clear();
            ArrayList listasignatura = Asignatura.listaAsignaturas();
            foreach (Asignatura asi in listasignatura)
                listAsignaturas.Items.Add(asi);
        }
    }
}
