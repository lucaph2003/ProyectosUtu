using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.Logica;
using System.Collections;

namespace EDChat.AccesoDatos
{
    class GrupoBD
    {
        //Metodo para registrar grupo
        public static Grupo RegistrarGrupo(Grupo grupo, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            Grupo grupo2 = null;
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "INSERT INTO grupos (idorientacion,grado,nombre,turno) VALUES(@idorientacion,@grado,@nombre,@turno)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idorientacion", grupo.Orientacion.Id);
                comando.Parameters.AddWithValue("@grado", grupo.Grado);
                comando.Parameters.AddWithValue("@nombre", grupo.Nombre);
                comando.Parameters.AddWithValue("@turno", grupo.Turno);

                grupo2 = ObtenerUltimoGrupo();

                codigo = comando.ExecuteNonQuery();
                mensaje = "Se ha registrado la orientacion correctamente.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se ha podido registrar la orientacion. " + ex.ToString();
            }
            return grupo2;
        }

        //Metodo para registrar los alumnos en los grupos
        public static void RegistrarAlumnosGrupo(Grupo grupo, Alumno alumno, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "INSERT INTO alumnos_grupo (idgrupo,idalumno) VALUES(@idgrupo,@idalumno)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idgrupo", grupo.Id);
                comando.Parameters.AddWithValue("@idalumno", alumno.Id);
                codigo = comando.ExecuteNonQuery();
                mensaje = "Se han registrado las asignaturas en la orientacion correctamente.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se han podido registrar las asignaturas en la orientacion. " + ex.ToString();
            }
        }

        //Metodo para eliminar grupos
        public static void EliminarGrupo(int idGrupo, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "DELETE FROM grupos WHERE idgrupo= @idgrupo";
                string sql2 = "DELETE FROM alumnos_grupo where idgrupo = @idgrupo";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idgrupo", idGrupo);
                MySqlCommand comando2 = new MySqlCommand(sql2, conexion);
                comando.Parameters.AddWithValue("@idgrupo", idGrupo);
                codigo = comando.ExecuteNonQuery();
                mensaje = "Se ha eliminado la asignatura correctamente.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se ha podido eliminar la asignatura. " + ex.ToString();
            }
        }

        //Metodo para Listar grupos
        public ArrayList ListarGrupos()
        {
            ArrayList lista = new ArrayList();

            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();
                MySqlDataReader reader;

                string sql = "SELECT * FROM grupos";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Grupo grupo = null;
                    grupo = new Grupo();
                    grupo.Id = int.Parse(reader["idgrupo"].ToString());
                    grupo.Grado = int.Parse(reader["grado"].ToString());
                    grupo.Nombre = reader["nombre"].ToString();
                    grupo.Turno= reader["turno"].ToString();
                    lista.Add(grupo);

                }

                Conexion.closeConexion();

            }
            catch (MySqlException ex) { }

            return lista;
        }

        //Metodo para buscar grupo
        public static Grupo BuscarGrupo(int IdGrupo)
        {
            try
            {
                Grupo grupo = new Grupo();

                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "SELECT * FROM grupos WHERE idgrupo= @idgrupo";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idgrupo", IdGrupo);
                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    grupo.Id = int.Parse(reader["idgrupo"].ToString());
                    grupo.Grado = int.Parse(reader["grado"].ToString());
                    grupo.Nombre = reader["nombre"].ToString();
                    grupo.Turno = reader["turno"].ToString();
                }
                Conexion.closeConexion();
                return grupo;
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }

        //Metodo para obtener el ultimo grupo rtegistrado y poder ingresar los alumnos
        public static Grupo ObtenerUltimoGrupo()
        {
            Grupo grupo = null;

            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();
                MySqlDataReader reader;

                string sql = "SELECT* FROM grupos order by idgrupo desc limit 1";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    grupo = new Grupo();
                    grupo.Id = int.Parse(reader["idgrupo"].ToString());
                }

                Conexion.closeConexion();

            }
            catch (MySqlException ex) { }

            return grupo;
        }

    }
}
