using System;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar una lista de números que corta cuando se
            // ingresa un cero y luego mostrar: la cantidad de números primos, la cantidad de
            // números pares, la cantidad de positivos y la cantidad de negativos.

            int primos = 0;
            int pares = 0;
            int positivos = 0;
            int negativos = 0;
            int divisorpares = 2;
            int numero;


            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if (numero % divisorpares == 0)
                {
                    pares++;
                }

                if (numero > 0)
                {
                    positivos++;
                }
                else
                {
                    negativos++;
                }

                int divisorprimos = 0;
                int restoprimos = 0;

                while (divisorprimos != numero)
                {
                    divisorprimos++;

                    if (numero % divisorprimos == 0)
                    {
                        restoprimos++;
                    }
                }

                if (restoprimos == 2)
                {
                    primos++;
                }
                
                Console.WriteLine("Ingrese un numero;");
                numero = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Cantidad de numeros primos: " + primos);
            Console.WriteLine("Cantidad de numeros pares: " + pares);
            Console.WriteLine("Cantidad de numeros positivos: " + positivos);
            Console.WriteLine("Cantidad de numeros negativos: " + negativos);
        }
    }
}
