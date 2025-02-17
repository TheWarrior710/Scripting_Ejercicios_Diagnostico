namespace Actividad2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Números primos en la serie de Fibonacci hasta el término 15:");
            ImprimirPrimosDeFibonacci(15);

            Console.WriteLine("\nConversión de segundos a formato HH:MM:SS:");
            int segundos = 3671;
            string resultado = ConvertirSegundosAFormato(segundos);
            Console.WriteLine($"{segundos} segundos equivalen a: {resultado}");
        }

        static void ImprimirPrimosDeFibonacci(int n)
        {
            List<int> fibonacci = GenerarFibonacci(n);

            foreach (int numero in fibonacci)
            {
                if (EsPrimo(numero))
                {
                    Console.WriteLine(numero);
                }
            }
        }

        static List<int> GenerarFibonacci(int n)
        {
            List<int> fibonacci = new List<int>();
            if (n > 0) fibonacci.Add(0);
            if (n > 1) fibonacci.Add(1);

            for (int i = 2; i < n; i++)
            {
                int siguiente = fibonacci[i - 1] + fibonacci[i - 2];
                fibonacci.Add(siguiente);
            }

            return fibonacci;
        }

        static bool EsPrimo(int numero)
        {
            if (numero < 2) return false;

            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0) return false;
            }

            return true;
        }

        static string ConvertirSegundosAFormato(int segundos)
        {
            int horas = segundos / 3600;
            int minutos = (segundos % 3600) / 60;
            int segundosRestantes = segundos % 60;

            return horas.ToString("D2") + ":" + minutos.ToString("D2") + ":" + segundosRestantes.ToString("D2");




        }
    }
}
