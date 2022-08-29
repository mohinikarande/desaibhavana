
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int[] arr = { 5, 8, 10, 18, 50 };
                int n = arr.Length;
                int x = 10;
                int result = binarySearch(arr, 0, n - 1, x);

                if (result == -1)
                    Console.WriteLine("Element is not present :");
                else
                    Console.WriteLine("Element is found at index :  " + result);
            }
            int binarySearch(int[] arr, int l, int r, int x)
            {
                if (r >= l)
                {
                    int mid = l + (r - l) / 2;
                
                if (arr[mid] == x)
                    return mid;



                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                return binarySearch(arr, mid + 1, r, x);
}

                return -1;            
        }
               Console.ReadLine();      
  }


            }
        }
     