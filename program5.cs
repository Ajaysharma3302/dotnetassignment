using System;
using System.Collections.Generic;

public class Program
{
    public static int LongestConsecutive(int[] arr)
    {
        if (arr.Length == 0)
            return 0;

        HashSet<int> numSet = new HashSet<int>(arr);
        int longestStreak = 0;

        foreach (int num in numSet)
        {
            
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;
                while (numSet.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }

  
    
