using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite una lista de números que corta cuando se
            // ingresa un cero y luego mostrar por pantalla el máximo de ellos y la posición
            // en la que fue ingresado.


            int numero;
            int maximo = 0;
            int orden = 0;
            int contador = 1;
            bool bandera = false;

            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if (!bandera)
                {
                    maximo = numero;
                    orden = contador;
                    bandera = true;
                }
                else if (numero > maximo)
                {
                    maximo = numero;
                    orden = contador;
                }

                contador++;
                Console.WriteLine("Por favor ingrese un numero:");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El numero mas alto ingresado es: " + maximo + " y el orden en el que fue ingresado es: " + orden);
        }
    }
}
