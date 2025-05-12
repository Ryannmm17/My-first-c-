using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_Progra1_Ryan
{
    internal class Menú
    {
        public void menu()
        {

            int Salir = 0, cantidad = 0, precioleche = 1300;
            string[] asociados = null;
            string asociado;
            while (Salir != 5)
            {
                Console.Clear();
                Console.WriteLine("o————————————————————————————————————-—o");
                Console.WriteLine("│ Elija una de las siguientes opciones │");
                Console.WriteLine("│ 1. Afiliación.                       │");
                Console.WriteLine("│ 2. Asociados.                        │");
                Console.WriteLine("│ 3. Ganado.                           │");
                Console.WriteLine("│ 4. Calculadora.                      │");
                Console.WriteLine("│ 5. Salir.                            │");
                Console.WriteLine("o——————————————————————————————————————o");
                Salir = int.Parse(Console.ReadLine());
                switch (Salir)
                {
                    // Aquí va afiliación
                    case 1:
                        Console.Write("Ingrese la cantidad de asociados que desea ingresar: ");
                        cantidad = int.Parse(Console.ReadLine());

                        asociados = new string[cantidad];

                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.Write($"Ingrese el nombre del asociado {i + 1}: ");
                            asociado = Console.ReadLine();

                            asociados[i] = asociado;

                        }
                        Console.WriteLine("Los asociados fueron ingresados al sistema correctamente");

                        break;
                    // Aquí va Asociados
                    case 2:
                        Console.WriteLine("Los asociados ingresados son:");
                        if (asociados != null)
                        {
                            for (int i = 0; i < asociados.Length; i++)
                            {
                                Console.WriteLine(asociados[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se han ingresado asociados aún.");
                        }
                        break;
                    // Aquí va Ganado
                    case 3:
                        Console.Clear();
                        string[] ganado = { "Vacuno", "Caprino", "Ovino", "Bufalino" };
                        for (int i = 0; i < ganado.Length; i++)
                            Console.WriteLine(ganado[i]);
                        break;
                    // Aquí va Calculadora
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre del asociado");
                        string asociadobuscar = Console.ReadLine();


                        for (int i = 0; i < asociados.Length; i++)
                        {
                            if (asociados[i].Equals(asociadobuscar))
                            {

                                int cantidadleche = 0;
                                Console.WriteLine("Ingrese la fecha de recolección de la leche");
                                string fechaleche = Console.ReadLine();
                                Console.WriteLine("Ingrese la cantidad de leche extraída");
                                cantidadleche = int.Parse(Console.ReadLine());

                                double pagar = cantidadleche * precioleche;
                                double pagarr = pagar;
                                double galon = 3.785;
                                double galones = cantidadleche / galon;
                                double aumento = 0;
                                double total = pagar + aumento;

                                if (pagar <= 5000)
                                {
                                    aumento = pagarr * 0.20;

                                }
                                else if (pagar >= 5000 && pagar <= 10000)
                                {
                                    aumento = pagarr * 0.15;
                                }
                                else if (pagar >= 10000)
                                {
                                    aumento = 0;

                                }
                                Console.Clear();
                                Console.WriteLine("o————————————————————————————————————-—o");
                                Console.WriteLine("|        PRODUCTORES DE LECHE          |");
                                Console.WriteLine(" Asociado:" + asociadobuscar);
                                Console.WriteLine(" Galones:" + galones);
                                Console.WriteLine(" Litros:" + cantidadleche);
                                Console.WriteLine(" Entrega:" + fechaleche);
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine(" Pago:" + pagar);
                                Console.WriteLine(" Aumento:" + aumento);
                                Console.WriteLine(" Total:" + (pagar + aumento));
                                Console.WriteLine("|        ESTAMOS PARA SERVIRLE         |");
                                Console.WriteLine("o——————————————————————————————————————o");
                            }
                            else
                            {
                                Console.WriteLine("No se encontró el asociado");
                            }

                        }
                        break;
                    // Aquí va salir
                    case 5:
                        Console.WriteLine("Saliendo. . .");
                        Salir = 5;
                        break;
                    default:
                        Console.WriteLine("o————---————————————————————————————————-—o");
                        Console.WriteLine("│Por favor, ingresar un número del 1 al 5.│");
                        Console.WriteLine("o—---———————————————————————————————————-—o");
                        break;


                }
                Console.ReadKey();
            }
        }
    }
}
