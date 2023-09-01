using System;
class Program
{
  static void Main()
  {
    int[] array = {2,3,6,3,2,6,4,3,2,10};
    for(int i = 0; i < array.Length; i++)
    {
      Console.WriteLine("before bubble sort " + array[i]);
    }
    bubbleSort(array);
    for(int i = 0; i < array.Length; i++)
    {
      Console.WriteLine(array[i]);
    }
  }

  public static void bubbleSort(int[] array)
  {
    for(int i = 0; i < array.Length - 1 ; i++)
    {

      for(int j = 0; j < array.Length - i - 1; j++)
      {
        if(array[j] > array[j + 1]) {
          int temp = array[j];
          array[j] = array[j + 1];
          array[j+1] = temp;
        }
      }
    }
  }
}