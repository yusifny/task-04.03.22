using System;

namespace daysInMonths
{
    class Program
    {
        static void Main(string[] args)
        {
            string Month = Console.ReadLine();

            if (Month == "January" || Month == "March" || Month == "May" || Month == "July" || Month == "August" || Month == "October" || Month == "December")
            {
                Console.WriteLine("There is 31 days");
            }
            else if (Month == "April" || Month == "June" || Month == "September" || Month == "November")
            {
                Console.WriteLine("There is 30 days");
            }
            else if (Month == "February")
            {
                Console.WriteLine("Either 28 or 29");
            }
            else
            {
                Console.WriteLine("There's no such a month");
            }
        }
       

    }
}
