using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        SearchMultyFly(3);
        SearchMulty();
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

    public static void SearchMulty()
    {
        int[] index = Enumerable.Range(1, 10).Where(x => x % 3 == 0).Select((x, y) => y).ToArray(); // Index
        int[] value = Enumerable.Range(1, 10).Where(x => x % 3 == 0).Select((x, y) => x).ToArray(); // Value

        for (int i = 0; i < index.Length; i++) 
        {
            Console.WriteLine($"{index[i]} = {value[i]}");
        }
    }
}