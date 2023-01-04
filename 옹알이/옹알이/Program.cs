using System;

public class Solution
{
    public int solution(string[] babbling)
    {
        int answer = 0;
        string[] check = new string[] { };
        for(int i = 0; i < babbling.Length; i++)
        {
            string x = babbling[i];
            x = x.Replace("aya", "!").Replace("ye", "@").Replace("woo", "#").Replace("ma", "$");
            x = x.Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");
            if (x.Length == 0)
            {
                answer++;
            }
        }

        return answer;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        string[] babbling = new string[] {"ayaye", "uuuma", "ye", "yemawoo", "ayaa"};
        Console.WriteLine(solution.solution(babbling));
    }
}