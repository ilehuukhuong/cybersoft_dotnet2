namespace baitapbuoi13
{
    public class HocSinh
    {
        public string MaHocSinh { get; set; }
        public string TenHocSinh { get; set; }
        public double DiemToan { get; set; }
        public double DiemVan { get; set; }
        public double DiemAnh { get; set; }

        public double DiemTrungBinh => (DiemToan + DiemVan + DiemAnh) / 3;

        public string XepLoai
        {
            get
            {
                if (DiemTrungBinh < 5) return "Yếu";
                if (DiemTrungBinh < 6.5) return "Trung bình";
                if (DiemTrungBinh < 8) return "Khá";
                return "Giỏi";
            }
        }
    }
}