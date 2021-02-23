using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesType
{
    class Program
    {
        private static string HiThere(int i)
        {
            return "Hi there! #" + (i * 100);
        }
        static void Main(string[] args)
        {
            ConvertsIntToString someMethod = new ConvertsIntToString(HiThere);
            string message = someMethod(5);
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
