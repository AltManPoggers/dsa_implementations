using System;
using LinkedList_DS;

class Program
{
  static void Main()
  {
    LinkedList linkedList = new LinkedList();
    linkedList.AddNodeToFront(1);
    linkedList.AddNodeToFront(2);
    linkedList.AddNodeToFront(3);
    linkedList.AddNodeToFront(4);
    linkedList.AddNodeToFront(5);
    Console.WriteLine("test");

    linkedList.PrintList();
    Console.WriteLine("line 17");

  }
}