// Link: https://leetcode.com/problems/strong-password-checker/

using System.Text.RegularExpressions;

namespace LeetCode;

public class _0420_StrongPasswordChecker
{
    public int StrongPasswordChecker(string password)
    {
        bool hasUpperCaseLetter = false;
        bool hasLowerCaseLetter = false;
        bool hasDigit = false;
        int insertUpdateStepCount = 0, deleteStepCount = 0;
        var repeatingGroups = new List<int>();
        char prevChar = char.MinValue;
        int prevCharCount = 1;

        foreach (char ch in password)
        {
            if (char.IsLower(ch)) hasLowerCaseLetter = true;
            if (char.IsUpper(ch)) hasUpperCaseLetter = true;
            if (char.IsDigit(ch)) hasDigit = true;

            if (ch == prevChar)
            {
                prevCharCount++;
            }
            else
            {
                if (prevCharCount >= 3)
                    repeatingGroups.Add(prevCharCount);
                prevCharCount = 1;
            }
            prevChar = ch;
        }
        if (prevCharCount >= 3)
        {
            repeatingGroups.Add(prevCharCount);
        }

        if (!hasDigit) insertUpdateStepCount++;
        if (!hasLowerCaseLetter) insertUpdateStepCount++;
        if (!hasUpperCaseLetter) insertUpdateStepCount++;

        if (password.Length + insertUpdateStepCount < 6)
            insertUpdateStepCount += 6 - password.Length - insertUpdateStepCount;

        if (password.Length > 20)
        {
            RemoveFromRepeatingGroups(password.Length, repeatingGroups);
            deleteStepCount = password.Length - 20;
        }

        var c = repeatingGroups.Select(c => c / 3).Sum();
        insertUpdateStepCount += insertUpdateStepCount >= c ? 0 : c - insertUpdateStepCount;

        return insertUpdateStepCount + deleteStepCount;
    }

    private void RemoveFromRepeatingGroups(int length, List<int> repeatingGroups)
    {
        int extra = length - 20;
        bool flag = true;
        while (extra > 0 && repeatingGroups.Any(x => x > 2) && flag)
        {
            flag = false;
            for (int k = 1; k <= 3; k++)
                for (int i = 0; i < repeatingGroups.Count; i++)
                    if (repeatingGroups[i] >= 3
                        && StepsCountToDecreaseReplaceCount(repeatingGroups[i]) == k
                        && extra >= k)
                    {
                        repeatingGroups[i] -= k;
                        extra -= k;
                        flag = true;
                    }
        }
    }

    private int StepsCountToDecreaseReplaceCount(int groupLength) => groupLength % 3 + 1;
}
