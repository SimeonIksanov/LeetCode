// Link https://leetcode.com/problems/valid-parentheses/

namespace LeetCode;

public class _0020_ValidParentheses
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        var bracketPairs = new Dictionary<char, char> { { ')', '(' }, { ']', '[' }, { '}', '{' } };
        var openBrackets = new HashSet<char> { '(', '{', '[' };
        for (int i = 0; i < s.Length; i++)
        {
            if (openBrackets.Contains(s[i]))
            {
                stack.Push(s[i]);
                continue;
            }

            if (stack.Count > 0)
            {
                var onTop = stack.Peek();
                if (onTop == bracketPairs[s[i]])
                {
                    _ = stack.Pop();
                    continue;
                }
            }

            stack.Push(s[i]);
        }

        return stack.Count == 0;
    }
}

