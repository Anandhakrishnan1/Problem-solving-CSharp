class Program
{
    public static void Main(string[] args)
    {
        var limit =  Convert.ToInt32(Console.ReadLine());
        int a = 0, b = 1, c = 0;

        Console.WriteLine(string.Format("Your fibinocii series on limit {0} is below; \n", limit));
        for (int i = 0; i < limit; i++)
        {
            Console.WriteLine(c);
            a = b;
            b = c;
            c = a + b;
        }
    }
}

