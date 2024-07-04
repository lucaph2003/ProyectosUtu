using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.AccesoDatos;

namespace EDChat.Logica
{
    class Grupo
    {
        //Declaracion de atributos de los grupos
        int id,grado;
        string nombre,turno;
        Orientacion orientacion;

        public int Id { get => id; set => id = value; }
        public int Grado { get => grado; set => grado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Turno { get => turno; set => turno = value; }
        public Orientacion Orientacion { get => orientacion; set => orientacion = value; }

        override
        public String ToString()
        {
            return Nombre;
        }

        //Metodo para Registrar grupos
        public static Grupo registrarGrupo(Orientacion pOrientacion,String pNombre, int pGrado,string pTurno, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";

            Grupo nuevogrupo = new Grupo();
            nuevogrupo.Orientacion = pOrientacion;
            nuevogrupo.Nombre = pNombre;
            nuevogrupo.Grado = pGrado;
            nuevogrupo.Turno = pTurno;
            return GrupoBD.RegistrarGrupo(nuevogrupo, out codigo, out mensaje);

        }

        //Metodo puente para registrar alumnos_grupo
        public static void registrarAlumnos_grupo(Grupo pgrupo, Alumno palumno, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";

            GrupoBD.RegistrarAlumnosGrupo(pgrupo, palumno, out codigo, out mensaje);

        }

        //Metodo para Listar Grupos
        public static ArrayList listaGrupos()
        {
            ArrayList lista = new ArrayList();

            GrupoBD grupoBD = new GrupoBD();

            return grupoBD.ListarGrupos();
        }

        //Metodo puente para eliminar un grupo
        public static void eliminarGrupo(int IdGrupo, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            GrupoBD.EliminarGrupo(IdGrupo, out codigo, out mensaje);
        }

    }
}
