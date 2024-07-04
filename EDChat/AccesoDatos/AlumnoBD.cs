using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.Logica;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace EDChat.AccesoDatos
{
    class AlumnoBD
    {
        //Metodo para listar alumnos
        public ArrayList ListaAlumnos()
        {
            ArrayList lista = new ArrayList();
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();
                MySqlDataReader reader;
                string sql = "SELECT * FROM alumnos";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Alumno usuario = null;
                    usuario = new Alumno();
                    usuario.Id = int.Parse(reader["idalumno"].ToString());
                    usuario.Password = reader["password"].ToString();
                    usuario.Nombre = reader["nombre"].ToString();
                    usuario.Apellido = reader["apellido"].ToString();
                    usuario.Ci = reader["ci"].ToString();
                    lista.Add(usuario);
                    
                }
                Conexion.closeConexion();
            }
            catch (MySqlException ex) { }
            return lista;
        }

        //Metodo para registrar Alumno
        public void RegistrarNuevoUsuario(Alumno alumno, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "INSERT INTO alumnos (nombre, apellido, password, ci, idalumno) VALUES(@nombre, @apellido, @password, @ci, @idalumno)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", alumno.Nombre);
                comando.Parameters.AddWithValue("@apellido", alumno.Apellido);
                comando.Parameters.AddWithValue("@password", alumno.Password);
                comando.Parameters.AddWithValue("@ci", alumno.Ci);
                comando.Parameters.AddWithValue("@idalumno", alumno.Id);
                codigo = comando.ExecuteNonQuery();
                mensaje = "Se ha registrado el alumno correctamente.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se ha podido registrar el alumno. " + ex.ToString();
            }
        }

        //Metodo para comprobar si existe la contrasenia
        public bool ExistePassword(string pPassword)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT ci FROM alumnos WHERE password LIKE @password";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@password", pPassword);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Metodo para elminar alumno
        public static void EliminarAlumno(int idAlumno, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "DELETE FROM alumnos WHERE idalumno= @idalumno";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idalumno", idAlumno);
                codigo = comando.ExecuteNonQuery();
                mensaje = "Se ha eliminado alumn@ correctamente.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se ha podido eliminar alumn@. " + ex.ToString();
            }
        }

        //Metodo para actualizar datos de los alumnos
        public void ActualizarDatosAlumno(String pNombre, string pApellido, string pCi, string pPassword, int pId, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();

                MySqlCommand comando = new MySqlCommand("UPDATE alumnos SET nombre = @nombre, apellido = @apellido, ci = @ci , password = @password WHERE idalumno = @idalumno", conexionBD);
                comando.Parameters.AddWithValue("@idalumno", pId);
                comando.Parameters.AddWithValue("@nombre", pNombre);
                comando.Parameters.AddWithValue("@apellido", pApellido);
                comando.Parameters.AddWithValue("@ci", pCi);
                comando.Parameters.AddWithValue("@password", pPassword);
                int ret = comando.ExecuteNonQuery();
                mensaje = "Se han actualizado correctamente los datos del alumno.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se han podido actualizar los datos del alumno. " + ex.ToString();
            }
        }

    }
}
