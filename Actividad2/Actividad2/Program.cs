namespace Actividad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso de la función que imprime los números primos de Fibonacci
            Console.WriteLine("Números primos en la serie de Fibonacci hasta el término 15:");
            ImprimirPrimosDeFibonacci(15);

            // Ejemplo de uso de la función que convierte segundos a formato HH:MM:SS
            Console.WriteLine("\nConversión de segundos a formato HH:MM:SS:");
            int segundos = 3671; // Por ejemplo, 3671 segundos
            string resultado = ConvertirSegundosAFormato(segundos);
            Console.WriteLine($"{segundos} segundos equivalen a: {resultado}");
        }

        // Función que imprime los números primos en la serie de Fibonacci hasta el n-ésimo término
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

        // Función auxiliar para generar la serie de Fibonacci hasta el n-ésimo término
        static List<int> GenerarFibonacci(int n)
        {
            List<int> fibonacci = new List<int> { 0, 1 };

            for (int i = 2; i < n; i++)
            {
                int siguiente = fibonacci[i - 1] + fibonacci[i - 2];
                fibonacci.Add(siguiente);
            }

            return fibonacci;
        }

        // Función auxiliar para verificar si un número es primo
        static bool EsPrimo(int numero)
        {
            if (numero < 2) return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }

            return true;
        }

        // Función que convierte segundos a formato HH:MM:SS
        static string ConvertirSegundosAFormato(int segundos)
        {
            int horas = segundos / 3600; // Una hora tiene 3600 segundos
            segundos %= 3600; // Restamos las horas completas

            int minutos = segundos / 60; // Un minuto tiene 60 segundos
            segundos %= 60; // Restamos los minutos completos

            // Formateamos el resultado como HH:MM:SS
            return $"{horas:D2}:{minutos:D2}:{segundos:D2}";
        }
    }
}
