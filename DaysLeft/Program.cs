using System;

namespace DaysLeft
{
    class Program
    {
        static void Main(string[] _)
        {
            if (_.Length.Equals(0))
            {
                var month = 0;
                var passedMonth = 0;
                var bDate = 0;
                var currentDay = 0;

                Console.WriteLine("Welcome Birthday Date Calculation Application");
                Console.WriteLine(" ");

                Console.Write("Enter Current Month: ");
                month += int.Parse(Console.ReadLine());

                Console.Write("Enter Birthday Month: ");
                passedMonth += int.Parse(Console.ReadLine());

                Console.Write("Enter B Day: ");
                bDate += int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Current Day: ");
                currentDay += int.Parse(Console.ReadLine());

                Console.WriteLine("How Many Days in Month: ");
                var days = int.Parse(Console.ReadLine());


                Console.WriteLine("Your Birthday is in: {0} Month's",
                    (Math.Abs(passedMonth - month)));
                Console.WriteLine("Your Birthday is in: {0} Day's ",
                    (Math.Abs(currentDay - bDate - days)));

                Console.ReadLine();
            }

        }
    
    
    }


}