using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.AccesoDatos;

namespace EDChat.Logica
{
    class Orientacion
    {
        //Declaracion de atributos de los docentes
        int id;
        string nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        //Metodos tostring
        override
        public String ToString()
        {
            return Nombre;
        }


        //Metodo para Registrar Orientaciones
        public static Orientacion registrarOrientacion( String pNombre, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";

            Orientacion nuevaorientacion = new Orientacion();
            nuevaorientacion.Nombre = pNombre;

            return OrientacionBD.RegistrarOrientacion(nuevaorientacion, out codigo, out mensaje);

        }

        //Metodo para registrar asignaturas en orientaciones
        public static void registrarAsignaturas_Orientacion(Orientacion pOrientacion, Asignatura pAsignatura, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";

            OrientacionBD.RegistrarAsignaturaOrientacion(pOrientacion, pAsignatura, out codigo, out mensaje);

        }


        //Metodo para Listar Grupos
        public static ArrayList listaOrientaciones()
        {
            ArrayList lista = new ArrayList();

            OrientacionBD orientacionBD = new OrientacionBD();

            return orientacionBD.ListarOrientaciones();
        }

        //Metodo puente para eliminar un grupo
        public static void eliminarOrientaciones(int pIdOrientacion, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            OrientacionBD.EliminarOrientacion(pIdOrientacion, out codigo, out mensaje);
        }

    }
}
