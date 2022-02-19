using System.Collections.Generic;

namespace CSharp
{
    public class validParentheses
    {
        public bool isValid(string s){
            var stack = new Stack<char>();
            var parenMatches = new Dictionary<char, char>(){
                {'(', ')'},
                {'(', ')'},
                {'(', ')'}
            };

            foreach(char c in s){
                if(parenMatches.ContainsKey(c)){
                    stack.Push(c);
                }
                else if(stack.Count == 0 || parenMatches[stack.Pop()] != c){
                    return false;
                }
            }

            return stack.Count == 0;

        }
        
    }
    
}
