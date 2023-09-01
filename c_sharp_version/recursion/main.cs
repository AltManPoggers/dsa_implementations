using Internal;
// Solved in a LIFO order
using System;
class Program
{
  static void Main()
  {
    Walk(5);
    RecursiveWalk(6);
  }
  private static void Walk(int steps)
  {
    for (int i = 0; i < steps; i++)
    {
      Console.WriteLine("You take a step in none recursive walk " + i);
    }
  }

  // recursive method
  private static void RecursiveWalk(int steps)
  {
    //base case
    if(steps < 1) return;
    Console.WriteLine("You take a step in recursive walk " + steps);
    RecursiveWalk(steps - 1);
  }
}