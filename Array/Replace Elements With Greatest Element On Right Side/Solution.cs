public class Solution {
    public static int[] ReplaceElements(int[] arr) {
       int max = -1;
       for(int j = arr.Length -1; j >= 0; j--)
       {
           int newMax = arr[j] > max ? arr[j] : max;
           arr[j] = max;
           max = newMax;
           
       }

       return arr;
    }

 static void Main(string[] args)
    {
      int[] array = { 12, 11, 13, 5, 6, 7, 100, 45, 80, 200, 132, 111 };
      Console.WriteLine(ReplaceElements(array));
    }
}

