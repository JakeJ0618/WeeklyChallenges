using System;
using System.ComponentModel;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public static bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static double Subtract(double minuend, double subtrahend)
        {
            Console.WriteLine("Please choose your first number.");
            minuend = double.Parse(Console.ReadLine());
            Console.WriteLine("Please choose your second number.");
            subtrahend = double.Parse(Console.ReadLine());
            return minuend - subtrahend;
        }

        public static int Add(int number1, int number2)
        {
            Console.WriteLine("Please choose your first number.");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please choose your second number");
            number2 = int.Parse(Console.ReadLine());
            return (number1 + number2);
        }
        public static void GetSmallestNumber(int number1, int number2)
        {
            Console.WriteLine("Please choose your first number.");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please choose your second number.");
            number2 = int.Parse(Console.ReadLine());
            
            
            
            if(number1 < number2)
            {
                Console.WriteLine("Your first number is smaller than the second one.");
            }
            else
            {
                Console.WriteLine("Your second number is smaller than the first one.");
            }
            return ;
            
        }

        public static long Multiply(long factor1, long factor2)
        {
            Console.WriteLine("Please choose your first number.");
            factor1 = long.Parse(Console.ReadLine());
            Console.WriteLine("Please choose your second number.");
            factor2 = long.Parse(Console.ReadLine());
            return factor1 * factor2;
            
        }

        public static string GetGreeting(string nameOfPerson)
        {
            Console.WriteLine("Hello, what's your name?");
            var fullName = Console.ReadLine();
            Console.WriteLine($"Hello, {fullName}");
            return nameOfPerson;
        }

        public string GetHey()
        {
            Console.WriteLine("Hey!");
            return GetHey();
        }
            
            
        


       
        
    }
    
    
} 
