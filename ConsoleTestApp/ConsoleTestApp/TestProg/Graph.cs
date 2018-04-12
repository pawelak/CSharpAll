using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.TestProg
{
    class Graph
    {
        public static int Count(params int[] tree)
        {
            var list = new List<int>();
            foreach (var el in tree)
            {
                if ((!list.Contains(el)) && (el != -1))
                {
                   list.Add(el);
                }

               
            }

            return list.Count;
        }
    }
}
