// search through an array and keep track of the minimum value during each iteration. At the end of each iteration, we swap variables
// n^2
//small ds = ok
//large ds = BAD

using Internal;
using System;
class Program
{
  static void Main()
  {
    int[] array = {5,3,7,19,12,23,412,21,1};
    for (int i = 0; i < array.Length; i++)
    {
      Console.WriteLine("Before selection sort algo " + array[i]);
    }
    selectionSort(array);
    for (int i = 0; i < array.Length; i++)
    {
      Console.WriteLine("After selection sort algo " + array[i]);
    }
  }

  public static void selectionSort(int[] array)
  {
    for(int i = 0; i < array.Length; i++)
    {
      int min = i;
      for(int j = i + 1; j < array.Length;j++)
      {
        if(array[min] > array[j])
        {
          min = j;
        }
      }
      int temp = array[i];
      array[i] = array[min];
      array[min] = temp;
    }
  }
}