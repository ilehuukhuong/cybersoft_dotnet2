using baitapvenhabuoi8;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Bai 1
        // int[] IstNumber = { 20, 81, 97, 63, 72, 11, 20, 15, 33, 15, 41, 20 };
        // Console.WriteLine($"Tổng các số trong mảng là: {Bai1.TinhTong}");
        #endregion

        #region Bai 2
        // List<int> ints = new List<int>() { 2, 7, 11, 15 };
        // int target = 9;
        // List<int> ans = new List<int>();
        // ans = Bai2.TwoSumDictionary(ints, target);
        // if (ans == null)
        // {
        //     Console.WriteLine("Không có hai số nào có thể ");
        // }
        // else
        // {
        //     Console.WriteLine($"Chỉ số 2 só có tổng bằng target là: {string.Join(',', ans)}");
        // }
        #endregion

        #region Bai 3
        // List<int> numbers = new List<int> { 1, 1, 1, 2, 2, 3, 3, 3, 4, 4, 5, 5, 6, 6 };
        // Console.WriteLine(Bai3.XoaBoPhanTuTrungNhau(numbers));
        #endregion

        #region Bai 4
        List<int> nums = new List<int>() { 1, 1, 1, 2, 2, 3 };
        int k = 2;
        Console.WriteLine("Phần tử xuất hiện nhiều nhất: [" + string.Join(", ", Bai4.SoLanXuatHien(nums, k)) + "]");
        #endregion

        #region Bai 5
        List<int> prices = new List<int>() { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine("Lợi nhuận lớn nhất là: " + Bai5.BestDay(prices));
        #endregion
    }
}