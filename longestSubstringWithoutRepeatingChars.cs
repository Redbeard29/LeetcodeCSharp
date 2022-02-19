using System;

namespace CSharp
{
    public class longestSubstringWithoutRepeatingChars
    {

    public int getLengthOfLongestSubstring(string s) {
        
        int start = 0;
        int longestSub = 0;
        
        Dictionary<char, int> charIndexDict = new Dictionary<char, int>();
        
        for(int end = 0; end < s.Length; end++){
            
            if(!(charIndexDict.ContainsKey(s[end]))){
                charIndexDict.Add(s[end], end);
            }
            
            else{
                if(end - start > longestSub){
                    longestSub = end - start;
                }
                
                start = end;
            }
            
        }
        
        foreach(KeyValuePair<char, int> kvp in charIndexDict){
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
        }
        
        return longestSub;
            
    }
    }
}
