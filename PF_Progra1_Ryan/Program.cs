using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_Progra1_Ryan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menú program = new Menú();
            string usuario1 = "UPI23";
            string usuario2 = "PRO23";
            string contraseña1 = "Chr0mE%";
            string contraseña2 = "1nt3rN3T%";
            int intentos = 1;

            Console.WriteLine("Inicio de sesión");

            while (intentos <= 2)
            {
                Console.Write("Ingrese el nombre de usuario: ");
                string usuario = Console.ReadLine();

                Console.Write("Ingrese la contraseña: ");
                string insertarContraseña = Console.ReadLine();

                if (usuario == usuario1 && insertarContraseña == contraseña1)
                {
                    Console.WriteLine("Inicio de sesión exitoso.");
                    program.menu();
                    intentos = 3;

                }
                else if (usuario == usuario2 && insertarContraseña == contraseña2)
                {
                    Console.WriteLine("Inicio de sesión exitoso.");
                    program.menu();
                    intentos = 3;

                }
                else
                {
                    Console.WriteLine("Usuario o contraseña incorrecto, intento " + intentos + " de 2");
                    intentos = intentos + 1;
                }

                Console.ReadKey();

            }

        }
    }
}





