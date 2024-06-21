using System.ComponentModel.Design;
using System.Reflection;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        
        //Write a method to check whether a given number is even or odd
        
        //Write a method to check whether a given number is positive or negative
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintThousand();
            EveryThree();
            CheckEquality(5, 6);
            NumberCheck(4);
            CheckSign(5);
            CheckEligibility();
            CheckRange();
            MultiplyNumber();

        }

        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void EveryThree()
        {
            for (int i = 3; i < 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static bool CheckEquality(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void NumberCheck(int a)
        {
            
            if (a % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            
        }

        public static void CheckSign(int a)
        {
            
            if (a > 0)
            {
                Console.WriteLine("This is a postive number.");
            }
            else
            {
                Console.WriteLine("This is a negative number.");
            }
        }

        public static void CheckEligibility()
        {
            Console.WriteLine("What is your age?");
            string input = Console.ReadLine();

            int age;
            bool isParsable = int.TryParse(input, out age);

            if (isParsable)
            {
                if (age >= 18)
                {
                    Console.WriteLine("You are eligible to vote.");
                }
                else
                {
                    Console.WriteLine("You are not eligible to vote.");
                }
            }
        }

        public static void CheckRange()
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            int number;
            bool isParsable = int.TryParse(input, out number);

            if (isParsable)
            {
                int lowerBound = -10;
                int upperBound = 10;

                if (number >= lowerBound && number <= upperBound)
                {
                    Console.WriteLine($"The number {number} is within the range {lowerBound} to {upperBound}.");
                }
                else
                {
                    Console.WriteLine($"The number {number} is not within range {lowerBound} to {upperBound}.");
                }
            }

            
        }
        public static void MultiplyNumber()
        {
            Console.WriteLine("Enter a number to display its multiplication table: ");
            string input = Console.ReadLine();

            int num;
            bool isParsable = int.TryParse(input, out num);

            if (isParsable)
            {
                for(int i = 1; i <= 12; i++)
                {
                    int result = num * i;
                    Console.WriteLine($"{num} x {i} = {result}");
                }
            }
               
        }    


    }
}
