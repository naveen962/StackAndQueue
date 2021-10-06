using System;

namespace LinkedList_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LINKEDLIST-STACK");
            Stack linkedListStack = new Stack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
        }
    }
    
}
