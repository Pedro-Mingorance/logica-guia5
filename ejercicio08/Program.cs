using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite una lista de números que corta cuando se
            // ingresa un cero y luego mostrar por pantalla el menor y el segundo menor.

            bool banderamenor1 = false;
            bool banderamenor2 = false;
            int primermenor = 0;
            int segundomenor = 0;
            int numero;

            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                if (!banderamenor1)
                {
                    primermenor = numero;
                    banderamenor1 = true;
                }
                else if (!banderamenor2)
                {
                    if (numero < primermenor)
                    {
                        segundomenor = primermenor;
                        primermenor = numero;
                        banderamenor2 = true;
                    }
                    else
                    {
                        segundomenor = numero;
                    }
                }
                else if (numero < primermenor)
                {
                    segundomenor = primermenor;
                    primermenor = numero;
                }
                else if (numero < segundomenor)
                {
                    segundomenor = numero;
                }
                Console.WriteLine("Ingrese un numero:");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Primer menor: " + primermenor);
            Console.WriteLine("Segundo menor: " + segundomenor);
        }

    }
}
