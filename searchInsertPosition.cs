//Given a sorted array of distinct integers and a target value, return the index if the target is found. If the target is not
//found, return the index where it would be if it were inserted in order. Your algorithm must run in O(log n) time.
//Ex Input: nums = [1, 3, 5, 6], target = 5 Output: 2
//Ex 2 Input: nums = [1, 3, 5, 6], target = 7 Output: 4 

namespace CSharp{
    
    public class searchInsertPosition{

        public static int SearchInsert(int[] nums, int target){
            int left = 0;
            int right = nums.Length - 1;

            while(left <= right){
                int center = (left + right) / 2;

                if(nums[center] == target){
                    return center;
                }

                else if(nums[center] > target){
                    right = center - 1;
                }

                else{
                    left = center + 1;
                }
            }

            return left;

        }

    }

}