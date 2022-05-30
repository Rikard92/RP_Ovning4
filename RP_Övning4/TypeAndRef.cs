namespace RP_Övning4
{
    internal class TypeAndRef
    {
        internal int ReturnValue()
        {

            int x = new int();
            x = 3;
            int y = new int();
            y = x;
            y = 4;
            return x;
        }

        internal int ReturnValue2()
        {
            MyInt x = new MyInt();
            x.MyValue = 3;
            MyInt y = new MyInt();
            y = x;
            y.MyValue = 4;
            return x.MyValue;
        }
    }
}