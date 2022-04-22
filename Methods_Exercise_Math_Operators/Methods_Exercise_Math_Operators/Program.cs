using System;

namespace Methods_Exercise_Math_Operators
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            var name = Console.ReadLine();

            var result = Add(10, 20);
            Console.WriteLine(result);

            result= Subtract(10, 20);
            Console.WriteLine(result);
            
            result = Multiply(10, 20);
            Console.WriteLine(result);

            result = Divide(10, 20);
            Console.WriteLine(result);




        }

        public static int Add(int num1, int num2)
        {           
            return num1 + num2;

        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

    }








}
