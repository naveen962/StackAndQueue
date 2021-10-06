using System;

namespace LinkedList_Stack_UC2
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
            linkedListStack.Peek();
            linkedListStack.Pop();
            linkedListStack.IsEmpty();
        }
    }
}
