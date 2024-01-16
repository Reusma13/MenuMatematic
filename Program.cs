using System;
using Internal;

namespace MenuMatematic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MostrarMenu();
        }

        static void MostrarMenu()
        {
            int num, numero1, numero2;
            Console.WriteLine("Escriu un numero del menu: ");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                CrearMenu();
                switch (num)
                {
                    case 0:
                        Salir(num);
                        break;
                    case 1:
                        Console.WriteLine("Digam el valor del primer numero: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digam el valor del segon numero: ");
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Maxima(ref numero1, ref numero2));
                        break;
                    case 2:
                        Console.WriteLine("Digam el valor del primer numero: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digam el valor del segon numero: ");
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Mcd(numero1, numero2));
                        break;
                    case 3:
                        Console.WriteLine("Digam el valor del primer numero: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digam el valor del segon numero: ");
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Mcm(numero1, numero2));
                        break;
                    case 4:
                        Console.WriteLine("Introdueix un numero: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Factorial(numero1));
                        break;
                    case 5:
                        Console.WriteLine("Digam el valor del primer numero: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digam el valor del segon numero: ");
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Combinatori(numero1, numero2));
                        break;
                    case 6:
                        Console.WriteLine("Introdueix un numero: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(DivisioMajor(numero1));
                        break;
                    case 7:
                        Console.WriteLine("Introdueix un numero: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(EsPrimer(numero1));
                        break;
                    case 8:
                        Console.WriteLine("Introdueix un numero: ");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(NPrimersPrimers(numero1));
                        break;
                    default:
                        Console.WriteLine("Opcio no valida");
                        break;
                }
            } while (num != 0);

        }
        static void Salir(int num)
        {

        }
        static bool Maxima(ref int numero1, ref int numero2)
        {
            bool maxim = true;
            if (numero1 < numero2)
            {
                maxim = false;
                int temp = numero1;
                numero1 = numero2;
                numero2 = temp;
            }
            return maxim;
        }
        static int Mcd(int numero1, int numero2)
        {
            int maxDivisor = 1, cont = 1;
            while (cont <= numero1 && cont <= numero2)
            {
                if (numero1 % cont == 0 && numero2 % cont == 0)
                {
                    maxDivisor = cont;
                }
                cont++;
            }
            return maxDivisor;
        }
        static int Mcm(int numero1, int numero2)
        {
            int mcm = 1, cont;
            cont = numero1 * numero2;
            while (cont > numero1 && cont > numero2)
            {
                if (cont % numero1 == 0 && cont % numero2 == 0)
                {
                    mcm = cont;
                }
                cont--;
            }
            return mcm;
        }
        static int Factorial(int num)
        {
            int res = 1;
            for (int i = 1; i <= num; i++)
            {
                res *= i;
            }
            return res;
        }
        static int Combinatori(int n, int m)
        {
            return Factorial(n) / (Factorial(m) * Factorial(n - m));
        }
        static int DivisioMajor(int num)
        {
            int divisorMayor = 1;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    divisorMayor = i;
                }
            }
            return divisorMayor;
        }
        static bool EsPrimer(int numero)
        {
            bool primer = false;
            int cont = 1, resultat = 0;
            while (cont <= numero)
            {
                if (numero % cont == 0)
                {
                    Console.WriteLine("El residu es 0. ");
                    resultat++;
                }
                cont++;
            }

            if (resultat < 2)
            {
                primer = true;
            }
            return primer;
        }
        static string NPrimersPrimers(int primers)
        {
            int n = 1, a, j, i = 1;
            string primersprimers = "";
            while (n < primers)
            {
                a = 0;
                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        a++;
                    }
                }
                if (a == 2)
                {
                    n++;
                    primersprimers += i + " ";
                }
                i++;
            }
            return primersprimers;
        }
        static void TornarMenu()
        {
            int i = 5;
            while (i != 0)
            {
                Console.Write("\r");
                Console.WriteLine($"Tornant al menu: {i}'s");
                Thread.Sleep(1000);
                i--;
            }
            MostrarMenu();
        }
        static string CrearMenu()
        {
            string Text =
                "--------------------------------------------------------"
                "--------------------------------------------------------"
        }
        static void FlechasMenu()
        {
            string[] menuItems = {
            "Maxim",
            "Mcd",
            "Mcm",
            "Factorial",
            "Combinatori",
            "MostrarDivisorMajor",
            "EsPrimer",
            "NPrimersPrimers",
            "Salir"
        };

            int currentIndex = 0;

            while (true)
            {
                Console.Clear();

                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == currentIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine(menuItems[i]);

                    Console.ResetColor();
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    currentIndex = (currentIndex == 0) ? menuItems.Length - 1 : currentIndex - 1;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    currentIndex = (currentIndex == menuItems.Length - 1) ? 0 : currentIndex + 1;
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    switch (currentIndex)
                    {
                        case 0:
                            Console.WriteLine("Digam el valor del primer numero: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digam el valor del segon numero: ");
                            numero2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Maxima(ref numero1, ref numero2));
                            break;
                        case 1:
                            Console.WriteLine("Digam el valor del primer numero: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digam el valor del segon numero: ");
                            numero2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Mcd(numero1, numero2));
                            break;
                        case 2:
                            Console.WriteLine("Digam el valor del primer numero: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digam el valor del segon numero: ");
                            numero2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Mcm(numero1, numero2));
                            break;
                        case 3:
                            Console.WriteLine("Introdueix un numero: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Factorial(numero1));
                            break;
                        case 4:
                            Console.WriteLine("Digam el valor del primer numero: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digam el valor del segon numero: ");
                            numero2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(Combinatori(numero1, numero2));
                            break;
                        case 5:
                            Console.WriteLine("Introdueix un numero: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(DivisioMajor(numero1));
                            break;
                        case 6:
                            Console.WriteLine("Introdueix un numero: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(EsPrimer(numero1));
                            break;
                        case 7:
                            Console.WriteLine("Introdueix un numero: ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(NPrimersPrimers(numero1));
                            break;
                        case 8:
                            Salir(num);
                            break;
                    }
                }
            }


        }
    }