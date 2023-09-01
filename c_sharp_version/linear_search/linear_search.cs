using System;

namespace LinearSearch
{
  class Algo
  {
    int[] array = new int[] {1,2,3,4,5,6,7,8,9,10};

    public int DoSearch(int value)
    {
      int index = linearSearch(array, value);
      if(index != -1)
      {
        Console.WriteLine("Element found at index: " + index);
        return index;
      }
      else
      {
        Console.WriteLine("Element not found");
        return -1;
      }
    }

    public int linearSearch(int[] array, int value)
    {
      for(int i = 0; i < array.Length; i++)
      {
        if(array[i] == value)
        {
          return i;
        }
      }
      return -1;
    }
  }
}