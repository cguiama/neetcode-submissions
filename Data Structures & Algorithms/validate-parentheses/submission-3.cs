public class Solution {
    public bool IsValid(string s) {
        
        var stack = new Stack<char>();

        foreach(char c in s)
        {
            if(c is '(' or '[' or '{')
                stack.Push(c);
            else
            {
                if(stack.Count == 0) return false;
                bool valid = (c, stack.Pop()) switch
                {
                    (')', '(') => true,
                    (']', '[') => true,
                    ('}', '{') => true,
                    _ => false
                };
                if(!valid) return false;
            }       
        }
        return stack.Count == 0;
    }
}
