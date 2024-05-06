class Solution
{
    public static void Main(string[] args)
    {
        var students = new List<int> { 1, 1, 1, 0, 0, 1 };
        var sandwiches = new List<int> { 1, 0, 0, 0, 1, 1 };
        var result = CountStudents(students, sandwiches);
        Console.WriteLine(result);

    }
    public static int CountStudents(List<int> students, List<int> sandwiches)
    {
        var count = sandwiches.Count;
        for(int x = 0; x < count; x++)
        {
            int i = 0, j = 0;
            while (j < students.Count)
            {
                if (!(sandwiches[i] == students[i]))
                {
                    students.Add(students[i]);
                    students.RemoveAt(i);
                }
                else
                {
                    students.Remove(students[i]);
                    sandwiches.Remove(sandwiches[i]);
                }
                j++;
            }
        }
        return students.Count;
    }
}
