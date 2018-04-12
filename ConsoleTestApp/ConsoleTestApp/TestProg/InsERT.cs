using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp.TestProg
{
    class InsERT
    {

        public int e1(int M, int[] A)
        {
            int N = A.Length;
            int[] count = new int[M + 1];
            for (int i = 0; i <= M; i++)
                count[i] = 0;
            int maxOccurence = 0;
            int index = -1;
            for (int i = 0; i < N; i++)
            {
                if (A[i] >= 0 && A[i] <= M)
                {
                    int tmp = count[A[i]];
                    if (tmp > maxOccurence)
                    {
                        maxOccurence = tmp;
                        index = i;
                    }

                    count[A[i]] = tmp + 1;
                }
                else
                {
                    index = (index != -1) ? i : index;
                    count[A[i]] = count[A[i]]++;
                }
            }

            return A[index];
        }


        public int e2(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            char last = '(';
            int countL=0, countR=0;
            foreach (var sign in S)
            {
                if (sign == '(' && last == ')') break;
                if (sign == '(') //if first part
                {
                   
                    countL++;
                }
                if (sign == ')')
                {
                    countR++;
                }

                last = sign;
            }

            return countR+countL-countL;
        }

        public int e3(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (count <= 1000000000)
                {
                    for (int j = i+1; j < A.Length; j++)
                    {
                        if (A[i] == A[j])
                        {
                            count++;
                        }
                    }
                }
                else
                {
                    return 1000000000;
                }

                
            }
            return count;
        }
    }

}


