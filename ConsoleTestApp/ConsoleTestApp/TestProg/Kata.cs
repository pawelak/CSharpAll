using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleTestApp.TestProg
{
    public class Kata
    {


        public int DuplicateCount(string str)
        {
            str = str.ToLower();
            var res = str.GroupBy(x => x).Select(group => new {letter = group.Key, Count = group.Count()})
                .OrderByDescending(x => x.Count);
            int maxCount = 0;
            char letter = char.MinValue;
            int result = 0;
            foreach (var re in res)
            {
                if (re.Count >= maxCount && re.Count > 1)
                {
                    maxCount = re.Count;
                    result++;
                }
            }

            return result;
        }

        public int FindShort(string s)
        {
            int lowest = Int32.MaxValue;
            string[] result = s.Split(' ');
            foreach (var word in result)
            {
                if (word.Length < lowest)
                {
                    lowest = word.Length;
                }
            }

            return lowest;
            //return s.Split(' ').Min(x => x.Length); //or
        }

        public string Longest(string s1, string s2)
        {
            var help = ((s1 + s2).ToCharArray().Distinct().ToArray());
            Array.Sort(help);
            return new string(help);
        }

        public int CountBits(int n)
        {
            return Convert.ToString(n, 2).GroupBy(x => x).Select(x => x.Count()).FirstOrDefault();
        }


        public long FindNextSquare(long num)
        {
            long res = (long) Math.Sqrt(num);
            if (res * res != num)
            {
                return -1;
            }

            return (res + 1) * (res + 1);
        }

        public string MakeComplement(string dna)
        {
            var dna2 = dna.ToArray();
            for (int i = 0; i < dna.Length; i++)
            {
                if (dna[i].Equals('A')) dna2[i] = 'T';
                if (dna[i].Equals('T')) dna2[i] = 'A';
                if (dna[i].Equals('C')) dna2[i] = 'G';
                if (dna[i].Equals('G')) dna2[i] = 'C';
            }

            return new string(dna2);
        }

        public string Order(string words)
        {
            string[] help = words.Split(' ');
            var result = new string[help.Length];
            foreach (var el in help)
            {
                int position = 0;
                foreach (var letter in el)
                {
                    if (Char.IsDigit(letter))
                    {
                        position = letter - '0';
                        break;
                    }
                }

                result[position - 1] = el;
            }

            return String.Join(" ", result);
        }

        public int Sum(int[] numbers)
        {

            return (numbers.Length > 1) ? numbers.Sum() - numbers.Max() - numbers.Min() : 0;
        }

        public string DoubleChar(string s)
        {
            string result = null;
            foreach (var el in s)
            {
                var help = (el + el).ToString();
                result += (el + el).ToString();
            }

            return result;
            // return string.Join("", s.Select(x => "" + x + x));
        }

        public long digPow(int n, int p) //now work
        {
            var num = n.ToString();
            int result = 0, res = 0;
            foreach (var nu in num)
            {
                int tmp = (nu - '0');
                for (int i = 1; i < p; i++)
                {
                    tmp *= (nu - '0');
                }

                result += tmp;
                p++;
            }

            for (int i = 1; i < Math.Sqrt(result); i++)
            {
                if (result % i == 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public string Tickets(int[] peopleInLine)
        {
            int bill25 = 0, bill50 = 0;
            foreach (var p in peopleInLine)
            {
                switch (p)
                {
                    case 100:
                        if (bill50 >= 1 && bill25 >= 1)
                        {
                            bill50--;
                            bill25--;
                            bill25++;
                        }
                        else if (bill25 >= 3)
                        {
                            bill25 = bill25 - 2;
                        }
                        else
                        {
                            return "NO";
                        }

                        break;
                    case 50:
                        if (bill25 >= 1)
                        {
                            bill25--;
                            bill50++;
                        }
                        else
                        {
                            return "NO";
                        }

                        break;
                    case 25:
                        bill25++;
                        break;
                }

            }

            return "YES";
        }


    }
}

