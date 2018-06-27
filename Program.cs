using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application10
{
    class mainfuncaion
    {
        public static int Count(string x)
        {
            int result = 0;

            x = x.Trim();
            if (x == "")
                return 0;
            while (x.Contains("  "))
                x = x.Replace("  ", " ");
            foreach (string y in x.Split(' '))
                result++;

            return result;
        }
        static void Main(string[] args)
        {
            string x = "";
            Console.WriteLine("Enter the String:");
            x = Console.ReadLine();
            mainfuncaion mf = new mainfuncaion();
            mf.Count(x);
            Console.ReadKey();
        }
    }
}
