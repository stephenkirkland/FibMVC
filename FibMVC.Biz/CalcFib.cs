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
        public static int temp = 1;
        public static int a = 0;
        public static int b = 0;
        public static int p = 0;
        
        public CalcFib()
        {
        }

        public CalcFib(int s)
        {
            p = s;
            a = 0;
            b = 1;
            for (int i = 0; i < s; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                d.Add(a);
            }
        }

        public static List<int> Fib()
        {
            for (int i = 0; i < 15; i++)
            {
                a = b;
                b = temp + b;
                d.Add(a);
                temp = a;
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

        public int UserInput
        {
            get { return p; }
            set { p = value; }
        }

    }
}
