using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace String_Formats
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp = 20.4;
            string s = String.Format("The temperature is {0}°C.", temp);
            Console.WriteLine(s);

            string msg = string.Format("There are {0} owls", 5);
            Console.WriteLine(msg);

            Console.WriteLine("There are {0} eagles", 3);

            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("There are {0} hawks", 4);
            Console.WriteLine(builder);

        }
    }

}
