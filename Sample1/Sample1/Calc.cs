using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample1
{
    public class Calc
    {
        public long Add(int a, int b)
        {
            return a + b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }

        public double DivB(int a, int b)
        {
            return (double)a / b;
        }

    }
}
