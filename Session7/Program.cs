using Session7;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        #region function trong List cuar Collection
        // //khoiwr taoj danh sachs
        // List<int> numbers = new List<int>();
        // //nhaapj n tuwf banf phims voiws n laf soos luonwgj phaaafn tuwr cuar mangr
        // Console.Write("Mời bạn nhập số phần tử nhập vào: ");
        // string? n = Console.ReadLine();
        // int formatNumber = Convert.ToInt32(n);
        // for (int i = 0; i < formatNumber; i++)
        // {
        //     Console.Write($"Mời bạn nhập số thứ {i + 1}: ");
        //     int number = Convert.ToInt32(Console.ReadLine());
        //     numbers.Add(number);
        // }
        // Console.WriteLine();
        // Console.WriteLine("Danh sách phần tử đã nhập là !");
        // int j = 0;
        // foreach (int number in numbers)
        // {
        //     j++;
        //     Console.WriteLine($"Số thứ {j} là {number}");
        // }

        // // dùng function sort để sắp xếp phần tử của mảng
        // numbers.Sort();
        // Console.WriteLine("Danh sách phần tử đã sắp xếp: ");
        // j = 0;
        // foreach (int number in numbers)
        // {
        //     j++;
        //     Console.WriteLine($"Số thứ {j} là {number}");
        // }

        // //dùng function Reverse()
        // Console.WriteLine("Danh sách phần tử sau khi dùng hàm Reverse: ");
        // numbers.Reverse();
        // Console.WriteLine(String.Join(",", numbers));
        #endregion

        #region Tính tổng các số lớn hơn 50 trong mảng
        // List<int> numbers = new List<int>{
        //     20,50,60,10,30,90,100,40,70
        // };
        // Console.WriteLine($"Tổng các số lớn hơn 50 là {Bai1.TinhTongSoLonHon50(numbers)}");
        #endregion

        #region Tìm số lớn nhất của mảng
        // List<int> numbers = new List<int>
        // {20,50,60,10,30,90,100,40,70};
        // Console.WriteLine($"Số lớn nhất là {Bai2.TimSoLonNhat(numbers)}");
        #endregion

        #region Bai3
        // List<string> strings= new List<string>{
        //     "mango",
        //     "lemon",
        //     "me",
        //     "mang cau",
        //     "apple"
        // };
        // Console.WriteLine(string.Join(",",Bai3.TimChuoiBatDauLaM(strings)));
        #endregion

        #region Bai4
        // List<int> numbers = new List<int> { 1, 1, 1, 2, 2, 3, 3, 3, 4, 4, 5, 5, 6, 6 };
        // Console.WriteLine(string.Join(",", Bai4.XoaBoPhanTuTrungNhau(numbers)));
        #endregion

        #region Tim hieu ve dictionary trong collection
        Dictionary<string, string> dic = new Dictionary<string, string>
        {
            //them key-value vao dic
            { "Alice", "test" },
            { "Bob", "string" }
        };
        dic.Add("Nam", "as");
        dic["Do"] = "Nam Trung";

        //duyeetj dic
        foreach (KeyValuePair<string, string> pointer in dic)
        {
            //pointer: key - value
            Console.WriteLine($"Hoj: {pointer.Key}, Teen: {pointer.Value}");
        }

        //duyeetj mooix key hoacjw value => y chang nhuw been list
        //chir duyeetj key
        Console.WriteLine("Cacs Key laf:");
        foreach (string str in dic.Keys)
        {
            Console.WriteLine(str);
        }
        //Cachs 2
        for (int i = 0; i < dic.Keys.Count; i++)
        {
            Console.WriteLine(dic.Keys.ElementAt(i));
        }
        //update value cho dic
        dic["Alice"] = "Johson";
        Console.WriteLine("Dic sau khi update");
        foreach (KeyValuePair<string, string> pointer in dic)
        {
            Console.WriteLine($"Hoj: {pointer.Key}, Teen: {pointer.Value}");
        }

        //delete key value
        dic.Remove("Alice");
        Console.WriteLine("Dic sau khi remove");
        foreach (KeyValuePair<string, string> pointer in dic)
        {
            Console.WriteLine($"Hoj: {pointer.Key}, Teen: {pointer.Value}");
        }
        #endregion
    }
}