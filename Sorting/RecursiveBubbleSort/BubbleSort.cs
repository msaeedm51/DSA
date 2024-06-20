public class BubbleSortExample
{
   public static void RecursiveBubbleSort(int[] array, int length)
        {
            if (length == 0)
                return;


            int count = 0;

            for (int i = 0; i < length; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    count++;
                }
            }

            if (count == 0)
                return;

            RecursiveBubbleSort(array, length - 1);
        }
    static void Main(string[] args)
    {
        int[] array = { 12, 11, 13, 5, 6, 7, 100, 45, 80, 200, 132, 111 };
        Console.WriteLine("Given Array:");
        Console.WriteLine(string.Join(" ", array));

        RecursiveBubbleSort(array, array.Length - 1);

        Console.WriteLine("\nSorted Array:");
        Console.WriteLine(string.Join(" ", array));
    }

}