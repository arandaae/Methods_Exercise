using System;

namespace MethodsExercise_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Operators");
            Add();
            Console.WriteLine();
            Subtract();
            Console.WriteLine();
            Multiply();
            Console.WriteLine();
            Divide();

        }
        

        public static void Add()
        {
            Console.WriteLine("Add two numbers");
            Console.WriteLine("Enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine($"Your answer is {result}.");
        }

        public static void Subtract()
        {
            Console.WriteLine("Subtract two numbers");
            Console.WriteLine("Enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 - num2;
            Console.WriteLine($"Your answer is {result}.");
        }

        public static void Multiply()
        {
            Console.WriteLine("Multiply two numbers");
            Console.WriteLine("Enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2;
            Console.WriteLine($"Your answer is {result}.");
        }

        public static void Divide()
        {
            Console.WriteLine("Divide two numbers");
            Console.WriteLine("Enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine($"Your answer is {result}.");
        }
    }
}
