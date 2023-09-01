using Internal;
// Divide and Conquer Paradigm
using System;

class Program
{
  static void Main()
  {
    int[] array = {5,10,22,11,14,21,32,31,34,45,54};
    for(int i = 0; i < array.Length; i++)
    {
      Console.WriteLine("Before Merge Sort " + array[i]);
    }
    mergeSort(array);
    for(int i = 0; i < array.Length; i++)
    {
      Console.WriteLine("After Merge Sort " + array[i]);
    }
  }
  private static void mergeSort(int[] array)
  {
    int length = array.Length;
    if (length <= 1) return; // base case
    int middle = length / 2;
    int[] leftArray = new int[middle];
    int[] rightArray = new int[length - middle];
    int i = 0;
    int j = 0;
    for(; i < length; i++)
    {
      if(i < middle)
      {
        //copy element from original array to left array
        leftArray[i] = array[i];
      } else
      {
        rightArray[j] = array[i];
        j++;
      }
    }
    mergeSort(leftArray);
    mergeSort(rightArray);
    merge(leftArray, rightArray, array);
  }
  private static void merge(int[] leftArray,int[] rightArray, int[] array)
  {
    int leftSize = array.Length / 2;
    int rightSize = array.Length - leftSize;
    int i = 0, l = 0, r = 0; // indcies we using
    //check conditions for merging
    while(l < leftSize && r < rightSize)
    {
      if(leftArray[l] < rightArray[r])
      {
        array[i] = leftArray[l];
        i++;
        l++;
      } else
      {
        array[i] = rightArray[r];
        i++;
        r++;
      }
    }
    while(l < leftSize)
    {
      array[i] = leftArray[l];
      i++;
      l++;
    }
    while(r < rightSize)
    {
      array[i] = rightArray[r];
      i++;
      r++;
    }
  }
}