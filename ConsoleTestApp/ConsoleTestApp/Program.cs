using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ConsoleTestApp.TestProg;

namespace ConsoleTestApp
{
    class Program
    {
        //        public static int Count(params int[] tree)
        //        {
        //            var max = tree.Max();
        //            int t[max];
        //            foreach (var el in tree)
        //            {
        //                if ((!list.Contains(el)) && (el != -1))
        //                {
        //                    list.Add(el);
        //                }
        //
        //
        //            }
        //
        //            return list.Count;
        //        }

        public static int FindMaxSum(List<int> list)
        {
            var biggest = -1;
            var secondBiggest = -1;

            foreach (var el in list)
            {
                if (el > biggest)
                {
                    biggest = el;
                    secondBiggest = biggest;
                }
               
            }

            return biggest + secondBiggest;
        }


        static void Main(string[] args)
        {

//            Console.WriteLine(new MatryoshkaDoll(new MatryoshkaDoll()).NumberOfSmallerDolls);

//
//            Graph graph = new Graph();
//            int[] tab = { 5, 9, 7, 11 };
//            List<int> list = new List<int> { 5, 9, 7, 11 };

            //Console.WriteLine(Count(tab));

            //Console.WriteLine(FindMaxSum(list));


//            DocumentStore documentStore = new DocumentStore(2);
//            documentStore.AddDocument("item");
//            documentStore.AddDocument("item2");
//            documentStore.AddDocument("item3");
//            Console.WriteLine(documentStore);


            Kata kata = new Kata();
            Console.WriteLine(kata.Order("asdas2asd asda1asd"));

            Console.ReadKey();
        }
    }
}
