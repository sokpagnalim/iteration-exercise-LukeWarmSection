using System;

namespace iterationExerciseLukeWarmSection
{
    internal class Program
    {
        //Write a method that will print to the console all numbers 1000 through -1000
        public static void Print1000s()
        {
            for (var i = 1000; i>= -1000; i--)
            { 
            Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Print3times()
        {
            for (var i = 3; i<= 999; i += 3)
            {
                Console.WriteLine(i);
             }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void EqualIntergers(int x, int y)
        {
            //if (x == y)
            //{
            //    Console.WriteLine("x equals y.");
            //}
            //else
            //{
            //    Console.WriteLine("x does not equal to y.");
            //}

            Console.WriteLine((x == y) ? "x equals to y." : "x does not equal to y.");

        }
        //Write a method to check whether a given number is even or odd
        public static void OddOrEven(int x)
        {
            if (x % 2 != 0)
               {
                Console.WriteLine($"{x} is odd.");
                    
               }
          else
            { 
                Console.WriteLine($"{x} is even");
            }

            
        }



        //Write a method to check whether a given number is positive or negative
        public static void PosOrNeg(int x)
        {
            if (x < 0)
            {
                Console.WriteLine($"{x} is negative.");
            }
           else if (x>0)
            {
                Console.WriteLine($"{x} is positive.");
            }
            else
            {
                Console.WriteLine($"{x} is neither positive nor negative.");
            }




        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void VoteAgeEligibility()
        {
            bool age;
            int result;
           
            do

            {
                Console.WriteLine("Please enter your age.");
                age = int.TryParse(Console.ReadLine(), out result);

            }while(!age);

            if (result < 18)
            {
                Console.WriteLine("sorry you are not old enough to vote.");

            }
            else
            {
                Console.WriteLine("Congrate!! you can vote.");
            }

        }

        //Hint: Use Parse or the safer TryParse() for an extra challenge
        static void Main(string[] args)
        {

            //Print1000s();
            //Print3times();  
            //EqualIntergers(2, 3);
            //EqualIntergers(3, 3);
            //OddOrEven(5);
            //OddOrEven(2);
            //OddOrEven(0);
            //PosOrNeg(5);
            //PosOrNeg(-2);
            //PosOrNeg(0);
            VoteAgeEligibility();

        }
    }
}
