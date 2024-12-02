using Newtonsoft.Json;

namespace baitapbuoi13
{
    public class QuanLyHocSinh
    {
        private List<HocSinh> danhSachHocSinh = new List<HocSinh>();

        // Thêm học sinh
        public void ThemHocSinh(HocSinh hocSinh)
        {
            danhSachHocSinh.Add(hocSinh);
            Console.WriteLine("Đã thêm học sinh.");
        }

        // Tìm kiếm học sinh theo tên
        public void TimKiemHocSinh(string ten)
        {
            var ketQua = danhSachHocSinh.Where(hs => hs.TenHocSinh.Contains(ten)).ToList();
            if (ketQua.Any())
            {
                foreach (var hs in ketQua)
                {
                    HienThiThongTinHocSinh(hs);
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy học sinh nào.");
            }
        }

        // Cập nhật điểm học sinh
        public void CapNhatDiem(string maHocSinh, double diemToan, double diemVan, double diemAnh)
        {
            var hocSinh = danhSachHocSinh.FirstOrDefault(hs => hs.MaHocSinh == maHocSinh);
            if (hocSinh != null)
            {
                hocSinh.DiemToan = diemToan;
                hocSinh.DiemVan = diemVan;
                hocSinh.DiemAnh = diemAnh;
                Console.WriteLine("Đã cập nhật điểm.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy học sinh.");
            }
        }

        // Xóa học sinh
        public void XoaHocSinh(string maHocSinh)
        {
            var hocSinh = danhSachHocSinh.FirstOrDefault(hs => hs.MaHocSinh == maHocSinh);
            if (hocSinh != null)
            {
                danhSachHocSinh.Remove(hocSinh);
                Console.WriteLine("Đã xóa học sinh.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy học sinh.");
            }
        }

        // Hiển thị danh sách xếp loại
        public void HienThiDanhSachXepLoai()
        {
            foreach (var hs in danhSachHocSinh.OrderByDescending(hs => hs.DiemTrungBinh))
            {
                HienThiThongTinHocSinh(hs);
            }
        }

        // Hiển thị học sinh theo tên
        public void HienThiHocSinhTheoTen()
        {
            var ketQua = danhSachHocSinh.OrderBy(hs => hs.TenHocSinh.Split(' ').Last()).ToList();
            foreach (var hs in ketQua)
            {
                HienThiThongTinHocSinh(hs);
            }
        }

        // Lưu danh sách ra file JSON
        public void LuuDuLieu(string duongDan)
        {
            var json = JsonConvert.SerializeObject(danhSachHocSinh, Formatting.Indented);
            File.WriteAllText(duongDan, json);
            Console.WriteLine("Đã lưu dữ liệu ra file.");
        }

        // Đọc dữ liệu từ file JSON
        public void DocDuLieu(string duongDan)
        {
            if (File.Exists(duongDan))
            {
                var json = File.ReadAllText(duongDan);
                danhSachHocSinh = JsonConvert.DeserializeObject<List<HocSinh>>(json) ?? new List<HocSinh>();
                Console.WriteLine("Đã đọc dữ liệu từ file.");
            }
            else
            {
                Console.WriteLine("File không tồn tại.");
            }
        }

        private void HienThiThongTinHocSinh(HocSinh hs)
        {
            Console.WriteLine($"Mã: {hs.MaHocSinh}, Tên: {hs.TenHocSinh}, Điểm TB: {hs.DiemTrungBinh:F2}, Xếp loại: {hs.XepLoai}");
        }
    }
}