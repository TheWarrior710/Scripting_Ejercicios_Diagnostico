namespace ActividadesScripting
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                Console.WriteLine("--- Bienvenido al Baloto ---");

                // Solicitar el número ganador
                Console.Write("Ingrese el número ganador (4 dígitos): ");
                string numeroGanador = Console.ReadLine();

                // Validar que el número ganador tiene 4 dígitos
                if (numeroGanador.Length != 4 || !int.TryParse(numeroGanador, out _))
                {
                    Console.WriteLine("El número ganador debe ser un valor de 4 dígitos.");
                    return;
                }

                // Solicitar el número del jugador
                Console.Write("Ingrese su número (4 dígitos): ");
                string numeroJugador = Console.ReadLine();

                // Validar que el número del jugador tiene 4 dígitos
                if (numeroJugador.Length != 4 || !int.TryParse(numeroJugador, out _))
                {
                    Console.WriteLine("Su número debe ser un valor de 4 dígitos.");
                    return;
                }

                // Solicitar el monto apostado
                Console.Write("Ingrese el monto apostado: $ ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal montoApostado) || montoApostado <= 0)
                {
                    Console.WriteLine("El monto apostado debe ser un número positivo.");
                    return;
                }

                // Determinar el premio
                decimal premio = CalcularPremio(numeroGanador, numeroJugador, montoApostado);

                // Mostrar el resultado
                if (premio > 0)
                {
                    Console.WriteLine($"¡Felicidades! Ha ganado un premio de: $ {premio:F2}");
                }
                else
                {
                    Console.WriteLine("Lo sentimos, no ha ganado ningún premio.");
                }
            }

            static decimal CalcularPremio(string numeroGanador, string numeroJugador, decimal montoApostado)
            {
                // Caso 1: Número exacto en el mismo orden
                if (numeroGanador == numeroJugador)
                {
                    return montoApostado * 4500;
                }

                // Caso 2: Número exacto en cualquier orden
                if (EsNumeroEnDesorden(numeroGanador, numeroJugador))
                {
                    return montoApostado * 200;
                }

                // Caso 3: Últimas 3 cifras en orden
                if (numeroGanador.Substring(1) == numeroJugador.Substring(1))
                {
                    return montoApostado * 400;
                }

                // Caso 4: Últimas 2 cifras en orden
                if (numeroGanador.Substring(2) == numeroJugador.Substring(2))
                {
                    return montoApostado * 50;
                }

                // Caso 5: Última cifra en orden
                if (numeroGanador[^1] == numeroJugador[^1])
                {
                    return montoApostado * 5;
                }

                // No hay premio
                return 0;
            }

            static bool EsNumeroEnDesorden(string numeroGanador, string numeroJugador)
            {
                // Convertir ambos números a arreglos de caracteres y ordenarlos
                char[] ganadorArray = numeroGanador.ToCharArray();
                char[] jugadorArray = numeroJugador.ToCharArray();
                Array.Sort(ganadorArray);
                Array.Sort(jugadorArray);

                // Comparar los arreglos ordenados
                return new string(ganadorArray) == new string(jugadorArray);
            }
        
    }
}