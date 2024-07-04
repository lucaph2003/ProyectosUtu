using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.AccesoDatos;

namespace EDChat.Logica
{
    class Control
    {
        //Metodo para el inicio de sesion sano
        public string ctrlLogin(string ci, string password)
        {
            //Metodo para el login, crea la session
            AdministradorBD administradorBD = new AdministradorBD();
            string respuesta = "";
            Administrador datosAdministrador = null;

            if (string.IsNullOrEmpty(ci) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosAdministrador = administradorBD.porCi(ci);

                if (datosAdministrador == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (datosAdministrador.Password != password)
                    {
                        respuesta = "El usuario o la contraseña no coinciden";
                    }
                    else
                    {
                        Session.id = datosAdministrador.Id;
                        Session.ci = ci;
                        Session.nombre = datosAdministrador.Nombre;
                        Session.apellido = datosAdministrador.Apellido;
                        Session.password = datosAdministrador.Password;
                        Session.fotoperfil = datosAdministrador.FotoPerfil;
                    }
                }
            }
            return respuesta;
        }
        public string ctrlRegistroDocente(Docente docentes)
        {
            //Metodo para verificar que la contrasenia no exista con todos los casos
            DocenteBD docenteBD = new DocenteBD();
            string respuesta = "";

            if (string.IsNullOrEmpty(docentes.Nombre) || string.IsNullOrEmpty(docentes.Apellido) || string.IsNullOrEmpty(docentes.Password) || string.IsNullOrEmpty(docentes.Ci))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (docentes.Password == docentes.Password)
                {
                    if (docenteBD.ExistePassword(docentes.Password))
                    {
                        respuesta = "Esta contraseña ya esta usada";
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }
            }
            return respuesta;
        }

        public string ctrlRegistroAlumno(Alumno alumnos)
        {
            //Metodo para verificar que la contrasenia no exista con todos los casos
            AlumnoBD alumnoBD = new AlumnoBD();
            string respuesta = "";

            if (string.IsNullOrEmpty(alumnos.Nombre) || string.IsNullOrEmpty(alumnos.Apellido) || string.IsNullOrEmpty(alumnos.Password) || string.IsNullOrEmpty(alumnos.Password) || string.IsNullOrEmpty(alumnos.Ci))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (alumnos.Password == alumnos.Password)
                {
                    if (alumnoBD.ExistePassword(alumnos.Password))
                    {
                        respuesta = "Esta contraseña ya esta usada";
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }
            }
            return respuesta;
        }


    }
}