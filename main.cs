using System;

namespace CSharp
{
    public class main
    {
        static void Main(string[] args){
            string[] strs = {"flower", "flow", "flight"};
            string prefix = longestCommonPrefix.LongestCommonPrefix(strs);
            Console.WriteLine(prefix);
        }
    }
}
