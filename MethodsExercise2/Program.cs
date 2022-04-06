using System;

namespace MethodsExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the first number you would like to multiply?");
            var num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the second number?");
            var num2 = Convert.ToInt32(Console.ReadLine());

            var multiAnswer = Multiply(num1, num2);
            Console.WriteLine();
            Console.WriteLine($"Your answer is: {multiAnswer}");

            Console.WriteLine();

            Console.WriteLine("What is the first number you would like to add?");
            var sumNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the second number you would like to add?");
            var sumNum2 = Convert.ToInt32(Console.ReadLine());

            var sumAnswer = Sum(sumNum1, sumNum2);
            Console.WriteLine();
            Console.WriteLine($"Your answer is: {sumAnswer}");
        }

        public static int Sum(int num1, int num2)
        {
            int answer = num1 + num2;
            return answer; 
        }
        
        public static int Multiply(int num1, int num2)
        {
            int answer = num1 * num2;
            return answer;   
        }        
    }
}
