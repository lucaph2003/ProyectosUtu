using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDChat.UI
{
    class Atajos
    {
        //Metodo para dejar de ver el texto de los txtbox cuando ponemos el mouse
        public static void EnterDatos(TextBox x, string dato)
        {
            if (x.Text == dato)
            {
                x.Text = "";
                x.ForeColor = Color.Black;
            }
            if (x.Name == "txtPassword")
            {
                x.UseSystemPasswordChar = true;
            }
            if (x.Name == "txtConPassword")
            {
                x.UseSystemPasswordChar = true;
            }
        }
        

        //Metodo para ver nuevamente el texto al retirar el mouse
        public static void LeaveDatos(TextBox x, string dato)
        {
            if (x.Text == "")
            {
                x.Text = dato;
                x.ForeColor = Color.Black;

                if (x.Name == "txtPassword")
                {
                    x.UseSystemPasswordChar = false;
                }
                if (x.Name == "txtConPassword")
                {
                    x.UseSystemPasswordChar = false;
                }
            }
        }

    }
}
