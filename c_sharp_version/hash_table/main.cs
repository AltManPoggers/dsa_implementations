using System.Collections;
using System;

class Program
{
  static void Main()
  {
    Hashtable<Integer, String> table = new Hashtable<>(10);
    table.Add(100, "Spongebob");
    table.Add(123, "Patrick");
    table.Add(321, "Sandy");
    table.Add(555, "Squidward");
    table.Add(777, "Gary");
  }
}