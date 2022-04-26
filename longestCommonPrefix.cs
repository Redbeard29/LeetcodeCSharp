//Write a function to find the longest common prefix string amongst an array 
//of strings. If there is no common prefix, return an empty string "".
//Ex: Input = ["flower", "flow", "flight"], Output = "fl"
//Ex2: Input = ["dog", "racecar", "car"], Output = ""

namespace CSharp{

    public class longestCommonPrefix{

        public static string LongestCommonPrefix(string[] strs){

            if(strs.Length == 0) return "";

            string prefix = strs[0];

            for(int x = 1; x < strs.Length; x++){
                while(strs[x].IndexOf(prefix) != 0){
                    prefix = prefix.Substring(0, prefix.Length - 1);
                }
            }

            return prefix;
        }
    }

}