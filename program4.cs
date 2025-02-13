using System;


public class Program
{
    public static char FirstUniqueChar(string str)
    {
        
        D<char, int> charCount = new D<char, int>();

      
        foreach (char ch in str)
        {
            if (charCount.ContainsKey(ch))
            {
                charCount[ch]++;
            }
            else
            {
                charCount[ch] = 1;
            }
        }

        foreach (char ch in str)
       
