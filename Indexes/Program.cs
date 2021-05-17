using System;

namespace String_Formats_index
{
    class Program
    {
        static void Main(string[] args)
        {
            int oranges = 2;
            int apples = 4;
            int bananas = 3;

            string str1 = String.Format("There are {0} oranges, {1} apples and {2} bananas", oranges, apples, bananas);
            string str2 = String.Format("There are {1} oranges, {2} bananas and {0} apples", apples, oranges, bananas);
            Console.WriteLine(str1);
            Console.WriteLine(str2);

            Console.WriteLine(str1, oranges, apples, bananas);
            Console.WriteLine(str2, apples, oranges, bananas);
        }
    }
}
