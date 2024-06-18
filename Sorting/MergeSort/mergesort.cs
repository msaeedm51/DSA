using System;

class MergeSortExample
{
    // Merge function to merge two subarrays
    static void Merge(int[] array, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        // Temporary arrays
        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        // Copy data to temporary arrays
        Array.Copy(array, left, leftArray, 0, n1);
        Array.Copy(array, middle + 1, rightArray, 0, n2);

        // Initial indexes of the temporary arrays
        int i = 0, j = 0;
        int k = left; // Initial index of merged subarray

        while (i < n1 && j < n2)
        {
            if (leftArray[i] <= rightArray[j])
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }

        // Copy remaining elements of leftArray[], if any
        while (i < n1)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }

        // Copy remaining elements of rightArray[], if any
        while (j < n2)
        {
            array[k] = rightArray[j];
            j++;
            k++;
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
