using System;

namespace Final20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year where you born?: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What month? (1-12) : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What day?: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age in seconds is " + Program.CalculateAge(year,month,day));
            
        }
        public static double CalculateAge(int year, int month, int day)
        {
            double ageInSeconds;
            DateTime now = DateTime.Now;
            DateTime dob = new DateTime(year, month, day);
            ageInSeconds = (now - dob).TotalSeconds;
            return ageInSeconds;
        }
    }
}
