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
            return minuend - subtrahend;
        }

        public static int Add(int number1, int number2)
        {
            return (number1 + number2);
        }
        public static void GetSmallestNumber(int number1, int number2)
        {
            
            
            if(number1 < number2)
            {
                Console.WriteLine("Your first number is smaller than the second one.");
            }
            else
            {
                Console.WriteLine("Your second number is smaller than the first one.");
            }
            
        }

        public static long Multiply(long factor1, long factor2)
        {
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
