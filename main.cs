using System;

namespace CSharp
{
    public class main
    {
        static void Main(string[] args){
            int[] nums = {1, 2, 3, 4, 5, 7, 8, 10, 12, 37, 52, 100};
            int index = searchInsertPosition.SearchInsert(nums, 11);
            Console.WriteLine(index);
        }
    }
}
