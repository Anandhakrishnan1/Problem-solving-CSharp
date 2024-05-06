class Solution
{
    static void Main(String[] args)
    {
        string odd = "";
        string even = "";
        var N = Convert.ToInt32(Console.ReadLine());
        var str = new List<string>();
        for(int j = 0; j< N; j++)
        {
            string S = Console.ReadLine();
            var length = S.Length;
            for (int i = 0; i < length; i++)
            {
                if (i == 0 || i % 2 == 0)
                {
                    even = string.Concat(even, S[i]);
                }
                else
                {
                    odd = string.Concat(odd, S[i]);
                }
            }
            str.Add(string.Concat(even," ",  odd));
            odd = "";
            even = "";
        }
        foreach(string s in str)
        {
            Console.WriteLine(s);
        }
        
    }
}