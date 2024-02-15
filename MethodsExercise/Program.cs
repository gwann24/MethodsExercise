using System.ComponentModel;

namespace MethodsExercise
{
    public class Program
    {
        public static string GetAnswer(string question)
        {
            //string userInput;
            Console.WriteLine(question);
            //userInput = Console.ReadLine();
            return Console.ReadLine();
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
        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
        public static int Add2(params int[] numList)
        {
            return numList.Sum();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1\n");
            //
            string fName = GetAnswer("What is your first name?");
            string color = GetAnswer("What is your favorite color?");
            string animal = GetAnswer("What is your favorite animal?");
            string food = GetAnswer("What is your favorite food?");
            string music = GetAnswer("What is your favorite music genre?");
            Console.WriteLine($"On a sunny afternoon, {fName} was walking along the river wearing a {color} jumpsuit while eating {food} when a {animal} jumps out of the water and begins singing {music} music while playing an air guitar.");

            Console.WriteLine("\n\nExercise 2\n");
            //
            Console.WriteLine($"5 + 10 = {Add(5,10)}");
            Console.WriteLine($"15 - 10 = {Subtract(15,10)}");
            Console.WriteLine($"5 * 20 = {Multiply(5,20)}");
            Console.WriteLine($"25 / 5 = {Divide(25,5)}");
            Console.WriteLine($"5 % 2 = {Modulus(5,2)}");
            Console.WriteLine($"2 + 4 = {Add2(2,4)}");
            Console.WriteLine($"2 + 4 + 6 = {Add2(2,4,6)}");
            Console.WriteLine($"1 + 1 + 1 + 1 + 1 = {Add2(1,1,1,1,1)}");
        }

    }
}
