using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
//          Hacer un programa que muestre los números del 1 al 100 de 5 en 5. Ejemplo:
//          0, 5, 10, 15, 20.... 100. Usando While.

            int acu = 0;

            while (acu < 101)
            {
                Console.WriteLine(acu);
                acu += 5;
            }

        }
    }
}
