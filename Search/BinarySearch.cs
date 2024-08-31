using System;

public class BinarySearch
{
    public static void Main(string[] args)
    {
        int[] arr = new int[]{1,2,3,5,7,9,10,11,13,15,16,18, 20};
        int returnIndex = BinarySearch(arr, 20);
        Console.WriteLine (returnIndex);
    }
    
    public static int BinarySearch(int[] filterData, int key)
    {
        int min = 0, max = filterData.Length - 1;
        while(min <= max)
        {
            int mid = (min + max) / 2;
            if(key == filterData[mid])
            {
                return mid;
            }
            
            if(key < filterData[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
            
        }
        
        return -1;
    }
}