public class Solution {
    public static void FindMaxAndMin(int[] array)
    {
        int min = array[0];
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }

            if(array[i] > max)
            {
                max = array[i];
            }
        }

        Console.WriteLine($"[{min},{max}]");
    }

    static void Main(string[] args)
    {
        int[] array = { 2, 3, 5, -3, -2, 1, 6 };
        FindMaxAndMin(array);
    }
}