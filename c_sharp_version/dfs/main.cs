using System.Collections.Generic;
using System;
namespace dfs
{
  class Program
  {
    static void Main()
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

      DepthFirstSearch dfs = new DepthFirstSearch(g, 0);
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

  public class DepthFirstSearch
  {
    private readonly bool[] marked;
    private readonly int[] edgeTo;

    public DepthFirstSearch(Graph graph, int startVertex)
    {
      marked = new bool[graph.Vertices];
      edgeTo = new int[graph.Vertices];
      DFS(graph, startVertex);
    }

    private void DFS(Graph graph, int vertex)
    {
      marked[vertex] = true;
      System.Console.WriteLine("Visited " + vertex);

      foreach (var nextVertex in graph.Adj[vertex])
      {
        if (!marked[nextVertex])
        {
            edgeTo[nextVertex] = vertex;
            DFS(graph, nextVertex);
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