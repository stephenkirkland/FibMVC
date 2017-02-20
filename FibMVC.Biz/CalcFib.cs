using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibMVC.Biz
{
    public class CalcFib
    {
        public static List<int> d = new List<int>();
        public static int a = 0;
        public static int b = 1;
        public static List<int> Fib()
        {
            for (int i = 0; i < 15; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                d.Add(a);
            }
            return d;
        }

        public static List<int> Fib(int s)
        {
            a = 0;
            b = 1;
            for (int i = 0; i < s; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                d.Add(a);
            }
            return d;
        }
    }
}
