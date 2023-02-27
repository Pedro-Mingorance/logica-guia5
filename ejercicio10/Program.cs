using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite una lista de números que corta cuando se
            // ingresa un cero y luego emitir por pantalla el máximo de los números
            // negativos y el mínimo de los números positivos.

            bool negativos = false;
            bool positivos = false;
            int maximonegativo = 0;
            int minimopositivo = 0;
            int numero;

            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if (numero > 0)
                {
                    if (!positivos)
                    {
                        minimopositivo = numero;
                        positivos = true;
                    }
                    else if (numero < minimopositivo)
                    {
                        minimopositivo = numero;
                    }
                }
                else if (!negativos)
                {
                    maximonegativo = numero;
                    negativos = true;
                }
                else if (numero > maximonegativo)
                {
                    maximonegativo = numero;
                }

                Console.WriteLine("Ingrese un numero:");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El maximo numero negativo es: " + maximonegativo);
            Console.WriteLine("El minimo numero positivo es: " + minimopositivo);
        }
    }
}
