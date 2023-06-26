// Link https://leetcode.com/problems/text-justification/

namespace LeetCode;

public class _0068_TextJustification
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        var lines = SplitIntoLines(words, maxWidth);

        var formatedLines = new List<string>();
        foreach (var line in lines)
        {
            formatedLines.Add(line.Format());
        }
        return formatedLines;
    }

    class Line
    {
        private readonly int _maxWidth;


        public Line(int maxWidth)
        {
            _maxWidth = maxWidth;
        }


        public readonly List<string> words = new();

        public bool Last = false;

        public int Length
            => words.Sum(x => x.Length) + words.Count - 1;

        public bool CanTake(string word)
            => Length + 1 + word.Length <= _maxWidth;

        public string Format()
        {
            if (words.Count == 1 || Last)
                return FormatLeftJustify();

            return FormatJustify();
        }


        private string FormatJustify()
        {
            var delims = GetSpaceDelimeters();
            return words
                .Skip(1)
                .Zip(delims, (a, b) => string.Format("{0}{1}", b, a))
                .Aggregate(words[0], string.Concat);
        }

        private string FormatLeftJustify()
        {
            return string.Format("{0}{1}", string.Join(' ', words), new string(' ', _maxWidth - Length));
        }

        private string[] GetSpaceDelimeters()
        {
            var totalSpaces = _maxWidth - words.Sum(x => x.Length);
            var delimCount = words.Count - 1;
            var basicSpaceCount = totalSpaces / delimCount;
            var additionalSpaces = totalSpaces % delimCount;
            var spaces = new string[delimCount];
            for (int i = 0; i < delimCount; i++)
            {
                if (additionalSpaces-- > 0)
                    spaces[i] = new string(' ', basicSpaceCount + 1);
                else
                    spaces[i] = new string(' ', basicSpaceCount);
            }
            return spaces;
        }
    }

    private List<Line> SplitIntoLines(string[] words, int maxWidth)
    {
        var lines = new List<Line>();
        int wordIndex = 0;
        while (wordIndex < words.Length)
        {
            var line = new Line(maxWidth);
            lines.Add(line);

            while (wordIndex < words.Length && line.CanTake(words[wordIndex]))
            {
                line.words.Add(words[wordIndex]);
                wordIndex++;
                if (wordIndex >= words.Length)
                    line.Last = true;
            }
        }
        return lines;
    }
}
