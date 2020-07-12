using System;
using System.Globalization;

namespace Remove_Duplicates_from_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            Console.WriteLine((RemoveDuplicates(nums)));
            Console.WriteLine("Hello World!");
        }
        public static int RemoveDuplicates(int[] nums)
        {
            int len = nums.Length - 1;
            int k = 0;
            int i = 0;
            while (i <= len)
            {
                int j = i + 1;
                nums[k++] = nums[i];
                while (j <= len && nums[i] == nums[j]) j++;
                i = j;
            }

            return k;
        }
    }
}
