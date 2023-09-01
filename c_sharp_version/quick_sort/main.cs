using System;

class Program
{
  static void Main()
  {
    int[] array = {5,10,2,3,4,32,42,41,55,100};
    for(int i = 0; i < array.Length; i++)
    {
      Console.WriteLine("before quick sort " + array[i]);
    }
    quickSort(array, 0, array.Length - 1);
    for(int i = 0; i < array.Length; i++)
    {
      Console.WriteLine("after quick sort " + array[i]);
    }
  }

  public static void quickSort(int[] array, int start, int end)
  {
    if(end <= start) return; //base case :p
    int pivot = partition(array, start, end);
    quickSort(array, start, pivot - 1);
    quickSort(array, pivot + 1, end);
  }

  //Helper function
  public static int partition(int[] array, int start, int end)
  {
    int pivot = array[end];
    int i = start - 1;
    int temp;  // Declare temp here once

    for(int j = start; j <= end - 1; j++)
    {
      if(array[j] < pivot)
      {
        i++;
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
      }
    }

    i++;
    temp = array[i];  // Remove second declaration and use the already declared temp variable
    array[i] = array[end];
    array[end] = temp;
    return i;
  }
}