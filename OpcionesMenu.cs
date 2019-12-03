using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuProyecto
{
    public class OpcionesMenu
    {
        public void LisOpciones()
        {
            Console.Clear();

            int opcion;
            do{
                Console.WriteLine("MENU DE OPCIONES" +
                    "\n\n [1] Perfil" +
                    "\n [2] Amigos" +
                    "\n [3] Buscar Amigos" +
                    "\n [0] Salir");
                Console.Write("\nIngrese opcion: "); opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 0:
                        Console.WriteLine("\nSesión cerrada exitosamente");
                        break;

                    default:
                        Console.WriteLine("Caracter incorrecto, intentalo de nuevo");
                        break;
                }
            } while (opcion !=0);
        }
    }
}
