public class BubbleSortExample
{
    public static void BubbleSort(int[] array, int length)
    {
        int i = 0, j, temp;
        bool swapped;
        for (; i < length; i++)
        {
            swapped = false;
            for (j = 0; j < length - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            if (swapped == false)
            {
                break;
            }
        }


    }

    static void Main(string[] args)
    {
        int[] array = { 12, 11, 13, 5, 6, 7, 100, 45, 80, 200, 132, 111 };
        Console.WriteLine("Given Array:");
        Console.WriteLine(string.Join(" ", array));

        BubbleSort(array, array.Length - 1);

        Console.WriteLine("\nSorted Array:");
        Console.WriteLine(string.Join(" ", array));
    }

}