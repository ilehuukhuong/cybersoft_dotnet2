namespace baitapvenhabuoi8
{
    public class Bai3
    {
        public static int XoaBoPhanTuTrungNhau(List<int> numbers)
        {
            List<int> result = [numbers[0]];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1]) result.Add(numbers[i]);
            }
            return result.Count;
        }
    }
}