namespace RP_Övning4
{
    internal class QueueClass
    {
        Queue<String> theQueue;

        public QueueClass()
        {
            theQueue = new Queue<String>();
        }
        internal void TestQueue()
        {
            AddToQueue("Kalle");
            AddToQueue("Greta");
            ExpediteQueue();
            AddToQueue("Stina");
            ExpediteQueue();
            AddToQueue("Olle");
            DisplayQueue();
        }

        public void AddToQueue(String name)
        {
            theQueue.Enqueue(name);
        }
        public void ExpediteQueue()
        {
            theQueue.Dequeue();
        }

        public void DisplayQueue()
        {
            int i = 0;
            foreach (string person in theQueue)
            {
                i++;
                Console.WriteLine($"{i}: {person}");
            }
        }
    }
}