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
    class OrientacionBD
    {
        //Metodo para registrar orientacion
        public static Orientacion RegistrarOrientacion(Orientacion orientacion, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            Orientacion ultima = null;
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "INSERT INTO orientaciones (nombre) VALUES(@nombre)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", orientacion.Nombre);
                codigo = comando.ExecuteNonQuery();
                
                ultima = ObtenerUltimaOrientacion();
                
                mensaje = "Se ha registrado la orientacion correctamente.";
            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se ha podido registrar la orientacion. " + ex.ToString();
            }
            return ultima;
        }

        //Metodo para registrar asignaturas en orientaciones
        public static void RegistrarAsignaturaOrientacion(Orientacion orientacion, Asignatura asignatura, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "INSERT INTO asignaturas_orientacion (idasignatura,idorientaciones) VALUES(@idasignatura,@idorientaciones)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idasignatura", asignatura.Idasignatura);
                comando.Parameters.AddWithValue("@idorientaciones", orientacion.Id);
                codigo = comando.ExecuteNonQuery();
                mensaje = "Se han registrado las asignaturas en la orientacion correctamente.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se han podido registrar las asignaturas en la orientacion. " + ex.ToString();
            }
        }

        //Metodo para eliminar orientaciones
        public static void EliminarOrientacion(int idOrientacion, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "DELETE FROM orientaciones WHERE idorientaciones= @idorientaciones";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idorientaciones", idOrientacion);
                codigo = comando.ExecuteNonQuery();
                mensaje = "Se ha eliminado la orientacion correctamente.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se ha podido eliminar la orientacion. " + ex.ToString();
            }
        }

        //Metodo para Listar Orientaciones
        public ArrayList ListarOrientaciones()
        {
            ArrayList lista = new ArrayList();

            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();
                MySqlDataReader reader;

                string sql = "SELECT * FROM orientaciones";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Orientacion orientacion = null;
                    orientacion = new Orientacion();
                    orientacion.Id = int.Parse(reader["idorientaciones"].ToString());
                    orientacion.Nombre = reader["nombre"].ToString();
                    lista.Add(orientacion);
                }

                Conexion.closeConexion();

            }
            catch (MySqlException ex) { }

            return lista;
        }

        //Metodo para buscar las orientaciones
        public static Orientacion BuscarOrientacion(int IdOrientacion)
        {
            try
            {
                Orientacion orientacion = new Orientacion();

                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "SELECT * FROM orientaciones WHERE idorientacion= @idorientacion";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idorientacion", IdOrientacion);
                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    orientacion.Id = int.Parse(reader["idgrupo"].ToString());
                    orientacion.Nombre = reader["nombre"].ToString();
                }
                Conexion.closeConexion();
                return orientacion;
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }

        //Metodo para obtener la ultima orientacion
        public static Orientacion ObtenerUltimaOrientacion()
        {
            Orientacion orientacion = null;

            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();
                MySqlDataReader reader;

                string sql = "SELECT* FROM orientaciones order by idorientaciones desc limit 1";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    orientacion = new Orientacion();
                    orientacion.Id = int.Parse(reader["idorientaciones"].ToString());
                    orientacion.Nombre = reader["nombre"].ToString();
                }

                Conexion.closeConexion();

            }
            catch (MySqlException ex) { }

            return orientacion;
        }

    }
}
