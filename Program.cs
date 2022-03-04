using System;

namespace daysInMonth0
{
    class Program
    {
        static void Main(string[] args)
        {
            var Month = Convert.ToInt32(Console.ReadLine());


            if (Month>0 && Month<4)
            {
                Console.WriteLine("I rüb");
            }
            else if (Month > 3 && Month < 7)
            {
                Console.WriteLine("II rüb");
            }
            else if (Month > 6 && Month < 9)
            {
                Console.WriteLine("III rüb");
            }
            else if (Month > 8 && Month < 13)
            {
                Console.WriteLine("IV rüb");
            }
            else
            {
                Console.WriteLine("Düzgün rəqəm daxil edin");
            }
                
        }
    }
}
