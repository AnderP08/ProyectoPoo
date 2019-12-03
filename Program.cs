using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 1;

            string Usuario = "123"; string IngUsu;
            string Clave = "123";     string contraseña;
            
            Console.WriteLine("- - -BIENVENIDO A LIFEHOT- - -");
            do
            {
                Console.Write("\nIngrese nombre de usuario: ");
                IngUsu = Console.ReadLine();
                Console.Write("Ingrese contraseña: ");
                contraseña = Console.ReadLine();
                if (Usuario == IngUsu && Clave == contraseña)
                {
                    Console.WriteLine("Bienvenido");
                    OpcionesMenu opcionesMenu = new OpcionesMenu();
                    opcionesMenu.LisOpciones();
                    intentos = 4;
                }
                else
                {
                    Console.WriteLine("Clave erronea");
                    intentos++;
                }
                
            } while (intentos != 4);
            Console.ReadKey();
        }
    }
}
