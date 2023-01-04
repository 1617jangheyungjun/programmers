using System;
using System.Linq;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

public class Solution
{
    public int solution(int[] queue1, int[] queue2)
    {
        int answer = -2;
        Stack queue_1 = new Stack();
        Stack queue_2 = new Stack();
        for(int i = 0; i < queue1.Length;)
        {
            queue_1.Push(queue1[i]);
            queue_2.Push(queue2[i]);
        }
        if  (queue1.Sum() - queue2.Sum() < 0)
        {
            int x = queue2.Sum() - queue1.Sum();
            var index1 = queue_2.Pop(Array.IndexOf(queue2, x));
        }
        else
        {
            int x = queue1.Sum() - queue2.Sum();
            var index1 = queue_1.Pop(Array.IndexOf(queue2, x));
        }
        
        return answer;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] ints = new int[] { 3, 2, 7, 2 };
        int[] intz = new int[] { 4, 6, 5, 1 };
        Console.WriteLine(solution.solution(ints, intz));
    }
}