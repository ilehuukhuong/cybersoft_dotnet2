namespace baitapbuoi15_2
{
    public class ThoiTrang : SanPham
    {
        public double GiamGia { get; set; }

        public ThoiTrang(string maSanPham, string tenSanPham, double giaGoc, double giamGia)
            : base(maSanPham, tenSanPham, giaGoc)
        {
            GiamGia = giamGia;
        }

        public override double TinhGiaBan()
        {
            return GiaGoc - GiamGia;
        }
    }

}