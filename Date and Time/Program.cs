using System;

namespace String_formats_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;

            Console.WriteLine("Short date: {0:d}", today);
            Console.WriteLine("Long date: {0:D}", today);
            Console.WriteLine("Short time: {0:t}", today);
            Console.WriteLine("Long time: {0:T}", today);
            Console.WriteLine("Month: {0:M}", today);
            Console.WriteLine("Date Time String: {0:R}", today);
            Console.WriteLine("Universal Sortable Date: {0:U}", today);
            Console.WriteLine("Month Year: {0:Y}", today);
        }
    }
}
