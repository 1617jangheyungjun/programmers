using System;

public class Solution {
    public int[] solution(int[] array)
    {
        int[] answer = new int[] {};
        for(int i = 0; i < solution.Count; i++)
        {
            if(solution[i] > solution[i-1]);
            {
                if(answer.Count == 0)
                {
                    answer.Add(solution[i]);
                    answer.Add(i);
                }
                else
                {
                    answer.RemoveAt(0,1);
                }
            }
        }
        return answer;
    }

class program
{
    static void Main(string[] args)
    {
        Solution.solution([1,8,3]);
    }
}
}