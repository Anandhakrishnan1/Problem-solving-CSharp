class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        for (int i = 1; i <= 10; i++) 
        {
            Console.WriteLine(n +" x "+ i +" = "+ (n*i));
        }
    }
}
