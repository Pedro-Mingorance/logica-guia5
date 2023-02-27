using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite la edad de un grupo de personas. El programa
            //deberá pedir edades hasta que se ingrese una edad menor a 18 años. Deberá
            //mostrar por pantalla cuántas personas mayores se registraron.
            
            int contador = 0;
            int numero;

            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 18)
            {
                
                contador++;
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El total de numeros mayor a 18 es: " + contador);
        }
    }
}
