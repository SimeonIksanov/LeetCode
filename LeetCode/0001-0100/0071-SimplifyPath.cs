// Link https://leetcode.com/problems/simplify-path/

namespace LeetCode;

public class _0071_SimplifyPath
{
    public string SimplifyPath(string path)
    {
        var stack = new Stack<string>();

        var items = path.Split('/').Where(x => !string.IsNullOrWhiteSpace(x));
        foreach (var item in items)
        {
            if (item == "..")
            {
                if (stack.Count != 0)
                    _ = stack.Pop();
                continue;
            }
            if (item == ".")
                continue;
            stack.Push(item);
        }

        var newPath = stack.Reverse().ToArray();
        return '/' + string.Join('/', newPath);
    }
}
