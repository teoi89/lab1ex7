using System;

namespace lab1ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
            impar
                * In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
                * Google :even and odd number */
            Console.WriteLine("Write a number and I`ll check if it is odd or even");

            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Is even");
            }
            else
            {
                Console.WriteLine("Is odd");
            }

        }
    }
}
