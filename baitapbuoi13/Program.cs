namespace baitapbuoi13;
internal class Program
{
    private static void Main(string[] args)
    {
        var quanLy = new QuanLyHocSinh();
        string duongDan = "danhSachHocSinh.json";

        while (true)
        {
            Console.WriteLine("\n--- Quản Lý Học Sinh ---");
            Console.WriteLine("1. Thêm học sinh");
            Console.WriteLine("2. Tìm kiếm học sinh");
            Console.WriteLine("3. Cập nhật điểm học sinh");
            Console.WriteLine("4. Xóa học sinh");
            Console.WriteLine("5. Hiển thị danh sách xếp loại");
            Console.WriteLine("6. Hiển thị học sinh theo tên");
            Console.WriteLine("7. Lưu dữ liệu ra file");
            Console.WriteLine("8. Đọc dữ liệu từ file");
            Console.WriteLine("9. Thoát");
            Console.Write("Chọn chức năng: ");
            var chon = Console.ReadLine();

            switch (chon)
            {
                case "1":
                    Console.Write("Mã học sinh: ");
                    var ma = Console.ReadLine();
                    Console.Write("Tên học sinh: ");
                    var ten = Console.ReadLine();
                    Console.Write("Điểm Toán: ");
                    var toan = double.Parse(Console.ReadLine());
                    Console.Write("Điểm Văn: ");
                    var van = double.Parse(Console.ReadLine());
                    Console.Write("Điểm Anh: ");
                    var anh = double.Parse(Console.ReadLine());
                    quanLy.ThemHocSinh(new HocSinh { MaHocSinh = ma, TenHocSinh = ten, DiemToan = toan, DiemVan = van, DiemAnh = anh });
                    break;

                case "2":
                    Console.Write("Nhập tên học sinh cần tìm: ");
                    var tenTim = Console.ReadLine();
                    quanLy.TimKiemHocSinh(tenTim);
                    break;

                case "3":
                    Console.Write("Mã học sinh: ");
                    var maCapNhat = Console.ReadLine();
                    Console.Write("Điểm Toán: ");
                    var diemToan = double.Parse(Console.ReadLine());
                    Console.Write("Điểm Văn: ");
                    var diemVan = double.Parse(Console.ReadLine());
                    Console.Write("Điểm Anh: ");
                    var diemAnh = double.Parse(Console.ReadLine());
                    quanLy.CapNhatDiem(maCapNhat, diemToan, diemVan, diemAnh);
                    break;

                case "4":
                    Console.Write("Mã học sinh: ");
                    var maXoa = Console.ReadLine();
                    quanLy.XoaHocSinh(maXoa);
                    break;

                case "5":
                    quanLy.HienThiDanhSachXepLoai();
                    break;

                case "6":
                    quanLy.HienThiHocSinhTheoTen();
                    break;

                case "7":
                    quanLy.LuuDuLieu(duongDan);
                    break;

                case "8":
                    quanLy.DocDuLieu(duongDan);
                    break;

                case "9":
                    return;

                default:
                    Console.WriteLine("Chọn sai chức năng, vui lòng thử lại.");
                    break;
            }
        }
    }
}