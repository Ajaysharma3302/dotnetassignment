using System;

public class Program
{
    public static int ArraySum(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum;
    }

    public static void Main()
    {
        int[] arr = {1, 2, 3, 4, 10, 11};
        int result = ArraySum(arr);
        Console.WriteLine(result);  
    }
}
