//Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element
//appears only once. The relative order of the elements should be kept the same. Since it is impossible to change the length
//of the array in some languages, you must instead have the result be placed in the first part of the array nums. More formally,
//if there are k elements after removing the duplicates, then the first k elements of nums should hold the final results. It
//does not matter what you leave beyond the first k elements. Return the array after placing the final result in the first k 
//slots of nums. Do NOT allocate extra space for another array. You must do this by modifying the input array in-place with O(1)
//extra memory.
//Ex: Input nums = [1, 1, 2]; Output nums = [1, 2, _];
//Your function should return the array with the first two elements of nums being 1 and 2 respectively. It does not matter what
//you leave beyond the returned k (hence the underscores);

namespace CSharp{
    public class removeDuplicatesFromSortedArray{
        public static int[] RemoveDuplicates(int[] nums){

            if(nums.Length <= 1)
                return nums;
            
            int y = 1;
            for(int x = 1; x < nums.Length; x++){
                if(nums[x] != nums[x - 1]){
                    nums[y] = nums[x];
                    y++;
                }
            }

            return nums;
        }
    }
}