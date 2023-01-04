using System;
public class Solution
{
    public int[] solution(int[] array)
    {
        int[] answer = new int[2];
        {
            int k = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    k = i;
                }
                else
                {
                    k = i + 1;
                }
            }
            answer[0] = array[k];
            answer[1] = k;
        }
        return answer;
    }
        
}
class Program
{
    static void Main(string[] args)
    {
        int[] check = new int[3] { 1, 8, 3 }


        Console.WriteLine(Solution.solution(check))
    }
}