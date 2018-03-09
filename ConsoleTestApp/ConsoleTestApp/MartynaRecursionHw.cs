
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
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
            for (int i = 0; i < end; i++)
            {
                List.Add(11);
            }
        }

        public List<int> List { get => list; set => list = value; }

        public void Func(int end, int deep = 0)
        {
            var str = "";
            for (int i = 0; i < 10; i++)
            {
                if (end - 1 <= deep)
                {
                    if ( !List.Contains(i))
                    {
                        List[end - 1] = i;
                        str = "";

                        foreach (var var in List)
                        {
                            str += var;
                        }

                        Console.WriteLine(str);
                    }
                }
                else
                {
                    if (List.Contains(i) && i < 10) 
                    {
                       
                    }
                    else
                    {
                        List[deep] = i;
                        Func(end, deep + 1);

                    }
                }

            }

            List[deep] = 11;
        }

    }
}
