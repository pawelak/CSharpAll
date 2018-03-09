using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using martyna2;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var howMuchNumbers = 4;
            var obj = new MartynaRecursionHw(howMuchNumbers);
            obj.Func(howMuchNumbers);
            Console.ReadKey();
        }
    }
}
