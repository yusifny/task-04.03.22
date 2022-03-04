using System;

namespace daysInMonth0
{
    class Program
    {
        static void Main(string[] args)
        {
            var Month = Console.ReadLine();


            if (Month == "January" || Month == "February" || Month == "March")
            {
                Console.WriteLine("1st Quarter");
            }
            else if (Month == "April" || Month == "May" || Month == "June")
            {
                Console.WriteLine("2nd Quarter");
            }
            else if (Month == "July" || Month == "August" || Month == "September")
            {
                Console.WriteLine("3rd Quarter");
            }
            else if (Month == "October" || Month == "November" || Month == "December")
            {
                Console.WriteLine("4th Quarter");
            }
            else
            {
                Console.WriteLine("There is no such Month");
            }

        }
    }
}
