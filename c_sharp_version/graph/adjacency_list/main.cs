using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        Graph graph = new Graph();
        graph.addNode(new Node("A"));
        graph.addNode(new Node("B"));
        graph.addNode(new Node("C"));
        graph.addNode(new Node("D"));
        graph.addNode(new Node("E"));
        graph.addEdge(0,1);
        graph.addEdge(1,2);
        graph.addEdge(1,4);
        graph.addEdge(2,3);
        graph.addEdge(2,4);
        graph.addEdge(4,0);
        graph.addEdge(4,2);

        graph.print();
    }
}

public class Graph
{
    List<LinkedList<Node>> alist;
    public Graph()
    {
      alist = new List<LinkedList<Node>>();
    }
    public void addNode(Node node)
    {
      LinkedList<Node> currentList = new LinkedList<Node>();
      currentList.AddFirst(new LinkedListNode<Node>(node));
      alist.Add(currentList);
    }
    public void addEdge(int src, int dst)
    {
      LinkedList<Node> currentList = alist[src];
      Node dstNode = alist[dst].First.Value;
      currentList.AddFirst(new LinkedListNode<Node>(dstNode));
    }

    public void print()
    {
      for (int i = 0; i < alist.Count; i++)
      {
        Console.Write($"Node {alist[i].Last.Value.data} is connected to: ");
        foreach (var node in alist[i].Take(alist[i].Count - 1))
        {
            Console.Write($"{node.data} ");
        }
        Console.WriteLine();
        }
    }
}

public class Node
{
  public string data;
  public Node(string data)
  {
    this.data = data;
  }
} 