using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite UN número y luego calcule y emita un cartel
            // aclaratorio si el mismo es primo o no es primo.
            // Nota: usando While. Ya lo hicimos con FOR, ahora con While.

            int numero;
            int divisor = 0;
            int contador = 0;
            const int cero = 0;
            const int dos = 2;

            Console.WriteLine("Por favor ingrese un numero para saber si es primo:");
            numero = int.Parse(Console.ReadLine());

            while (divisor != numero)
            {
                divisor++;
                if (numero % divisor == cero)
                {
                    contador++;
                }
            }

            if (contador == dos)
            {
                Console.WriteLine("Primo");
            }
            else
            {
                Console.WriteLine("No Primo");
            }


        }
    }
}
