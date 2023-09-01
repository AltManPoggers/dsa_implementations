// better than bubble sort
// n^2
using System;
class Program
{
  static void Main()
  {
    int[] array = {5,21,32,41,2,1,46,10};
    for(int i = 0; i < array.Length; i++)
    {
      Console.WriteLine("before insertion sort " + array[i]);
    }
    insertionSort(array);
        for(int i = 0; i < array.Length; i++)
    {
      Console.WriteLine("after insertion sort " + array[i]);
    }
  }

  private static void insertionSort(int[] array)
  {
    for (int i = 1; i < array.Length; i++)
    {
      int temp = array[i];
      int j = i - 1;

      while(j >= 0 && array[j] > temp)
      {
        array[j + 1] = array[j];
        j--;
      }
      array[j + 1] = temp;
    }
  }
}