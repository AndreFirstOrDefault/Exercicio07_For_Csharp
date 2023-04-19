using System;

namespace ExercicioFor07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) 
            {
                Console.Write(i + " ");
                Console.Write(i*i + " ");
                Console.Write(i*i*i + "\n");

            }
        }
    }
}
