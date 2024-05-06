class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        for(int i = n-1; i >= 0; i--) {
            Console.Write(arr[i] + " ");
        }
    }
    //public static void Main(string[] args)
    //{
    //    int n = Convert.ToInt32(Console.ReadLine().Trim());

    //    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
    //    var i = 0;
    //    arr.Reverse();
    //    foreach (var ele in arr)
    //    {
    //        Console.Write(arr[i] + " ");
    //        i++;
    //    }
    //}
}
