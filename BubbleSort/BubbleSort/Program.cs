using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
       
            static void bubbleSort(int[] arr, int n)

            {

                int i, j, temp;

                bool swapped;

                for (i = 0; i < n - 1; i++)

                {

                    swapped = false;

                    for (j = 0; j < n - i - 1; j++)

                    {

                        if (arr[j] > arr[j + 1])

                        {

                           

                            temp = arr[j];

                            arr[j] = arr[j + 1];

                            arr[j + 1] = temp;

                            swapped = true;

                        }

                    }

                   

                    if (swapped == false)

                        break;

                }

            }

           

            static void printArray(int[] arr, int size)

            {

                int i;

                for (i = 0; i < size; i++)

                    Console.Write(arr[i] + " ");

                Console.WriteLine();

            }


            public static void Main()

            {

                int[] arr = { 84, 44, 35, 12, 33, 11, 80 };

                int n = arr.Length;

                bubbleSort(arr, n);

                Console.WriteLine("Sorted array");

                printArray(arr, n);
             Console.ReadLine();

            }

        }
    }
    

