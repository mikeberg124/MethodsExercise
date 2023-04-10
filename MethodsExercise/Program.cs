namespace MethodsExercise
{
    public class Program
    {

        static void Main(string[] args)
        {


            Methods.Add(6,8);
            Methods.Subtract(6,8);
            Methods.Multiply(6,8);
            Methods.Divide(6,8);






            //Exercise 1

            Console.WriteLine("What is your name");
            string Name = Console.ReadLine();

            Console.WriteLine($"Hello {Name},what is your favorite color?");
            string favoriteColor  = Console.ReadLine();

            Console.WriteLine($"{favoriteColor} is not my favorite. My favorite animal is a tiger, what is yours?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"That a great {favAnimal}! What is your favorite band?");
            string favoriteBand = Console.ReadLine();



            Console.WriteLine ($"{Name} wants a {favoriteColor}-colored fruit while he watches the {favAnimal}./n" +
                $"He watches the {favAnimal} while hes listening to {favoriteBand} on his phone.") ;
        }
    }
}










