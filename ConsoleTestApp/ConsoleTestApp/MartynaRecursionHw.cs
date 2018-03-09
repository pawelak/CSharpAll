
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace martyna2
{
    class MartynaRecursionHw
    {

        private List<int> list;

        public MartynaRecursionHw(int end)
        {
            List = new List<int>();
            for (int i = 0; i < end - 1; i++)
            {
                List.Add(0);
            }
        }

        public List<int> List { get => list; set => list = value; }

        public void Func(int end, int deep = 0)
        {
            var str = "";
            for (int i = 0; i < 10; i++)
            {
                if (end <= deep + 1)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        str = "";
                        foreach (var var in List)
                        {
                            str += var;
                        }
                        Console.WriteLine(str+j);
                    }
                }
                else
                {
                    List[deep] = i;
                    Func(end, deep + 1);
                }

            }
        }

    }
}
