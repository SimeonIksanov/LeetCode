
using System.Security.Cryptography.X509Certificates;

namespace LeetCode;

public class _1235_MaximumProfitInJobScheduling
{
    public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
    {
        var jobs = CreateJobs(startTime, endTime, profit);

        return FindMaxProfit(jobs);
    }

    private int FindMaxProfit(Job[] jobs)
    {
        if (jobs.Length == 0) return 0;

        var dp = new int[jobs.Length];
        dp[0] = jobs[0].profit;

        for (int i = 1; i < jobs.Length; i++)
        {
            var lastNotConcurent = FindLastNonConcurentJob(jobs, i);
            if (lastNotConcurent == -1)
            {
                dp[i] = Math.Max(jobs[i].profit, dp[i - 1]);
                continue;
            }

            var including = jobs[i].profit + dp[lastNotConcurent];
            var exluding = dp[i - 1];
            dp[i] = Math.Max(including, exluding);
        }

        return dp[jobs.Length - 1];
    }

    private int FindLastNonConcurentJob(Job[] jobs, int index)
    {
        int low = 0, high = index - 1, mid;
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (jobs[mid].end <= jobs[index].start)
            {
                if (jobs[mid + 1].end > jobs[index].start)
                    return mid;
                low = mid + 1;
            }
            else
                high = mid - 1;
        }
        return -1;
    }

    private Job[] CreateJobs(int[] startTime, int[] endTime, int[] profit)
    {
        var jobs = new Job[startTime.Length];
        for (int i = 0; i < startTime.Length; i++)
            jobs[i] = new Job(startTime[i], endTime[i], profit[i]);
        Array.Sort(jobs, new JobComparer());
        return jobs;
    }
}

record Job(int start, int end, int profit);

class JobComparer : IComparer<Job>
{
    public int Compare(Job x, Job y)
    {
        return x.end.CompareTo(y.end);
    }
}
