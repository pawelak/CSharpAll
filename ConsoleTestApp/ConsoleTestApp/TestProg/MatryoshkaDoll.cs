using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.TestProg
{
    public class MatryoshkaDoll
    {
        private readonly MatryoshkaDoll containedDoll;

        public MatryoshkaDoll() { }

        public MatryoshkaDoll(MatryoshkaDoll containedDoll)
        {
            this.containedDoll = containedDoll;
        }

        public int NumberOfSmallerDolls
        {

            get
            {
                if (containedDoll != null)
                {
                    return containedDoll.NumberOfSmallerDolls + 1;
                }

                return 0;

            }
        }

       
    }
}


