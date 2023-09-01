using System;
using System.Collections.Generic;
namespace QueueDataStructure
{
  public class Queue
  {
    public Queue()
    {
      //Define queue
      Queue<int> queue = new Queue<int>();
      // Add items to Queue
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);
      int count = queue.Count;
      Console.WriteLine("Queue before dequing " + count);
      while (count > 0)
      {
        int peekQueue = queue.Peek();
        Console.WriteLine("Items being peeked in while loop " + peekQueue);
        int dequeuedItemInwhileloop = queue.Dequeue();
        Console.WriteLine("Items being dequeued in while loop " + dequeuedItemInwhileloop);
      }

    }
  }
}