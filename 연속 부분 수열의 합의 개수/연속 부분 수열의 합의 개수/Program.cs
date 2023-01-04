using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] elements)
    {
        int answer = 0;
        List<int> result = new List<int>();
        List<int> check = new List<int>();
        int num = 0;
        for(int i = 0; i < elements.Length; i++)
        {
            while(num < elements.Length)
            {
                if (num + i >= elements.Length)
                {
                    check.Add(elements[num + i - elements.Length]);
                    result.Add(check.Sum());
                    num++;
                }
                else
                {
                    check.Add(elements[num + i]);
                    result.Add(check.Sum());
                    num++;
                }
            }
            check.Clear();
            num = 0;
        }
        result = result.Distinct().ToList();
        answer = result.Count();
        return answer;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] ints = new int[] { 7, 9, 1, 1, 4 };
        Console.WriteLine(solution.solution(ints));
    }
}
