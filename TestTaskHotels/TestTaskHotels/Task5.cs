using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskHotels
{
    public class Task5
    {
        private int[] arr1, arr2;

        public Task5(int[] arr1, int[] arr2)
        {
            this.arr1 = arr1;
            this.arr2 = arr2;
        }

        public int[] GetCrossedArray()
        {
            List<int> arr1Doubles = GetDoubles(arr1);
            List<int> arr2Doubles = GetDoubles(arr2);
            List<int> finalList = new List<int>();
            foreach (int i in arr1Doubles)
            {
                if (arr2Doubles.Contains(i))
                {
                    finalList.Add(i);
                }
            }
            return finalList.ToArray();
        }
        private List<int> GetDoubles(int[] arr)
        {
            if (arr.Length < 2)
                return new List<int>();
            List<int> doubles = new List<int>();
            List<int> left = new List<int>();
            int count = 1;
            int element = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (element == arr[i])
                {
                    count++;
                }
                else
                {
                    left.Add(arr[i]);
                }
            }
            int[] doublesRecursion = GetDoubles(left.ToArray()).ToArray();
            foreach (int i in doublesRecursion)
            {
                doubles.Add(i);
            }
            if (count >= 2)
                doubles.Add(element);
            return doubles;

        }
    }
}
