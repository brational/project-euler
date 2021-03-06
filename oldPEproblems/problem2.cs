using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
//By starting with 1 and 2, the first 10 terms will be:
//1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
//By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
//find the sum of the even-valued terms.

namespace project_euler
{
    class Program
    {
        static void Main()
        {
            int evenSum = 2;

            int fiboSubB = 1;
            int fiboSubA = 2;
            int newFibo = 3;
            while (newFibo < 4000000)
            {              
                fiboSubB = fiboSubA;
                fiboSubA = newFibo;
                newFibo = fiboSubA + fiboSubB;
                if (newFibo%2 == 0)
                {
                    evenSum += newFibo;
                }                
            }
            Console.WriteLine("evenSum is {0}", evenSum);
            Console.ReadKey();
        }

    }
}
