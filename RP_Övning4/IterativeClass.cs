namespace RP_Övning4
{
    internal class IterativeClass
    {
        internal int IterativeOdd(int n)
        {
            if(n==0) return 1;

            int result = 1;

            for(int i = 1; i <= n; i++)
            {
                result += 2;
            }
            return result;
        }

        internal int IterativeEven(int n)
        {
            if (n == 0) return 1;

            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result += 1;
            }
            return result;
        }

        internal int IterativeFibonaccise(int n)
        {
            if (n == 0) return 0;

            if (n == 1) return 1;

            int firstNum = 0;

            int secondNum = 1;

            int nextNum = 0;

            for (int i = 2; i <= n; i++)
            {
                nextNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = nextNum;
            }
            return nextNum;
        }
    }
}