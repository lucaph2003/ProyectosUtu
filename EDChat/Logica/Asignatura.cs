using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.AccesoDatos;

namespace EDChat.Logica
{
    class Asignatura
    {
        //Declaracion de los atributos de las asignaturas
        int idasignatura,canthoras;
        string nombre;

        public int Idasignatura { get => idasignatura; set => idasignatura = value; }
        public int Canthoras { get => canthoras; set => canthoras = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        //Metodos tostring
        override
        public String ToString()
        {
            return Nombre ;
        }

        //Metodo puente para registrar asignatura
        public static void registrar(String pNombre, int pCantHoras, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";

            Asignatura nuevaAsignatura = new Asignatura();
            nuevaAsignatura.Nombre = pNombre;
            nuevaAsignatura.Canthoras = pCantHoras;
            AsignaturaBD.RegistrarNuevaAsignatura(nuevaAsignatura, out codigo, out mensaje);

        }

        //Metodo puente del listado de asignaturas
        public static ArrayList listaAsignaturas()
        {
            ArrayList lista = new ArrayList();

            AsignaturaBD asignaturaBD = new AsignaturaBD();

            return asignaturaBD.ListarAsignaturas();
        }

        //Metodo puente para eliminar una asignatura
        public static void eliminarAsignatura(int IdAsignatura, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            AsignaturaBD.EliminarAsignatura(IdAsignatura, out codigo, out  mensaje);
        }

        //Metodo puente para actualizar datos de una asignatura
        public static void actualizarDatos(String pNombre, int pCantidadHoras, int pId, out int codigo, out String mensaje)
        {
            AsignaturaBD asignaturaBD = new AsignaturaBD();
            asignaturaBD.ActualizarDatos(pNombre, pCantidadHoras, pId, out codigo, out mensaje);
        }

    }
}
