﻿using System;

namespace findSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = "August";

            if (month == "December" || month == "January" || month == "February")
            {
                Console.WriteLine("It's winter");
            }
            else if (month == "March" || month == "April" || month == "May")
            {
                Console.WriteLine("It's spring");
            }
            else if (month == "June" || month == "July" || month == "August")
            {
                Console.WriteLine("It's summer");
            }
            else if (month == "September" || month == "October" || month == "November")
            {
                Console.WriteLine("It's autmn");
            }
            else
            {
                Console.WriteLine("There's no such a Month!");
            }
        }
    }
}
