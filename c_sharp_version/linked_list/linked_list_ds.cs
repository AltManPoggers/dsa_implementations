// Use apart from Array and ArrayList because it has an avantage for inserting
// Arrays we have to shift in order to insert O(n);
// Arrays have index so accessing element is O(1)
// Accessing an element of a linked list is O(n)
// In linked list we just have to change the memory location to insert new data
// Double linked list could traverse forward and backward but it 

using System;
using System.Collections.Generic;

namespace LinkedList_DS
{
  
  class LinkedListNode
  {
    public int data;
    public LinkedListNode next;
    public LinkedListNode(int x)
    {
      data = x;
      next = null;
    }
  }

  class LinkedList
  {
    LinkedListNode head;
    int count;

    public LinkedList()
    {
      head = null;
      count = 0;
    }
    public void AddNodeToFront(int data)
    {
        LinkedListNode node = new LinkedListNode(data);
        node.next = head;
        head = node; // Set head to the new node
        count++;
    }
    public void PrintList()
    {
      LinkedListNode runner = head;
      while(runner != null)
      {
        Console.WriteLine(runner.data);
        runner = runner.next;
      }
    }
  }

}