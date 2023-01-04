using System;
using System.Collections;
public class Solution
{
    public int solution(int[] common)
    {
        int answer = 0;
        if(common[0] - common[1] == common[1] - common[2])
        {
            int m = common[2] - common[1];
            answer = common[^1] + m;
        }
        else
        {
            int m = common[2] / common[1];
            answer = common[common.Length - 1] * m;
        }
        return answer;  
    }
}
class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] common = new int[] {2,4,8,16};
        Console.WriteLine(solution.solution(common));
    }
}


