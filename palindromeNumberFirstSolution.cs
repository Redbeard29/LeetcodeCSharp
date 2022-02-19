using System;

namespace CSharp
{
    public class palindromeNumberFirstSolution
    {
        public bool isPalindrome(int x){
            string intAsString = x.ToString();
            StringBuilder reversedInt = new StringBuilder();
            
            if(x < 0){
                return false;
            }
            
            for(int idx = intAsString.Length - 1; idx >= 0; idx--){
                reversedInt.Append(intAsString[idx]);
            }
            
            return intAsString == reversedInt.ToString();
        }
        
    }
}
