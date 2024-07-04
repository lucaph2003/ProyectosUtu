using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.AccesoDatos;

namespace EDChat.Logica
{
    class Alumno
    {
        //Declaracion de atributo de los alumnos
        int id;
        string nombre, apellido, password, ci;
        Image fotoperfil;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Password { get => password; set => password = value; }
        public string Ci { get => ci; set => ci = value; }
        public int Id { get => id; set => id = value; }
        public Image FotoPerfil { get => fotoperfil; set => fotoperfil = value; }

        override
        public String ToString()
        {
            return Ci + " - " + Nombre + " " + Apellido;
        }

        //Metodo puente del listado de alumnos
        public static ArrayList listaAlumnos()
        {
            AlumnoBD alumnoBD = new AlumnoBD();

            return alumnoBD.ListaAlumnos();
        }

        //Metodo puente para registrar alumnos
        public static void registrar(String pNombre, String pApellido, String pPassword,  String pCi, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";

            Alumno nuevoUsuario = new Alumno();
            nuevoUsuario.Nombre = pNombre;
            nuevoUsuario.Apellido = pApellido;
            nuevoUsuario.Password = pPassword;
            nuevoUsuario.Ci = pCi;

            try
            {

                Logica.Control control = new Logica.Control();
                AlumnoBD alumnoBD = new AlumnoBD();

                //Valido que se hayan cargado todos los datos en el formulario
                string respuesta = control.ctrlRegistroAlumno(nuevoUsuario);

                if (respuesta.Length > 0)
                {
                    codigo = -1;
                    mensaje = respuesta;
                }
                else
                {
                    //Paso validacion y llamo a metodo que guarda el nuevo Usuario
                    alumnoBD.RegistrarNuevoUsuario(nuevoUsuario, out codigo, out mensaje);
                    //Si resultado es cero hubo algun error
                }
            }
            catch (Exception ex)
            {
                codigo = -1;
                mensaje = "No se ha podido registrar el docente. " + ex.ToString(); ;
            }
        }

        //Metodo puente para elminar alumnos
        public static void eliminarAlumno(int idAlumno, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            AlumnoBD.EliminarAlumno(idAlumno, out codigo, out mensaje);
        }

        //Metodo puente para actualizar datos alumno
        public static void actualizarDatosAlumno(String pNombre, string pApellido, string pCi, string pPassword, int pId, out int codigo, out String mensaje)
        {
            AlumnoBD alumnoBD = new AlumnoBD();
            alumnoBD.ActualizarDatosAlumno(pNombre, pApellido,pCi,pPassword, pId, out codigo, out mensaje);
        }

    }
}
