namespace MenuMatematic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num; 
            Console.WriteLine("Escriu un numero del menu: ");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Salir(num);
                    break;
                case 1:
                    Maxima(num);
                    break;
                case 2:
                    Mcd(num);
                    break;
                case 3:
                    Mcm(num);
                    break;
                case 4:
                    Factorial(num);
                    break;
                case 5:
                    Factorial(num);
                    break;
                case 6:
                    DivisioMajor(num);
                    break;
                case 7:
                    EsPrimer(num);
                    break;
                case 8:
                    NPrimersPrimers(num);
                    break;
                default:
                    Console.WriteLine("Opcio no valida");
                    break;
            }
        }
        static void Salir(int num)
        {

        }
        static void Maxima (int num)
        {

        }
        static void Mcd(int num)
        {
            int numero1, numero2, maxDivisor = 1, cont = 1;
            Console.WriteLine("Digam el valor del primer numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digam el valor del segon numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            while (cont <= numero1 && cont <= numero2)
            {
                if (numero1 % cont == 0 && numero2 % cont == 0)
                {
                    maxDivisor = cont;
                }
                cont++;
            }
            Console.WriteLine($"El MCD de {numero1} i {numero2} es de: {maxDivisor}");
        }
        static void Mcm(int num)
        {
            int numero1, numero2, mcm = 1, cont;
            Console.WriteLine("Digam el valor del primer numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digam el valor del segon numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            cont = numero1 * numero2;
            while (cont > numero1 && cont > numero2)
            {
                if (cont % numero1 == 0 && cont % numero2 == 0)
                {
                    mcm = cont;
                }
                cont--;
            }
            Console.WriteLine($"El MCM es de: {mcm}");
        }
        static void Factorial(int num)
        {
            int n, m, factorialN = 1, resultat = 0, contN = 1, contM = 1, contNM = 1, factorialM = 1, factoralNM = 1;
            Console.WriteLine("Digam el valor de numero 1: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digam el valor de numero 2: ");
            m = Convert.ToInt32(Console.ReadLine());
            if (n >= m)
            {
                for (int i = 1; i < n; i++)
                {
                    factorialN = factorialN * i;
                }
                for (int i = 1; i < m; i++)
                {
                    factorialM = factorialM * i;
                }
                for (int i = 1; i < (n - m); i++)
                {
                    factoralNM = factoralNM * i;
                }
            }
            resultat = factorialN / (factorialM * factoralNM);
            Console.WriteLine($"El resultat de {n}! / {m}! * ({n} - {m})! es: {resultat}");
            if (num == 5)
                return
        }
        static void Combinatori(int num)
        {
            Factorial(num);
            int resultat = Factorial(n) / (factorialM * factorialNM);
        }
        static void DivisioMajor(int num)
        {

        }
        static void EsPrimer (int num)
        {
            int numero, cont = 1, resultat = 0;
            Console.WriteLine("Posa un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            while (cont <= numero)
            {
                if (numero % cont == 0)
                {
                    Console.WriteLine("El residu es 0. ");
                    resultat++;
                }
                cont++;
            }
            if (resultat > 2)
            {
                Console.WriteLine("El numero no es primer");
            }
            else
            {
                Console.WriteLine("El numero es primer");
            }
        }
        static void NPrimersPrimers(int num)
        {
            int n = 1, primers, a, j, i = 1;

            Console.WriteLine("Escriu un numero: ");
            primers = Convert.ToInt32(Console.ReadLine());

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
                    Console.WriteLine("" + i + "");
                }
                i++;
            }
        }
    }
}