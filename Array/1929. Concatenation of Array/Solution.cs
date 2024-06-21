public class Solution {
    public static int[] GetConcatenation(int[] nums) {
        int[] sNums = new int[nums.Length * 2];
        for(int j = 0; j < nums.Length; j++)
        {
            sNums[j] =nums[j];
            sNums[nums.Length + j] = nums[j];
        }

        return sNums;
    }

    static void Main(string[] args)
    {
        int[] array = { 12, 11, 13, 5, 6, 7, 100, 45, 80, 200, 132, 111 };
        Console.WriteLine(GetConcatenation(array));
    }
}