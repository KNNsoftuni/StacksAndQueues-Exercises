namespace basicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int S = input[1];
            int X = input[2];
            Queue<int> numQueue = new Queue<int>();
            List<int> enqueNum = Console.ReadLine().Split().Select(int.Parse).ToList();

            enqueNum.ForEach(x => numQueue.Enqueue(x));

            for (int i = 0; i < S; i++)
            {
                numQueue.Dequeue();
            }

            if (numQueue.Count() > 0)
                if (numQueue.Contains(X))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numQueue.Min());
                }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}