using System;

namespace CSharp
{
    public class main
    {
        static void Main(string[] args){
            int[] nums = {1, 1, 1, 2, 2, 3, 4, 5, 7, 8, 8, 10, 12, 37, 52, 100};
            int[] sortedArr = removeDuplicatesFromSortedArray.RemoveDuplicates(nums);
            Console.WriteLine("[{0}]", string.Join(", ", sortedArr));
        }
    }
}
