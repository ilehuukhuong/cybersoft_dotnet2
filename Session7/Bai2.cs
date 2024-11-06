namespace Session7
{
    public class Bai2
    {
        public static int TimSoLonNhat(List<int> numbers)
        {
            int max = numbers.ElementAt(0);
            foreach (int numberItem in numbers)
                if (numberItem > max) max = numberItem;
            return max;
        }
    }
}