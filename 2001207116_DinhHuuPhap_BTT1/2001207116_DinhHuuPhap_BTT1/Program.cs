using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001207116_DinhHuuPhap_BTT1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Binary search Main
            int[] arr = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 40;

            int result = binarySearch(arr, 0, n - 1, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                  + result);
            Console.ReadKey();
            #endregion
        }
        /*
        #region 
        //Thuat toan Selection Sort Mang hon loan thanh mang giam dan
        Console.Title = "Selection Sort";
        var numbers = new[] {10, 3, 1, 7, 9, 2, 0};

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int m = i;
            int maxValue = numbers[i];

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j].CompareTo(maxValue) > 0)
                {
                    m = j;
                    maxValue = numbers[j];
                }
            }

            int temp = numbers[i];
            numbers[i] = numbers[m];
            numbers[m] = temp;

                
        }
        Console.ReadKey();
    #endregion
     */

        /*
        #region
        // MegerSort 
        //Link tham khao:https://vietjack.com/bai-tap-csharp/
        List<int> unsorted = new List<int>();// Khoi tao mang va dat ten la chua sap xep de phan biet
        List<int> sorted;//Khoi tao mang sap xep de sap xep xong thi do vao mang nay

        Random random = new Random();
        Console.WriteLine("Sap xep tron (Merge Sort) trong C#:");
        Console.WriteLine("------------------------------------");
            Console.WriteLine("In mang ban dau:");
        for (int i = 0; i < 10; i++)
        {
            unsorted.Add(random.Next(0, 100));
            Console.Write(unsorted[i] + " ");
        }
        Console.WriteLine();

            
        sorted = MergeSort(unsorted);

        Console.WriteLine("\nIn mang da qua sap xep: ");
        foreach (int x in sorted)
        {
            Console.Write(x + " ");
        }
        Console.Write("\n");

        Console.ReadKey();
    }


    private static List<int> MergeSort(List<int> unsorted)
    {
        if (unsorted.Count <= 1)
            return unsorted;

        List<int> left = new List<int>();
        List<int> right = new List<int>();

        int middle = unsorted.Count / 2;
        for (int i = 0; i < middle; i++)  //chia danh sach chua qua sap xep  
        {
            left.Add(unsorted[i]);
        }
        for (int i = middle; i < unsorted.Count; i++)
        {
            right.Add(unsorted[i]);
        }

        left = MergeSort(left);
        right = MergeSort(right);
        return Merge(left, right);
    }

    private static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();

        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left.First() <= right.First())  //so sanh hai phan tu dau tien  
                {                                   //de xem phan tu nao nho hon
                    result.Add(left.First());
                    left.Remove(left.First());      //phan con lai cua list, ngoai tru  
                }                                   //phan tu dau tien
                else
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            else if (left.Count > 0)
            {
                result.Add(left.First());
                left.Remove(left.First());
            }
            else if (right.Count > 0)
            {
                result.Add(right.First());
                right.Remove(right.First());
            }
        }
        return result;
    }
#endregion
         */

        #region
        //Binary search Method

        // Returns index of x if it is present in 
        // arr[l..r], else return -1 
        
        static int binarySearch(int[] arr, int l, int r, int x)//Binary Search Chi Nen Ap Dung cho Mang Tang Hoac Giam, Hon loan se ko hieu qua!
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;//Khoi tao gia tri phan doi Mang bang cach lay 0 + n-1(so luong phan tu tru di 1) /2 (Mang co 5 phan tu nen gia tri mid la 2)

                // If the element is present at the 
                // middle itself 
                if (arr[mid] == x)//Day la vi tri giua mang-> neu nam o day la qua may man
                    return mid;

                // If element is smaller than mid, then 
                // it can only be present in left subarray 
                if (arr[mid] > x)// Nam o phia truoc mang( gia tri giua>gia tri can tim)
                    return binarySearch(arr, l, mid - 1, x);

                // Else the element can only be present 
                // in right subarray 
                //Nam o phia sau mang(gia tri giua < gia tri can tim)
                return binarySearch(arr, mid + 1, r, x);
            }

            // We reach here when element is not present 
            // in array 
            return -1;
        }
        #endregion
   }
}