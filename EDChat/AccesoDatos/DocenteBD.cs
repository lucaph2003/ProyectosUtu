using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.Logica;
using MySqlConnector;

namespace EDChat.AccesoDatos
{
    class DocenteBD
    {

        //Metodo para listar todos los docentes
        public ArrayList ListaDocentes()
        {
            ArrayList lista = new ArrayList();

            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();
                MySqlDataReader reader;

                string sql = "SELECT * FROM docentes";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Docente usuario = null;
                    usuario = new Docente();
                    usuario.Id = int.Parse(reader["iddocente"].ToString());
                    usuario.Password = reader["password"].ToString();
                    usuario.Nombre = reader["nombre"].ToString();
                    usuario.Apellido = reader["apellido"].ToString();
                    usuario.Ci = reader["ci"].ToString();
                    usuario.Asignatura = AsignaturaBD.BuscarAsignatura(int.Parse(reader["idasignatura"].ToString())); 
                    lista.Add(usuario);
                }
                Conexion.closeConexion();
            }
            catch (MySqlException ex) { }

            return lista;
        }

        //Metodo para registrar nuevo Docente
        public void RegistrarNuevoUsuario(Docente docente, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "INSERT INTO docentes (nombre, apellido, password, ci, iddocente, idasignatura) VALUES(@nombre, @apellido, @password, @ci, @iddocente,@idasignatura)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", docente.Nombre);
                comando.Parameters.AddWithValue("@apellido", docente.Apellido);
                comando.Parameters.AddWithValue("@password", docente.Password);
                comando.Parameters.AddWithValue("@ci", docente.Ci);
                comando.Parameters.AddWithValue("@iddocente", docente.Id);
                comando.Parameters.AddWithValue("@idasignatura", docente.Asignatura.Idasignatura);
                codigo = comando.ExecuteNonQuery();
                mensaje = "Se ha registrado el docente correctamente.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se ha podido registrar el docente. " + ex.ToString();
            }
        }

        //Metodo para verificar si existe la contrasenia
        public bool ExistePassword(string pPassword)
        {
            //Metodo para ver si la contrasenia ya existe
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT ci FROM docentes WHERE password LIKE @password";
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

        //Metodo para actualizar los datos del docente
        public void ActualizarDatosDocente(String pNombre, string pApellido, string pCi, string pPassword, int pId,Asignatura pasig, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();

                MySqlCommand comando = new MySqlCommand("UPDATE docentes SET nombre = @nombre, apellido = @apellido, ci = @ci , password = @password, idasignatura=@idasignatura WHERE iddocente = @iddocente", conexionBD);
                comando.Parameters.AddWithValue("@iddocente", pId);
                comando.Parameters.AddWithValue("@nombre", pNombre);
                comando.Parameters.AddWithValue("@apellido", pApellido);
                comando.Parameters.AddWithValue("@ci", pCi);
                comando.Parameters.AddWithValue("@password", pPassword);
                comando.Parameters.AddWithValue("@idasignatura", pasig.Idasignatura);
                int ret = comando.ExecuteNonQuery();
                mensaje = "Se han actualizado correctamente los datos del docente.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se han podido actualizar los datos del alumno. " + ex.ToString();
            }
        }

        //Metodo para eliminar los datos del docente
        public static void EliminarDocente(int idDocente, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "DELETE FROM docentes WHERE iddocente= @iddocente";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@iddocente", idDocente);
                codigo = comando.ExecuteNonQuery();
                mensaje = "Se ha eliminado docente correctamente.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se ha podido eliminar docente. " + ex.ToString();
            }
        }


    }
}
