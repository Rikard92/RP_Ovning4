namespace RP_Övning4
{
    internal class ParanthesisClass
    {
        internal void CheckParanthesis(string theText)
        {
            bool formed = true;
            Stack<char> Par = new Stack<char>();

            foreach (char c in theText)
            {
                if (c=='{'|| c == '[' || c == '(' )
                {
                    Par.Push(c);
                }else if(c == '}' || c == ']' || c == ')')
                {
                    if((Par.Peek()== '{' && c == '}')|| (Par.Peek() == '[' && c == ']') || (Par.Peek() == '(' && c == ')'))
                    {
                        Par.Pop();
                    }
                    else
                    {
                        formed = false;
                        break;
                    }
                }
            }
            if (Par.Count() > 0)
                formed = false;
            if (formed)
            {
                Console.WriteLine("String is Well formed.");
            }
            else
            {
                Console.WriteLine("String is poorly formed");
            }

            
        }
    }
}