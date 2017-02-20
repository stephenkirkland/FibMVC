using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibMVC.Biz
{
    public class CalcFib
    {
        public List<int> d;
        public int a = 0;
        public int b = 1;
        public List<int> Fib()
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

        public List<int> Fib(int s)
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
