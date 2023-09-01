using System;
using System.Collections.Generic;

namespace StackDataStructure
{
    public class MyStack
    {
        public MyStack()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            
            int count = myStack.Count;
            Console.WriteLine("Number of elements in a stack " + count);

            int topElement = myStack.Peek();
            Console.WriteLine("Peek method of a stack " + topElement);

            while(myStack.Count > 0)
            {
                int poppedElement = myStack.Pop();
                Console.WriteLine("Popped Element " + poppedElement);
            }
        }
    }
}