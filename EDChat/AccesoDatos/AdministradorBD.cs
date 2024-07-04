using MySqlConnector;
using System;
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
    class AdministradorBD
    {

        //Metodo para registrar por ci 
        public Administrador porCi(string ciIngresado)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT * FROM administrador WHERE ci = @ci";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@ci", ciIngresado);

            reader = comando.ExecuteReader();

            Administrador usuario = null;

            while (reader.Read())
            {
                usuario = new Administrador();
                usuario.Id = int.Parse(reader["idadmin"].ToString());
                usuario.Password = reader["password"].ToString();
                usuario.Nombre = reader["nombre"].ToString();
                usuario.Apellido = reader["apellido"].ToString();

                if (!Convert.IsDBNull(reader["fotoperfil"]))
                {
                    byte[] aByte = (byte[])reader["fotoperfil"];
                    MemoryStream ms = new MemoryStream(aByte);
                    usuario.FotoPerfil = Image.FromStream(ms);
                }

            }
            Conexion.closeConexion();
            return usuario;
        }

        //Metodo para actualizar Datos del administrador
        public void ActualizarDatos(Image pFotoPerfil, String pNombre, String pApellido, int pId, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MemoryStream ms = new MemoryStream();
                pFotoPerfil.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();

                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();

                MySqlCommand comando = new MySqlCommand("UPDATE administrador SET nombre = @nombre, apellido = @apellido,  fotoperfil = @fotoperfil WHERE idadmin = @idadmin", conexionBD);
                comando.Parameters.AddWithValue("@nombre", pNombre);
                comando.Parameters.AddWithValue("@apellido", pApellido);
                comando.Parameters.AddWithValue("@fotoperfil", aByte);
                comando.Parameters.AddWithValue("@idadmin", pId);
                int ret = comando.ExecuteNonQuery();
                mensaje = "Se han actualizado correctamente los datos de perfil.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se han podido actualizar los datos de perfil. " + ex.ToString();
            }
        }

        //Metodo para actualizar password del administrador
        public void ActualizarPassword(string pPassword, int pId, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();

                MySqlCommand comando = new MySqlCommand("UPDATE administrador SET password = @password WHERE idadmin = @idadmin", conexionBD);
                comando.Parameters.AddWithValue("@password", pPassword);
                comando.Parameters.AddWithValue("@idadmin", pId);
                int ret = comando.ExecuteNonQuery();
                mensaje = "Se han actualizado correctamente los datos de perfil.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se han podido actualizar los datos de perfil. " + ex.ToString();
            }
        }

        public static Administrador porId(int pId)
        {
            //Metodo para registrar por dni si no existe
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT * FROM administrador WHERE idadmin = @idadmin";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idadmin", pId);

            reader = comando.ExecuteReader();

            Administrador usuario = null;

            while (reader.Read())
            {
                usuario = new Administrador();
                usuario.Id = int.Parse(reader["idadmin"].ToString());
                usuario.Password = reader["password"].ToString();
                usuario.Nombre = reader["nombre"].ToString();
                usuario.Apellido = reader["apellido"].ToString();
            }
            Conexion.closeConexion();
            return usuario;
        }

    }
}
