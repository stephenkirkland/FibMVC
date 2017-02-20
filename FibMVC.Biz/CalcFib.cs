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
        public int b = 0;
        public List<int> Fib()
        {
            d.Add(0);
            d.Add(1);
            for (int i = 0; i < 15; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return d;
        }

        public void Fib(int s, int t)
        {

        }
    }
}
