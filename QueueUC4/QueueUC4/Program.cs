using System;

namespace QueueUC4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           Queue linkedListQueue = new Queue();
            linkedListQueue.Enqueue(70);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(56);
            linkedListQueue.Dequeue();
            Console.WriteLine("After performing one dequeue operation the queue is having  : ");
            linkedListQueue.Display();
        }
    }
}
