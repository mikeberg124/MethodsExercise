using System;
namespace MethodsExercise
{
    public class Methods
    {
        public static void Add(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);


        }
        public static void Subtract(int num1, int num2)
        {

            int sum = num1 - num2;
            Console.WriteLine(sum);


        }

        public static void Multiply(int num1, int num2)
        {

            int sum = num1 * num2;
            Console.WriteLine(sum);

        }
        public static void Divide(int num1, int num2)
        {
            int sum = num1 / num2;
            Console.WriteLine(sum);


        }
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {

                sum = sum + number;
            }
            return Add();


        }

        public static int 












































        }
    }

