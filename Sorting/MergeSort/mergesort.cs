using System;

class MergeSortExample
{
    // Merge function to merge two subarrays
    public static void Merge(int[] array, int left, int mid, int right)
        {
            int leftArrayLength = mid - left + 1;
            int rightArrayLength = right - mid;
            int[] leftArray = new int[leftArrayLength];
            int[] rightArray = new int[rightArrayLength];

            for (int l = 0; l < leftArrayLength; l++)
            {
                leftArray[l] = array[left + l];
            }

            for (int r = 0; r < rightArrayLength; r++)
            {
                rightArray[r] = array[mid + 1 + r];
            }

            int li = 0;
            int ri = 0;
            int mi = left;

            while (li < leftArrayLength && ri < rightArrayLength)
            {
                if (leftArray[li] <= rightArray[ri])
                {
                    array[mi] = leftArray[li];
                    li++;
                }
                else
                {
                    array[mi] = rightArray[ri];
                    ri++;
                }
                mi++;
            }

            while (li < leftArrayLength)
            {
                array[mi] = leftArray[li];
                li++;
                mi++;
            }

            while (ri < rightArrayLength)
            {
                array[mi] = rightArray[ri];
                ri++;
                mi++;
            }


        } 

    // MergeSort function
    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = left + (right - left) / 2;

            // Sort first and second halves
            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);

            // Merge the sorted halves
            Merge(array, left, middle, right);
        }
    }

    // Main function to test the MergeSort algorithm
    static void Main(string[] args)
    {
        int[] array = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Given Array:");
        Console.WriteLine(string.Join(" ", array));

        MergeSort(array, 0, array.Length - 1);

        Console.WriteLine("\nSorted Array:");
        Console.WriteLine(string.Join(" ", array));
    }
}
