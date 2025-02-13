using System;

public class Program
{
    public static void ReverseArray(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start < end)
        {
            
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }
    }

    public static void Main()
    {
        int[] arr = {1, 2, 3, 4};
        ReverseArray(arr);
    
        Console.WriteLine(string.Join(", ", arr));  
    }
}
