namespace ActividadesScripting
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("--- Bienvenido al Sorteo ---");

            Console.Write("Ingrese el número ganador (4 dígitos): ");
            string numeroGanador = Console.ReadLine();

            
            if (numeroGanador.Length != 4 || !int.TryParse(numeroGanador, out _))
            {
                Console.WriteLine("Error: El número ganador debe tener 4 dígitos y ser un número.");
                return;
            }

         
            Console.Write("Ingrese su número (4 dígitos): ");
            string numeroJugador = Console.ReadLine();

           
            if (numeroJugador.Length != 4 || !int.TryParse(numeroJugador, out _))
            {
                Console.WriteLine("Error: Su número debe tener 4 dígitos y ser un número.");
                return;
            }

       
            Console.Write("Ingrese el monto apostado: $ ");
            string montoTexto = Console.ReadLine();
            decimal montoApostado;
            if (!decimal.TryParse(montoTexto, out montoApostado) || montoApostado <= 0)
            {
                Console.WriteLine("Error: El monto apostado debe ser un número positivo.");
                return;
            }

            decimal premio = 0;

        
            if (numeroGanador == numeroJugador)
            {
                premio = montoApostado * 4500;
            }
            else
            {
                char[] ganadorArray = numeroGanador.ToCharArray();
                char[] jugadorArray = numeroJugador.ToCharArray();
                Array.Sort(ganadorArray);
                Array.Sort(jugadorArray);

                if (new string(ganadorArray) == new string(jugadorArray))
                {
                    premio = montoApostado * 200;
                }
                else if (numeroGanador.Substring(1) == numeroJugador.Substring(1))
                {
                    premio = montoApostado * 400;
                }
                else if (numeroGanador.Substring(2) == numeroJugador.Substring(2))
                {
                    premio = montoApostado * 50;
                }
                else if (numeroGanador[3] == numeroJugador[3])
                {
                    premio = montoApostado * 5;
                }
            }


            if (premio > 0)
            {
                Console.WriteLine($"¡Felicidades! Ha ganado un premio de: $ {premio:F2}");
            }
            else
            {
                Console.WriteLine("Lo sentimos, no ha ganado ningún premio.");

            }

        }


    }
}