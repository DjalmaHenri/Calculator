using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
    static int number1 = 0;
        static int number2 = 0;
        static string funcion = "";

        public static void Main(string[] args)
        {
            Console.Clear();

            string nomeUser = "";

            Console.WriteLine("Hello, What's your name?");
            nomeUser = Console.ReadLine();

            Console.WriteLine($"Hello {nomeUser}!");

            Console.WriteLine("Choose the first number:");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose your funcion:");
            funcion = Console.ReadLine();

            Console.WriteLine("Choose the first number:");
            number2 = int.Parse(Console.ReadLine());

            Resolvertoswitch(funcion);

            Console.WriteLine("YEah baby");

        }
        static string Resolvertoswitch(string opcion)
        {
            switch(opcion)
            {   
                case "+":
                Console.WriteLine($"{number1} + {number2} = {number1 + number2}.");
                break;

                case "-":
                Console.WriteLine($"{number1} - {number2} = {number1 - number2}.");
                break;

                case "*":
                Console.WriteLine($"{number1} * {number2} = {number1 * number2}.");
                break;

                case "/":
                Console.WriteLine($"{number1} / {number2} = {number1 / number2}.");
                break;

            }

            return opcion;
        }
    }
    
}