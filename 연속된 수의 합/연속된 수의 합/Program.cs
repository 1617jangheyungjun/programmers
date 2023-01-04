using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;

public class Solution
{
    public int[] solution(int num, int total)
    {
        List<int> list = new List<int>();
        int a = (2*total/num + 1 - num) / 2;
        for(int i = 0; i < num; i++)
        {
            list.Add(a + i);
        }
        int[] answer = list.ToArray();
        return answer;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] x = new int[] { 5, 15 };
        Console.WriteLine(solution.solution(4,14));
        }
}