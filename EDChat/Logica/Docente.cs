using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.AccesoDatos;

namespace EDChat.Logica
{
    class Docente
    {
        //Declaracion de atributos de los docentes
        int id;
        string nombre, apellido, password, conPassword, ci;
        Asignatura asignatura;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Password { get => password; set => password = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
        public string Ci { get => ci; set => ci = value; }
        public int Id { get => id; set => id = value; }
        public Asignatura Asignatura { get => asignatura; set => asignatura = value; }


        override
         public String ToString()
        {
            return Ci + " - " + Nombre + " " + Apellido;
        }

        //Metodo puente del listado de docentes
        public static ArrayList listaDocentes()
        {
            ArrayList lista = new ArrayList();

            DocenteBD docenteBD = new DocenteBD();

            return docenteBD.ListaDocentes();
        }

        //Metodo puente para registrar Docentes
        public static void registrar(String pNombre, String pApellido, String pPassword,  String pCi, Asignatura pAsignatura, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";

            Docente nuevoUsuario = new Docente();
            nuevoUsuario.Nombre = pNombre;
            nuevoUsuario.Apellido = pApellido;
            nuevoUsuario.Password = pPassword;
            nuevoUsuario.Ci = pCi;
            nuevoUsuario.Asignatura = pAsignatura;

            try
            {

                Logica.Control control = new Logica.Control();
                DocenteBD docenteBD = new DocenteBD();

                //Valido que se hayan cargado todos los datos en el formulario
                string respuesta = control.ctrlRegistroDocente(nuevoUsuario);

                if (respuesta.Length > 0)
                {
                    codigo = -1;
                    mensaje = respuesta;
                }
                else
                {
                    //Paso validacion y llamo a metodo que guarda el nuevo Usuario
                    docenteBD.RegistrarNuevoUsuario(nuevoUsuario, out codigo, out mensaje);

                    //Si resultado es cero hubo algun error

                }
            }
            catch (Exception ex)
            {
                codigo = -1;
                mensaje = "No se ha podido registrar el docente. " + ex.ToString(); ;
            }
        }

        //Metodo puente para eliminar docentes
        public static void eliminarDocente(int idDocente, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            DocenteBD.EliminarDocente(idDocente, out codigo, out mensaje);
        }

        //Metodo puente para actualizar Docente
        public static void actualizarDatosDocente(String pNombre, string pApellido, string pCi, string pPassword, int pId, Asignatura pasig,out int codigo, out String mensaje)
        {
            DocenteBD docenteBD = new DocenteBD();
            docenteBD.ActualizarDatosDocente(pNombre, pApellido, pCi, pPassword, pId,pasig, out codigo, out mensaje);
        }

    }
}
