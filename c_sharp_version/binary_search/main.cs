using Internal;
using System;

class Program
{
  static void Main()
  {
    int[] array = new int[100];
    int target = 72;

    for(int i = 0; i < array.Length; i++)
    {
      array[i] = i;
    }

    int index = binarySearch(array, target);

    if (index == -1)
    {
      Console.WriteLine(target + " not found");
    } else
    {
      Console.WriteLine(target + " found");
    }
  }

  private static int binarySearch(int[] array, int target)
  {
    int low = 0;
    int high = array.Length - 1;

    while(low <= high)
    {
      int middle = low + (high - low) / 2;
      int value = array[middle];
      Console.WriteLine("middle: " + value);

      if(value < target)
      {
        low = middle + 1; 
      } else if(value > target)
      {
        high = middle - 1;
      } else
      {
        return middle;
      }
    }

    return - 1;
  }

}