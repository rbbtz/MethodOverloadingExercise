using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        public static int Add(int num1, int num2) // 1. Add is the method that accepts two integers (int num1 and int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2) // 2. Add method is given an overload to add two decimals
        {
            return num1 + num2;

        }

        public static string Add(int num1, int num2, bool isCheck) // 3. Add given another overload that returns a string and accepts 3 parameters: 2 integers and 1 boolean
        {
            var sum = num1 + num2;

            if (isCheck == true && sum > 1)
            }
                return $"{sum} dollars"; // if the sum is greather than one dollar write "{sum} dollar"
            }
            else if (isCheck == true && sum == 1) // otherwise if the sum is equal to 1 dollar write "{1} dollar"
            {
                return $"{sum} dollar";
            }
            else if (isCheck == true && sum < 1)
            { 
            return $"{sum} dollars";
             }
            else
            {
                return sum.ToString(); // sends the sum return to a string?
            }
        }

        static void Main(string[] args)
        {
            var x = 29;
            var y = 55;

            var answer = Add(x, y);

            var a = 32.0m;
            var b = 45.0m;

            var decimalAnswer = Add(a, b);

            var thirdAnswer = Add(0, 1, true);

                Console.WriteLine($"int add: {answer} decimal add: {decimalAnswer}");
                Console.WriteLine(thirdAnswer);
        }
    }
}
