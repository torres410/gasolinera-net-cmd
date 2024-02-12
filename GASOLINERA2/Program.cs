using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GASOLINERA2
{
    class Program
    {
        static void Main(string[] args)
        {
            cFila cola = new cFila();
            int opcion = 1;
            string nom;
                        
            Console.WriteLine("                BIENVENIDO A GASOLINERA ''+GAS''");
            Console.WriteLine("*****************************************************************");
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            Console.WriteLine("¿Cuál bomba prefieres?" +                
                "\n1.- BOMBA 1: TRANSPORTE PESADO" +
                "\n2.- BOMBA 2: TRANSPORTE PESADO" +
                "\n3.- BOMBA 3: VEHÍCULOS LIVIANOS" +
                "\n4.- BOMBA 4: VEHÍCULOS LIVIANOS" +
                "\n5.- BOMBA 5: VEHÍCULOS LIVIANOS" +
                "\n6.- SALIR\n" );    

            String s1 = null;

            s1 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            switch (s1)
            {
                case "1":
                    Console.WriteLine(" ");
                    Console.WriteLine("Opción elegida --> BOMBA 1: TRANSPORTE PESADO");
                    Console.WriteLine("CLIENTES EN ESPERA:");
                    cola.Encolar("Enrique");
                    cola.Encolar("Gerardo");
                    break;
                case "2":
                    Console.WriteLine(" ");
                    Console.WriteLine("Opción elegida --> BOMBA 2: TRANSPORTE PESADO");
                    Console.WriteLine("CLIENTES EN ESPERA:");
                    cola.Encolar("Edgardo");
                    cola.Encolar("Ricardo");
                    break;
                case "3":
                    Console.WriteLine(" ");
                    Console.WriteLine("Opción elegida --> BOMBA 3: VEHÍCULOS LIVIANOS");
                    Console.WriteLine("CLIENTES EN ESPERA:");
                    cola.Encolar("Jennifer");
                    cola.Encolar("Alexandra");
                    break;
                case "4":
                    Console.WriteLine(" ");
                    Console.WriteLine("Opción elegida --> BOMBA 4: VEHÍCULOS LIVIANOS");
                    Console.WriteLine("CLIENTES EN ESPERA:");
                    cola.Encolar("Francisco");
                    cola.Encolar("Marcela");
                    break;
                case "5":
                    Console.WriteLine(" ");
                    Console.WriteLine("Opción elegida --> BOMBA 5: VEHÍCULOS LIVIANOS");
                    Console.WriteLine("CLIENTES EN ESPERA:");
                    cola.Encolar("Gabriela");
                    cola.Encolar("Vanessa");
                    break;
                case "6":
                    Console.WriteLine("Opción salir");
                    break;
            }
            Console.ReadLine();


            cola.transversa();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("********* MENÚ *********");
            Console.WriteLine("1. INGRESAR CLIENTE A LA COLA");
            Console.WriteLine("2. BUSCAR CLIENTE EN ESPERA");
            Console.WriteLine("3. ATENDER AL CLIENTE");
            Console.WriteLine("0. SALIR");

            while (opcion != 0)
            {
                Console.Write("OPCION: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Digite el nombre del cliente: ");
                    nom = Console.ReadLine();
                    cola.Encolar(nom);
                    Console.ForegroundColor = ConsoleColor.Green;
                    cola.transversa();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (opcion == 2)
                {
                    Console.Write("Digite el nombre del cliente: ");
                    nom = Console.ReadLine();
                    
                    if (cola.BuscarCliente(nom) == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0}, está en la cola", nom);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("{0}, no está en la cola", nom);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else if (opcion == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.WriteLine("El cliente {0} ya está siendo atendido", cola.Peek());
                    cola.Desencolar();

                    Console.WriteLine(" ");
                    Console.WriteLine("CLIENTES EN ESPERA:");

                    cola.transversa();
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("¡Gracias por su preferencia, lo esperamos pronto!");
            Console.ReadLine();
        }
    }
}
