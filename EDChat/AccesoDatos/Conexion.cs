using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDChat.AccesoDatos
{
    class Conexion
    {
        public static string database { get; private set; }

        //Metodo para obtener conexion a la base de datos
        public static MySqlConnection getConexion()

        {

            string servidor = "192.168.1.16";
            string puerto = "3306";
            string usuario = "lpodesta22";
            string password = "password";
            string bd = "proyecto";

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + "; database=" + bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;
        }

        //Metodo para abrir la conexion a la base de datos
        public static void openConexion()
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
        }

        //Metodo para cerrar la conexion a la base de datos
        public static void closeConexion()
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Close();
        }
    }
}
