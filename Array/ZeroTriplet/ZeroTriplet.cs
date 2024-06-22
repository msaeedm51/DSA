public class Solution {
    public static void FindZeroTriplet(int[] array)
    {
        for (int i = 0; i < array.Length - 2; i++)
        {
            for (int j = i + 1; j < array.Length - 1; j++)
            {
                for (int k = j + 1; k < array.Length; k++)
                {
                    if (array[i] + array[j] + array[k] == 0)
                    {
                        Console.WriteLine($"[{array[i]},{array[j]},{array[k]}]");
                    }
                }
            }
        }
    }

    static void Main(string[] args)
    {
        int[] array1 = { 2, 3, 5, -3, -2, 1, 6 };
        FindZeroTriplet(array1);
    }
}