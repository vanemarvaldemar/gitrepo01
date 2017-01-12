namespace Sample1
{
    public class Calc: ICalc
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

        public double DivD(int a, int b)
        {
            return (double)a / (double)b;
        }

        public long Mult(int a, int b)
        {
            return a*b;
        }
    }
}
