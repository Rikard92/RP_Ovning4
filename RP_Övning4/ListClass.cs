namespace RP_Övning4
{
    internal class ListClass
    {
        internal void ExamineList()
        {
            List<int> theList = new List<int>();

            CapAndCount(theList);

            theList.Add(1);
            CapAndCount(theList);
            theList.Add(2);
            CapAndCount(theList);

            theList.Add(3);
            theList.Add(4);
            CapAndCount(theList);

            theList.Add(5);
            theList.Add(6);
            theList.Add(7);                
            theList.Add(8);
            CapAndCount(theList);

            theList.Add(9);
            CapAndCount(theList);

            theList.Add(10);
            theList.Add(11);
            theList.Add(12);
            theList.Add(13);
            theList.Add(14);
            theList.Add(15);
            theList.Add(16);
            theList.Add(17);
            CapAndCount(theList);

            theList.RemoveAt(theList.Count()-1);
            theList.RemoveAt(theList.Count() - 1);
            CapAndCount(theList);
        }

        private void CapAndCount(List<int> L)
        {
            Console.WriteLine($"Capacity Is: {L.Capacity}");
            Console.WriteLine($"Count Is: {L.Count} ");
        }
    }
}