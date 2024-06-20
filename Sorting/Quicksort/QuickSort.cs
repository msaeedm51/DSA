public class QuickSortExample
{
    static void Main(string[] args)
    {
        int[] array = { 12, 11, 13, 5, 6, 7, 100, 45, 80, 200, 132, 111 };
        Console.WriteLine("Given Array:");
        Console.WriteLine(string.Join(" ", array));

        QuickSort(array, 0, array.Length - 1);

        Console.WriteLine("\nSorted Array:");
        Console.WriteLine(string.Join(" ", array));
    }
    public static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(array, low, high);
            QuickSort(array, low, partitionIndex - 1);
            QuickSort(array, partitionIndex + 1, high);
        }
    }

    public static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int index = (low - 1);
        for (int j = low; j <= high - 1; j++)
        {
            if (array[j] < pivot)
            {
                index++;
                Swap(array, index, j);
            }
        }
        index++;
        Swap(array, index, high);
        return index;

    }

    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}