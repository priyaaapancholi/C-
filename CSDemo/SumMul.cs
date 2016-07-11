using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSDemo;

class SumMul
    {
        public static void Main(int[] arg)
        {
            int n1 = arg[0];
            int n2 = arg[1];
            Console.WriteLine("the sum of {0} and {1} is:{2}", n1, n2, Sum.add(n1, n2));
            Console.WriteLine("the sum of {0} and {1} is:{2}", n1, n2, Multiply.Mul(n1, n2));
        }
    }

