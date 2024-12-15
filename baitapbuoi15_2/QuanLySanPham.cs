namespace baitapbuoi15_2
{
    public class QuanLySanPham
{
    private List<SanPham> danhSachSanPham = new List<SanPham>();

    public void ThemSanPham(SanPham sanPham)
    {
        if (danhSachSanPham.Any(sp => sp.MaSanPham == sanPham.MaSanPham))
        {
            Console.WriteLine("Mã sản phẩm đã tồn tại.");
            return;
        }
        danhSachSanPham.Add(sanPham);
        Console.WriteLine("Thêm sản phẩm thành công.");
    }

    public void HienThiSanPham()
    {
        Console.WriteLine("=== Danh sách sản phẩm ===");
        foreach (var sanPham in danhSachSanPham)
        {
            sanPham.HienThiThongTin();
        }
    }

    public double TinhTongDoanhThu()
    {
        return danhSachSanPham.Sum(sp => sp.TinhGiaBan());
    }

    public void XoaSanPham(string maSanPham)
    {
        var sanPham = danhSachSanPham.FirstOrDefault(sp => sp.MaSanPham == maSanPham);
        if (sanPham != null)
        {
            danhSachSanPham.Remove(sanPham);
            Console.WriteLine("Xóa sản phẩm thành công.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sản phẩm.");
        }
    }
}
}