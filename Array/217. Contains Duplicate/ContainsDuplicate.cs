public class Solution {
    public static bool ContainsDuplicate(int[] nums) {
        Dictionary<int,int> d = new Dictionary<int,int>();
        for(int j = 0; j < nums.Length; j++)
        {
            if(d.ContainsKey(nums[j]))
            {
                return true;
            }

            d.TryAdd(nums[j],1);
        }

        return false;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(IsAnagram("anagram", "nagaram"));
        Console.WriteLine(IsAnagram("Test DSA", "Tesi DAS"));
    }
}