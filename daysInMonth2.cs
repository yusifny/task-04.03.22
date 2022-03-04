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
                    Console.WriteLine("There is 31 days.");
                    break;
                case "February":
                    Console.WriteLine("There is 28/29 days.");
                    break;
                case "March":
                    Console.WriteLine("There is 31 days.");
                    break;
                case "April":
                    Console.WriteLine("There is 30 days.");
                    break;
                case "May":
                    Console.WriteLine("There is 31 days.");
                    break;
                case "June":
                    Console.WriteLine("There is 30 days.");
                    break;
                case "July":
                    Console.WriteLine("There is 31 days.");
                    break;
                case "August":
                    Console.WriteLine("There is 31 days.");
                    break;
                case "September":
                    Console.WriteLine("There is 30 days.");
                    break;
                case "October":
                    Console.WriteLine("There is 31 days.");
                    break;
                case "November":
                    Console.WriteLine("There is 30 days.");
                    break;
                case "December":
                    Console.WriteLine("There is 31 days.");
                    break;
                default:
                    Console.WriteLine("There is no such a Month");
                    break;
                    
            }
        }
    }
}
