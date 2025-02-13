using System;

public class Program
{
    public static int FindMissNumber(int[] arr, int n)
    {
    
        int expectedSum = n * (n + 1) / 2;

    
        int actualSum = 0;
        foreach (int num in arr)
        {
            actualSum += num;
        }

        
        return expectedSum - actualSum;
    }

    public static void Main()
    {
        int[] arr = { 1, 2, 4, 5, 6 };
        int n = 6;
        int result = FindMissNumber(arr, n);
        Console.WriteLine(result);  
    }
}
