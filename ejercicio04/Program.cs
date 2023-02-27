using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite dos números y luego muestre los números
            // entre el menor y el mayor de ellos. Acordate, usando While.

            int n1, n2, mayor, menor;

            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                mayor = n1;
                menor = n2;
            }
            else
            {
                mayor = n2;
                menor = n1;
            }

            while (menor < mayor)
            {
                menor++;
                Console.WriteLine(menor);
            }

        }
    }
}
