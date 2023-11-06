using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        SearchMultyFly(3);
    }

    public static void SearchMultyFly(int val)
    {
        int[] nums = Enumerable.Range(1, 10).ToArray();
        var query = from num in nums
                    where (num % val) == 0
                    select num;

        foreach (var item in query)
        {
            Console.WriteLine(item);
        }
    }
}