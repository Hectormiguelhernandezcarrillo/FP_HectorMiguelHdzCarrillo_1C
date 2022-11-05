using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejemploclase_FP_HectorMiguel_1C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();

            //variables
            string nameUser, lastName, contactNumber, city, FBProfile, email;
            string user, password, passwordConfirm, codeAccess;
            byte age = 0;


            Console.WriteLine("ingresa tu nombre y al finalizar presiona ENTER");
            nameUser = Console.ReadLine();
            Console.WriteLine("ingresa tu apellido y al finalizar presiona ENTER");
            lastName = Console.ReadLine();
            Console.WriteLine("ingresa tu edad con digito y al finalizar presiona ENTER");
            age = Convert.ToByte(Console.ReadLine());

            //if
            if (age >= 18)
            {


                Console.WriteLine("completa tu registro para obtener tu codigo");
                Console.WriteLine("ingresa tu numnero de contacto");
                contactNumber = Console.ReadLine();
                Console.WriteLine("ingresa tu ciudad ");
                city = Console.ReadLine();
                Console.WriteLine("ingresa tu perfil de facebook");
                FBProfile = Console.ReadLine();
                Console.WriteLine("ingresa tu email");
                email = Console.ReadLine();
                Console.WriteLine("ingresa tu usuario ");
                user = Console.ReadLine();
                Console.WriteLine("ingresa tu contraseña ");
                password = Console.ReadLine();
                Console.WriteLine("cuelve a ingresar tu contraseña ");
                passwordConfirm = Console.ReadLine();

                if (password == passwordConfirm)
                {
                    Random rnd = new Random();
                    codeAccess = rnd.Next(1000, 9999).ToString();
                    Console.WriteLine("Codigo de acceso: {0}", codeAccess);
                }

            }

            else
            {
                Console.WriteLine("no eres mayor de edad, entonces no puedes entrar");
            }
            Console.WriteLine("saliendo del sistema.");
            Thread.Sleep(100);
            Console.WriteLine("saliendo del sistema..");
            Thread.Sleep(100);
            Console.WriteLine("saliendo del sistema...");
            Thread.Sleep(100);
            Console.WriteLine("saliendo del sistema....");
            Thread.Sleep(100);
            Console.ReadKey();

        }
    }
}
