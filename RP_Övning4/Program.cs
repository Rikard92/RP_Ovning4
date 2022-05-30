using System;

namespace RP_Övning4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Frågor:
             * 1: 
             * Stacker: Minen som sparas i en staple av information. Sås om en bunte lådor staplad åvnapå varandra
             * Heap: Minen som sparas i en hög av information. kan kåmma pt dire utan att först behöva 
             * 2:
             * Value types håller värden och object. Reference types är en "länk" till ett värde eller object.
             * 3:
             * ReturnValue använder x och y som value types (), ReturnValue2 använder x och y som reference types (Som referara till varandra)
            */
            TypeAndRef TAR = new TypeAndRef();

            Console.WriteLine(TAR.ReturnValue());
            Console.WriteLine(TAR.ReturnValue2());
            

            ListClass LC = new ListClass();

            LC.ExamineList();
            /*
             * Övning​ ​1:​ 
             * 2: Kapaciteten för en lista ökar när Listans mängd blir störe än kapacitet
             * 3: När ett object förs in för första gånge ökas kapaciteten med 4, sen dubleras den varje gång efter det.
             * 4: Det är mer effectivt och enkare att göra så, Om Kapaciteten ändrade varje gång ett nytt object la till så böver listan omkonfiurara sig varje gågn, och det far mer tid. 
             * 5: Nej
             * 6: Om du ska ha en samling av data som kan eventuelt håll mer värde än förväntat.
            */

            QueueClass QC = new QueueClass();
            QC.TestQueue();
            Console.WriteLine();

            StackClass SC = new StackClass();
            SC.TestStack();
            Console.WriteLine();
            /*
             * Övning​ 3:​ 
             * 1: För att Stack tar ut objected som senast har blivigt tillagd i "kön", deta skulle leda till att ingen ville handla på ICA
            */
            SC.ReverseText("Ordet");

            /*
            * Övning​ 4:​ 
            * 1: Jag använder en Stack, effert som (), [] och {} behöver encapsulera för att fungera. Om charactern på toppen av stacken inte machar nästa symbålen som ska encapsulera mening, eller om det finsk kvar character i stacken, då är det dåligt skrivet.
           */
            Console.WriteLine();
            ParanthesisClass PC = new ParanthesisClass();
            PC.CheckParanthesis("{[()]}");
            PC.CheckParanthesis("{[(])}");
            PC.CheckParanthesis("{[()]");

            Console.WriteLine();
            RecursiveClass RC = new RecursiveClass();

            Console.WriteLine(RC.RecursiveOdd(1));
            Console.WriteLine(RC.RecursiveOdd(3));
            Console.WriteLine(RC.RecursiveOdd(5));
            Console.WriteLine();
            Console.WriteLine(RC.RecursiveEven(1));
            Console.WriteLine(RC.RecursiveEven(3));
            Console.WriteLine(RC.RecursiveEven(5));
            Console.WriteLine();
            Console.WriteLine(RC.RecursiveFibonaccise(1));
            Console.WriteLine(RC.RecursiveFibonaccise(3));
            Console.WriteLine(RC.RecursiveFibonaccise(6));
            Console.WriteLine(RC.RecursiveFibonaccise(7));
            Console.WriteLine();

            IterativeClass IC = new IterativeClass();
            Console.WriteLine(IC.IterativeOdd(1));
            Console.WriteLine(IC.IterativeOdd(3));
            Console.WriteLine(IC.IterativeOdd(5));
            Console.WriteLine();
            Console.WriteLine(IC.IterativeEven(1));
            Console.WriteLine(IC.IterativeEven(3));
            Console.WriteLine(IC.IterativeEven(5));
            Console.WriteLine();
            Console.WriteLine(IC.IterativeFibonaccise(1));
            Console.WriteLine(IC.IterativeFibonaccise(3));
            Console.WriteLine(IC.IterativeFibonaccise(6));
            Console.WriteLine(IC.IterativeFibonaccise(7));
            Console.WriteLine();
            /*
            * Övning​ 6:​ 
            * Fråga: Jag skulle säga Rekursive, eftersom det är en function som anropar sigsjälv tar det inte mer plats än en lista eller en iterative function. 
            * Iterativa functioner och listor behöver mer "utrymme", flera variabler att spara data och mer functioner so som for och andra sådan functioner att hantera data, 
            * medans Rekursiv a functioner kallar en function i minet, sigsjälv.
           */


            Console.ReadKey();
        }
    }
}