using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.AccesoDatos;

namespace EDChat.Logica
{
    class Administrador
    {
        //Declaracion de atributos de un administrador
        int id;
        string nombre, apellido, password, ci;
        Image fotoperfil;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Password { get => password; set => password = value; }
        public string Ci { get => ci; set => ci = value; }
        public int Id { get => id; set => id = value; }
        public Image FotoPerfil {get => fotoperfil; set => fotoperfil = value; }


    //Metodo puente para actualizar los datos del administrador
        public static void actualizarDatos(Image pFotoPerfil, String pNombre, String pApellido, int pId, out int codigo, out String mensaje)
        {
            AdministradorBD administradorBD = new AdministradorBD();
            administradorBD.ActualizarDatos(pFotoPerfil, pNombre, pApellido, pId, out codigo, out mensaje);

            Session.nombre = pNombre;
            Session.apellido = pApellido;
            Session.id = pId;
            Session.fotoperfil = pFotoPerfil;

        }

        //Metodo para actualizar password del administrador
        public static void actualizarPassword(string pOldPassword, string pConPassword, string pPassword, int pId, out int codigo, out String mensaje)
        {
            if (pOldPassword == Session.password)
            {
                if (pPassword == pConPassword)
                {
                    AdministradorBD administradorBD = new AdministradorBD();
                    administradorBD.ActualizarPassword(pPassword, pId, out codigo, out mensaje);

                    Session.password = pPassword;
                    Session.id = pId;
                }
                else
                {
                    codigo = -1;
                    mensaje = "Sus contrasenias no coinciden.";
                }

            }
            else
            {
                codigo = -1;
                mensaje = "Su contrasenia actual esta mal.";
            }
        }
        
    }  
}
