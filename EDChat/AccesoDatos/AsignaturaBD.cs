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
    class AsignaturaBD
    {
        //Metodo para registrar una asignatura
        public static void RegistrarNuevaAsignatura(Asignatura asignatura, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "INSERT INTO asignatura (nombre, cantidadhoras) VALUES( @nombre, @cantidadhoras)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", asignatura.Nombre);
                comando.Parameters.AddWithValue("@cantidadhoras", asignatura.Canthoras);
                codigo = comando.ExecuteNonQuery();
                mensaje = "Se han registrado la asignatura correctamente.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se ha podido registrar la asignatura. " + ex.ToString();
            }
        }

        //Metodo para eliminar asignatura
        public static void EliminarAsignatura(int IdAsignatura, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "DELETE FROM asignatura WHERE idasignatura= @idasignatura";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idasignatura", IdAsignatura);
                codigo = comando.ExecuteNonQuery();
                mensaje = "Se ha eliminado la asignatura correctamente.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se ha podido eliminar la asignatura. " + ex.ToString();
            }
        }

        //Metodo para Listar asignaturas
        public ArrayList ListarAsignaturas()
        {
                ArrayList lista = new ArrayList();

                try
                {
                    MySqlConnection conexion = Conexion.getConexion();
                    conexion.Open();
                    MySqlDataReader reader;

                    string sql = "SELECT * FROM asignatura";
                    MySqlCommand comando = new MySqlCommand(sql, conexion);
                    reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        Asignatura asignatura = null;
                        asignatura = new Asignatura();
                        asignatura.Idasignatura = int.Parse(reader["Idasignatura"].ToString());
                        asignatura.Canthoras = int.Parse(reader["cantidadhoras"].ToString());
                        asignatura.Nombre = reader["nombre"].ToString();
                        lista.Add(asignatura);
                        
                    }

                    Conexion.closeConexion();

                }
                catch (MySqlException ex) { }

                return lista;
        }

        //Metodo para actulizar datos de la asignatura
        public void ActualizarDatos(String pNombre, int pCantHoras,int pId ,out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();

                MySqlCommand comando = new MySqlCommand("UPDATE asignatura SET nombre = @nombre, cantidadhoras = @cantidadhoras WHERE idasignatura = @idasignatura", conexionBD);
                comando.Parameters.AddWithValue("@idasignatura", pId);
                comando.Parameters.AddWithValue("@nombre", pNombre);
                comando.Parameters.AddWithValue("@cantidadhoras", pCantHoras);
                int ret = comando.ExecuteNonQuery();
                mensaje = "Se han actualizado correctamente los datos de la asignatura.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se han podido actualizar los datos de la asignatura. " + ex.ToString();
            }
        }

        //Metodo para buscar datos de la asignatura
        public static Asignatura BuscarAsignatura(int IdAsignatura)
        {
            try
            {
                Asignatura asignatura = new Asignatura();

                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "SELECT * FROM asignatura WHERE idasignatura= @idasignatura";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idasignatura", IdAsignatura);
                MySqlDataReader reader;
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    
                    asignatura.Idasignatura = int.Parse(reader["Idasignatura"].ToString());
                    asignatura.Canthoras = int.Parse(reader["cantidadhoras"].ToString());
                    asignatura.Nombre = reader["nombre"].ToString();
                }
                Conexion.closeConexion();
                return asignatura;
            }
            catch (MySqlException ex)
            {
                return null;
            }
        }

    }
}
