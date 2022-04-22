using System;

namespace MethodExercise
{

    internal class Program
    {
        static void Main(string[] args)
        {
            storyElements.UserResponses();
            
            //storyElements.ComputerResponse();
        }
    }

        public static class storyElements
        {
            public static void UserResponses()

            {
                Console.WriteLine("Hello user!");
                           

                Console.WriteLine("What is your name?");               
                string name = Console.ReadLine();

                Console.WriteLine("What is your favorite color?");
                string favoriteColor = Console.ReadLine();

                Console.WriteLine("What is your favorite animal?");
                string favoriteAnimal = Console.ReadLine();

                Console.WriteLine("Who is your favorite band?");
                string favoriteBand = Console.ReadLine();

                Console.WriteLine($"Hello, {name}. I see your favorite color is {favoriteColor}. That's great! I also see your favorite animal is a {favoriteAnimal}. Lastly, I see your favorite band is {favoriteBand}. Interesting... ");

            }
            

            //public static string ComputerResponse()
            //{
            //Console.WriteLine($"Hello, {name} ";
            //}


        }

    
}
