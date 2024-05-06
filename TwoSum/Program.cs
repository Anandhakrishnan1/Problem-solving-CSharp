class Solution
{
    public static void Main(string[] args)
    {
        var nums = new List<int> { 2, 7, 11, 15 };
        var target = 9;
        var result = TwoSum(nums, target);
        Console.WriteLine(string.Join(",",result));
    }

    private static int[] TwoSum(List<int> nums, int target)
    {
        for(var i  = 0; i < nums.Count; i++)
        {
            for (var j = i+1; j < nums.Count; j++)
            {
                if ((nums[i] + nums[j]) == target)
                {
                    return new int[] {i, j};
                }
            }
        }
        return new int[0];
    }
}