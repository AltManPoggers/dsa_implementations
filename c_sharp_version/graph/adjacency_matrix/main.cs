
using System;
using System.Collections.Generic;
// rows = unique nodes
// columns = unique nodes
namespace AdjacencyList
{
  class Program
  {
    static void Main()
    {
      Graph graph = new Graph(5);
      graph.addNode(new Node("A"));
      graph.addNode(new Node("B"));
      graph.addNode(new Node("C"));
      graph.addNode(new Node("D"));
      graph.addNode(new Node("E"));

      graph.addEdge(0,1);
      graph.addEdge(1,2);
      graph.addEdge(2,3);
      graph.addEdge(2,4);
      graph.addEdge(4,0);
      graph.addEdge(4,2);
      graph.print();
      // Unidirectional
      // A -> B -> C
      // C -> D
      // C -> E
      // E -> C
      // E -> A
      // B -> E
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

  public class Graph
  {
    int[][] matrix;
    List<Node> nodes = new List<Node>();

    public Graph(int size)
    {
      matrix = new int[size][];
      for (int i = 0; i < size; i++)
      {
        matrix[i] = new int[size];
      }
    }

    public void addNode(Node node)
    {
      nodes.Add(node);
    }

    public void addEdge(int src, int dst)
    {
      matrix[src][dst] = 1;
    }

    // Check edge
    public Boolean checkEdge(int src, int dst)
    {
      if(matrix[src][dst] == 1)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

  public void print()
  {
      Console.Write("    ");
      // Printing node names at the top
      for (int i = 0; i < nodes.Count; i++)
      {
        Console.Write(nodes[i].data + " ");
      }
      Console.WriteLine();
      
      for(int i = 0; i < matrix.Length; i++)
      {
        // Printing node names on the left
        Console.Write(nodes[i].data + " ");
        
        for(int j = 0; j < matrix[i].Length; j++)
        {
            Console.Write("  " + matrix[i][j] + " ");
        }
        Console.WriteLine();
      }
    }
  }
}