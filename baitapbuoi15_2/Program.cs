namespace baitapbuoi15_2;
internal class Program
{
    private static void Main(string[] args)
    {
        QuanLySanPham quanLySanPham = new QuanLySanPham();

        while (true)
        {
            Console.WriteLine("\n===== MENU QUẢN LÝ SẢN PHẨM =====");
            Console.WriteLine("1. Thêm sản phẩm");
            Console.WriteLine("2. Hiển thị danh sách sản phẩm");
            Console.WriteLine("3. Tính tổng doanh thu dự kiến");
            Console.WriteLine("4. Xóa sản phẩm");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng (1-5): ");

            string luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1":
                    ThemSanPham(quanLySanPham);
                    break;
                case "2":
                    quanLySanPham.HienThiSanPham();
                    break;
                case "3":
                    Console.WriteLine($"Tổng doanh thu dự kiến: {quanLySanPham.TinhTongDoanhThu():F2}");
                    break;
                case "4":
                    Console.Write("Nhập mã sản phẩm cần xóa: ");
                    string maSanPham = Console.ReadLine();
                    quanLySanPham.XoaSanPham(maSanPham);
                    break;
                case "5":
                    Console.WriteLine("Thoát chương trình.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }

    private static void ThemSanPham(QuanLySanPham quanLySanPham)
    {
        Console.WriteLine("Chọn loại sản phẩm:");
        Console.WriteLine("1. Điện tử");
        Console.WriteLine("2. Thời trang");
        Console.WriteLine("3. Thực phẩm");
        Console.Write("Lựa chọn: ");
        string loai = Console.ReadLine();

        Console.Write("Nhập mã sản phẩm: ");
        string maSanPham = Console.ReadLine();

        Console.Write("Nhập tên sản phẩm: ");
        string tenSanPham = Console.ReadLine();

        Console.Write("Nhập giá gốc: ");
        double giaGoc = double.Parse(Console.ReadLine());

        switch (loai)
        {
            case "1":
                Console.Write("Nhập thuế bảo hành: ");
                double thueBaoHanh = double.Parse(Console.ReadLine());
                quanLySanPham.ThemSanPham(new DienTu(maSanPham, tenSanPham, giaGoc, thueBaoHanh));
                break;
            case "2":
                Console.Write("Nhập mức giảm giá: ");
                double giamGia = double.Parse(Console.ReadLine());
                quanLySanPham.ThemSanPham(new ThoiTrang(maSanPham, tenSanPham, giaGoc, giamGia));
                break;
            case "3":
                Console.Write("Nhập phí vận chuyển: ");
                double phiVanChuyen = double.Parse(Console.ReadLine());
                quanLySanPham.ThemSanPham(new ThucPham(maSanPham, tenSanPham, giaGoc, phiVanChuyen));
                break;
            default:
                Console.WriteLine("Loại sản phẩm không hợp lệ.");
                break;
        }
    }
}
