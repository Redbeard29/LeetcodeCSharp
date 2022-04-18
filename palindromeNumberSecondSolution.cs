using System;

namespace CSharp
{
    public class palindromeNumberSecondSolution
    {
        public static bool isPalindrome(int x){

            if(x < 0){
                return false;
            }
            
            string intAsString = x.ToString();

            int left = 0;
            int right = intAsString.Length - 1;

            while(left <= right){
                if(intAsString[left] != intAsString[right]){
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
        
    }
    
}
