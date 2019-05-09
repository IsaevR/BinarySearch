using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search");
            int[] array = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30};
            int size = array.Length;
            int val  = 28;
            Console.WriteLine("Binary Search result: " + BinarySearch(array, size, val));
        }
        public static int BinarySearch(int[] arr, int size,int value)
        {
            int mid ;
            int low = 0;
            int high = size - 1;

            while(low <= high)
            {
                mid = low + (high -low)/2; // Чтобы избежать переполнения
                if(arr[mid] == value)
                {
                    return mid;
                }
                else if(arr[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }

    }

}
