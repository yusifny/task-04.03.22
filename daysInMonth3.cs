using System;

namespace daysInMonth2
{
    class Program
    {
        static void Main(string[] args)

        {
            string Month = Console.ReadLine();

            switch (Month)
            {
                case "January":
                case "March":
                case "May":
                case "July":
                case "August":
                case "October":
                case "December":
                    Console.WriteLine("There are 31 days.");
                    break;
                case "April":
                case "June":
                case "September":
                case "November":
                    Console.WriteLine("There are 30 days.");
                    break;
                case "February":
                    Console.WriteLine("There are 28/29 days.");
                    break;
                default:
                    Console.WriteLine("There is no such a Month");
                    break;

            }
        }
    }
}
