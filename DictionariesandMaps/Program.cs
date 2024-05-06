class Program
{
    public static void Main(String[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        var phoneBook = new Dictionary<string, int>();
        var nameList = new List<string>();
        for (int i = 0; i < n; i++)
        {
            string[] entry = Console.ReadLine().TrimEnd().Split(' ');
            var name = entry[0];
            var number = Convert.ToInt32(entry[1]);
            phoneBook[name]= number;
        }
        while (true)
        {
            var name = Console.ReadLine();
            if (name == null ||name == "") 
            {
                break;
            }
            nameList.Add(name);
        }
        foreach(var name in nameList)
        {
            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine(name + "=" + phoneBook[name].ToString());
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}