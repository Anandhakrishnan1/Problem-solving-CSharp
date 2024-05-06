using System;
using System.Collections.Generic;

class Solution
{
    public static void Main(string[] args)
    {
        var tickets = new List<int> { 83, 86, 38, 31, 59, 25, 89, 71, 54, 71, 84 };
        var k = 1;
        var result = CountStudents(tickets, k);
        Console.WriteLine(result);
    }

    public static int CountStudents(List<int> tickets, int k)
    {
        var time = 0;
        while (tickets[k] > 0)
        {
            for (int i = 0; i < tickets.Count; i++) 
            {
                if (tickets[i] > 0)
                {
                    tickets[i]--;
                    time++;
                    if (i == k && tickets[k] == 0)
                    {
                        return time;
                    }
                }
            }
        }
        return time;
    }
}
