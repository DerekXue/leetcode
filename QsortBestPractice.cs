using System;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 3, 56, 1, 23, 4,4,15,6,2,3,14,5,-13,-23,6,123,41,45  };
            //bestQsort(array,0,array.Length-1);
            //foreach (var item in array)
            //{
            //    Console.Write(item.ToString()+" ");
            //}
            //Console.ReadKey();
            Console.WriteLine(1 + 3 / 3);

        }

         static int[] BubbleSort(int[] array)
        {
            for(int i = array.Length-1; i >0; i--)
            {
                for(int q = 0; q < i; q++)
                {
                    if (array[q] > array[q + 1])
                    {
                        int temp = array[q];
                        array[q] = array[q + 1];
                        array[q + 1] = temp;
                    }
                }
            }

            return array;
        }

        public static void qsort(int[] arr, int l, int r)
        {
            int i = l;
            int j = r;
            int p = arr[(l + r) / 2];

            while (i < j)
            {
                while (arr[i] < p) i++;
                while (arr[j] > p) j--;
                int t = arr[i];
                arr[i] = arr[j];
                arr[j] = t;
                i++;
                j--;
            }
            if (l < j) qsort(arr, l, j);
            if (r > i) qsort(arr, i, r);
        }

        static void bestQsort(int[] arr, int l,int r)
        {
            int i = l;
            int j = r;
            int p = arr[(l + r) / 2];
            while (i < j)
            {
                while (arr[i] < p) i++;
                while (arr[j] > p) j--;
                int t = arr[i];
                arr[i] = arr[j];
                arr[j] = t;
                i++;
                j--;
            }

            if (l < j) bestQsort(arr, l, j);
            if (i < r) bestQsort(arr, i, r);

        }
    }
}
