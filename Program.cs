using System.Collections;
using System.Timers;

internal class Program
{
    private static void Main(string[] args)
    {
        bool Addmenu = true;
        while (Addmenu)
        {
            Console.WriteLine("Menu Principal");
            Console.WriteLine("1. Ingresa el valor n y reciba el numero Fibonacci correspondiente");
            Console.WriteLine("2. Verifica si es un numero Fibonacci o no");
            Console.WriteLine("3. Listado de numeros Fibonacci");
            Console.WriteLine("4. Salir");
            var option = Convert.ToString(Console.ReadLine());
            if (option == "1")
            {
                Console.WriteLine("Ingresa el valor n a buscar");
                var n = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                var Fibo = 0;
                ArrayList numerosfibo = new ArrayList();
                numerosfibo.Add(0);
                numerosfibo.Add(1);
                for (int i = 2; i <= n; i++)
                {
                    var Fn1 = Convert.ToInt32(numerosfibo[i - 1]);
                    var Fn2 = Convert.ToInt32(numerosfibo[i - 2]);
                    Fibo = Fn1 + Fn2;
                    numerosfibo.Add(Fibo);
                }
                Fibo = Convert.ToInt32(numerosfibo[numerosfibo.Count - 1]);
                Console.WriteLine($"El numero fibocciano es: {Fibo}");
                Console.ReadKey();
                Console.Clear();
            }
            if (option == "2")
            {
                Console.WriteLine("Ingresa el numero a buscar");
                var nbusqueda = Convert.ToInt32(Console.ReadLine());
                var n = nbusqueda;
                var Fibo = 0;
                ArrayList numerosfibo = new ArrayList();
                numerosfibo.Add(0);
                numerosfibo.Add(1);
                for (int i = 2; i <= n; i++)
                {
                    var Fn1 = Convert.ToInt32(numerosfibo[i - 1]);
                    var Fn2 = Convert.ToInt32(numerosfibo[i - 2]);
                    Fibo = Fn1 + Fn2;
                    numerosfibo.Add(Fibo);
                }
                Console.WriteLine(numerosfibo.Contains(nbusqueda) ? "El numero es Fibonacci" : "El numero no es Fibonacci");
                Console.ReadKey();
                Console.Clear();
            }
            if (option == "3")
            {
                Console.WriteLine("Ingresa el numero m deseado: ");
                var n = Convert.ToInt32(Console.ReadLine());
                var Fibo = 0;
                ArrayList numerosfibo = new ArrayList();
                numerosfibo.Add(0);
                numerosfibo.Add(1);
                for (int i = 2; i <= n; i++)
                {
                    var Fn1 = Convert.ToInt32(numerosfibo[i - 1]);
                    var Fn2 = Convert.ToInt32(numerosfibo[i - 2]);
                    Fibo = Fn1 + Fn2;
                    numerosfibo.Add(Fibo);
                    Console.WriteLine($"{Fibo}");
                }
                Console.ReadKey();
                Console.Clear();
            }
            if (option == "4")
            {
                Addmenu = false;
            }
        }
    }
}