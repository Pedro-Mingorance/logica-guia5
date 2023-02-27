using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Realizar el nuevamente el ejercicio 8 pero ahora debe devolver además la
            // posición en la que fue encontrado cada uno de los mínimos.

            bool banderamenor1 = false;
            bool banderamenor2 = false;
            int primermenor = 0;
            int segundomenor = 0;
            int posicion1 = 0;
            int posicion2 = 0;
            int contador = 0;
            int numero;

            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                contador++;

                if (!banderamenor1)
                {
                    primermenor = numero;
                    posicion1 = contador;
                    banderamenor1 = true;
                }
                else if (!banderamenor2)
                {
                    if (numero < primermenor)
                    {
                        segundomenor = primermenor;
                        primermenor = numero;
                        posicion2 = posicion1;
                        posicion1 = contador;
                        banderamenor2 = true;
                    }
                    else
                    {
                        segundomenor = numero;
                        posicion2 = contador;
                    }
                }
                else if (numero < primermenor)
                {
                    segundomenor = primermenor;
                    primermenor = numero;
                    posicion2 = posicion1;
                    posicion1 = contador;
                }
                else if (numero < segundomenor)
                {
                    segundomenor = numero;
                    posicion2 = contador;
                }
                Console.WriteLine("Ingrese un numero:");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Primer menor: " + primermenor + " y la posicion en la que fue ingresado es: " + posicion1);
            Console.WriteLine("Segundo menor: " + segundomenor + " y la posicion en la que fue ingresado es: " + posicion2);

        }
    }
}
