using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise
{
    internal class MathOperators
    {
        public static void Math(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var name = Console.ReadLine();

            var result = Add(10, 20);
        }

        public static int Add(int num1, int num2)
        {
            //code here
            Console.WriteLine("Add two numbers");
            Console.ReadLine(num1, num2);
            Add(num1, num2);
            //int x = num1;

        }


        public static int Subtract(int num1, int num2)
        {
            //code here
        }

        public static int Multiply(int num1, int num2)
        {
            //code here
        }


        public static int Divide(int num1, int num2)
        {
            //code here
        }
    }
}
