
public class Program
{
    static void Main(string[] args)
    {
        string[] nums = Console.ReadLine().Split(" ");
        int n = int.Parse(nums[0]);
        int m = int.Parse(nums[1]);
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            set.Add(num);
        }
        HashSet<int> res = new HashSet<int>();
        for (int i = 0; i < m; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (set.Contains(num))
            {
                res.Add(num);
            }
        }
        foreach (int item in set)
        {
            if (res.Contains(item))
            {
                Console.Write(item + " ");
            }
        }
    }
}

