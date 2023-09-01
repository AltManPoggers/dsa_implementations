using System.Collections.Generic;
using System;

namespace BreadthFirstSearch
{
  class Program
  {
    public static void Main(string[] args)
    {
      Graph g = new Graph(6);

        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 3);
        g.AddEdge(1, 4);
        g.AddEdge(2, 4);
        g.AddEdge(3, 4);
        g.AddEdge(3, 5);
        g.AddEdge(4, 5);

        BreadthFirstSearch bfs = new BreadthFirstSearch(g, 0);

        bfs.PrintPath(0, 5); // Will print the shortest path from vertex 0 to vertex 5
    }
  }

  public class Graph
  {
    public int Vertices { get; }
    public List<int>[] Adj { get; }

    public Graph(int vertices)
    {
        Vertices = vertices;
        Adj = new List<int>[vertices];

        for (int i = 0; i < vertices; i++)
        {
            Adj[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        Adj[v].Add(w);
    }
  }
public class BreadthFirstSearch
{
    private readonly bool[] marked;
    private readonly int[] edgeTo;

    public BreadthFirstSearch(Graph graph, int startVertex)
    {
      marked = new bool[graph.Vertices];
      edgeTo = new int[graph.Vertices];
      BFS(graph, startVertex);
    }

    private void BFS(Graph graph, int vertex)
    {
      Queue<int> queue = new Queue<int>();
      marked[vertex] = true;

      queue.Enqueue(vertex);
      while (queue.Count != 0)
      {
        int v = queue.Dequeue();
        System.Console.WriteLine("Visited " + v);

        foreach (int nextVertex in graph.Adj[v])
        {
          if (!marked[nextVertex])
          {
              edgeTo[nextVertex] = v;
              marked[nextVertex] = true;
              queue.Enqueue(nextVertex);
          }
        }
      }
    }

    public void PrintPath(int startVertex, int endVertex)
    {
      if (!marked[endVertex])
      {
        System.Console.WriteLine("No path from " + startVertex + " to " + endVertex);
      }
      else
      {
        Stack<int> path = new Stack<int>();
        for (int x = endVertex; x != startVertex; x = edgeTo[x])
        {
            path.Push(x);
        }
        path.Push(startVertex);

        string pathString = "";
        while (path.Count != 0)
        {
            pathString += path.Pop();
            if (path.Count != 0) pathString += "->";
        }

        System.Console.WriteLine("Path from " + startVertex + " to " + endVertex + ": " + pathString);
      }
    }
  }
}