using System.ComponentModel.Design;
using System.Diagnostics;

namespace IterationStatements
{
    public class Program
    {


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            MultiplicationTable(7);
        }


        //Heatin Up Section:


        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool IsTenRange(int num)
        {
            if(num <= 10 && num >= -10)
            {
                return true;
            }
            return false;
        }


        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }


        //LukeWarm Section: 


        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static bool OfVotingAge(int age)
        {
            if (age >=18)
            {
                Console.WriteLine($"They are old enough to vote");
                return true;
            }
            else
            {
                Console.WriteLine($"They are not old enough to vote");
                return false;
            }

        }

        //Write a method to check whether a given number is positive or negative
        public static bool IsPositive(int num1)
        {

            if (num1 > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //Write a method to check whether a given number is even or odd
        public static void IsEven(int number)
        { 
            if(number % 2 == 0)
            {
                Console.WriteLine($"That's an even number!");
            }
            else
            {
                Console.WriteLine($"That's an odd number!");
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static bool IsEqual(int a, int b)
        {
            //How do I determine if two numbers are the same?
            if(a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintRange(int ceiling, int floor)
        {
            for (int i = ceiling; i >= floor; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
