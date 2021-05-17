using System;

namespace String_format_Numeric
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 345672832;
            double db = 127.345;
            Console.WriteLine("Number: {0:N}", db);
            Console.WriteLine("Scientific: {0:E}", db);
            Console.WriteLine("Currency: {0:C}", db);
            Console.WriteLine("Percent: {0:P}", db);
            Console.WriteLine("Hexadecimal: {0:X}", a);
        }
    }
}
