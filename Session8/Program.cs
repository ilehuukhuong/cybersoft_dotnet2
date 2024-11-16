using Session8;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> lst = new List<int> { 2, 7, 9, 11, 15 };

        int target = 26;
        List<int> ans = new List<int>();
        ans = TwoSum.TwoSumDictionary(lst, target);
        if (ans == null)
        {
            Console.WriteLine("Không có hai số nào có thể ");
        }
        else
        {
            Console.WriteLine($"Chỉ số 2 só có tổng bằng target là: {string.Join(',', ans)}");
        }
    }
}