using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w7lab
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public class CustomMath
        {
            public static int multiply(int a, int b)
            {
                return a * b;
            }
        }
    }

    public class DivisibleNb
    {
        public static bool isDivisible(long n, long x, long y)
        {
            return (n / x == 0 && n / y == 0);
        }
    }

}

