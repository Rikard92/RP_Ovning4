namespace RP_Övning4
{
    internal class StackClass
    {
        Stack<String> theStack;
        public StackClass()
        {
            theStack = new Stack<String>();
        }
        internal void TestStack()
        {
            AddToStack("Kalle");
            AddToStack("Greta");
            RemoveFromStack();
            AddToStack("Stina");
            RemoveFromStack();
            AddToStack("Olle");
            DisplayStack();
        }

        public void AddToStack(String name)
        {
            theStack.Push(name);
        }

        public void RemoveFromStack()
        {
            theStack.Pop();
        }

        public void DisplayStack()
        {
            int i = theStack.Count()+1;
            foreach (string person in theStack)
            {
                i--;
                Console.WriteLine($"{i}: {person}");
            }
        }

        public void ReverseText(String text)
        {
            var reversedStr = "";
            Stack<string> myStack = new Stack<string>();
            foreach (char c in text)
                myStack.Push(c.ToString());
            while (myStack.Count > 0)
                reversedStr += myStack.Pop();

            Console.WriteLine(reversedStr);
        }
    }
}