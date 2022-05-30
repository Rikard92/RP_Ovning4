namespace RP_Övning4
{
    internal class RecursiveClass
    {
        internal int RecursiveOdd(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            return (RecursiveOdd(n-1)+2);
        }

        internal int RecursiveEven(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return (RecursiveEven(n - 1) + 1);
        }

        internal int RecursiveFibonaccise(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            if (n < 1)
            {
                return 0;
            }
            return (RecursiveFibonaccise(n - 1) + RecursiveFibonaccise(n - 2));
        }
    }
}